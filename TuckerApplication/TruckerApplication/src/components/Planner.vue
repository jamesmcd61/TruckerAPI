<template>
    <div>
        <h1 style="text-align:center">Planner</h1>
    </div>
</template>

<script setup lang="ts">
    import { ref, onMounted } from 'vue';
    import axios from 'axios';
    import moment from 'moment';

    function SavedTodo() {
        location.reload();
    }

    onMounted(async () => {
    })

</script>

<style scoped>
    .container {
        column-count: 3;
        column-gap: 40px;
        padding: 40px;
    }
</style>