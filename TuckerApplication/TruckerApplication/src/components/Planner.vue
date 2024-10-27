<template>
    <div>
        <h1 style="text-align:center">Planner</h1>
    </div>
    <CNav variant="tabs">
        <CNavItem href="javascript:void(0);"
            :active="tabPaneActiveKey === 1"
            @click="() => {tabPaneActiveKey = 1}">
            Planner
        </CNavItem>
        <CNavItem
            href="javascript:void(0);"
            :active="tabPaneActiveKey === 2"
            @click="() => {tabPaneActiveKey = 2}">
            Delivery Man Infomation
        </CNavItem>
        <CNavItem href="javascript:void(0);"
            :active="tabPaneActiveKey === 3"
            @click="() => {tabPaneActiveKey = 3}">
            Delivery Information
        </CNavItem>
    </CNav>

    <CTabContent>
    <CTabPane role="tabpanel" aria-labelledby="home-tab" :visible="tabPaneActiveKey === 1">
        <DxScheduler>

        </DxScheduler>
    </CTabPane>
    <CTabPane role="tabpanel" aria-labelledby="profile-tab" :visible="tabPaneActiveKey === 2">
        <DeliveryManInfo>
        </DeliveryManInfo>
    </CTabPane>
    <CTabPane role="tabpanel" aria-labelledby="contact-tab" :visible="tabPaneActiveKey === 3">
        Put here the Component for the Delivery Information
    </CTabPane>
  </CTabContent>
</template>

<script setup lang="ts">
    import { ref, onMounted } from 'vue';
    import axios from 'axios';
    import moment from 'moment';
    import { DxScheduler, DxResource } from 'devextreme-vue/scheduler';
    import { CNav, CNavItem, CNavLink, CTabPane, CTabContent } from '@coreui/vue'
    import DeliveryManInfo from './DeliveryManInfo.vue';
    import DeliveryInfo from './DeliveryInfo.vue';

    const tabPaneActiveKey = ref(1)


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