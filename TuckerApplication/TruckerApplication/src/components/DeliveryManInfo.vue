<template>
    <DxForm>
        <DxSimpleItem data-field="FirstName"/>
        <DxSimpleItem data-field="FirstName"/>
        <DxSimpleItem data-field="FirstName"/>
        <DxSimpleItem data-field="FirstName"/>
        <DxSimpleItem data-field="FirstName"/>
    </DxForm>
</template>

<script setup lang="ts">
    import { ref, onMounted } from 'vue';
    import axios from 'axios';
    import moment from 'moment';
    import {DxForm, DxSimpleItem, DxGroupItem, DxLabel} from 'devextreme-vue/form';

    function SavedTodo() {
        location.reload();
    }
</script>

<style scoped>
    .container {
        column-count: 3;
        column-gap: 40px;
        padding: 40px;
    }
</style>