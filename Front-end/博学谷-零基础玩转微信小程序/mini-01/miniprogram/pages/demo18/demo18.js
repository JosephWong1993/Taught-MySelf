// pages/demo18/demo18.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    console.log("onLoad");
    //  onLoad 发送异步请求来初始化页面数据
  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {
    console.log("onShow");
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {
    console.log("onReady");
  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {
    console.log("onHide");
  },

  /**
   * 生命周期函数--监听页面卸载 也是可以通过点击超链接来演示
   */
  onUnload: function () {
    console.log("onUnload");
  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {
    console.log("onPullDownRefresh");
    //  页面的数据 或者效果重新刷新
  },

  /**
   * 页面上拉触底事件的处理函数
   * 需要让页面出现上下滚动才行
   */
  onReachBottom: function () {
    console.log("onReachBottom");
    //  上拉加载下一页数据
  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {
    console.log("onShareAppMessage");
  },

  /**
   * 页面滚动就可以触发
   */
  onPageScroll() {
    console.log('onPageScroll');
  },

  /**
   * 页面的尺寸发生改变的时候触发
   * 小程序 发生了 横屏竖屏 切换的时候触发
   */
  onResize() {
    console.log("onResize");
  },

  /**
   * 1 必须要求当前页面也是 tabbar 页面
   * 2 点击的自己的 tab item 的时候才触发
   */
  onTabItemTap() {
    console.log("onTabItemTap");
  }
})