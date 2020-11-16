package com.wong.context;

import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * ServletContext对象的方法
 * <p>
 * String getInitParameter(String name) 获取web应用程序的初始化参数
 * 配置web.xml中参数
 * 方法的参数，传递是键名，获得值
 * <p>
 * 目前获取初始化参数意义不大
 * 以前的时候，在配置文件中，配置数据库的连接信息
 * 使用连接池技术
 */
public class Context2Servlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //止跌调用父类方法，后去ServletContext对象
        ServletContext context = getServletContext();
        //获取初始化参数
        String s = context.getInitParameter("java");
        System.out.println(s);
    }
}
