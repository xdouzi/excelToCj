/*
*excel_to_c#
added by yh @ 2023/6/25 17:35
注意: go build excel_to_cx.go
*/
package main

import (
	"fmt"
	"io/ioutil"
	"os"
	"os/signal"
	"path/filepath"
	"strings"

	"github.com/xuri/excelize/v2"
)

func main() {

	dirPath := "./excel"
	// 检查文件夹是否存在
	if _, err := os.Stat(dirPath); os.IsNotExist(err) {
		// 如果不存在则创建文件夹
		err := os.MkdirAll(dirPath, os.ModePerm)
		if err != nil {
			fmt.Println("Failed to create directory:", err)
			return
		}
		fmt.Println("Directory created successfully!")
	}

	files, err := os.Open(dirPath)
	if err != nil {
		fmt.Println(err)
		return
	}
	defer files.Close()

	fileNames, err := files.Readdirnames(0)
	if err != nil {
		fmt.Println(err)
		return
	}
	//go build excel_to_cx.go
	fmt.Printf("----------*.xlsx生成规则--------------------\n")
	fmt.Printf("--第一行 字段属性为 默认空:客户端和服务端使用;c:只有客户端用;s:只有服务端使用;\n")
	fmt.Printf("--第二行 字段属性名字 如果为空字符串这个列将不生成配置\n")
	fmt.Printf("--第三行 字段类型 如果为空 将默认为int,其它类型有 string,float\n")
	fmt.Printf("--第四行 字段介绍名称\n")
	fmt.Printf("--第五行 字段属性使用介绍\n")
	fmt.Printf("--第六行 配置第一行数据开始\n")
	fmt.Printf("added by yh @ 2023/6/25 17:35 408309839@qq.com \n")

	for _, fileName := range fileNames {
		if filepath.Ext(fileName) == ".xlsx" {
			filePath := filepath.Join(dirPath, fileName)
			OpenExcelFile(filePath)
		}
	}
	fmt.Printf("\n")
	fmt.Printf("----------生成所有C#配置完成---------------------\n")
	Hang()
}
func Hang() {

	c := make(chan os.Signal, 1)
	signal.Notify(c, os.Interrupt, os.Kill)
	s := <-c
	//ServerClose()
	fmt.Printf("kill process exit ------- signal:[%v]", s)
	//log4.Info("kill process exit ------- signal:[%v]", s)

}
func OpenExcelFile(filePath string) {
	//"j-奖励表.xlsx"
	f, err := excelize.OpenFile(filePath)
	if err != nil {
		fmt.Println(err)
		return
	}
	defer func() {
		// Close the spreadsheet.
		if err := f.Close(); err != nil {
			fmt.Println(err)
		}
	}()
	sheetlist := f.GetSheetMap()
	t := &ExcelToCx{}
	t.F = f
	t.ExcelPath = filePath
	for i := 0; i < len(sheetlist); i++ {
		sheetName := sheetlist[i+1]
		if sheetName == "" {
			continue
		}
		if strings.Contains(sheetName, "说明") {
			fmt.Printf("包含说明 %s 不处理\n", sheetName)
		} else {
			fmt.Printf("开始导出:%s sheetName= %s\n", f.Path, sheetName)
			file_content = ""
			t.DoSheetTable(f, sheetName)
		}

	}
}

type ExcelToCx struct {
	F                   *excelize.File
	fileName            string   //文件名字
	ctypeNameList       []string //参数名字
	ctypeList           []string //类型
	ctypeAnnotationList []string //注释

	classBaseName     string
	classBaseInfoName string
	baseInfo_data     string
	ExcelPath         string
}

func (t *ExcelToCx) DoSheetTable(f *excelize.File, sheetName string) {
	// Get value from cell by given worksheet name and cell reference.
	/*
		cell, err := f.GetCellValue(sheetName, "B2")
			if err != nil {
				fmt.Println(err)
				return
			}
			fmt.Println(cell)
	*/
	// 读取 Sheet1 中的数据
	rows, err := f.GetRows(sheetName)
	if err != nil {
		fmt.Println(err)
		return
	}
	/**
	0:规则第一行不要 备注用
	1:第二行 属性名字 当为空字符串 本列不做数据导入
	2：第三行 类型默认 int
	3:属性说明
	4:属性功能使用说明

	*/

	t.fileName = sheetName
	t.classBaseName = fmt.Sprintf("Cfg_%s", t.fileName)

	WLine("using System.Collections.Generic;")

	t.DoBaseInfo(rows)
	t.DocfgClass(rows)

	t.SaveCxFile()
}

