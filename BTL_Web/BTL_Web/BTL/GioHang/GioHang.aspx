<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="BTL_Web.BTL.GioHang.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Giỏ Hàng</title>
    <link rel="stylesheet" href="GioHang.css">
    <script src="GioHang.js" defer></script>
</head>
<body>
    <header id="header"></header>
    <main class="main_container">
        <h1>Giỏ hàng</h1>
        <div class="tieuDe_table">
        <table>
            <tr>
                <th>Sản phẩm</th>
                <th>Đơn giá</th>
                <th>Số lượng</th>
                <th>Số tiền</th>
                <th>Thao tác</th>
            </tr>
        </table>
        </div>
        <div class="product_list" id="product_list" runat="server">
            <table>
                <tr>
                    <td>
                        <div class="product">
                            <div class="product_img">
                                <img src="../anh/Product/Nike/N01.png" alt="">
                            </div>
                            <div class="product_info">
                                <div class="name" id="name_sp">
                                    Giày Nike A
                                </div>
                                <div class="op">
                                    <div class="mau op_item">
                                        <label>Màu: </label>
                                        <span id="mau_sp">White</span>
                                    </div>
                                    <div class="size op_item">
                                        <label>Kích thước: </label>
                                        <span id="size_sp">40</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </td>
                    <td>
                        <span id="price_sp">2.000.000</span>
                    </td>
                    <td>
                        <div class="amount">
                            <button id="btn_minus" name="btn_minus" value="minus" onclick="">-</button>
                            <span id="soLuong_sp">1</span>
                            <button id="btn_plus" name="btn_plus" value="plus" onclick="">+</button>
                        </div>
                    </td>
                    <td>
                        <span id="tien">2.000.000</span>
                    </td>
                    <td>
                        <button id="btn_delete" name="btn_delete" value="delete" onclick="">X</button>
                    </td>
                </tr>
            </table>
        </div>
        <div class="thanhToan">
            <div class="aside"></div>
            <div class="thanhToan_main">
                <div class="thanhToan_item">
                    <label>Tổng tiền hàng:</label>
                    <span id="price_total" runat="server">2.000.000 đ</span>
                </div>
                <div class="thanhToan_item">
                    <label>Tiền ship:</label>
                    <span id="price_ship" runat="server">0 đ</span>
                </div>
                <div class="thanhToan_item tongTien">
                    <label>Tổng Tiền:</label>
                    <span id="total" runat="server">2.000.000 đ</span>
                </div>
            </div>
        </div>
        <div class="info">
            <h2>Thông tin đặt hàng</h2>
            <div class="info_user">
                <input type="text" name="hoten" id="hoten" placeholder="Họ và tên">
                <input type="text" name="sdt" id="sdt" placeholder="Số điện thoại" runat="server">
            </div>
            <div class="diaChi">
                <textarea name="diaChi" id="diaChi" placeholder="Địa chỉ"></textarea>
            </div>
            <div class="pt_thanhToan">
                <label for="op_pay">Phương thức thanh toán: </label>
                <select name="op_pay" id="op_pay">
                    <option value="cash">Tiền mặt</option>
                    <option value="bank">Chuyển khoản</option>
                </select>
            </div>
        </div>
        <div class="btn">
            <button name="btn_datHang" id="btn_datHang" value="datHang">Đặt Hàng</button>
        </div>
    </main>
    <footer id="footer"></footer>
</body>
</html>
