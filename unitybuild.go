/*
*
added by yh @ 2023/6/28 12:30
注意:
*/
package main

import (
	"fmt"
	"log"
	"os"
	"os/exec"
)

// go build unitybuild.go
// 自动打包项目
func main() {
	YourUnityScript_YourMethod := "PackageTool.BuildAssetBundlesForCurrentChannel"
	YourUnityProjectPath := "D:\\lqyyhuatuo"
	fmt.Printf("----------开始执行脚本--------------------\n")
	pth := "C:\\Program Files\\Unity\\Hub\\Editor\\2021.3.15f1\\Editor\\unity.exe"
	cmd := exec.Command(pth, "-quit", "-batchmode", "-executeMethod", YourUnityScript_YourMethod)
	cmd.Dir = YourUnityProjectPath

	cmd.Stdout = os.Stdout
	cmd.Stderr = os.Stderr

	err := cmd.Run()
	if err != nil {
		log.Fatal(err)
	}
}
