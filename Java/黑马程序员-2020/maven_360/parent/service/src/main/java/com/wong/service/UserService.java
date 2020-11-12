package com.wong.service;

import com.wong.dao.UserDao;
import com.wong.pojo.User;

import java.sql.SQLException;

public class UserService {
    /**
     * 写入用户的业务层
     * web层传递pojo对象
     * 调用业务曾传递Pojo
     */
    public void saveUser(User user) {
        UserDao userDao = new UserDao();
        try {
            userDao.saveUser(user);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}