package main

import (
	"github.com/gin-gonic/gin"
	"github.com/prashantkhandelwal/devfeed/controllers/feed"
)

func main() {
	r := gin.Default()
	r.GET("/ping", feed.GetPing)
	r.Run()
}
