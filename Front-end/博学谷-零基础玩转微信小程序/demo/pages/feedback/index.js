/**
 * 1 点击“+”触发 tap 点击事件
 *   1. 调用小程序内置的选择图片的 api
 *   2. 获取到图片的路径 数组
 *   3. 把图片路径存到 data 的变量中
 *   4. 页面就可以根据 图片数组 进行循环显示 自定义组件
 * 2 点击 自定义图片 组件
 *   1 获取被点击的元素的索引
 *   2 获取 data 中的图片数组
 *   3 根据索引 数组中删除对应的元素
 *   4 把数组重新设置回 data 中
 * 3 点击“提交”
 *   1 获取文本域的内容 类似 输入框的获取
 *     a data 中定义变量 表示 输入框内容
 *     b 文本域 绑定 输入事件 事件触发的时候 把输入框的值 存入到变量中
 *   2 对这些内容 合法性验证
 *   3 验证通过 用户选择的图片 上传到专门的图片的服务器 返回图片外围的链接
 *     a 遍历图片数组 
 *     b 挨个上传
 *     c 自己维护图片数组 存放 图片上传后的外网的链接
 *   4 文本域 和 外网的图片的路径 一起提交到服务器（前端模拟）
 *   5 清空当前页面
 *   6 返回上一页
 */
Page({
  /** 页面的初始数据 */
  data: {
    tabs: [
      { id: 0, value: "体验问题", isActive: true },
      { id: 1, value: "商品、商家投诉", isActive: false }
    ],
    /** 被选中的图片路径 数组 */
    chooseImgs: [],
    /** 文本域的内容 */
    textVal: '',
  },
  /** 外网的图片路径数组 */
  UpLoadImgs: [],

  /** 标题点击事件 从子组件传递过来 */
  handleTabsItemChange(e) {
    //  1 获取被点击的标题索引
    const { index } = e.detail;
    //  2 修改原数组
    let { tabs } = this.data;
    tabs.forEach((v, i) => i === index ? v.isActive = true : v.isActive = false);
    this.setData({
      tabs
    });
  },
  /** 点击“+”选择图片 */
  handleChooseImg() {
    //  2 调用小程序内置的选择图片api
    wx.chooseImage({
      /** 最多可以选择的图片张数 */
      count: 9,
      /** 所选的图片的尺寸 */
      sizeType: ['original', 'compressed'],
      /** 选择图片的来源 */
      sourceType: ['album', 'camera'],
      success: (result) => {
        console.log(result);
        this.setData({
          //  图片数组 进行拼接
          chooseImgs: [...this.data.chooseImgs, ...result.tempFilePaths]
        })
      }
    });
  },
  /** 点击 自定义图片组件 */
  handleRemoveImg(e) {
    // 获取被点击的组件的索引
    const { index } = e.currentTarget.dataset;
    // 获取 data 中的图片数组
    let { chooseImgs } = this.data;
    // 删除元素
    chooseImgs.splice(index, 1);
    this.setData({
      chooseImgs
    });
  },
  /** 文本域的输入事件 */
  handleTextInput(e) {
    this.setData({
      textVal: e.detail.value
    })
  },
  /** 提交按钮的点击 */
  handleFormSub() {
    // 获取文本域的内容
    const { textVal, chooseImgs } = this.data;
    // 合法性的验证
    if (!textVal.trim()) {
      wx.showToast({
        title: '输入不合法',
        icon: 'none',
        mask: true
      });
      return;
    }
    // 准备上传图片 到专门的图片服务器
    // 上传文件的 api 不支持 多个文件同时上传 遍历数组 挨个上传
    // 显示正在等待的图片
    wx.showLoading({
      title: '正在上传中',
      mask: true,
    });

    // 判断有没有需要上传的图片数组
    if (chooseImgs.length != 0) {
      chooseImgs.forEach((v, i) => {
        wx.uploadFile({
          // 图片上传地址
          url: '',
          // 被上传的文件的路径
          filePath: v,
          // 上传的文件的名称 后台来获取文件 file
          name: 'file',
          // 顺带的文本信息
          formData: {},
          success: (result) => {
            let url = JOSN.parse(result.data).url;
            this.UpLoadImgs.push(url);

            //  所有的图片都上传完毕了才触发
            if (i === chooseImgs.length - 1) {
              wx.hideLoading();
              console.log("把文本的内容和外围的图片数组 提交到后台中");
              // 提交都成功了
              // 重置页面
              this.setData({
                textVal: '',
                chooseImgs: []
              });
              // 返回上一个页面
              wx.navigateBack({
                delta: 1
              });
            }
          },
        });
      });
    } else {
      console.log("只是提交了文本");
      wx.navigateBack({
        delta: 1
      });
    }
  }
})