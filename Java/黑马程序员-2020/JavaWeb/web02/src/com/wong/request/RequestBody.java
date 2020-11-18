package com.wong.request;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.Enumeration;

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
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //获取请求头
        //User-Agent：值是重要信息 浏览器名字，和操作系统
        String header = request.getHeader("User-Agent");
        //        header.toLowerCase().contains("edge");
        System.out.println(header);
        
        //request.getHeaderNames() 获取所有请求头的键，返回值是向量枚举 Enumeration
        //集合Collection从JDK1.2开始，迭代器Iterator
        //JDK1.0，1.1 Enumeration是迭代器的前生
        //Iterator hasNext() next() Enumeration hasMoreElement() element()
        Enumeration<String> names = request.getHeaderNames();  //获取所有请求头的键，返回值是向量枚举
        while (names.hasMoreElements()) {
            String s = names.nextElement();
            System.out.println(s + "::" + request.getHeader(s));
        }
    }
    
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
