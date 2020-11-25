package com.wong.service.impl;

import com.wong.dao.AccountDao;
import com.wong.pojo.Account;
import com.wong.service.AccountService;

/**
 * 账户的业务层接口实现类
 */
public class AccountServiceImpl implements AccountService {
    //依赖注入
    private AccountDao accountDao;
    
    public void setAccountDao(AccountDao accountDao) {
        this.accountDao = accountDao;
    }
    
    @Override
    public void update(Account account) {
        accountDao.update(account);
    }
    
    @Override
    public Account getByName(String name) {
        return accountDao.getByName(name);
    }
}
