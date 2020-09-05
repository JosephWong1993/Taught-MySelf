<template>
  <div>
    <h1>首页</h1>
    <router-link to="/about">跳转到about</router-link>
    <div>
      {{count}}
      <button @click="handleIncrement">+10</button>
      <button @click="handleDecrease">-1</button>
      <button @click="handleActionIncrement">action+1</button>
      <button @click="handleAsyncIncrement">async+1</button>
    </div>
    <div>数组:{{list}} 数组长度:{{listCount}}</div>
    <div>
      随机增加:
      <Counter :number="number"></Counter>
    </div>
  </div>
</template>
<script>
import Counter from "./counter.vue";
export default {
  components: {
    Counter: Counter
  },
  data: function() {
    return {
      number: 0
    };
  },
  computed: {
    //  计算属性
    count() {
      return this.$store.state.count;
    },
    list() {
      return this.$store.getters.filteredList;
    },
    listCount() {
      return this.$store.getters.listCount;
    }
  },
  methods: {
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
    },
    hanldeAddRandom: function(num) {
      this.number += num;
    }
  },
  created() {
    this.$bus.on("add", this.hanldeAddRandom);
  },
  beforeDestroy() {
    this.$bus.off("add", this.hanldeAddRandom);
  }
};
</script>