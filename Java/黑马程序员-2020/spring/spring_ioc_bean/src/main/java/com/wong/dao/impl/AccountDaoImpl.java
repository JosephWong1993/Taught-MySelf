package com.wong.dao.impl;

import com.wong.dao.AccountDao;

public class AccountDaoImpl implements AccountDao {
    @Override
    public void saveAccount() {
        System.out.println("模拟保存账户");
    }
}
