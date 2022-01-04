<script>
import SearchBox from './components/search-box.vue'
import TitleHeader from './components/title-header.vue'
import BodyForm from './components/body-form.vue'

export default {
  components: {TitleHeader, BodyForm, SearchBox},
  name: 'App',
  component: {
    TitleHeader,
    BodyForm,
    SearchBox
  }
}
</script>
<template>
  <div id="app">
    <title-header></title-header>
      <search-box><form>
        </form></search-box>
        <body-form>
        </body-form>
    <router-view/>
  </div>
</template>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  margin-top: 30px;
  color: #2c3e50;
}

h1 {
  font-size: 3rem;
  font-family: 'Indie Flower', cursive;
  margin-top: 60px;
}
</style>
