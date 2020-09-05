//  0 引入 用来发送请求的 方法 一定要把路径补全
import { request } from "../../request/index";

//Page Object
Page({
  data: {
    //  轮播图数组
    swiperList: [],
    //  导航数组
    catesList: [],
    //  楼层数据
    floorList: []
  },
  //options(Object)
  //  页面开始加载 就会触发
  onLoad: function (options) {
    //  1 发送异步请求获取轮播图数据
    //  优化的手段可以通过es6 的promise来解决这个问题
    // wx.request({
    //   url: 'https://api-hmugo-web.itheima.net/api/public/v1/home/swiperdata',
    //   success: (result) => {
    //     this.setData({
    //       swiperList: result.data.message
    //     });
    //   }
    // });

    this.getSwiperList();
    this.getCateList();
    this.getFloorList();
  },

  //  获取轮播图数据
  getSwiperList() {
    request({
      url: '/home/swiperdata',
    }).then(result => {
      result.forEach(v => {
        v.navigator_url = v.navigator_url.replace('main', 'index');
      });
      this.setData({
        swiperList: result
      });
    });
  },
  //  获取分类导航数据
  getCateList() {
    request({
      url: '/home/catitems',
    }).then(result => {
      this.setData({
        catesList: result
      });
    });
  },
  //  获取楼层数据
  getFloorList() {
    request({
      url: '/home/floordata',
    }).then(result => {
      result.forEach(v => {
        v.product_list.forEach(p => {
          p.navigator_url = p.navigator_url.replace('?', '/index?');
        })
      });
      this.setData({
        floorList: result
      });
    });
  }
});
