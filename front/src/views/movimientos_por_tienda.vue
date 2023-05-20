<template>
    <div class="container">
      <div class="col">
        <h3>Listado de operaciones de la tienda</h3>
                <input
                v-model="destino"
                class="form-control mt-3 mb-3"
                id="myInput"
                type="text"
                placeholder="Buscar destino"
                />
        
                <table class="table">
                    <tr>
                        <th scope="col">IdDetalle</th>
                        <th scope="col">IdTransaccion</th>
                        <th scope="col">Origen</th>
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
  import dataTable from "../components/dataTableOperacionesTienda.vue"
  import axios from "axios"
  export default{
    props: {
        id: String
    },
    components:{
        dataTable,
    },
    data() {
        return {
            entradasJSON: [],
            operacion: {},
            loading: false,
            destino: null
        };
    },
    mounted(){
        this.getDestinos();
    },
    methods:{
        getDestinos(){
            this.loading = true
            axios.get("https://localhost:44311/Reportes/GetOperacionesDestino")
            .then(response=>{
            response.data.forEach((operacion) => {
                this.operacion = operacion;
                console.log(operacion);
                console.log(this.id);
                if(this.operacion.idTienda == this.id){
                    this.entradasJSON.push(operacion)
                    
                }
                
            });
            })
            .catch(err =>{
            alert(err.data)
            })
            .finally(data =>{
            this.loading = false
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