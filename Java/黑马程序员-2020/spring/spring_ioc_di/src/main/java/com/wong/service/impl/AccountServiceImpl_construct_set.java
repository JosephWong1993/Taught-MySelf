package com.wong.service.impl;

import com.wong.service.AccountService;

import java.util.Date;

/**
 * 业务接口实现类
 */
public class AccountServiceImpl_construct_set implements AccountService {
    
    private String name;
    
    private Integer age;
    
    private Date date;
    
    //采用set方法的方式进行依赖注入
    public void setName(String name) {
        this.name = name;
    }
    
    public void setAge(Integer age) {
        this.age = age;
    }
    
    public void setDate(Date date) {
        this.date = date;
    }
    
    //采用构造方法的方式进行依赖注入
   /* public AccountServiceImpl(String name, Integer age, Date date) {
        this.name = name;
        this.age = age;
        this.date = date;
    }*/
    
    @Override
    public void save() {
        System.out.println(name + "====" + age + "====" + date);
    }
}
