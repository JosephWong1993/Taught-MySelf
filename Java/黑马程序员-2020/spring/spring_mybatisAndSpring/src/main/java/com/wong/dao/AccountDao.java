package com.wong.dao;

import com.wong.pojo.Account;

/**
 * 账户的dao接口
 */
public interface AccountDao {
    //更新账户
    void update(Account account);
    
    //根据 name 查询账户
    Account getByName(String name);
}
