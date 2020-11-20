package com.wong.cookie;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.net.URLDecoder;
import java.net.URLEncoder;

/**
 * Cookie可以存储中文数据，不建议
 * 键不能是中文，值可以是中文
 * <p>
 * Tomcat8.5版本开始，可以直接使用中文
 * 8.5版本之前，不允许直接写中文的
 * <p>
 * 中文 转码UTF-8码
 */
@WebServlet(urlPatterns = "/chineseCookie")
public class ChineseCookie extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String str = "中文";
        str = URLEncoder.encode(str, "utf-8");
        System.out.println(str);
        
        /*Cookie cookie = new Cookie("china", str);
        response.addCookie(cookie);*/
        
        Cookie[] cookies = request.getCookies();
        for (Cookie cookie : cookies) {
            if (cookie.getName().equals("china")) {
                String value = URLDecoder.decode(cookie.getValue(), "utf-8");
                System.out.println(cookie.getName() + "::" + value);
            } else {
                System.out.println(cookie.getName() + "::" + cookie.getValue());
            }
        }
    }
    
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
