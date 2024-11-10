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
    const toggleProducts = document.querySelectorAll('.product')

    toggleProducts.forEach(toggleProduct => {
        toggleProduct.addEventListener("click",function()
    {
        let productID = toggleProduct.getAttribute("data-id");
            console.log(productID);
            window.location.href = `../ChiTiet/ChiTiet.aspx?idProduct=${productID}`;
    })
        
    });

// Thay đổi sort
const urlPram = new URLSearchParams(window.location.search);
let hangUrl = urlPram.get("hang");
let sortUrl = urlPram.get("sort")
const sortChange = document.getElementById("sort")
sortChange.addEventListener("change",function()
{
    sortValue = sortChange.value;
        window.location.href = `../DanhSach/DanhSach.aspx?hang=${hangUrl}&sort=${sortValue}`;
})

sortChange.value = sortUrl;

const danhSach_left = document.querySelectorAll('.list_item');
danhSach_left.forEach(item_left => {
    left_value = item_left.querySelector("a").innerHTML;
    if (left_value !== hangUrl) {
        item_left.classList.remove("selected");
    }
    else {
        item_left.classList.add("selected")
    }
})