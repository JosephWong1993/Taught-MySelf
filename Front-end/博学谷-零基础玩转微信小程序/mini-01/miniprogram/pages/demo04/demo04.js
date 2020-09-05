// pages/demo04/demo04.js
Page({
  data: {
    num: 0,
  },
  //  输入框的input世界的执行逻辑
  handleInput(e) {
    console.log(e.detail.value);
    this.setData({
      num: e.detail.value
    });
  },
  //  加 减 按钮的事件
  handleTap(e) {
    //  获取自定义属性 operation
    const operation = e.currentTarget.dataset.operation;
    this.setData({
      num: this.data.num + operation
    });
  }
})