import "babel-polyfill";

import Vue from "vue";
import router from "./router";

import "./global-components";
import AppLayout from "./components/AppLayout.vue";

import VueFetch, { $fetch } from "./plugins/fetch";
Vue.use(VueFetch, {
    baseUrl: "http://localhost:3000/",
});

import state from "./state";
import VueState from "./plugins/state";
Vue.use(VueState, state);

import * as filters from "./filters";
for (const key in filters) {
    Vue.filter(key, filters[key]);
}

async function main() {
    //  获取用户信息
    try {
        state.user = await $fetch("user");
    } catch (e) {
        console.warn(e);
    }

    //  启动应用
    new Vue({
        el: "#app",
        data: state,
        //  将路由器提供给应用
        router,
        render: h => h(AppLayout),
    });
}

main();
