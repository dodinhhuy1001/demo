<template>
    <div class="text-field">
        <!-- <label class="text-field__title">Field label</label> -->
        <div class="text-field__body">
            <input class="text-field__input text-field__input--combobox" placeholder="Type here"/>
            <i class="fa-solid fa-chevron-down icon--md text-field__icon--combobox"></i>
        </div>  
        <div class="combobox__result-list">
            <div class="combobox__result combobox__result--title">
                - Chọn giá trị -
                <i class="fa-solid fa-check icon_combo"></i>
            </div>
            <p class="combobox__result">Hà Nội</p>
            <p class="combobox__result">TP. Hồ Chí Minh</p>
            <p class="combobox__result">Đà Nẵng</p>
            <p class="combobox__result">Hải Phòng</p>
            <p class="combobox__result">Hải Dương</p>
        </div>
    </div>
</template>

<script>
/* eslint-disable */
export default {
    name:"Combobox"
}
</script>

<style>
@import url("../../css/combobox.css");
</style>