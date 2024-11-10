using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.DangKy
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { List<User> users = (List<User>)Application["danhsachUser"];
            if (IsPostBack) 
            {
                string tendk = Request.Form["user_name"];
                string password = Request.Form["password"];
                string sdt = Request.Form["sdt"];
                bool userFound = false;
                string script = "";
                for (int i = 0; i < users.Count; i++)
                {
                    if(tendk == users[i].UserName)
                        { userFound = true; break; }
                }

                if (!userFound)
                {
                    User user = new User();
                    user.UserName = tendk;
                    user.Password = password;
                    user.Role = "user";
                    Session[user.UserName+"sdt"] = sdt;
                    users.Add(user);
                    Application["danhsachUser"] = users;
                    script = "alert('Đăng ký thành công'); window.location.href='../DangNhap/DangNhap.aspx';";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertDangKy", script,true);
                }
                else
                {
                    script = "if (confirm('Tài khoản đã tồn tại. Nếu đã có tài khoản bạn muốn đăng nhập không?'))window.location.href = '../DangNhap/DangNhap.aspx';";
                    ClientScript.RegisterStartupScript(this.GetType(), "confirmDangNhap", script, true);
                }    
            }
        }
    }
}