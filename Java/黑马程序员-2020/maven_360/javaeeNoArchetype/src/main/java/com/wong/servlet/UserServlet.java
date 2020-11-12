package com.wong.servlet;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(urlPatterns = "/user")
public class UserServlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.getWriter().write("Hello User");
        /**
         * GET方式请求：乱码 ä½ å¥½
         *
         * tomact7版本，request对象设置编码表名字，对请求体有效
         * GET的请求行，无效
         *
         * 编码一次，解码一次来实现
         */
//        request.setCharacterEncoding("utf-8"); //Tomcat 8.5
        String username = request.getParameter("username"); // ä½ å¥½ ISO8859-1

        //字符串转字节数组
        byte[] bytes = username.getBytes("iso8859-1");
        //数组转字符串
        username = new String(bytes, "utf-8");
        System.out.println(username);
    }
}
