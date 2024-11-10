

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

// Sử lý các lỗi
const tenFiled = document.getElementById("user_name");
const passwordFiled = document.getElementById("password");
const repasswordFiled = document.getElementById("repassword");
const sdtFiled = document.getElementById("sdt");
const loi_ten = document.getElementById("loi_user");
const loi_password = document.getElementById("loi_password");
const loi_repassword = document.getElementById("loi_repassword");
const loi_sdt =document.getElementById("loi_sdt");


function loi_chung(Filed, loi)
{
    if(Filed.value ==="")
    {
        loi.innerHTML="còn trống";
        return false;
    }
    return true;
}

function check_password()
{
    
    const kiTu = /^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-z0-9]{6,}$/
    const check = kiTu.test(passwordFiled.value);
    if(!check)
    {   
        loi_password.innerHTML="Lỗi dữ liệu";
        return false;
    }
    return true;
}

function check_repassword()
{
    if(passwordFiled.value !== repasswordFiled.value)
    {
        loi_repassword.innerHTML="Lỗi dữ liệu";
        return false;
    }
    return true;
}

function check_sdt()
{
    const so = /^0[0-9]{9,}$/
    const check_so = so.test(sdtFiled.value);
    if(!check_so)
    {
        loi_sdt.innerHTML="Lỗi dữ liệu"
        return false;
    }
    return true;
}

function Loi()
{let ketQua = true;
    if(!loi_chung(tenFiled,loi_ten))
    {
        ketQua =false;
    }
    if(loi_chung(passwordFiled,loi_password))
    {
        if (!check_password()) {
            ketQua = false;
        }            
    }
    else
    {
        ketQua = false;
    }
    if(loi_chung(repasswordFiled,loi_repassword))
    {
        if (!check_repassword()) {
            ketQua = false;
        }            
    }
    else
    {
        ketQua = false;
    }
    if(loi_chung(sdtFiled,loi_sdt))
    {
        if (!check_sdt()) {
            ketQua = false;
        }
    }
    else
    {
        ketQua = false;
    }
    return ketQua;
}

const form_dangky = document.getElementById("form_dangky")
form_dangky.addEventListener("submit",function(e)
{
    if (!Loi()) {
        e.preventDefault();
        console.error("Lỗi")
    }
    
})

// Xử lý bấm để xem được password
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

const toggleRePassword = document.querySelector('.repassword img')
toggleRePassword.addEventListener("mousedown",function(e)
{   
    e.preventDefault();
    const src = toggleRePassword.getAttribute("src")
    {
        if(src=="../anh/Icon/hide.png")
        {
            repasswordFiled.setAttribute("type","text");
            toggleRePassword.setAttribute("src","../anh/Icon/view.png");
        }
        if(src=="../anh/Icon/view.png")
            {
                repasswordFiled.setAttribute("type","password");
                toggleRePassword.setAttribute("src","../anh/Icon/hide.png");
            }
    }
    repasswordFiled.focus();
})

// Sự kiện bấm vào từng ô
tenFiled.addEventListener("focus",function()
{
    loi_ten.innerHTML="";
})
const requestPassword = document.querySelector('.request_password')
passwordFiled.addEventListener("focus",function()
{
    loi_password.innerHTML="";
    requestPassword.style.visibility = "visible";
})

passwordFiled.addEventListener("blur",function()
{
    requestPassword.style.visibility = "hidden";
})

const requestRePassword = document.querySelector('.request_repassword')
repasswordFiled.addEventListener("focus",function()
{
    loi_repassword.innerHTML="";
    requestRePassword.style.visibility = "visible";
})

repasswordFiled.addEventListener("blur",function()
{
    requestRePassword.style.visibility = "hidden";
})

const requestSdt = document.querySelector('.request_sdt')
sdtFiled.addEventListener("focus",function()
{
    loi_sdt.innerHTML="";
    requestSdt.style.visibility = "visible";
})

sdtFiled.addEventListener("blur",function()
{
    requestSdt.style.visibility = "hidden";
})

const toggleTrangChu = document.querySelector(".logo");
toggleTrangChu.addEventListener("click", function () {
    window.location.href = "../TrangChu/TrangChu.aspx";
})


//const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
