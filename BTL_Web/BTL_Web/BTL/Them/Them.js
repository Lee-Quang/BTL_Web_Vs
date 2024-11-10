fetch("../Menu/Menu.html")
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response not ok');
        }
        return response.text();
    })
    .then(data => {
        const header = document.getElementById('header');
        header.innerHTML = data;
        const script = document.createElement('script');
        script.src = "../Menu/Menu.js";
        script.defer = true;
        document.body.appendChild(script);
        script.onload = () => {
            CheckLogin();
            console.log("Check login");
        };
    })
    .catch(error => {
        console.error('Có lỗi xảy ra:', error);
    });

// Loi 
const id_sp = document.getElementById("id_sp");
const hang_sp = document.getElementById("hang_sp");
const name_sp = document.getElementById("name_sp");
const price_sp = document.getElementById("price_sp");
const loi_hang = document.getElementById("loi_hang");
const loi_name = document.getElementById("loi_name");
const loi_gia = document.getElementById("loi_gia");
function loi_chung(Filed, loi) {
    if (Filed.value === "") {
        loi.innerHTML = "còn trống";
        return false;
    }
    return true;
}

function check_price() { 
    price_sp.value = price_sp.value.replace(/\./g, '');
    const so = /^[0-9]+$/;
    let checkSo = so.test(price_sp.value);
    if (!checkSo) {
        loi_gia.innerHTML = "Phải là số";
        return false;
    }
    return true;
}

function Loi() {
    let ketQua = true;
    
        if (!loi_chung(hang_sp, loi_hang)) {
            ketQua = false;
        }
    
    if (!loi_chung(name_sp, loi_name)) {
        ketQua = false;
    }
    if (!loi_chung(price_sp, loi_gia)) {
        ketQua = false;
    }
    else {
        if (!check_price()) {
            ketQua = false;
        }            
    }
    return ketQua;
        
}

const form_them = document.getElementById("form_them")
form_them.addEventListener("submit", function (e) {
    if (!Loi()) {
        e.preventDefault();
        console.error("Lỗi");
    }
    
})
const trangThai = document.getElementById("trangThai_sp");
function Huy() {
    id_sp.value = "";
    price_sp.value = "";
    hang_sp.value = "";
    name_sp.value = "";
    loi_hang.innerHTML = "";
    loi_name.innerHTML = "";
    loi_gia.innerHTML = "";
    trangThai.value = "1";
    document.getElementById("tieuDe").innerHTML = "Thêm sản phẩm";
}

const toggleHuy = document.getElementById("btn_huy");
toggleHuy.addEventListener("click", function (e) {
    Huy();
    e.preventDefault();
})

hang_sp.addEventListener("focus", function () {
    loi_hang.innerHTML = "";
})

name_sp.addEventListener("focus", function () {
    loi_name.innerHTML = "";
})

price_sp.addEventListener("focus", function () {
    loi_gia.innerHTML = "";
})

// Đổi số khi nhập và khi gửi

price_sp.addEventListener("input", function (e) {
    let price_Value = e.target.value.replace(/\./g, '');
    if (!isNaN(price_Value) && price_Value !== '') {
        e.target.value = Number(price_Value).toLocaleString('vi-VN');
    }
    else {
        e.target.value = ''; // Xóa giá trị nếu không phải là số
    }
})

//Bấm nút xoá
const toggleXoa = document.getElementById("btn_xoa");
toggleXoa.addEventListener("click", function (e) {
    if (!confirm('Bạn có muốn xoá sản phẩm này không?')) {
        e.preventDefault();
    }
})
