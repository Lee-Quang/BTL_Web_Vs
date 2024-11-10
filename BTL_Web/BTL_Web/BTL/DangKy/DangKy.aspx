<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BTL_Web.BTL.DangKy.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng Ký</title>
    <link rel="stylesheet" href="DangKy.css">
    <script src="DangKy.js" defer></script>
</head>
<body>
     <header id="header">
        <div class="logo">
            <a src="../TrangChu/TrangChu.aspx"><img src="../anh/Logo/Logo.png" alt=""></a>
        </div>
        <div class="support">
            <a href="">Bạn có cần hỗ trợ gì không?</a>
        </div>
    </header>
    <form method="post" id="form_dangky" runat="server">
        <h1>Đăng Ký</h1>
        <main class="main_container">
            <div class="main_aside">
               
            </div>
            <div class="main_content">
                <div class="user_box user_name">
                    <input type="text" name="user_name" id="user_name" placeholder="Nhập tên đăng ký">
                    <span id="loi_user"></span>
                </div>
                <div class="user_box password">
                    <input type="password" name="password" id="password" placeholder="Nhập mật khẩu">
                    <img src="../anh/Icon/hide.png" alt="">
                    <span id="loi_password"></span>
                </div>
                <div class="user_box repassword">
                    <input type="password" name="repassword" id="repassword" placeholder="Nhập lại mật khẩu">
                    <img src="../anh/Icon/hide.png" alt="">
                    <span id="loi_repassword"></span>
                </div>
                <div class="user_box sdt">
                    <input type="text" name="sdt" id="sdt" placeholder="Nhập số điện thoại">
                    <span id="loi_sdt"></span>
                </div>
                <div>
                    <label for="ngay_Sinh"></label>
                </div>
                <div class="btn_box">
                    <button id="btn_dangKy" name="btn_dangKy" value="dangky" >Đăng ký</button>
                    
                </div>
                <div class="dangNhap_khac">
                    <div class="or">
                        <div class="or_aside or_item">

                        </div>
                        <div class="or_main or_item">
                            <span>Hoặc</span>
                        </div>
                        <div class="or_aside or_item"></div>
                    </div>
                    <div class="btn_or">
                        <button id="facebook" name="facebook" value="facebook">Facebook</button>
                        <button id="gg" name="gg" value="gg">Google</button>
                    </div>
                </div>
                <div class="dangNhap">
                    <span>Nếu bạn chưa có tài khoản: </span><a href="../DangNhap/DangNhap.aspx">Đăng nhập</a>
                </div>
            </div>
            <div class="main_request">
                <div class="head">

                </div>
                <div class="request_password request_item">
                    <p>- Tối thiểu 6 kí tự</p>
                    <p>- Bao gồm cả kí tự và số</p>
                </div>
                <div class="request_repassword request_item">
                    <p>- Mật khẩu phải trùng</p>
                </div>
                <div class="request_sdt request_item">
                    <p>- Phải là số</p>
                    <p>- Bắt đầu là số 0</p>
                    <p>- Gồm ít nhất 10 số</p>
                </div>
            </div>
        </main>
    </form>
    <footer id="footer"></footer>
</body>
</html>
