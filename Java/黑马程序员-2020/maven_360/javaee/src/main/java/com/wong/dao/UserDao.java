package com.wong.dao;

import com.wong.pojo.User;
import com.wong.utils.C3p0Utils;
import org.apache.commons.dbutils.QueryRunner;
import org.apache.commons.dbutils.handlers.BeanListHandler;

import java.sql.SQLException;
import java.util.List;

public class UserDao {
    public List<User> findAll() throws SQLException {
        QueryRunner qr = new QueryRunner(C3p0Utils.getDataSource());
        return qr.query("select * from tb_user", new BeanListHandler<User>(User.class));
    }
}
