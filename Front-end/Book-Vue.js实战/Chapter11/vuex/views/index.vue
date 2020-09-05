<template>
  <div>
    <h1>首页</h1>
    <router-link to="/about">跳转到about</router-link>
    {{count}}
    <button @click="handleIncrement">+10</button>
    <button @click="handleDecrease">-1</button>
    <button @click="handleActionIncrement">action+1</button>
    <button @click="handleAsyncIncrement">async+1</button>
    <div>{{list}}</div>
    <div>{{listCount}}</div>
  </div>
</template>
<script>
export default {
  computed: {
    count() {
      return this.$store.state.count;
    },
    list() {
      return this.$store.getters.filteredList;
    },
    listCount() {
      return this.$store.getters.listCount;
    }
  }, //  计算属性
  methods: {
    // handleIncrement: function() {
    //   this.$store.commit({
    //     type: "increment",
    //     count: 10
    //   });
    // },
    handleIncrement: function() {
      this.$store.commit("increment", 10);
    },
    handleDecrease() {
      this.$store.commit("decrease");
    },
    handleActionIncrement() {
      this.$store.dispatch("increment");
    },
    handleAsyncIncrement() {
      this.$store.dispatch("asyncIncrement").then(() => {
        console.log(this.$store.state.count); //  1
      });
    }
  }
};
</script>