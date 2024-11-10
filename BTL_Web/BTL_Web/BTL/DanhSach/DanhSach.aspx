<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSach.aspx.cs" Inherits="BTL_Web.BTL.DanhSach.DanhSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>DanhSach</title>
    <link rel="stylesheet" href="DanhSach.css">
    <script src="DanhSach.js" defer></script>
</head>
<body>
    <header id="header"></header>
    <main class="main_container">
        <div class="main_header">
            <h1 id="tieuDe" runat="server">NIKE</h1>
        </div>
        <div class="main_content">
            <div class="content_left">
                <h2>Danh sách sản phẩm</h2>
                <ul class="list">
                    <li class="list_item selected"><a href="../DanhSach/DanhSach.aspx?hang=Nike&sort=0">Nike</a></li>
                    <li class="list_item"><a href="../DanhSach/DanhSach.aspx?hang=Adidas&sort=0">Adidas</a></li>
                    <li class="list_item"><a href="../DanhSach/DanhSach.aspx?hang=MLB&sort=0">MLB</a></li>
                </ul>
            </div>
            <div class="content_product">
                <div class="content_header">
                    <select name="sort" id="sort">
                        <option value="0">Theo giá tăng dần</option>
                        <option value="1">Theo giá giảm dần</option>
                    </select>
                    <div class="amount_product">
                        <span>Số lượng sản phẩm: </span>
                        <span id="amount" runat="server">0</span>
                    </div>
                </div>
                <div class="product_list" id="product_list" runat="server">
                    <article class="product" data-id="N01">
                        <ul class="feature">
                            <li class="feature_item img">
                                <img src="../anh/Product/Nike/N01.png" alt="">
                            </li>
                            <li class="feature_item name">Giày Nike A</li>
                            <li class="feature_item price">2.000.000 đ</li>
                        </ul>
                    </article>
                    
                </div>
            </div>
        </div>

    </main>
    <footer id="footer"></footer>
</body>
</html>
