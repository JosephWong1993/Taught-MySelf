import Vue from 'vue';
import VueRouter from 'vue-router';
Vue.use(VueRouter);
import Vuex from 'vuex';
Vue.use(Vuex);
import VueBus from './vue-bus';
Vue.use(VueBus);
import App from './app.vue';
import './style.css';





//#region   路由配置

const Routers = [{
        path: '/index',
        meta: {
            title: '首页'
        },
        component: (resolve) => require(['./views/index.vue'], resolve)
    },
    {
        path: '/about',
        meta: {
            title: '关于'
        },
        component: (resolve) => require(['./views/about.vue'], resolve)
    },
    {
        path: '/user/:id',
        meta: {
            title: '个人主页'
        },
        component: (resolve) => require(['./views/user.vue'], resolve)
    },
    { //  当访问的路径不存在时,重定向到首页
        path: '*',
        redirect: '/index'
    }
];
const RouterConfig = {
    //  使用HTML的History模式
    mode: 'history',
    routes: Routers
};
const router = new VueRouter(RouterConfig);
/**
 * beforeEach:在路由即将改变前触发
 * 参数:
 *  to:即将要进入的目标的路由对象
 *  from:当前导航即将要离开的路由对象
 *  next:调用该方法后,才能进入下一个钩子 
 */
router.beforeEach((to, from, next) => {
    window.document.title = to.meta.title;
    next();
});

/**
 * afterEach:在路由改变后触发
 */
router.afterEach((to, from, next) => {
    window.scrollTo(0, 0);
});

//#endregion

//  vuex的配置
const store = new Vuex.Store({
    state: {
        count: 0,
        list: [1, 5, 8, 10, 30, 50]
    },
    getters: {
        filteredList: state => {
            return state.list.filter(item => item < 10);
        },
        listCount: (state, getters) => {
            return getters.filteredList.length;
        }
    },
    mutations: {
        // increment(state, params) {
        //     state.count += params.count;
        // },
        increment(state, n = 1) {
            state.count += n;
        },
        decrease(state) {
            state.count--;
        }
    },
    actions: {
        increment(context) {
            context.commit('increment');
        },
        asyncIncrement(context) {
            return new Promise(resolve => {
                setTimeout(() => {
                    context.commit('increment');
                    resolve();
                }, 1000 * 3);
            });
        },
    }
});

new Vue({
    el: '#app',
    router: router,
    store: store, //  使用vuex
    render: h => h(App)
});