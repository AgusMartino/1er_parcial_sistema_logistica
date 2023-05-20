<template>
    <div class="container">
      <div class="col">
        <h3>Listado de destinos existentes</h3>
        <input
          v-model="destinos"
          class="form-control mt-3 mb-3"
          id="myInput"
          type="text"
          placeholder="Buscar destino"
        />
  
        <table class="table">
          <tr>
            <th scope="col">Nombre</th>
            <th scope="col">Provincia</th>
            <th scope="col">Localidad</th>
            <th scope="col">Seleccionar</th>
          </tr>
          <tbody id="myTable">
            <dataTable
              v-for="tienda in Destinosfilter"
              :IdTienda = "tienda.id"
              :Nombre = "tienda.Nombre"
              :Provincia="tienda.Provincia"
              :Localidad="tienda.Localidad"
            />
          </tbody>
        </table>
      </div>
    </div>
  </template>
  
  <script>
  import dataTable from "../components/dataTableTiendas.vue"
  import axios from "axios"
  export default{
      components:{
          dataTable,
      },
      data() {
          return {
              entradasJSON: [],
              loading: false,
              destinos: null
          };
      },
      mounted() {
          this.getDestinos();
      },
      methods: {
        getDestinos(){
              this.loading = true
              axios.get("https://localhost:44311/Sucursal/GetTiendas")
              .then(response=>{
              this.entradasJSON = response.data;
              })
              .catch(err =>{
              alert(err.data)
              })
              .finally(data =>{
              this.loading = false
              })
          }
      },
      computed:{
        Destinosfilter(){
                  if(!this.destinos)
                    return this.entradasJSON;
                  else
                    return this.entradasJSON.filter((data) => {
                    return !data.Nombre.toLowerCase().indexOf((this.destinos.toLowerCase()));
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