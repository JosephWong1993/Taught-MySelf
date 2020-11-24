package com.wong.service.impl;

import com.wong.dao.AccountDao;
import com.wong.dao.impl.AccountDaoImpl;
import com.wong.service.AccountService;

/**
 * 业务接口实现类
 */
public class AccountServiceImpl implements AccountService {
    //当前的代码耦合性强
    private AccountDao accountDao = new AccountDaoImpl();
    
    @Override
    public void saveAccount() {
        //调用dao层的保存账户的方法
        accountDao.saveAccount();
    }
}
