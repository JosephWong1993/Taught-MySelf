// pages/demo16/demo16.js
Page({
  data: {
    list: [
      { id: 0, name: "苹果", value: "apple" },
      { id: 1, name: "葡萄", value: "grape" },
      { id: 2, name: "香蕉", value: "bananer" },
    ],
    checkedList: []
  },
  //  复选框的选中事件
  handleItemChange(e) {
    //  1 获取被选中的复选框的值
    const checkedList = e.detail.value;
    //  2 进行赋值
    this.setData({
      checkedList
    })
  }
})