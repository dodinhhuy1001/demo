/* eslint-disable */
import { createApp } from 'vue'
import App from './App.vue'
import HuyButton from './components/dmo/Button.vue'
import MInput from './components/base/MInput.vue'

const app = createApp(App)
app.component("huy-button",HuyButton)
app.component("m-input",MInput)
app.mount('#app')
