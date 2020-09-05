<template>
  <main class="faq">
    <h1>Frenquently Asked Questions</h1>

    <div class="error" v-if="hasRemoteErrors">Can't load the questions</div>

    <section class="list">
      <article v-for="question of questionList">
        <h2 v-html="question.title"></h2>
        <p v-html="question.content"></p>
      </article>
    </section>

    <Loading v-if="remoteDataLoading" />
  </main>
</template>
<script>
import RemoteData from "../mixins/RemoteData";
export default {
  mixins: [
    RemoteData({
      questionList: "questions"
    })
  ]
};
</script>