using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web
{
    public partial class KiemTra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            if (IsPostBack)
            {
                string ten = Request.QueryString["tendk"];
                string date = Request.QueryString["ngaySinh"];
                string soThich1 = Request.QueryString["soThich1"];
                string soThich2 = Request.QueryString["soThich2"];
                string soThich3 = Request.QueryString["soThich3"];
                string soThich4 = Request.QueryString["soThich4"];
                string soThich5 = Request.QueryString["soThich5"];
               
                if (!string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(date))
                {

                    arr.Add(ten);
                    arr.Add(date);

                }
                if (!string.IsNullOrEmpty(soThich1))
                {
                    arr.Add(soThich1);
                }
                if (!string.IsNullOrEmpty(soThich2))
                {
                    arr.Add(soThich2);
                }
                if (!string.IsNullOrEmpty(soThich3))
                {
                    arr.Add(soThich3);
                }
                if (!string.IsNullOrEmpty(soThich4))
                {
                    arr.Add(soThich4);
                }
                if (!string.IsNullOrEmpty(soThich5))
                {
                    arr.Add(soThich5);
                }
                Application["danhsach"] = arr;
                for(int i = 0;i<arr.Count;i++)
                {
                    Response.Write(arr[i] +" ");
                }    
                Response.End();
            }
        }
    }
}