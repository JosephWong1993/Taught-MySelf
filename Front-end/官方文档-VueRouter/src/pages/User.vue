<template>
  <div>
    <h2>User {{$route.params.id}}</h2>
    <router-view></router-view>
    <router-view name="a"></router-view>
    <router-view name="b"></router-view>
  </div>
</template>
<script lang="ts">
import Vue from "vue";
export default Vue.extend({
  beforeRouteUpdate(to, from, next) {
    console.log("User-beforeRouteUpdate");
    console.log(arguments);
    next();
  }
});
</script>
