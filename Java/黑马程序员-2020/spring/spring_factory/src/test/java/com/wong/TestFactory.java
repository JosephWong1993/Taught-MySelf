package com.wong;

import com.wong.factory.BeanFactory;
import com.wong.service.AccountService;
import com.wong.service.impl.AccountServiceImpl;

/**
 * 测试类
 */
public class TestFactory {
    public static void main(String[] args) {
        //获取一个Service对象，调用保存方法
        //        AccountService accountService = new AccountServiceImpl();
        
        //使用工厂模式获取对象
        AccountService accountService = (AccountService) BeanFactory.getBean("AccountService");
        accountService.saveAccount();
    }
}
