<template>
<div class="container">
    <div class="row justify-content-center mt-5">
        <div class="col-3">
            <router-link to="/operaciones" type="button" class="btn btn-secondary">Operaciones</router-link>
        </div>
        <div class="col-3">
            <router-link to="/informes" type="button" class="btn btn-secondary">10 ultimmas operaciones</router-link>
        </div>
        <div class="col-3">
            <router-link to="/gestionTiendas" type="button" class="btn btn-secondary">Movimientos de tienda</router-link>
        </div>
    </div>
</div>
</template>

<script>
import axios from 'axios'
import { useRouter } from 'vue-router';

export default{
    components:{
    },
    methods: {
        logout(){
                axios.delete("https://localhost:44398/User/Logout", { params: { username: localStorage.getItem("username") } })
                .then(response=> {
                    if(response.status==200) {
                    alert('Hasta la proxima!');
                    localStorage.clear()
                    this.$router.replace("/")
                    }
                })
                .catch(err =>{
                    alert(err.data)
                })
        }
    }
}
</script>
<style>
.container{
    justify-content: center;
    align-items: center;
}
.col-4{
    justify-content: center;
    align-items: center;
    margin-top: 10%;
    padding-right: 30%;
    padding-left: 30%
}
</style>
