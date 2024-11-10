using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.ChiTiet
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            string idProduct = Request.QueryString["idProduct"];
            string action = Request.QueryString["action"];
            string op = "";
            op += "<section class='product_list'>";
            Product product1 = new Product();
            int soLuong_GoiY = 0;
            foreach (Product product in products)
            {
                if (product.IdProduct == idProduct)
                {
                    product1 = product;
                    img_product.InnerHtml = $"<img src='{product.ImagePath}' alt='Ảnh sp'>";
                    name.InnerHtml = product.NameProduct;
                    price.InnerHtml = product.PriceProduct.ToString("N0", new CultureInfo("de-DE")) + " đ";
                }
                else
                {
                    soLuong_GoiY++;
                    if (soLuong_GoiY <= 4)
                    {
                        op += $"<article class='product_img' data-id ='{product.IdProduct}'>"
                        + $"<img src='{product.ImagePath}' alt='Ảnh sp'>"
                        + "</article>";
                    }
                }
            }
            op += "</section>";
            product_gioY.InnerHtml = op;
            if (!string.IsNullOrEmpty(action))
            {
                if ((User)Session["currentUser"] == null)
                {
                    string script = "if(confirm('Bạn chưa đăng nhập. Bạn cần đăng nhập để có thể mua. Bạn có muốn đăng nhập không?'))window.location.href = '../DangNhap/DangNhap.aspx';";
                    ClientScript.RegisterStartupScript(this.GetType(), "confirmChiTiet", script, true);
                }
                else
                {
                    User user = (User)Session["currentUser"];
                    List<string> cartID = (List<string>)Session[user.UserName +"cartID"];
                    List<Cart> carts = (List<Cart>)Session[user.UserName + "cart"];
                    string mau = Request.QueryString["mau"];
                    string size = Request.QueryString["size"];
                    int.TryParse(size, out int size_int);
                    bool isProductFound = false;
                    if (carts.Count > 0)
                    {
                        for (int i = 0; i < carts.Count; i++)
                        {
                            if (carts[i].IDProduct == idProduct && carts[i].Size == size_int && carts[i].Mau == mau)
                            {
                                carts[i].SoLuong = carts[i].SoLuong + 1 ;
                                carts[i].Total = carts[i].SoLuong * carts[i].PriceProduct;
                                isProductFound = true;
                                break;
                            }

                        }
                    }
                    if(!isProductFound)
                    {
                        Cart cart = new Cart();
                        cart.IDCart = carts.Count >0?carts.Max(x => x.IDCart) +1 : 0;
                        cart.IDProduct = idProduct;
                        cart.PriceProduct = product1.PriceProduct;
                        cart.Mau = mau;
                        cart.Size = size_int;
                        cart.SoLuong = 1;
                        cart.Total = cart.PriceProduct * cart.SoLuong;
                        carts.Add(cart);
                        cartID.Add(cart.IDCart.ToString());
                    }
                    Session[user.UserName+"cartID"] = cartID;
                    Session[user.UserName + "cart"] = carts;
                    if (action == "buy")
                    {
                        string script = "window.location.href = '../GioHang/GioHang.aspx';";
                        ClientScript.RegisterStartupScript(this.GetType(), "Buy", script, true);
                    }
                }
                
            }
        }
    }
}