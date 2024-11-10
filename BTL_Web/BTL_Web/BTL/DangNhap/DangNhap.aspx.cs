using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.DangNhap
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> userList = (List<User>)Application["danhsachUser"];
            if (IsPostBack)
            {
                string tendn = Request.Form["user_name"];
                string password = Request.Form["password"];
                string script = "";
                bool userFound = false;
                bool passFound = false;
                for (int i = 0; i < userList.Count ; i++)
                {
                    if (tendn == userList[i].UserName)
                    {
                        userFound = true;
                        if (password == userList[i].Password)
                        {   
                            User currentUser = userList[i];
                            passFound = true;
                            Session["currentUser"] = currentUser;
                            if (Session[currentUser.UserName+"cartID"] == null)
                            {
                                Session[currentUser.UserName+"cart"] = new List<Cart>();
                                Session[currentUser.UserName + "cartID"] = new List<string>();
                            }    
                            break;
                        }
                    }
                }
                if (!userFound)
                {
                    //Response.Write("Không có");
                    script = "if (confirm('Tài khoản không tồn tại. Nếu chưa có tài khoản bạn muốn đăng ký không?'))window.location.href = '../DangKy/DangKy.aspx';";
                    ClientScript.RegisterStartupScript(this.GetType(), "confirmDangKy", script, true);
                }
                else 
                if (passFound)
                {
                    //Response.Write("có");
                    script = "alert('Đăng nhập thành công'); window.location.href='../TrangChu/TrangChu.aspx';";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertDangNhap", script, true);
                }
                else if (!passFound)
                {
                    loi_password.InnerHtml = "Password sai";
                }    
                    

            }
            

        }
    }
}