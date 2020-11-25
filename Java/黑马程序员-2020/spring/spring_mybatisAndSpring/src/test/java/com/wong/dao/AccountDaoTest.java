package com.wong.dao;

import com.wong.pojo.Account;
import org.apache.ibatis.io.Resources;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.ibatis.session.SqlSessionFactoryBuilder;
import org.junit.Before;
import org.junit.Test;

import javax.annotation.Resource;

import java.io.IOException;

import static org.junit.Assert.*;

public class AccountDaoTest {
    private SqlSession sqlSession = null;
    
    @Before
    public void setUp() throws Exception {
        SqlSessionFactory sqlSessionFactory = new SqlSessionFactoryBuilder()
                .build(Resources.getResourceAsStream("SqlMapConfig.xml"));
        sqlSession = sqlSessionFactory.openSession();
    }
    
    @Test
    public void update() throws IOException {
        AccountDao accountDao = sqlSession.getMapper(AccountDao.class);
        
        Account account = new Account();
        account.setId(3);
        account.setName("隔壁老王666");
        account.setMoney(1d);
        
        accountDao.update(account);
        sqlSession.commit();
    }
    
    @Test
    public void getByName() {
        AccountDao accountDao = sqlSession.getMapper(AccountDao.class);
        Account account = accountDao.getByName("aaa");
        System.out.println("account = " + account);
    }
}