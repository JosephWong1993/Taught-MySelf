import Vue, { CreateElement, RenderContext } from "vue"

import Vuex from "vuex";
Vue.use(Vuex);

// 如果在模块化构建系统中，请确保在开头调用了 Vue.use(Vuex)
const store = new Vuex.Store({
    state: {
        count: 0
    },
    mutations: {
        increment: state => state.count++,
        decrement: state => state.count--
    },
    actions: {
        incrementAsync({ commit }) {
            setTimeout(() => {
                commit('increment')
            }, 1000)
        }
    }
});

import App from "./App.vue";
const app = new Vue({
    store,
    components: { App },
    //  默认Vue不导入编译器,*.vue文件内部的模板会在构建时预编译成 JavaScript。
    //  因为运行时版本相比完整版体积要小大约 30%，所以应该尽可能使用这个版本。
    //  当使用 vue-loader 或 vueify 的时候，*.vue 文件内部的模板会在构建时预编译成 JavaScript。
    //  在最终打好的包里实际上是不需要编译器的，所以只用运行时版本即可。
    // https://cn.vuejs.org/v2/guide/installation.html#%E8%BF%90%E8%A1%8C%E6%97%B6-%E7%BC%96%E8%AF%91%E5%99%A8-vs-%E5%8F%AA%E5%8C%85%E5%90%AB%E8%BF%90%E8%A1%8C%E6%97%B6
    // template: '<App/>',
    render: function (h: CreateElement, hack: RenderContext<Record<never, any>>) {
        return h('App');
    },
}).$mount("#app");