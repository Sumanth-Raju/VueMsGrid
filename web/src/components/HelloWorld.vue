<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <Grid
    :columns="columns"
    :data-items="result"
    ></Grid>


  </div>
</template>

<script>

import http from "../services/Http-Common.js"
import colorCell from "./CustomCell.vue";

export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data(){
    return{
      result:[],
      columns:[
        { field: 'id',  title: 'ID', width: '80px', cell:colorCell },
                { field: 'name', title: 'Name', width: '80px' },
      ]
    }
  },
  methods:{
    getData(){
        http.get("/api/Medicine").then((res) => {
          this.result =res.data;
        }

        )
    }
  },
  mounted(){
    this.getData()
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
