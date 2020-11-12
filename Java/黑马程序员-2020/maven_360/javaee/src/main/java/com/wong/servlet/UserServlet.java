package com.wong.servlet;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.wong.pojo.User;
import com.wong.service.UserService;

import javax.servlet.ServletException;
import javax.servlet.ServletInputStream;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.Array;
import java.lang.reflect.Method;
import java.util.Arrays;
import java.util.List;

@WebServlet(urlPatterns = "/user")
public class UserServlet extends HttpServlet {

    private UserService service = new UserService();
    private ObjectMapper mapper = new ObjectMapper();

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        /**
         * 获取客户端请求参数
         * 反射调用相关方法
         */
        try {
            response.setContentType("text/html;charset=utf-8");
            String operator = request.getParameter("operator");
            System.out.println();
            Class clazz = this.getClass();
            Method method = clazz.getMethod(operator, HttpServletRequest.class, HttpServletResponse.class);
            method.invoke(this, request, response);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    public void findAll(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        /**
         * 调用业务层,获取数据集合
         * 转成json响应
         */
        List<User> userList = service.findAll();
        String json = mapper.writeValueAsString(userList);
        response.getWriter().write(json);
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
