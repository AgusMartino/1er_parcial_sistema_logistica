<template>
    <div class="container">
      <div class="col">
        <h3>Listado de operaciones de la tienda</h3>
            <h4>Filtro destino</h4>
                <input
                v-model="destino"
                class="form-control mt-3 mb-3"
                id="myInput"
                type="text"
                placeholder="Buscar por destinos"
                />
        
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
                        v-for="operacion in Destinosfilter"
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
</template>
  
  <script>
  import dataTable from "../components/dataTableOperaciones.vue"
  import axios from "axios"
  export default{
    components:{
        dataTable,
    },
    data() {
        return {
            entradasJSON: [],
            operacion: {},
            loading: false,
            destino: null,
            origen: null
        };
    },
    mounted(){
        this.getOperaciones();
    },
    methods:{
        getOperaciones(){
            this.loading = true
            axios.get("https://localhost:44311/Reportes/GetOperaciones")
            .then(response=>{
            this.entradasJSON = response.data 
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
                  if(!this.destino)
                    return this.entradasJSON;
                  else
                    return this.entradasJSON.filter((data) => {
                    return !data.NombreDestino.toLowerCase().indexOf((this.destino.toLowerCase()));
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