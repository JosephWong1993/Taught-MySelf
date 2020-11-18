package com.wong.request;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * 处理客户端请求的中文编码
 * request对象获取参数，使用的ISO8859-1编码
 * 设置request对象使用的编码表
 * <p>
 * Tomcat8以前：setCharacterEncoding("utf-8")；针对请求体 POST
 * 对请求行无效：GET
 * Tomcat8以后：setCharacterEncoding("utf-8")；都有效
 */
@WebServlet(urlPatterns = "/params2")
public class RequestParams2 extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        request.setCharacterEncoding("utf-8");
        String user = request.getParameter("user");
        System.out.println(user);
    }
    
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
