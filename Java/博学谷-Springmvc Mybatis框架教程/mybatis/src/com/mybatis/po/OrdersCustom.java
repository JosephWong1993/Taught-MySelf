package com.mybatis.po;

//通过此类映射订单和用户查询的结果，让此类继承字段较多的pojo类
/** 订单的扩展类 */
public class OrdersCustom extends Orders {
	// 添加用户属性

	private String username;

	private String sex;

	private String addressString;

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

	public String getAddressString() {
		return addressString;
	}

	public void setAddressString(String addressString) {
		this.addressString = addressString;
	}
}
