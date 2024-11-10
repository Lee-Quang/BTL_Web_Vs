<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="BTL_Web.BTL.ChiTiet.ChiTiet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ChiTiet</title>
    <link rel="stylesheet" href="ChiTiet.css">
    <script src="ChiTiet.js" defer></script>
</head>
<body>
    <header id ="header">

    </header>
    <form method="get" runat="server" id="form_chiTiet">
    <main class ="main_container">
        <div class="product_chiTiet">
            <div class="img_product" id="img_product" runat="server">
                <img src="../anh/Product/Nike/N01.png" alt="ảnh">
            </div>
            <div class="info_product">
                <div class="name" id="name" runat="server">Tên sản phẩm</div>
                <div class="price" id="price" runat="server">2.000.000 đ</div>
                <div class="mau op_product">
                    <span>Màu:</span>
                    <ul class="list_mau op_list">
                        <li class="mau_item selected" data-mau="white" style="background-color: white;"></li>
                        <li class="mau_item " data-mau="Black" style="background-color: black;"></li>
                        <li class="mau_item " data-mau="Yellow" style="background-color: yellow;"></li>
                    </ul>
                </div>
                <div class="size op_product">
                    <span>Kích thước:</span>
                    <ul class="list_size op_list">
                        <li class="size_item selected" data-size="36">36</li>
                        <li class="size_item" data-size="38">38</li>
                        <li class="size_item" data-size="40">40</li>
                        <li class="size_item" data-size="42">42</li>
                    </ul>
                </div>
                <div class="btn">
                    <button class="btn_item" id="buy_btn" name="buy_btn" value="buy">Mua ngay</button>
                    <button class="btn_item" id="add_btn" name="add_btn" value="add">Thêm vào giỏ hàng</button>
                </div>
            </div>
        </div>
        <div class="product_goiY" id="product_gioY" runat="server">
            <section class="product_list">
                <article class="product_img" data-id="N01">
                 <img src="../anh/Product/Nike/N01.png" alt="">
                </article>     
            </section>
        </div>
    </main>
        </form>
    <footer id="footer">

    </footer>
</body>
</html>
