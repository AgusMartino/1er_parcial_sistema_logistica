<template>
    <tr>
        <td scope="row">{{IdTienda}}</td>
        <td>{{Nombre}}</td>
        <td>{{Provincia}}</td>
        <td>{{Localidad}}</td>
        <td><router-link :to="{name:'movimientosPorTienda', params:{id:this.IdTienda}}" type="button" class="btn btn-outline-secondary" props="true">Seleccionar</router-link></td>
    </tr>
</template>

<script>
export default {
props: {
    IdTienda: String,
    Nombre: String,
    Provincia: String,
    Localidad: String
},
data() {
return {
    }
}
}
</script>

<style>
</style>