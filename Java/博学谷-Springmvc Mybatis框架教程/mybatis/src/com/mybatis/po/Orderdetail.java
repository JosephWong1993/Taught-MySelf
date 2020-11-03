package com.mybatis.po;

public class Orderdetail {
	private int id;

	private int itemsId;

	private String itemsNum;

	private int ordersId;

	/** 明细对应的商品信息 */
	private Items items;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getItemsId() {
		return itemsId;
	}

	public void setItemsId(int itemsId) {
		this.itemsId = itemsId;
	}

	public String getItemsNum() {
		return itemsNum;
	}

	public void setItemsNum(String itemsNum) {
		this.itemsNum = itemsNum;
	}

	public int getOrdersId() {
		return ordersId;
	}

	public void setOrdersId(int ordersId) {
		this.ordersId = ordersId;
	}

	public Items getItems() {
		return items;
	}

	public void setItems(Items items) {
		this.items = items;
	}
}
