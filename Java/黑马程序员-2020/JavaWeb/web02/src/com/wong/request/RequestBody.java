package com.wong.request;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * request对象获取客户端的请求体
 * 是HTTP协议的一部分
 * 数据是 k:v的形式
 * <p>
 * request对象的方法：
 * String getHeader(String key) 获取请求头信息
 * getHeaderNames() 获取所有请求头的健
 */
@WebServlet(urlPatterns = "/requestBody")
public class RequestBody extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //获取请求头
        //User-Agent：值是重要信息 浏览器名字，和操作系统
        String header = request.getHeader("User-Agent");
        System.out.println(header);
        request.getHeaderNames();
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
