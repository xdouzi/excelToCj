#!/bin/bash
#chmod u+x *.sh
#rm -rf bin
CGO_ENABLED=0 GOOS=linux GOARCH=amd64 go build ./excel_to_cx.go
#CGO_ENABLED=0 GOOS=linux GOARCH=amd64 go build ./examples/GateServer
