/*
*excel_to_c#
added by yh @ 2023/6/25 17:35
注意:
*/
package main

import (
	"fmt"
	"io/ioutil"
	"os"
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

	for _, fileName := range fileNames {
		if filepath.Ext(fileName) == ".xlsx" {
			filePath := filepath.Join(dirPath, fileName)
			OpenExcelFile(filePath)
		}
	}
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

	for i := 0; i < len(sheetlist); i++ {
		sheetName := sheetlist[i+1]
		if strings.Contains(sheetName, "说明表") {
			fmt.Println("包含说明表 %s 不处理", sheetName)
		} else {
			fmt.Println("开始导出:" + sheetName)
			file_content = ""
			t.DoSheetTable(f, sheetName)
		}

	}
}

type ExcelToCx struct {
	F             *excelize.File
	fileName      string
	ctypeNameList []string
	ctypeList     []string

	baseInfoName  string
	baseInfo_data string
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

	WLine("using System.Collections.Generic;")

	t.DoBaseInfo(rows)
	t.DocfgClass(rows)

	t.SaveCxFile()
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

func (t *ExcelToCx) DoBaseInfo(rows [][]string) {
	//基本信息
	for x, row := range rows {
		switch x {
		case 0:
		case 1:
			t.ctypeNameList = row
		case 2:
			t.ctypeList = row
			t.baseInfoName = t.fileName + "Info"
			WLine("public class " + t.baseInfoName)
			WLine("{")
			//添加参数
			for index, cname := range t.ctypeNameList {
				if cname == "" {
					continue
				}
				ctype := t.GetcType(index)
				if ctype == "" {
					ctype = "int"
				} else {
					ctype = "string"
				}
				WLine("public " + ctype + " " + cname + ";")

				_temp := ","
				//拿到参数串
				if index == len(t.ctypeNameList)-1 {
					_temp = ""
				}
				t.baseInfo_data += ctype + " " + cname + _temp
			}

			//构建函数  public FileNameInfo()

			WLine("public %s(%s)", t.baseInfoName, t.baseInfo_data)
			WLine("{")
			//参数赋值
			for index, cname := range t.ctypeNameList {
				if cname == "" {
					continue
				}
				ctype := t.GetcType(index)

				if ctype == "" {
					ctype = "int"
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
func (t *ExcelToCx) DocfgClass(rows [][]string) {
	/*
	   public static class Cfg_Test
	   {
	   }
	*/
	WLine("public class Cfg_%s", t.fileName)
	WLine("{")

	WLine("public static List<%s> list = new List<%s>()", t.baseInfoName, t.baseInfoName)
	//WLine("public Cfg_%s()", t.fileName)
	WLine("{")
	for x, row := range rows {
		if x < 5 {
			continue
		}
		canshuzhi := ""
		//for index, colCell := range row {
		colCell := ""
		_t := ","
		//添加参数
		for index, cname := range t.ctypeNameList {
			if cname == "" {
				continue
			}
			ctype := t.GetcType(index)
			if ctype != "" {
				if index > len(row)-1 {
					colCell = fmt.Sprintf("\"\"")
				} else {
					colCell = fmt.Sprintf("\"%s\"", row[index])
				}
			} else {
				if index > len(row)-1 {
					//不处理
				} else {
					colCell = row[index]
				}

			}

			if index == len(t.ctypeNameList)-1 {
				_t = ""
			}
			canshuzhi += colCell + _t
		}

		WLine("	[%d] = new %s(%s),", x-5, t.baseInfoName, canshuzhi)

		/*
			if x == 20 {
				break
			}
		*/

	}
	WLine("};")

	WLine("}")
}
func (t *ExcelToCx) GetcType(index int) string {
	ctype := ""
	if index < len(t.ctypeList) {
		ctype = t.ctypeList[index]
	}
	return ctype
}

// 遍历每一行数据
var file_content string

func WLine(format string, a ...any) {
	aline := fmt.Sprintf(format, a...)
	file_content += aline + "\n"

}
