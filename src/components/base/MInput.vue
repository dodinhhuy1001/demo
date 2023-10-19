<template>
  <div class="form-id-name">
    <div class="text-field-demo">
      <label class="text-field__title">Mã<span>*</span></label>
      <input type="text" class="text-field__input text-field__input--nomal form-id__input"  v-bind:value="modelValue" @input="onInput"/>
      <div>value Con:{{ modelValue }}</div>
      <p class="text-field__desc-error text-field__desc-error--hidden" id="code-error-desc"></p>
    </div>
  </div>
</template>

<script>
/* eslint-disable */
export default {
  name: "MInput",
  props: ["nameInput","modelValue"],
  methods: {
    onInput(event){
        const value = event.target.value;
        this.$emit("update:modelValue", value);
    }
  },
  data() {
    return {
    };
  },
};
</script>

<style>
@import url("../../css/form.css");
</style>
