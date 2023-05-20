import { createApp } from 'vue'
import App from './index.vue'
import { createRouter, createWebHistory } from 'vue-router'

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap/dist/js/bootstrap.js'

const routes = [
  {
    path:'/',
    name:'login',
    component: () => import('./views/login.vue')
},
{
    path:'/menuPrincipal',
    name:'menuPrincipal',
    component: () => import('./views/menuPrincipal.vue')
},
{
    path:'/operaciones',
    name:'operaciones',
    component: () => import('./views/operaciones.vue')
},
{
    path:'/informes',
    name:'informes',
    component: () => import('./views/informes.vue'),
},
{
    path:'/movimientosPorTienda/:id',
    name:'movimientosPorTienda',
    component: () => import('./views/movimientos_por_tienda.vue'),
    props: true
},
{
    path:'/gestionTiendas',
    name:'gestionTiendas',
    component: () => import('./views/gestionTiendas.vue')
}
]

const router = createRouter({
  history: createWebHistory('/'),
  routes
})

createApp(App).use(router).mount('#app')