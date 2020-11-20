package com.wong.cookie;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * Cookie的携带路径
 * 浏览器访问服务器，是否携带Cookie访问
 * <p>
 * 结论：Cookie数据在哪里产生的，在哪里访问才携带
 * <p>
 * 演示：
 * 浏览器先访问的是 /web03/pathCookie
 * 第二次访问的是 /web03/pathCookie
 * 第三次访问的是 /web03/a.jsp
 * 第四次访问的是 /web03/abc/b.jsp
 * 浏览器都携带Cookie数据（请求头有！）
 * <p>
 * 演示：
 * 浏览器先访问的是 /web03/abc/pathCookie（请求头有！）
 * 第二次访问的是 /web03/abc/pathCookie（请求头有！）
 * 第三次访问的是 /web03/abc/b.jsp（请求头有！）
 * 第四次访问的是 /web03/a.jsp（请求头没有！）
 */
@WebServlet(urlPatterns = "/abc/pathCookie")
public class PathCookieServlet extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        Cookie cookie = new Cookie("path", "cookiePath");
        response.addCookie(cookie);
    }
    
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
