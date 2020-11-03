package com.mybatis.mapper;

import java.util.List;

import com.mybatis.po.User;
import com.mybatis.po.UserCustom;
import com.mybatis.po.UserQueryVo;

/**
 * mapper接口，相当于dao接口，用户管理
 */
public interface UserMapper {
	// 用户信息综合查询
	public List<UserCustom> findUserList(UserQueryVo userQueryVo) throws Exception;

	// 用户信息综合查询总数
	public int findUserCount(UserQueryVo userQueryVo) throws Exception;

	// 根据id查询用户信息
	public User findUserById(int id) throws Exception;

	// 根据id查询用户信息，使用resultMap输出
	public User findUserByIdResultMap(int id) throws Exception;

	// 根据用户名称查询用户列表
	public List<User> findUserByName(String name) throws Exception;

	// 添加用户信息
	public void insertUser(User user) throws Exception;

	// 删除用户信息
	public void deleteUser(int id) throws Exception;

	// 更新用户
	public void updateUser(User user);
}
