/*
*excel_to_c#
added by yh @ 2023/6/25 17:35
注意:
*/
package main

import (
	"fmt"
	"io/ioutil"

	"github.com/xuri/excelize/v2"
)

func main() {
	f, err := excelize.OpenFile("j-奖励表.xlsx")
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

	for i := 0; i < len(sheetlist); i++ {
		sheetName := sheetlist[i+1]
		fmt.Println(sheetName)
		DoSheetTable(f, sheetName)
	}

}
func DoSheetTable(f *excelize.File, sheetName string) {
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

	fileName := sheetName
	var ctypeNameList []string
	var ctypeList []string
	//
	var baseInfoName string
	base_data := ""
	WLine("using System.Collections.Generic;")
	WLine("{")
	for x, row := range rows {
		switch x {
		case 0:
		case 1:
			ctypeNameList = row
		case 2:
			ctypeList = row
			baseInfoName = fileName + "Info"
			WLine("public class " + baseInfoName)
			WLine("{")
			//添加参数
			for index, cname := range ctypeNameList {
				if cname == "" {
					continue
				}
				ctype := ctypeList[index]
				if ctype == "" {
					ctype = "int"
				} else {
					ctype = "string"
				}
				WLine("public " + ctype + " " + cname + ";")

				_temp := ","
				//拿到参数串
				if index == len(ctypeNameList) {
					_temp = ""
				}
				base_data += ctype + " " + cname + _temp
			}
			//构建函数  public FileNameInfo()

			WLine("public %s(%s)", baseInfoName, base_data)
			WLine("{")
			//参数赋值
			for index, cname := range ctypeNameList {
				if cname == "" {
					continue
				}
				ctype := ctypeList[index]
				if ctype == "" {
					ctype = "int"
				}
				WLine("%s = %s;", cname, cname)
			}
			WLine("}")

			WLine("}")
			//=====================================================
			WLine("public class cfg_fileName")
			WLine("{")
			WLine("public List<%s> list = new List<%s>()", baseInfoName, baseInfoName)
			WLine("{")
		case 3:
		case 4:
		default:
			canshuzhi := ""
			for index, colCell := range row {
				_t := ","
				if index == len(ctypeNameList) {
					_t = ""
				}
				canshuzhi += colCell + _t
			}
			WLine(" list[%d] = new %s(%s);", x, baseInfoName, canshuzhi)
		}
		WLine("}")

	}
	WLine("}")

	// 将配置文件写入文件中
	err = ioutil.WriteFile(fileName+".cs", []byte(file_content), 0644)
	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Println("配置文件已生成")
}

// 遍历每一行数据
var file_content string

func WLine(format string, a ...any) {
	aline := fmt.Sprintf(format, a...)
	file_content += aline + "\n"

}
