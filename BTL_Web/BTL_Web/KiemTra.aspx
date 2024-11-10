<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KiemTra.aspx.cs" Inherits="BTL_Web.KiemTra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kiểm Tra</title>
    <script src="KiemTra.js" defer></script>
</head>
<body>
    <form id="form1" runat="server" method="get">
        <div>
            <div>
                <label for="tendk">Họ Tên:</label>
                <input type="text" name="tendk" id="tendk"/>
            </div>
            <div>
                <label for="ngaySinh">Ngày Sinh</label>
                <input type="date" name="ngaySinh" id="NgaySinh"/>
            </div>
            <div>
                <p>Sở thích:</p>
                <input type="checkbox" name="soThich1" class="st" value ="BongDa" id="st1"/> Bóng đá;
                <input type="checkbox" name="soThich2" class="st" value ="BongChuyen" id="st2"/> Bóng chuyền;
                <input type="checkbox" name="soThich3" class="st" value ="CauLong" id="st3"/> Cầu lông;
                <input type="checkbox" name="soThich4" class="st" value ="Boi" id="st4"/> Bơi;
                <input type="checkbox" name="soThich5" class="st" value ="BongRo" id="st5"/> Bóng rổ;
                <br />
                <label id="loi_sl"></label>
            </div>
            <div>
                <button name="xacNhan" id="xacNhan" value="xacNhan">Xác Nhận</button>
            </div>
        </div>
    </form>
</body>
</html>
