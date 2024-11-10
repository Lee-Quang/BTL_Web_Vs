<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Them.aspx.cs" Inherits="BTL_Web.BTL.Them.Them" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tuỳ Chỉnh Sản Phẩm</title>
    <link rel="stylesheet" href="Them.css">
    <script src="Them.js" defer></script>
</head>
<body>
     <header id="header"></header>
    <form  method="post" runat="server" id="form_them">
    <main class="main_container">
        <h1 id="tieuDe" runat="server">Thêm sản phẩm</h1>
        <div class="content">
            <div class="id_product content_item">
                <label for="id_sp">Mã sản phẩm: </label>
                <input type="text" name="id_sp" id="id_sp" readonly runat="server">
            </div>
            <div class="hang_product content_item">
                <label for="hang_sp">Hãng sản phẩm: </label>
                <input type="text" name="hang_sp" id="hang_sp" runat="server">
                <span id="loi_hang"></span>
            </div>
            <div class="name_product content_item">
                <label for="name_sp">Tên sản phẩm: </label>
                <input type="text" name="name_sp" id="name_sp" runat="server">
                <span id="loi_name"></span>
            </div>
            <div class="price_product content_item">
                <label for="Giá">Giá: </label>
                <input type="text" name="price_sp" id="price_sp" runat="server">
                <span id="loi_gia"></span>
            </div>
            <div class="trangThai_product content_item">
                <label for="trangThai_sp">Trạng thái: </label>
                <select name="trangThai_sp" id="trangThai_sp" runat="server">
                    <option value="1">Còn</option>
                    <option value="0">Không còn</option>
                </select>
            </div>
            <div class="btn">
                <button id="btn_xacNhan" name="btn_xacNhan" value="xacNhan" >Xác Nhận</button>
                <button id="btn_huy" name="btn_huy" value="huy">Huỷ</button>
            </div>
        </div>
        <div class="danhSach" id="danhSach" runat="server">
            <h1>Danh sách sản phẩm</h1>
            <table>
                <tr>
                    <th>STT</th>
                    <th>ID</th>
                    <th>Hãng</th>
                    <th>Tên</th>
                    <th>Giá</th>
                    <th>Trạng thái</th>
                    <th colspan="2">Thao tác</th>
                </tr>
                <tr>
                    <td>1</td>
                    <td>N01</td>
                    <td>Nike</td>
                    <td>Giày Nike A</td>
                    <td>2.000.000</td>
                    <td>Còn</td>
                    <td><a href="">Sửa</a></td>
                    <td><a href="">Xoá</a></td>
                </tr>
            </table>
        </div>
    </main>
</form>
    <footer id="footer"></footer>
</body>
</html>
