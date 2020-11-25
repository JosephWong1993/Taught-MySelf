package com.wong.service;

import com.wong.pojo.Account;

/**
 * 账户的业务层接口
 */
public interface AccountService {
    //更新账户
    void update(Account account);
    
    //根据 name 查询账户
    Account getByName(String name);
}
