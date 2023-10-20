<template>
    <!-- succes -->
    <div class="toast-message">
        <div class="toast-message__content">
            <div class="toast-message__info">
                <i class="fa-solid fa-circle-check icon icon--primary toast-message__icon-info"></i>
                <span class="toast-message__type toast-message__type--success">Thành công!</span>
                <span class="toast-message__desc">Công việc đã bị xóa.</span>
            </div>
            <span class="toast-message__help">Hoàn tác</span>
        </div>
        <div class="toast-message--close">
            <i class="fa-solid fa-xmark toast-message__icon--close"></i>
        </div>
    </div>
    <!-- Error -->
    <div class="toast-message">
        <div class="toast-message__content toast-message__content--error">
            <i class="fa-solid fa-circle-check icon icon--error toast-message__icon-info"></i>
            <div class="toast-message__info toast-message__info--error">
                <div>
                    <span class="toast-message__type toast-message__type--error">Lỗi!</span>
                    <span class="toast-message__desc">Không thể cập nhật được dữ liệu. Vui lòng kiểm tra lại kết nối internet.</span>
                </div>
                <a class="toast-message__help">Xem hướng dẫn</a>
            </div>
        </div>
        <div class="toast-message--close">
            <i class="fa-solid fa-xmark toast-message__icon--close"></i>
        </div>
    </div>
    <!-- Warning -->
    <div class="toast-message">
        <div class="toast-message__content toast-message__content--warning">
            <div class="toast-message__info">
                <i class="fa-solid fa-circle-exclamation icon icon--warning toast-message__icon-info"></i>
                <span class="toast-message__type toast-message__type--warning">Cảnh báo!</span>
                <span class="toast-message__desc">Dữ liệu của bạn đã bị thay đổi bởi người dùng khác.</span>
            </div>
        </div>
        <div>
            <i class="fa-solid fa-xmark toast-message__icon--close"></i>
        </div>
    </div>
    <!-- Thông tin -->
    <div class="toast-message">
        <div class="toast-message__content toast-message__content--info">
            <div class="toast-message__info">
                <i class="fa-solid fa-circle-exclamation icon icon--info toast-message__icon-info"></i>
                <span class="toast-message__type toast-message__type--info">Thông tin!</span>
                <span class="toast-message__desc">Bạn nên đọc kỹ nội dung trước khi gửi phê duyệt.</span>
            </div>
        </div>
        <div>
            <i class="fa-solid fa-xmark toast-message__icon--close"></i>
        </div>
    </div>
</template>

<script>
/* eslint-disable */
export default {
    name:"ToastMessenger"
}
</script>

<style>
@import url("../../css/toast-mesage.css");
</style>