package com.wong.factory;

import com.wong.service.AccountService;
import com.wong.service.impl.AccountServiceImpl;

/**
 * 采用类中静态方法的方式 进行Bean对象的创建
 */
public class StaticFactory {
    public static AccountService createAccountService() {
        return new AccountServiceImpl();
    }
}
