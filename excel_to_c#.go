/*
*excel_to_c#
added by yh @ 2023/6/25 17:35
注意:
*/
package main

import (
	"fmt"

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

	var ctypeNameList []string
	var ctypeList []string

	for x, row := range rows {

		switch x {
		case 0:
		case 1:
			ctypeNameList = row
		case 2:
			ctypeList = row
		case 3:
		case 4:
		default:
			for _, colCell := range row {

				fmt.Print(colCell, "\t")
			}
		}
		fmt.Println(len(ctypeNameList))
		fmt.Println(len(ctypeList))
	}
}
