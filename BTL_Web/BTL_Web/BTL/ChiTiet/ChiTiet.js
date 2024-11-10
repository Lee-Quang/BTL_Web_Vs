fetch("../Menu/Menu.html")
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response not ok');
        }
        return response.text();
    })
    .then(data => {
        const header = document.getElementById('header');
        header.innerHTML = data;
        const script = document.createElement('script');
        script.src = "../Menu/Menu.js";
        script.defer = true;
        document.body.appendChild(script);
        script.onload = () => {
            CheckLogin();
            console.log("Check login");
        };
    })
    .catch(error => {
        console.error('Có lỗi xảy ra:', error);
    });

// Footer
fetch("../Footer/Footer.html")
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response not ok');
        }
        return response.text();
    })
    .then(data => {
        const footer = document.getElementById('footer');
        footer.innerHTML = data;
    })
    .catch(error => {
        console.error('Có lỗi xảy ra:', error);
    });
// Bấm từng sản phẩm
    const toggleProducts = document.querySelectorAll('.product_img')

    toggleProducts.forEach(toggleProduct => {
        toggleProduct.addEventListener("click",function()
    {
        let productID = toggleProduct.getAttribute("data-id");
            console.log(productID);
            window.location.href = `../ChiTiet/ChiTiet.aspx?idProduct=${productID}`;
    })
        
    });
// Chọn option cho sản phẩm
const toggleMaus = document.querySelectorAll(".mau_item")
var mau = document.querySelector(".mau_item.selected").getAttribute("data-mau");
toggleMaus.forEach(toggleMau=>
{
    toggleMau.addEventListener("click",function()
{
    toggleMaus.forEach(item => {
        item.classList.remove("selected");
    });
    toggleMau.classList.add("selected");
    mau = document.querySelector(".mau_item.selected").getAttribute("data-mau");
    console.log(mau);
})
}
)

const toggleSizes = document.querySelectorAll(".size_item")
var size = document.querySelector(".size_item.selected").getAttribute("data-size");
toggleSizes.forEach(toggleSize=>
{
    toggleSize.addEventListener("click",function()
{
    toggleSizes.forEach(item => {
        item.classList.remove("selected");
    });
    toggleSize.classList.add("selected");
    size = document.querySelector(".size_item.selected").getAttribute("data-size");
    console.log(size);
})
}
)

//Bấm nút
const urlPram = new URLSearchParams(window.location.search);
let idProduct = urlPram.get("idProduct");
const toggleBuy = document.getElementById("buy_btn");
toggleBuy.addEventListener("click", function()
{
    window.location.href = `../ChiTiet/ChiTiet.aspx?idProduct=${idProduct}&mau=${mau}&size=${size}&action=buy`
})

const toggleAdd = document.getElementById("add_btn");
toggleAdd.addEventListener("click", function () {
    window.location.href = `../ChiTiet/ChiTiet.aspx?idProduct=${idProduct}&mau=${mau}&size=${size}&action=add`
})

const form_chiTiet = document.getElementById("form_chiTiet");
form_chiTiet.addEventListener("submit", function (e) {
    e.preventDefault();
})