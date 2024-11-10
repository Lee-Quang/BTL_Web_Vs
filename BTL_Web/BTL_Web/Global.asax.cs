using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["danhsachUser"] = _userList();
            Application["danhsachProduct"]= products();
            Application["danhsach"] = new List<string>();
        }

        private List<User> _userList ()
        {
            List<User> userList = new List<User>
            {
                new User( user_name:"admin",
                password:"123",
                role:"admin"
                ),
                new User (user_name:"user1",
                password:"123",
                role:"user"
                )
            };
            return userList;
        }

        private List<Product> products()
        {
            List<Product> productList = new List<Product>
            {
                //NIKE
                new Product(
                    id:"N01",
                    name:"Giày Nike A",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N01.png",
                    price:2000000,
                    trangThai:1
                    ),
                new Product(
                    id:"N02",
                    name:"Giày Nike B",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N02.png",
                    price:3950000,
                    trangThai:1
                    ),
                new Product(
                    id:"N03",
                    name:"Giày Nike C",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N03.png",
                    price:4500000,
                    trangThai:1
                    ),
                new Product(
                    id:"N04",
                    name:"Giày Nike D",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N04.png",
                    price:2500000,
                    trangThai:1
                    ),
                new Product(
                    id:"N05",
                    name:"Giày Nike E",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N05.png",
                    price:3450000,
                    trangThai:1
                    ),
                new Product(
                    id:"N06",
                    name:"Giày Nike F",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N06.png",
                    price:2200000,
                    trangThai:1
                    ),
                new Product(
                    id:"N07",
                    name:"Giày Nike G",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N07.png",
                    price:2460000,
                    trangThai:1
                    ),
                new Product(
                    id:"N08",
                    name:"Giày Nike H",
                    hang:"Nike",
                    imagePath:"../anh/Product/Nike/N08.png",
                    price:5000000,
                    trangThai:1
                    ),

                //ADIDAS
                new Product(
                    id:"A01",
                    name:"Giày Adidas A",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD01.png",
                    price:2240000,
                    trangThai:1
                    ),
                new Product(
                    id:"A02",
                    name:"Giày Adidas B",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD02.png",
                    price:2590000,
                    trangThai:1
                    ),
                new Product(
                    id:"A03",
                    name:"Giày Adidas C",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD03.png",
                    price:2880000,
                    trangThai:1
                    ),
                new Product(
                    id:"A04",
                    name:"Giày Adidas D",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD04.png",
                    price:3200000,
                    trangThai:1
                    ),
                new Product(
                    id:"A05",
                    name:"Giày Adidas E",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD05.png",
                    price:3400000,
                    trangThai:1
                    ),
                new Product(
                    id:"A06",
                    name:"Giày Adidas F",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD06.png",
                    price:3570000,
                    trangThai:1
                    ),
                new Product(
                    id:"A07",
                    name:"Giày Adidas G",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD07.png",
                    price:2940000,
                    trangThai:1
                    ),
                new Product(
                    id:"A08",
                    name:"Giày Adidas A",
                    hang:"Adidas",
                    imagePath:"../anh/Product/Adidas/AD08.png",
                    price:4990000,
                    trangThai:1
                    ),

                //MLB
                new Product(
                    id:"M01",
                    name:"Giày MLB A",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB01.png",
                    price:2240000,
                    trangThai:1
                    ),
                new Product(
                    id:"M02",
                    name:"Giày MLB B",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB02.png",
                    price:2440000,
                    trangThai:1
                    ),
                new Product(
                    id:"M03",
                    name:"Giày MLB C",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB03.png",
                    price:2550000,
                    trangThai:1
                    ),
                new Product(
                    id:"M04",
                    name:"Giày MLB D",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB04.png",
                    price:2880000,
                    trangThai:1
                    ),
                new Product(
                    id:"M05",
                    name:"Giày MLB E",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB05.png",
                    price:2990000,
                    trangThai:1
                    ),
                new Product(
                    id:"M06",
                    name:"Giày MLB F",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB06.png",
                    price:3350000,
                    trangThai:1
                    ),
                new Product(
                    id:"M07",
                    name:"Giày MLB G",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB07.png",
                    price:3990000,
                    trangThai:1
                    ),
                new Product(
                    id:"M08",
                    name:"Giày MLB H",
                    hang:"MLB",
                    imagePath:"../anh/Product/MLB/MLB08.png",
                    price:4990000,
                    trangThai:1
                    )
            };
            return productList;
        }
    }
}