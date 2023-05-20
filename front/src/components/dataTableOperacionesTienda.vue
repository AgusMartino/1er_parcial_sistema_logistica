<template>
    <tr>
        <td scope="row">{{IdDetalle}}</td>
        <td>{{IdTransaccion}}</td>
        <td>{{Origen}}</td>
        <td>{{Producto}}</td>
        <td>{{Cantidad}}</td>
        <td>{{usuario}}</td>
        <td>{{Fecha}}</td>
    </tr>
</template>

<script>
export default {
props: {
    IdDetalle: String,
    IdTransaccion: String,
    Origen: String,
    Producto: String,
    Cantidad: String,
    usuario: String,
    Fecha: String
},
data() {
return {
    }
}
}
</script>

<style>
</style>