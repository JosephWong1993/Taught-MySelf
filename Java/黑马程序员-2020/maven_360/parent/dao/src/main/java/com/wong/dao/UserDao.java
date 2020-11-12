package com.wong.dao;

import com.wong.pojo.User;
import com.wong.utils.C3p0Utils;
import com.wong.utils.UUIDUtils;
import org.apache.commons.dbutils.QueryRunner;

import java.sql.SQLException;

public class UserDao {
    /**
     * User对象数据，写入到数据表
     */
    public void saveUser(User user) throws SQLException {
        QueryRunner qr = new QueryRunner(C3p0Utils.getDataSource());
        String sql = "insert into user values(?,?,?,?,?,?)";
        Object[] params = {UUIDUtils.getUUID(), user.getUsername(), user.getPassword(), user.getPhone(), user.getAddress(), user.getMoney()};
        qr.update(sql, params);
    }
}