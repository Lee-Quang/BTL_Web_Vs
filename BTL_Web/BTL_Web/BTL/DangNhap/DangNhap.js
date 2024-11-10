// Footer
// Footer
fetch("../Footer/Footer.html")
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response not ok');
        }
        return response.text();
    })
    .then(data => {
        const footer = document.getElementById('footer');
        footer.innerHTML = data;
    })
    .catch(error => {
        console.error('Có lỗi xảy ra:', error);
    });

// Lỗi
const tenFiled = document.getElementById("user_name");
const passwordFiled = document.getElementById("password");
const loi_ten = document.getElementById("loi_user");
const loi_password = document.getElementById("loi_password");

function loi_chung(Filed, loi)
{
    if(Filed.value ==="")
    {
        loi.innerHTML="còn trống";
        return false;
    } else {
        loi.innerHTML = ""; // Xóa thông báo lỗi nếu có dữ liệu
    }
    return true;
}

function Loi()
{let ketQua = true;
    if(!loi_chung(tenFiled,loi_ten))
    {
        ketQua =false;
    }
    if(!loi_chung(passwordFiled,loi_password))
    {
        ketQua = false;
    }
    
    return ketQua;
}

const form_dangnhap = document.getElementById("form_dangnhap")
form_dangnhap.addEventListener("submit",function(e)
{
    if (!Loi()) {
        e.preventDefault();
        console.error("Lỗi")
    }
    else {
        //e.preventDefault();
    }
})

// Xem đc password

const togglePassword = document.querySelector('.password img')
togglePassword.addEventListener("mousedown",function(e)
{   
    e.preventDefault();
    const src = togglePassword.getAttribute("src")
    {
        if(src=="../anh/Icon/hide.png")
        {
            passwordFiled.setAttribute("type","text");
            togglePassword.setAttribute("src","../anh/Icon/view.png");
        }
        if(src=="../anh/Icon/view.png")
            {
                passwordFiled.setAttribute("type","password");
                togglePassword.setAttribute("src","../anh/Icon/hide.png");
            }
    }
    passwordFiled.focus();
})

tenFiled.addEventListener("focus",function()
{
    loi_ten.innerHTML="";
})

passwordFiled.addEventListener("focus",function()
{
    loi_password.innerHTML="";
})

const toggleTrangChu = document.querySelector(".logo");
toggleTrangChu.addEventListener("click", function () {
    window.location.href = "../TrangChu/TrangChu.aspx";
})