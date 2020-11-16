package com.wong.aunotation;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * Servlet程序的注解开发
 * 注解取代配置
 * Servlet版本3.0以后，有的注解开发
 * 注解 @WebServlet 写在类上
 * 注解属性 String[] urlPatterns() defaultP{};
 * 数组赋值一个
 */
@WebServlet(urlPatterns = "/annotation")
public class AnnotationServlet extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        System.out.println("欢迎使用注解开发");
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
