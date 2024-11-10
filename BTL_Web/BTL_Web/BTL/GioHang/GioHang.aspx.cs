using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.GioHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            int priceTotal = 0;
            string op = "";
            string action = Request.Form["action"];
            string idCart = Request.Form["idCart"];
            if ((User)Session["currentUser"] !=null)
            {
                User user = (User)Session["currentUser"];
                if (Session[user.UserName + "cart"] != null)
                {
                    List<string> cartIDs = (List<string>)Session[user.UserName + "cartID"];
                    List<Cart> carts = (List<Cart>)Session[user.UserName + "cart"];
                    if (!string.IsNullOrEmpty(action))
                    {
                        for (int i = 0; i < carts.Count; i++)
                        {
                            if (carts[i].IDCart == int.Parse(idCart))
                            {
                                if (action == "plus")
                                {
                                    carts[i].SoLuong++;
                                    carts[i].Total = carts[i].SoLuong * carts[i].PriceProduct;
                                }
                                if (action == "minus")
                                {
                                    if (carts[i].SoLuong > 0)
                                    {
                                        carts[i].SoLuong--;
                                        carts[i].Total = carts[i].SoLuong * carts[i].PriceProduct;
                                    }
                                }
                                if (action == "delete")
                                {
                                    cartIDs.Remove(carts[i].IDCart.ToString());
                                    carts.Remove(carts[i]);
                                }
                            }
                        }
                    }
                        op += "<table>";

                        for (int i = 0; i < carts.Count; i++)
                        {
                            foreach (Product product in products)
                            {
                                if (product.IdProduct == carts[i].IDProduct)
                                {
                                    op += "<tr>"
                                        //Ô 1 sản phẩm
                                        + "<td>"
                                        + "<div class='product'>"
                                        + "<div class='product_img'>"
                                        + $"<img src='{product.ImagePath}' alt='Ảnh sp'>"
                                        + "</div>"
                                        + "<div class='product_info'>"
                                        + "<div class='name' id='name_sp'>" + product.NameProduct + "</div>"
                                        + "<div class='op'>"
                                        + "<div class='mau op_item'>"
                                        + "<label> Màu: </label>"
                                        + "<span id='mau_sp'>" + carts[i].Mau + "</span>"
                                        + "</div>"
                                        + "<div class='size op_item'>"
                                        + "<label>Kích thước: </label>"
                                        + "<span id='size_sp'>" + carts[i].Size + "</span>"
                                        + "</div>"
                                        + "</div>"
                                        + "</div>"
                                        + "</div>"
                                        + "</td>"
                                        //Ô 2 
                                        + "<td>"
                                        + "<span id='price_sp'>" + product.PriceProduct.ToString("N0", new CultureInfo("de-DE")) + "</span>"
                                        + "</td>"
                                        //ô 3
                                        + "<td>"
                                        + "<div class='amount'>"
                                        + $"<button id='btn_minus' name='btn_minus' value='minus' onclick='handleMinus({carts[i].IDCart});'>-</button>"
                                        + $"<span id='soLuong_sp' class='soLuong_sp' data-id='{carts[i].IDCart}'>{carts[i].SoLuong}</span>"
                                        + $"<button id='btn_plus' name='btn_plus' value='plus' onclick='handlePlus({carts[i].IDCart});'>+</button>"
                                        + "</div>"
                                        + "</td>"
                                        //ô 4
                                        + "<td>"
                                        + "<span id='tien'>" + carts[i].Total.ToString("N0", new CultureInfo("de-DE")) + "</span>"
                                        + "</td>"
                                        //ô 5
                                        + "<td>"
                                        + $"<button id='btn_delete' name='btn_delete' value='minus' onclick='handleDelete({carts[i].IDCart});'>X</button>"
                                        + "</td>"
                                        + "</tr>";
                                    break;
                                }

                            }
                            priceTotal += carts[i].Total;
                        }
                    Session[user.UserName + "cartID"] = cartIDs;
                    Session[user.UserName + "cart"] = carts;
                    if(carts.Count==0)
                    {
                        op = "Giỏ hàng còn trống";
                    }
                }
                    

                sdt.Value = (string)Session[user.UserName + "sdt"];
            }
            else
            {
                op = "Bạn chưa đăng nhập, xin vui lòng đăng nhập";
            }
            op += "</table>";
            price_total.InnerHtml = priceTotal.ToString("N0", new CultureInfo("de-DE"))+" đ";
            total.InnerHtml = priceTotal.ToString("N0", new CultureInfo("de-DE"))+" đ";
            product_list.InnerHtml = op;
        }
    }
}