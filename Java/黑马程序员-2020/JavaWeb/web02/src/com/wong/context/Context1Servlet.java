package com.wong.context;

import javax.servlet.ServletContext;
import java.io.IOException;

/**
 * ServletContext对象（Servlet上下文对象）
 * 接口：ServletContext
 * 接口实现类对象 Tomcat启动的时候，已经创建好了，获取使用
 * 获取方式简单：
 * 父类的父类中，定义方法 public ServletContext getServletContext()
 * 继承关系，直接调用即可
 * org.apache.catalina.core.ApplicationContextFacade@7255f95f
 * 作用：ServletContext的作用
 * 就是Web应用程序对象，描述的是整个web程序
 * 每个应用程序只有一个对象
 * <p>
 * 原理：Tomcat服务器会在启动的时候扫描webapps
 * 找所有的Web程序，每个web程序，创建对象ServletContext
 */
public class Context1Servlet extends javax.servlet.http.HttpServlet {
    protected void doPost(javax.servlet.http.HttpServletRequest request, javax.servlet.http.HttpServletResponse response) throws javax.servlet.ServletException, IOException {
        doGet(request, response);
    }

    protected void doGet(javax.servlet.http.HttpServletRequest request, javax.servlet.http.HttpServletResponse response) throws javax.servlet.ServletException, IOException {
        ServletContext context = getServletContext();
        System.out.println(context);
    }
}
