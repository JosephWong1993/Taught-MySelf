import Vue from 'vue';
import App from './app.vue';

import './style.css';

new Vue({
    el: '#app',
    // render: h => h(App)
    // render: h => {
    //     return h(App);
    // }
    render: function (h) {
        return h(App);
    }
});

// document.getElementById('app').innerHTML = 'Hello webpack.';