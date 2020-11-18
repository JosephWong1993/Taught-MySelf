package com.wong.service;

import com.wong.dao.UserDao;
import com.wong.pojo.User;

import java.sql.SQLException;

/**
 * 注册功能的业务
 * web层调用业务层的方法，传递User对象
 * 业务层调用dao层方法，传递User
 */
public class UserService {
    public void register(User user) {
        UserDao userDao = new UserDao();
        try {
            userDao.register(user);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
