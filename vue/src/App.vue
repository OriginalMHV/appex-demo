<script>
import SearchBox from './components/search-box.vue'

export default {
  components: {SearchBox},
  name: 'App',
  component: {
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
