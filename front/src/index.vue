<template>
<div id="app">
    <nav class="navbar navbar-dark bg-dark navbar-expand-lg">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
            <router-link to="/menuPrincipal" class="nav-link active" aria-current="page">1er Parcial SAP</router-link>
            </li>
            <li class="nav-item">
            <router-link to="/operaciones" class="nav-link">Operaciones</router-link>
            </li>
            <li class="nav-item">
            <router-link to="/informes" class="nav-link">10 ultimas operaciones</router-link>
            </li>
            <li class="nav-item">
            <router-link to="/gestionTiendas" class="nav-link">Movimientos por tienda</router-link>
            </li>
        </ul>
    </nav>
    <router-view/>
</div>
</template>

<script>
</script>
<style>
</style>
