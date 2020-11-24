package com.wong.service;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**
 * 测试类
 */
public class AccountServiceTest {
    
    @Test
    public void saveAccount() {
        //使用spring框架IOC容器，加载Beans.xml文件，解析了Beans.xml文件，并把所有的Bean标签的内容 存到Map集合中
        ApplicationContext applicationContext = new ClassPathXmlApplicationContext("beans.xml");
        //获取AccountService对象方式一
        AccountService accountService = (AccountService) applicationContext.getBean("accountService");
        //获取AccountService对象方式二（常用）
        AccountService accountService2 = applicationContext.getBean(AccountService.class);
        //获取AccountService对象方式三
        AccountService accountService3 = applicationContext.getBean("accountService", AccountService.class);
        accountService.saveAccount();
        accountService.saveAccount();
    }
}