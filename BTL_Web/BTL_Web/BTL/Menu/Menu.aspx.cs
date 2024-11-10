using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.Menu
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"]!= null) {
                User user = (User)Session["currentUser"];
                string cartIDchain = "";
                List<string> cartIDs = (List<string>)Session[user.UserName+"cartID"];
                foreach (string cartID in cartIDs)
                {
                    cartIDchain += $"{cartID} ";
                }
                Response.Write($"{user.UserName} {cartIDchain} {user.Role}");
            }
            else
            {
                Response.Write("");
            }

        }
        }
    }