package com.wong.http;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * IDEA工具创建出的Servlet
 * 包含2个方法
 * doPost：处理客户的POST请求方式
 * doGet：处理客户的GET请求方式
 * <p>
 * Servlet接口，是Sun接口的标志
 * Tomcat引擎调用该接口实现类的方法 service
 * <p>
 * MyHttpServlet肯定是Servlet接口实现类
 * MyHttpServlet继承HttpServlet
 * HttpServlet继承GenericServlet
 * GenericServlet实现了接口Servlet
 */
public class MyHttpServlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        System.out.println("POST");
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        System.out.println("GET");
    }
}
