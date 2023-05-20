<template>
    <div class="container">
      <div class="col">
        <h3>Primera 10 operaciones entre fechas</h3>
        <input
          v-model="destino"
          class="form-control mt-3 mb-3"
          id="myInput1"
          type="text"
          placeholder="ID de Tienda"
        />
        <input
          v-model="FechaInicio"
          class="form-control mt-3 mb-3"
          id="myInput2"
          type="date"
          placeholder="Fecha Inicio"
        />
        <input
          v-model="FechaFinal"
          class="form-control mt-3 mb-3"
          id="myInput3"
          type="date"
          placeholder="Fecha Final"
        />
        <button @Click="getOperaciones()" type="button" class="btn btn-outline-secondary">Buscar operaciones</button>
        <div v-if="datos == true">
            <table class="table">
                    <tr>
                        <th scope="col">IdDetalle</th>
                        <th scope="col">IdTransaccion</th>
                        <th scope="col">Origen</th>
                        <th scope="col">Destino</th>
                        <th scope="col">Producto</th>
                        <th scope="col">Cantidad</th>
                        <th scope="col">Usuario</th>
                        <th scope="col">Fecha</th>
                    </tr>
                    <tbody id="myTable">
                        <dataTable
                        v-for="operacion in entradasJSON"
                        :IdDetalle="operacion.idOperacion"
                        :IdTransaccion = "operacion.idTransaccion"
                        :Origen="operacion.NombreOrigen"
                        :Destino="operacion.NombreDestino"
                        :Producto="operacion.NombreProducto"
                        :Cantidad="operacion.cantidad"
                        :usuario="operacion.usuario"
                        :Fecha="operacion.fecha"
                        />
                    </tbody>
            </table>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import { stringifyQuery } from "vue-router";
import dataTable from "../components/dataTableOperaciones.vue"
  import axios from "axios"
  export default{
      components:{
          dataTable,
      },
      data() {
          return {
              entradasJSON: [],
              loading: false,
              datos: false,
              destino: null,
              FechaInicio: null,
              FechaFinal: null,
              getOperacionesFiltroFecha:{
                id: null,
                inicio: null,
                final: null
              }
              
          };
      },
      methods: {
        getOperaciones(){
              this.loading = true
              this.getOperacionesFiltroFecha.id = this.destino
              this.getOperacionesFiltroFecha.inicio = this.FechaInicio
              this.getOperacionesFiltroFecha.final = this.FechaFinal
              axios.get("https://localhost:44311/Reportes/GetOperacionesFiltroFecha/{id}?getOperacionesFiltroFecha.id="+this.destino+"&getOperacionesFiltroFecha.inicio="+this.FechaInicio+"&getOperacionesFiltroFecha.final="+this.FechaFinal)
              .then(response=>{
              this.entradasJSON = response.data;
              console.log(this.getOperacionesFiltroFecha.inicio)
              console.log(this.getOperacionesFiltroFecha.final)
              })
              .catch(err =>{
              alert(err.data)
              })
              .finally(data =>{
              this.loading = false
              this.datos = true
              })
          }
      }
  }
  </script>
  
  <style>
  .container {
    justify-content: center;
    align-items: center;
  }
  .col {
    justify-content: center;
    align-items: center;
    padding-right: 20%;
    padding-left: 20%;
  }
  </style>