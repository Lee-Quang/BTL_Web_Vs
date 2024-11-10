using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.Them
{
    public partial class Them : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            string id_Pro = Request.QueryString["id_sp"];
            string hang = Request.QueryString["hang_sp"];
            string name_Pro = Request.QueryString["name_sp"];
            string price_Pro = Request.QueryString["price_sp"];
            
            string trangThai = Request.QueryString["trangThai_sp"];
           
            string action = Request.QueryString["action"];
            if (!IsPostBack)
            {
                
                if (!string.IsNullOrEmpty(id_Pro))
                { int.TryParse(price_Pro, out int price_out);
                    tieuDe.InnerHtml = "Sửa sản phẩm";
                    id_sp.Value = id_Pro;
                    hang_sp.Attributes.Add("readonly", "readonly");
                    hang_sp.Value = hang;
                    name_sp.Value = name_Pro;
                    price_sp.Value = price_out.ToString("N0", new CultureInfo("de-DE"));
                    trangThai_sp.Value = trangThai;
                }
            }
            if (IsPostBack)
            {
                 id_Pro = Request.Form["id_sp"];
                 hang = Request.Form["hang_sp"];
                 name_Pro = Request.Form["name_sp"];
                 price_Pro = Request.Form["price_sp"];
                int.TryParse(price_Pro, out int price);
                trangThai = Request.Form["trangThai_sp"];
                int.TryParse(trangThai, out int trangThai_int);
                if (string.IsNullOrEmpty(id_Pro))
                {
                    id_Pro = IDProduct_New(products, hang[0]);
                    Product product = new Product();
                    product.IdProduct = id_Pro;
                    product.HangProduct = hang;
                    product.NameProduct = name_Pro;
                    product.PriceProduct = price;
                    product.TrangThaiProduct = trangThai_int;
                    products.Insert(0, product);
                    string script = "alert('Thêm sản phẩm thành công');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertThemSanPham", script, true);
                }
                else
                {
                    foreach (Product product in products)
                    {

                        if (product.IdProduct == id_Pro)
                        {
                            product.HangProduct = hang;
                            product.NameProduct = name_Pro;
                            product.PriceProduct = price;
                            product.TrangThaiProduct = trangThai_int;
                        }
                    }
                    string script = "alert('Sửa sản phẩm thành công');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertSửaSanPham", script, true);
                }

            }
            if (!string.IsNullOrEmpty(action))
            {
                if (action == "xoa")
                {
                    foreach (Product product in products)
                    {

                        if (product.IdProduct == id_Pro)
                        {
                            product.TrangThaiProduct = 0;
                        }
                    }
                }
            }
            Application["danhsachProduct"] = products;
            List<Product> productList = products.OrderByDescending(product => product.TrangThaiProduct).ToList();
            string trangThai_Pro = "";
            string op = "";
            op += "<h1>Danh sách sản phẩm</h1>";
            op += "<table>"
                + "<tr>"
                + "<th>STT</th>"
                + "<th>ID</th>"
                + "<th>Hãng</th>"
                + "<th>Tên</th>"
                + "<th>Giá</th>"
                + "<th>Trạng thái</th>"
                + "<th colspan='2'>Thao tác</th>"
                + "</tr>";
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].TrangThaiProduct == 1)
                {
                    trangThai_Pro = "Còn";
                }
                else if (productList[i].TrangThaiProduct == 0)
                {
                    trangThai_Pro = "Không còn";
                }
                op += "<tr>"
                    + $"<td>{(i + 1)}</td>"
                    + $"<td>{productList[i].IdProduct}</td>"
                    + $"<td>{productList[i].HangProduct}</td>"
                    + $"<td>{productList[i].NameProduct}</td>"
                    + $"<td>{productList[i].PriceProduct.ToString("N0", new CultureInfo("de-DE"))}</td>"
                    + $"<td>{trangThai_Pro}</td>"
                    + $"<td><a href='../Them/Them.aspx?id_sp={productList[i].IdProduct}&hang_sp={productList[i].HangProduct}&name_sp={productList[i].NameProduct}&price_sp={productList[i].PriceProduct}'&trangThai_sp={productList[i].TrangThaiProduct}'>Sửa</a></td>"
                    + $"<td><a href='../Them/Them.aspx?id_sp={productList[i].IdProduct}&action=xoa' id='btn_xoa'>Xoá</a></td>"
                    + "</tr>";
            }
            op += "</table>";
            danhSach.InnerHtml = op;
        }

        private string IDProduct_New (List<Product> products, char kiTu)
        {
            var listProduct = products
                .Where(product => product.IdProduct[0] == kiTu)
                .Select(product => int.Parse(product.IdProduct.Substring(1)))
                .ToList();

            int nextNumber = listProduct.Count > 0 ? listProduct.Max() + 1 : 1;
            return kiTu.ToString() + nextNumber.ToString("D2");
        }
    }
}