<template>
  <div>
    Hello {{name}}
    <v-title title="Vue组件化"></v-title>
    <v-button @click="handleClick">组件按钮</v-button>
    <p>
      <img src="./images/image.png" style="width:200px;">
    </p>
    <router-view></router-view>
  </div>
</template>

<script>
//  导入组件
import vTitle from "./title.vue";
import vButton from "./button.vue";

export default {
  components: {
    // vTitle: vTitle,
    vTitle,
    // vButton: vButton
    vButton
  },
  data: function() {
    return {
      name: "Vue.js"
    };
  },
  methods: {
    handleClick: function(e) {
      console.log(e);
    }
  }
};
</script>

<style scoped>
div {
  color: #f60;
  font-size: 24px;
}
</style>
