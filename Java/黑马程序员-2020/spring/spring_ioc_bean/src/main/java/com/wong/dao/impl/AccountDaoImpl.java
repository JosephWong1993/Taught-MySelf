package com.wong.dao.impl;

import com.wong.dao.AccountDao;

public class AccountDaoImpl implements AccountDao {
    @Override
    public void saveAccount() {
        System.out.println("模拟保存账户");
    }
    
    /**
     * AccountDaoImpl对象创建好以后，进行对象初始化的方法
     */
    private void init() {
        System.out.println("AccountDaoImpl对象创建好。。。进行对象初始化的方法");
    }
    
    /**
     * AccountDaoImpl对象销毁前，执行的方法，用于对象的资源释放
     */
    private void destory() {
        System.out.println("AccountDaoImpl对象销毁前，执行的方法，用于对象的资源释放");
    }
}
