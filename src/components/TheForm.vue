<template>
    <div class="form-wrapper" id="form-wrapper">
        <div class="form--employee">
            <!-- form header -->
            <div class="form-header">
                <div class="form-header__right">
                    <div class="pseudo-element--top" tabindex="0"></div>
                    <button class="icon-wrapper icon--margin-left" id="btn-close-form" tabindex="0" @click="close" aria-label="Close modal">
                    </button>
                    <div class="icon icon-question" tabindex="0"></div>
                </div>
                <div class="form-header__left">
                    <label for="">Là nhà cung cấp</label>
                    <div class="checkbox-form">
                        <input type="checkbox" checked="checked">
                        <!-- <span class="checkmark"></span> -->
                    </div>
                    <div class="checkbox">
                        <label for="">Là khách hàng</label>
                        <input type="checkbox" checked="checked">
                        <!-- <span class="checkmark"></span> -->
                    </div>
                    <h3 class="form-header__title">Thông tin nhân viên</h3>
                </div>
            </div>
            <!-- form content -->
            <div class="form-content">
                <div class="form-content__top">
                    <div class="form-content__left">
                        <div class="form-id-name">
                            <div class="text-field">
                                <label class="text-field__title">Mã<span>*</span></label>
                                <input class="text-field__input text-field__input--nomal form-id__input" id="input-code" fieldName="code"/>
                                <p class="text-field__desc-error text-field__desc-error--hidden" id="code-error-desc"></p>
                            </div>
                            <div class="text-field">
                                <label class="text-field__title">Tên<span>*</span></label>
                                <input class="text-field__input text-field__input--nomal name-input" id="input-name" fieldName="name"/>
                                <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                            </div>
                        </div>
                        <div class="text-field form-input--w-100">
                            <label class="text-field__title">Đơn vị<span>*</span></label>
                            <input class="text-field__input text-field__input--nomal" id="input-organization" fieldName="organization"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden" id="organization-error-desc"></p>
                        </div>
                        <div class="text-field form-input--w-100">
                            <label class="text-field__title">Chức danh<span>*</span></label>
                            <input class="text-field__input text-field__input--nomal" id="input-title" fieldName="title"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                    </div>
                    <div class="form-content__right">
                        <div class="form-date-gender">
                            <div class="text-field">
                                <label class="text-field__title">Ngày sinh<span>*</span></label>
                                <input type="date" class="text-field__input text-field__input--nomal form-date-input" id="input-date-of-birth" fieldName="dateOfBirth"/>
                                <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                            </div>
                            <div class="text-field">
                                <label class="text-field__title">Giới tính</label>
                                <div class="text-field__wrapper--radio-input form-gender-input">
                                    <input class="text-field__input--radio-input" type="radio" id="male" name="gender" value="0">
                                    <label class="text-field__label--radio-input" for="male">Nam</label>
                                    <input class="text-field__input--radio-input" type="radio" id="female" name="gender" value="1">
                                    <label class="text-field__label--radio-input" for="female">Nữ</label>
                                    <input class="text-field__input--radio-input" type="radio" id="other" name="gender" value="2">
                                    <label class="text-field__label--radio-input" for="other">Khác</label>
                                </div>
                            </div>
                        </div>
                        <div class="form-id-card__wrapper">
                            <div class="text-field form-id-card__input">
                                <label class="text-field__title" title="Số chứng minh nhân dân">Số CMND</label>
                                <input class="text-field__input text-field__input--nomal" id="input-identity-id"/>
                                <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                            </div>
                            <div class="text-field">
                                <label class="text-field__title">Ngày cấp</label>
                                <input type="date" class="text-field__input text-field__input--nomal form-date-input" id="input-date-of-identity" fieldName="dateOfIdentity"/>
                                <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                            </div>
                        </div>
                        <div class="text-field form-input--w-100">
                            <label class="text-field__title">Nơi cấp</label>
                            <input class="text-field__input text-field__input--nomal" id="input-place-of-identity"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                    </div>
                </div>
                <div class="form-content__down">
                    <div class="text-field form-input--w-100">
                        <label class="text-field__title">Địa chỉ</label>
                        <input class="text-field__input text-field__input--nomal" id="input-address"/>
                        <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                    </div>
                    <div class="form-comunication">
                        <div class="text-field">
                            <label class="text-field__title">ĐT di động</label>
                            <input class="text-field__input text-field__input--nomal" id="input-mobile-phone"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                        <div class="text-field">
                            <label class="text-field__title">ĐT cố định</label>
                            <input class="text-field__input text-field__input--nomal" id="input-landline-phone"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                        <div class="text-field">
                            <label class="text-field__title">Email</label>
                            <input class="text-field__input text-field__input--nomal" id="input-email" fieldName="email"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                    </div>
                    <div class="form-bank">
                        <div class="text-field">
                            <label class="text-field__title">Tài khoản ngân hàng</label>
                            <input class="text-field__input text-field__input--nomal" id="input-bank-account"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                        <div class="text-field">
                            <label class="text-field__title">Tên ngân hàng</label>
                            <input class="text-field__input text-field__input--nomal" id="input-bank-name"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                        <div class="text-field">
                            <label class="text-field__title">Chi nhánh</label>
                            <input class="text-field__input text-field__input--nomal" id="input-bank-branch"/>
                            <p class="text-field__desc-error text-field__desc-error--hidden"></p>
                        </div>
                    </div>
                </div>
            </div>
            <hr>
            <!-- form footer -->
            <div class="form-footer">
                <div class="form-footer_btn-right">
                    <button class="btn btn--primary" id="btn-save-and-add">Cất và Thêm</button>
                    <button class="btn btn--secondary" id="btn-save">Cất</button>
                </div>
                <div class="form-footer_btn-left">
                    <button class="btn btn--secondary" id="btn-cancel-form">Hủy</button>
                    <div class="pseudo-element--down" tabindex="0"></div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
/* eslint-disable */
export default{
    name: "TheForm",
    methods: {
        close(){
            this.$emit("close");
        }
    },
}


</script>

<style>
@import url('../css/form.css');
</style>