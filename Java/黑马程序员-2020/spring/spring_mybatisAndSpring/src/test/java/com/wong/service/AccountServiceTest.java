package com.wong.service;

import com.wong.dao.AccountDao;
import com.wong.pojo.Account;
import org.junit.Before;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import static org.junit.Assert.*;

/**
 * 测试类：Mybatis与Spring框架的整合
 */
public class AccountServiceTest {
    private AccountService accountService;
    
    @Before
    public void setUp() throws Exception {
        ApplicationContext applicationContext = new ClassPathXmlApplicationContext("ApplicationContext.xml");
        accountService = applicationContext.getBean(AccountService.class);
    }
    
    @Test
    public void update() {
        //1.创建SpringIOC容器，加载Spring的核心配置文件
        //        ApplicationContext applicationContext = new ClassPathXmlApplicationContext("ApplicationContext.xml");
        //2.从SpringIOC容器，获取对象
        //        AccountService accountService = applicationContext.getBean(AccountService.class);
        
        Account account = new Account();
        account.setId(3);
        account.setName("隔壁老王");
        account.setMoney(999999d);
        
        //3.对象调用方法
        accountService.update(account);
    }
    
    @Test
    public void getByName() {
        Account account = accountService.getByName("aaa");
        System.out.println("account = " + account);
    }
}