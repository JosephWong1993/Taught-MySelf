import Vue from "vue"

//  引入VueRouter
import VueRouter from "vue-router";
Vue.use(VueRouter);

//  https://www.iviewui.com/docs/guide/start
//  引入iview
import 'iview/dist/styles/iview.css';
import iView from 'iview';
Vue.use(iView);
//  按需引用iview
// import { Button, Table } from 'iview';
// Vue.component('Button', Button);
// Vue.component('Table', Table);

// 1. 定义 (路由) 组件。
import Foo from "./pages/Foo.vue";
import Bar from "./pages/Bar.vue";
import User from "./pages/User.vue";

import UserHome from "./pages/User/UserHome.vue";
import UserProfile from "./pages/User/UserProfile.vue";
import UserPosts from "./pages/User/UserPosts.vue";

// 2. 定义路由
const routes = [
    // { path: "/foo", name: "Foo", component: Foo },
    //  重定向
    //  https://router.vuejs.org/zh/guide/essentials/redirect-and-alias.html#%E9%87%8D%E5%AE%9A%E5%90%91
    // { path: "/foo", redirect: { name: "bar" } },
    //  别名
    { path: '/foo', component: Foo, alias: '/a' },
    { path: "/bar", name: "bar", component: Bar },
    {
        path: "/user/:id", name: "user", component: User, children: [
            // // 当 /user/:id 匹配成功，
            // // UserHome 会被渲染在 User 的 <router-view> 中
            // { path: '', component: UserHome },
            // // 当 /user/:id/profile 匹配成功，
            // // UserProfile 会被渲染在 User 的 <router-view> 中
            // { path: "profile", component: UserProfile },
            // // 当 /user/:id/posts 匹配成功
            // // UserPosts 会被渲染在 User 的 <router-view> 中
            // { path: 'posts', component: UserPosts }
            {
                path: "/",
                components: {
                    default: UserHome,
                    a: UserProfile,
                    b: UserPosts
                }
            }
        ]
    },
]

// 3. 创建 router 实例，然后传 `routes` 配置
const router = new VueRouter({
    routes: routes
});

// 4. 创建和挂载根实例。
import App from "./App.vue";
const app = new Vue({
    components: { App },
    //  默认Vue不导入编译器,*.vue文件内部的模板会在构建时预编译成 JavaScript。
    //  因为运行时版本相比完整版体积要小大约 30%，所以应该尽可能使用这个版本。
    //  当使用 vue-loader 或 vueify 的时候，*.vue 文件内部的模板会在构建时预编译成 JavaScript。
    //  在最终打好的包里实际上是不需要编译器的，所以只用运行时版本即可。
    // https://cn.vuejs.org/v2/guide/installation.html#%E8%BF%90%E8%A1%8C%E6%97%B6-%E7%BC%96%E8%AF%91%E5%99%A8-vs-%E5%8F%AA%E5%8C%85%E5%90%AB%E8%BF%90%E8%A1%8C%E6%97%B6
    // template: '<App/>',
    render: function (h, hack)
    {
        return h('App');
    },
    router: router
}).$mount("#app");