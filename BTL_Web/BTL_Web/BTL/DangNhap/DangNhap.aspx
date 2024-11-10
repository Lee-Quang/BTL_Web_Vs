<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTL_Web.BTL.DangNhap.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng Nhập</title>
    <link rel="stylesheet" href="DangNhap.css">
    <script src="DangNhap.js" defer></script>
</head>
<body>
          <header id="header">
        <div class="logo">
            <img src="../anh/Logo/Logo.png" alt="">
        </div>
        <div class="support">
            <a href="">Bạn có cần hỗ trợ gì không?</a>
        </div>
    </header>
    <form method="post" id="form_dangnhap" runat="server">
        <h1>Đăng Nhập</h1>
        <main class="main_container">
            <div class="main_aside">
               
            </div>
            <div class="main_content">
                <div class="user_box user_name">
                    <input type="text" name="user_name" id="user_name" placeholder="Nhập tên đăng nhập">
                    <span id="loi_user" runat="server"></span>
                </div>
                <div class="user_box password">
                    <input type="password" name="password" id="password" placeholder="Nhập mật khẩu">
                    <img src="../anh/Icon/hide.png" alt="">
                    <span id="loi_password" runat="server"></span>
                    <a href="">Quên mật khẩu</a>
                </div>
                <div class="btn_box">
                    <button id="btn_dangNhap" name="btn_dangNhap" value="dangnhap" type ="submit">Đăng nhập</button>
                    
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
                <div class="dangKy">
                    <span>Nếu bạn chưa có tài khoản: </span><a href="../DangKy/DangKy.aspx">Đăng ký</a>
                </div>
            </div>
            <div class="main_request">

            </div>
        </main>
    </form>
    <footer id="footer"></footer>
</body>
</html>
