package com.mybatis.mapper;

import static org.junit.jupiter.api.Assertions.*;

import java.io.InputStream;
import java.util.List;

import org.apache.ibatis.io.Resources;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.ibatis.session.SqlSessionFactoryBuilder;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import com.mybatis.po.Orders;
import com.mybatis.po.OrdersCustom;
import com.mybatis.po.User;

class OrdersMapperCustomTest {
	private SqlSessionFactory sqlSessionFactory;

	@BeforeEach
	void setUp() throws Exception {
		// 创建SqlSessionFactory

		// mybatis配置文件
		String resource = "SqlMapConfig.xml";
		// 得到配置文件流
		InputStream inputStream = Resources.getResourceAsStream(resource);
		// 创建会话工厂
		this.sqlSessionFactory = new SqlSessionFactoryBuilder().build(inputStream);
	}

	@Test
	void testFindOrdersUser() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		OrdersMapperCustom ordersMapperCustom = sqlSession.getMapper(OrdersMapperCustom.class);
		// 调用mapper方法
		List<OrdersCustom> list = ordersMapperCustom.findOrdersUser();
		sqlSession.close();
		System.out.println(list);
	}

	@Test
	void testFindOrdersUserResultMap() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		OrdersMapperCustom ordersMapperCustom = sqlSession.getMapper(OrdersMapperCustom.class);
		// 调用mapper方法
		List<Orders> list = ordersMapperCustom.findOrdersUserResultMap();
		sqlSession.close();
		System.out.println(list);
	}

	@Test
	void testFindOrdersAndOrderDetailResultMap() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		OrdersMapperCustom ordersMapperCustom = sqlSession.getMapper(OrdersMapperCustom.class);
		// 调用Mapper方法
		List<Orders> list = ordersMapperCustom.findOrdersAndOrderDetailResultMap();
		sqlSession.close();
		System.out.println(list);
	}

	@Test
	void testFindUserAndItemsResultMap() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		OrdersMapperCustom ordersMapperCustom = sqlSession.getMapper(OrdersMapperCustom.class);
		// 调用Mapper方法
		List<User> list = ordersMapperCustom.findUserAndItemsResultMap();
		sqlSession.close();
		System.out.println(list);
	}

	/** 查询订单关联查询用户，用户信息使用延迟加载 */
	@Test
	void testFindOrdersUserLazyLoading() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		OrdersMapperCustom ordersMapperCustom = sqlSession.getMapper(OrdersMapperCustom.class);
		// 查询订单信息（单表）
		List<Orders> list = ordersMapperCustom.findOrdersUserLazyLoading();
		// 遍历上边的订单列表
		for (Orders orders : list) {
			// 执行getUser()去查询用户信息，这里实现按需加载
			User user = orders.getUser();
			System.out.println(user);
		}
		sqlSession.close();
	}

	/** 一级缓存测试 */
	@Test
	void testCachel() throws Exception {
		SqlSession sqlSession = sqlSessionFactory.openSession();
		// 创建代理对象
		UserMapper userMapper = sqlSession.getMapper(UserMapper.class);
		// 下边查询使用一个SqlSession
		// 第一次发起请求，查询id为1的用户
		User user1 = userMapper.findUserById(1);
		System.out.println(user1);

		// 如果sqlSession执行commit操作（执行插入、更新、删除），清空SqlSession中的一级缓存，这样做的目的是为了让缓存中存储的是最新的消息，避免脏读。
		// 更新user1的信息
		user1.setUsername("测试用户22");
		userMapper.updateUser(user1);
		// 执行commit操作清空缓存
		sqlSession.commit();
		
		// 第二次发起请求，查询id为1的用户
		User user2 = userMapper.findUserById(1);
		System.out.println(user2);
		sqlSession.close();
	}
}
