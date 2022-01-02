<script>
import SearchBox from './components/search-box.vue'
import BodyForm from './components/body-form.vue'

export default {
  components: {BodyForm, SearchBox},
  name: 'App',
  component: {
    BodyForm,
    SearchBox
  }
}
</script>
<template>
  <div id="app">
    <header></header>
      <search-box><form>
        <input type="text" v-model="search" @keyup.enter="searchFor" placeholder="Search {org nr, name...}">
        </form></search-box>
        <body-form :org="org" :search="search"></body-form>
    <router-view/>
  </div>
</template>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
