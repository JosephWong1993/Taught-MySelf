<template>
  <div>
    <p>{{ count }}</p>
    <p>
      <button @click="increment">+</button>
      <button @click="decrement">-</button>
    </p>
  </div>
</template>
<script lang="ts">
import Vue from "vue";

declare type VueVm = Vue;

export default {
  computed: {
    count(this: VueVm) {
      return this.$store.state.count;
    }
  },
  methods: {
    increment(this: VueVm) {
      this.$store.commit("increment");
    },
    decrement(this: VueVm) {
      this.$store.commit("decrement");
    }
  }
};
</script>
