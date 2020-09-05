<template>
  <div class="daily">
    <div class="daily-menu">
      <div class="daily-menu-item" :class="{on:type==='recommend'}">每日推荐</div>
      <div class="daily-menu-item" :class="{on:type==='daily'}" @click="showThemes= !showThemes">主题日报</div>
      <ul v-show="showThemes">
        <li v-for="item in themes">
          <a :class="{ on:items.id === themeId && type=== 'daily'}" @click="handleToTheme(item.id)">{{item.name}}</a>
        </li>
      </ul>
    </div>
    <div class="daily-list" ref="list">
      <template v-if="type==='recommend'">
        <div v-for="list in recommendList">{{formatDay(list.date)}}</div>
        <Item v-for="item in list.stories" :date="item" :key="item.id"></Item>
      </template>
      <template v-if="type==='daily'">
        <Item v-for="item in list" :date="item" :key="item.id"></Item>
      </template>
    </div>
    <daily-article></daily-article>
  </div>
</template>

<script>
//  导入组件
import $ from ".libs/util";
import Item from "./components/item.vue";

export default {
  components: { Item },
  data: function() {
    return {
      themes: [],
      showThemes: false,
      type: "recommend",
      list: [],
      themeId: 0,
      recommendList: [], //  推荐文章列表的数据
      dailyTime: $.getTodayTime(),
      isLoading: false
    };
  },
  methods: {
    //  转换为带汉子的月日
    format(date) {
      let month = date.substr(4, 2);
      let day = date.substr(6, 2);
      if (month.substr(0, 1) === "0") month = month.substr(1, 1);
      if (day.substr(0, 1) === "0") day = day.substr(1, 1);
      return `${month}月${day}日`;
    },
    handleToRecommend() {
      this.type = "recommend";
      this.recommendList = [];
      this.dailyTime = $.getTodayTime();
      this.getRecommendList();
    },
    getRecommendList() {
      //  加载时设置为true,加载完成后置为false
      this.isLoading = true;
      const prevDay = $.prevDay(this.dailyTime + 24 * 60 * 60 * 1000);
      $.ajax.get("news/before/" + prevDay).then(res => {
        this.recommendList.push(res);
        this.isLoading = false;
      });
    },
    handleToTheme(id) {
      //  改变菜单分类
      this.type = "daily";
      //  设置当前点击子类的主题日报id
      this.themeId = id;
      //  清空中间栏的数据
      this.list = [];
      $ajax.get("theme/" + id).then(res => {
        //  过滤掉类型为1的文章,该类型下的文章为空
        this.list = res.stories.filter(item => item.type !== 1);
      });
    },
    getThemes() {
      //  axios发起get请求
      $.ajax.get("themes").then(res => {
        this.themes = res.others;
      });
    }
  },
  mounted() {
    //  初始化时调用
    this.getThemes();

    this.getRecommendList();
    //  获取到DOM
    const $list = this.$refs.list;
    //  监听中栏的滚动事件
    $list.addEventListener("scroll", () => {
      //  在"主题日报"正在加载推荐列表时停止操作
      if (this.type === "daily" || this.isLoading) return;
      //  已经滚动的距离加页面的高度等于整个内容区域高度时,视为接触底部
      if ($list.scrollTop + document.body.clientHeight >= $list.scrollHeight) {
        //  时间相对减少一天
        this.dailyTime -= 86400000;
        this.getRecommendList();
      }
    });
  }
};
</script>
