<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="BTL_Web.BTL.TrangChu.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TrangChu</title>
    <link rel="stylesheet" href="TrangChu.css">
    <script src="TrangChu.js" defer></script>
</head>
<body>
     <header id="header">
    </header>
    <form  id ="form_trangChu" runat="server">
    <main class="main_container">
            <div class="banner">
                <div class="list_images">
                    <img src="../anh/Banner/Banner1.png" alt="">
                    <img src="../anh/Banner/Banner2.png" alt="">
                    <img src="../anh/Banner/Banner3.png" alt="">
                </div>  
                <div class = "btns">
                    <div class="btn_left btn">
                        <img src="../anh/Icon/left-arrow.png" alt="">
                        </div>
                    <div class ="btn_right btn">
                        <img src="../anh/Icon/right-arrow.png" alt="">
                        </div>
                </div>
            </div>

        <div class="main_content">
            <div class="content_item product_hotSell" id="product_hotSell" runat="server">
                <h1>Sản phẩm bán chạy</h1>
                <section class="product_list">
                    <article class="product" data-id="N01">
                        <ul class="feature">
                            <li class="feature_item img">
                                <img src="../anh/Product/Nike/N01.png" alt="">
                            </li>
                            <li class="feature_item name">Giày Nike A</li>
                            <li class="feature_item price">2.000.000 đ</li>
                        </ul>
                    </article>
                </section>
            </div>
            <div class="content_item product_Note" id="product_Note" runat="server">
                <h1>Sản phẩm tiêu biểu</h1>
                <section class="product_list">
                    <article class="product" data-id="N01">
                        <ul class="feature">
                            <li class="feature_item img">
                                <img src="../anh/Product/Nike/N01.png" alt="">
                            </li>
                            <li class="feature_item name">Giày Nike A</li>
                            <li class="feature_item price">2.000.000 đ</li>
                        </ul>
                    </article>
                </section>
            </div>
        </div>
    </main>
</form>
<footer id="footer"></footer>
</body>
</html>
