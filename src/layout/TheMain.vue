
<template>
    <div class="content">
            <div class="content-title">
                <div class="content-title_info">
                    <div class="title-info__text">Danh Sách Nhân Viên</div>
                    <div class="title-info__icon"></div>
                </div>
                <div class="content-title__action">
                    <button class="btn_action" @click="showModal">
                        <div class="btn_action-icon"></div>
                        <span>Thêm mới</span>
                    </button>
                    <div class="btn_options">

                    </div>
                </div>
            </div>
            <div class="content-table">
                <div class="content-table_title">
                    <!-- <m-input v-model="name"></m-input>
                    <div>value Cha: {{ name }}</div> -->
                    <div class="table_title_ip">
                        <input type="text" placeholder="Tìm theo mã, tên nhân viên">
                        <div class="table_title_ip_search"></div>
                    </div>
                    <div class="table_title-icon"></div>
                </div>
                <div class="table-wrapper">
                    <table>
                        <thead>
                            <tr>
                                <th>
                                    <label class="checkbox-th">
                                        <input type="checkbox" checked="checked">
                                        <span class="checkmark"></span>
                                    </label>
                                </th>
                                <th class="txt-left">Mã nhân viên</th>
                                <th class="txt-left">Họ tên</th>
                                <th class="txt-left">Giới tính</th>
                                <th class="txt-center">Ngày sinh</th>
                                <th class="txt-left">Địa chỉ</th>
                                <th class="txt-right">Số tiền nợ</th>
                                <th>Chức năng</th>
                            </tr>

                        </thead>

                    
                        <tbody>
                            <tr v-for="item in items" v-bind:key="item.CustomerId">
                                <td class="txt-center">
                                    <label class="checkbox-th">
                                        <input type="checkbox" checked="checked">
                                        <span class="checkmark"></span>
                                    </label>
                                </td>
                                <td class="txt-left">{{ item.MemberCardCode }}</td>
                                <td class="txt-left">{{ item.FullName }}</td>
                                <td class="txt-left">{{ convertGender(item.Gender) }}</td>
                                <td class="txt-center">{{ convertDOB(item.DateOfBirth) }}</td>
                                <td class="txt-left">{{ item.Address }}</td>
                                <td class="txt-right">
                                {{ convertDebitAmount(item.DebitAmount) }}
                                </td>
                                <td class="txt-center">
                                <div class="table__tooltip">
                                    <button class="table__tooltip--icon1">                      
                                    <i class="fas fa-pen"></i>
                                    </button>
                                    <button class="table__tooltip--icon2">
                                    <i class="fas fa-ellipsis-h"></i>
                                    </button>
                                </div>
                                </td>
                            </tr>
                        </tbody>
                
                        <tfoot>
                            <tr><td colspan="2" style="border-right: none;">Tổng số: <b>1035</b> bản ghi </td>
                            <td colspan="7">
                                <div style="display: flex; justify-content: end;">
                                    <select>
                                        <option>20 bản ghi trên 1 trang</option>
                                    </select>
                                    <div class="pagination">
                                        <a href="#">Trước</a>
                                        <a href="#" class="table_active">1</a>
                                        <a href="#">2</a>
                                        <a href="#">3</a>
                                        <a href="#">...</a>
                                        <a href="#">6</a>
                                        <a href="#">Sau</a>
                                    </div>
                                </div>
                            </td>
                        </tr></tfoot>
                    </table>
                </div>
               
               
            </div>
        <TheForm v-if="isModalVisible" @close="closeModal"></TheForm>
        <!-- <ToastMessenger></ToastMessenger> -->
        <!-- <Combobox></Combobox> -->
    </div>
</template>

<script>
import TheForm from '@/components/TheForm.vue';
import ToastMessenger from '@/components/base/MToastMessenger.vue';
// import Combobox from '@/components/base/MCombobox.vue';
/* eslint-disable */
export default{
    name: "Table",
    data() {
        return {
            name: "Đỗ Đình Huy",
            items: [],
            isModalVisible: false,
        };
    },
    methods: {
        showModal() {
            this.isModalVisible = true;
        },
        closeModal() {
            this.isModalVisible = false;
        },
        convertGender(x) {
            if (x == 0)
                return 'Nữ';
            else
                return 'Nam';
        },
        convertDOB(dob) {
            let date = new Date(dob);
            let d = date.getDate();
            let m = date.getMonth() + 1;
            let y = date.getFullYear();
            d = d < 10 ? `0${d}` : d;
            m = m < 10 ? `0${m}` : m;
            let res = `${d}/${m}/${y}`;
            return res;
        },
        convertDebitAmount(inp) {
            let res = new Intl.NumberFormat('vi-VN', {
                style: 'currency',
                currency: 'VND',
            }).format(inp);
            return res;
        },
    },
    component: {},
    mounted() {
        fetch('https://cukcuk.manhnv.net/api/v1/customers')
            .then((res) => res.json())
            .then((data) => {
            this.items = data;
        });
    },
    components: { TheForm,ToastMessenger}
};
</script>

<style>
@import url('../css/main.css');
</style>