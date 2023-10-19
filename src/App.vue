<template>
  <TheHeader></TheHeader>
  <TheSidebar></TheSidebar>
  <TheMain></TheMain>
</template>

<script>
import TheHeader from './layout/TheHeader.vue';
import TheSidebar from './layout/TheSidebar.vue';
import TheMain from './layout/TheMain.vue';
export default {
  name:"App",
  components:{
    TheHeader,TheSidebar,TheMain
  }
  };
</script>

<style>
 body {
    overflow: hidden;
 }
</style>
