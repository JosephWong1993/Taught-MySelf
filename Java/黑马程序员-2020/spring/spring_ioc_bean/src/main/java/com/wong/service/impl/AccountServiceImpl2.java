package com.wong.service.impl;

import com.wong.dao.AccountDao;
import com.wong.dao.impl.AccountDaoImpl;
import com.wong.service.AccountService;

/**
 * 业务接口实现类
 */
public class AccountServiceImpl2 implements AccountService {
    //当前的代码耦合性强
    private AccountDao accountDao = new AccountDaoImpl();
    
    @Override
    public void save() {
        //调用dao层的保存账户的方法
        accountDao.saveAccount();
    }
}