func (t *ExcelToCx) DoBaseInfo(rows [][]string) {
	//基本信息
	t.classBaseInfoName = fmt.Sprintf("Cfg_%s_Item", t.fileName)

	for x, row := range rows {
		switch x {
		case 0:
		case 1:
			t.ctypeNameList = row
		case 2:
			t.ctypeList = row
		case 3:
			t.ctypeAnnotationList = row
		case 4:

			WLine("public class " + t.classBaseInfoName)
			WLine("{")
			//添加参数
			for index, cname := range t.ctypeNameList {
				if cname == "" {
					continue
				}
				ctype := t.GetcTypeName(index)
				zhushi := t.GetcTypeAnnotation(index)

				WLine("	public %s %s;//%s", ctype, cname, zhushi)

				_temp := ","
				//拿到参数串
				if index == len(t.ctypeNameList)-1 {
					_temp = ""
				}
				t.baseInfo_data += ctype + " " + cname + _temp
			}

			//构建函数  public FileNameInfo()

			WLine("public %s(%s)", t.classBaseInfoName, t.baseInfo_data)
			WLine("{")
			//参数赋值
			for _, cname := range t.ctypeNameList {
				if cname == "" {
					continue
				}
				WLine("  this.%s = %s;", cname, cname)
			}
			WLine("}")

			WLine("}")
			//=====================================================
		default:
			break
		}
	}
}

// 第一个参数id A3位置
func (t *ExcelToCx) GetKeyByListOrDic() bool {
	ctype := t.GetcTypeName(0)
	if ctype == "int" {
		return true
	}
	return false
}
func (t *ExcelToCx) DocfgClass(rows [][]string) {

	WLine("public class %s", t.classBaseName)
	WLine("{")
	WLine("public static Dictionary<string,%s> list = new Dictionary<string,%s>()", t.classBaseInfoName, t.classBaseInfoName)

	WLine("{")
	for x, row := range rows {
		if x < 5 {
			continue
		}
		canshuzhi := ""
		_t := ","
		//添加参数
		for index, cname := range t.ctypeNameList {
			colCell := ""
			if cname == "" {
				continue
			}
			ctype := t.GetcTypeName(index)
			if ctype == "string" {
				if index > len(row)-1 {
					colCell = fmt.Sprintf("\"\"")
				} else {
					colCell = fmt.Sprintf("\"%s\"", row[index])
				}
			} else {
				if index > len(row)-1 {
					//没有值根据类型 给默认值
					colCell = t.GetcTypeValue(index)
				} else {
					colCell = row[index]
					if colCell == "" {
						colCell = t.GetcTypeValue(index)
					}
					if ctype == "float" {
						colCell = row[index] + "f"
					}
				}

			}

			if index == len(t.ctypeNameList)-1 {
				_t = ""
			}
			canshuzhi += colCell + _t
		}

		WLine("	[\"%s\"] = new %s(%s),", row[0], t.classBaseInfoName, canshuzhi)

		/*
			if x == 20 {
				break
			}
		*/

	}
	WLine("};")

	WLine("}")
}

func (t *ExcelToCx) GetcTypeName(index int) string {
	//返回名字 默认int
	ctype := ""
	if index < len(t.ctypeList) {
		ctype = t.ctypeList[index]
	}
	if ctype == "" {
		ctype = "int"
	} else if ctype == "float" {
		ctype = ctype
	} else {
		ctype = "string"
	}

	return ctype
}

// 获取注释
func (t *ExcelToCx) GetcTypeAnnotation(index int) string {
	zhushi := ""
	if index < len(t.ctypeAnnotationList) {
		zhushi = t.ctypeAnnotationList[index]
	}
	return zhushi
}

func (t *ExcelToCx) GetcTypeValue(index int) string {
	//返回值
	ctype := t.GetcTypeName(index)
	switch ctype {
	case "int":
		return "0"
	case "float":
		return "0f"
	case "string":
		return "\"\""
	default:
		return "\"\""
	}
	//float
	return ctype
}

func (t *ExcelToCx) SaveCxFile() {
	dirPath := "./Cx_output"
	// 检查文件夹是否存在
	if _, err := os.Stat(dirPath); os.IsNotExist(err) {
		// 如果不存在则创建文件夹
		err := os.MkdirAll(dirPath, os.ModePerm)
		if err != nil {
			fmt.Println("Failed to create directory:", err)
			return
		}
		fmt.Println("Directory created successfully!")
	}

	outputFile := fmt.Sprintf("./Cx_output/%s.cs", t.fileName)
	// 将配置文件写入文件中
	err := ioutil.WriteFile(outputFile, []byte(file_content), 0644)
	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Println("配置文件已生成", outputFile)
	file_content = ""
}

// 遍历每一行数据
var file_content string

func WLine(format string, a ...any) {
	aline := fmt.Sprintf(format, a...)
	file_content += aline + "\n"

}
