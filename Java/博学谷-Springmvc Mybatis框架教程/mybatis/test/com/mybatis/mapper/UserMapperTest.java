package com.mybatis.mapper;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.List;

import org.apache.ibatis.io.Resources;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.ibatis.session.SqlSessionFactoryBuilder;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import com.mybatis.po.User;
import com.mybatis.po.UserCustom;
import com.mybatis.po.UserQueryVo;

class UserMapperTest {

	private SqlSessionFactory sqlSessionFactory;

	// 此方法是在执行testFindUserById之前执行
	@BeforeEach
	public void setUp() throws Exception {
		// 创建SqlSessionFactory

		// mybatis配置文件
		String resource = "SqlMapConfig.xml";
		// 得到配置文件流
		InputStream inputStream = Resources.getResourceAsStream(resource);
		// 创建会话工厂
		this.sqlSessionFactory = new SqlSessionFactoryBuilder().build(inputStream);
	}

	// 用户信息综合查询
	@Test
	void testFindUserList() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建UserMapper对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 创建包装对象，设置查询条件
		UserQueryVo userQueryVo = new UserQueryVo();
		UserCustom userCustom = new UserCustom();
		userCustom.setSex("1");
		userCustom.setUsername("张三丰");
		// 传入多个id
		List<Integer> ids = new ArrayList<Integer>();
		ids.add(39);
		ids.add(40);
		userQueryVo.setIds(ids);
		userQueryVo.setUserCustom(userCustom);
		// 调用userMapper的方法
		List<UserCustom> list = userMapper.findUserList(userQueryVo);
		sqlSession.close();
		System.out.println(list);
	}

	// 用户信息综合查询
	@Test
	void testFindUserCount() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建UserMapper对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 创建包装对象，设置查询条件
		UserQueryVo userQueryVo = new UserQueryVo();
		UserCustom userCustom = new UserCustom();
		userCustom.setSex("1");
		userCustom.setUsername("张三丰");
		userQueryVo.setUserCustom(userCustom);
		// 调用userMapper的方法
		int count = userMapper.findUserCount(userQueryVo);
		sqlSession.close();
		System.out.println(count);
	}

	@Test
	void testFindUserById() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建UserMapper对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 调用userMapper的方法
		User user = userMapper.findUserById(1);
		sqlSession.close();
		System.out.println(user);
	}

	@Test
	void testFindUserByIdResultMap() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建UserMapper对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 调用userMapper的方法
		User user = userMapper.findUserByIdResultMap(1);
		sqlSession.close();
		System.out.println(user);
	}

	@Test
	void testFindUserByName() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建UserMapper对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 调用userMapper的方法
		List<User> list = userMapper.findUserByName("小明");
		sqlSession.close();
		System.out.println(list);
	}
}
