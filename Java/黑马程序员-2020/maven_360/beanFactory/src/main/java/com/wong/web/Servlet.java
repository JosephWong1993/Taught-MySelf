package com.wong.web;

import com.wong.dao.UserDao;
import com.wong.service.UserService;
import com.wong.service.impl.UserServiceImpl;
import com.wong.utils.BeanFactory;

public class Servlet {
    public void doGet() {
        /*
         * web层获取业务层接口实现类，不能new
         * 通过工具类
         */
        UserService userService = BeanFactory.getInstance(UserService.class);
        userService.register();

        UserDao userDao = BeanFactory.getInstance(UserDao.class);
        userDao.register();
    }
}
