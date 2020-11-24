package com.wong.factory;

import com.wong.service.AccountService;
import com.wong.service.impl.AccountServiceImpl;

/**
 * 采用对象调用普通方法的方式
 */
public class InstanceFactory {
    public AccountService createAccountService() {
        return new AccountServiceImpl();
    }
}
