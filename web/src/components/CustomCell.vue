<template>
    <td :style="CellBg(dataItem)">
        {{dataItem[field]}}
    </td>
</template>
<script>
export default{
      name: 'CustomCell',
  props: {
        field: String,
        dataItem: Object,
  },
  data(){
      return {

      }
  },
  methods:{
      CellBg(col){
            if(col.id == 1){
                return {
                    "background-color": 'green'
                }
            }
      }
  }
}
</script>
