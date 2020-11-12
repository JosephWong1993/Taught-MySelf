package com.wong.service;

import com.wong.dao.UserDao;
import com.wong.pojo.User;

import java.sql.SQLException;
import java.util.List;

public class UserService {
    public List<User> findAll() {
        UserDao userDao = new UserDao();
        List<User> userList = null;
        try {
            userList = userDao.findAll();
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return userList;
    }
}
