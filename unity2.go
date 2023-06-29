/*
*
added by yh @ 2023/6/28 18:03
注意:
*/
package main

import (
	"fmt"
	"io/ioutil"
	"log"
	"os/exec"
	"strings"
)

func main() {
	// 设置Unity编辑器的路径
	unityPath := "C:\\Program Files\\Unity\\Hub\\Editor\\2021.3.15f1\\Editor\\unity.exe"
	killProcess(unityPath)
	// 设置Unity项目的路径
	projectPath := "D:\\lqyyhuatuo"

	// 设置编译日志文件的路径 C:/Path/To/Your/Log/File.log
	logPath := "./File.log"
	fmt.Printf("----------开始执行脚本--------------------\n")
	YourScript_YourMethod := "PackageTool.BuildAssetBundlesForCurrentChannel"
	// 构建Unity命令行参数
	args := []string{
		"-projectPath",
		projectPath,
		"-batchmode",
		"-logFile",
		logPath,
		"-executeMethod",
		YourScript_YourMethod,
	}

	// 创建命令行命令
	cmd := exec.Command(unityPath, args...)

	// 执行命令并等待完成
	err := cmd.Run()
	if err != nil {
		fmt.Println("Error:", err)
		return
	}

	// 读取编译日志文件内容
	logContent, err := ioutil.ReadFile(logPath)
	if err != nil {
		fmt.Println("Error:", err)
		return
	}

	// 打印编译日志
	fmt.Println(string(logContent))
}
func killProcess(processPath string) {
	// 指定要杀掉的进程路径
	//processPath := "C:\\path\\to\\process.exe"

	// 执行tasklist命令获取所有进程信息
	tasklistCmd := exec.Command("tasklist")
	tasklistOutput, err := tasklistCmd.Output()
	if err != nil {
		log.Fatal(err)
	}

	// 解析tasklist命令输出，找到指定路径的进程ID
	processes := strings.Split(string(tasklistOutput), "\n")
	for _, process := range processes {
		if strings.Contains(process, processPath) {
			// 提取进程ID
			fields := strings.Fields(process)
			processID := fields[1]

			// 杀掉进程
			killCmd := exec.Command("taskkill", "/F", "/PID", processID)
			killOutput, err := killCmd.Output()
			if err != nil {
				log.Fatal(err)
			}

			fmt.Printf("Killed process %s\n", processID)
			fmt.Println(string(killOutput))
		}
	}
}
