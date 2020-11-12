package com.wong.dao.impl;

import com.wong.dao.UserDao;

public class UserDaoImpl implements UserDao {
    @Override
    public void register() {
        System.out.println("用户注册持久层");
    }
}
