<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="BTL_Web.BTL.TimKiem.TimKiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tìm Kiếm</title>
    <link rel="stylesheet" href="TimKiem.css">
    <script src="TimKiem.js" defer></script>
</head>
<body>
    <header id="header"></header>
    <main class="main_container">
        <div class="main_header">
            <h1 id="tieuDe" runat="server">NIKE</h1>
        </div>
        <div class="main_content">
            <div class="content_left">
               
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
