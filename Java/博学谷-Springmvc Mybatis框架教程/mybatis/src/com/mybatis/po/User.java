package com.mybatis.po;

import java.io.Serializable;
import java.util.Date;
import java.util.List;

/** 用户po */
public class User implements Serializable {
	// 属性名和数据库表的字段对应
	private int id;
	/** 用户姓名 */
	private String username;
	/** 性别 */
	private String sex;
	/** 生日 */
	private Date birthday;
	/** 地址 */
	private String address;

	/** 用户创建的订单列表 */
	private List<Orders> ordersList;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getSex() {
		return sex;
	}

	public void setSex(String sex) {
		this.sex = sex;
	}

	public Date getBirthday() {
		return birthday;
	}

	public void setBirthday(Date birthday) {
		this.birthday = birthday;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public List<Orders> getOrdersList() {
		return ordersList;
	}

	public void setOrdersList(List<Orders> ordersList) {
		this.ordersList = ordersList;
	}
}
