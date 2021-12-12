import Vue from 'vue'
import App from './App.vue'
import '@progress/kendo-theme-default/dist/all.css'
import {Grid} from "@progress/kendo-vue-grid"


Vue.config.productionTip = false


Vue.component("Grid", Grid);


new Vue({
  render: h => h(App),
}).$mount('#app')
