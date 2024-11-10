// Header
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
        script.onload = () => {
            CheckLogin();
            console.log("Check login");
        };
        document.body.appendChild(script);
        
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

const listImages =document.querySelector('.list_images');
const imgs = document.querySelectorAll('.list_images img');
const btnLeft = document.querySelector(".btn_left");
const btnRight = document.querySelector(".btn_right");
const lengthImg = imgs.length;
let current = 0;

const handleChangeBanner = () =>
{
    if(current == (lengthImg)-1)
        {
            current=0;
            let width = imgs[0].offsetWidth;
            listImages.style.transform = `translateX(0px)`;
        }
        else
        {
            current++;
            let width = imgs[0].offsetWidth;
            listImages.style.transform = `translateX(${width*-1*current}px)`;
        }
        console.log(lengthImg);
}

let handleEventChangeBanner = setInterval(handleChangeBanner,3000);
btnRight.addEventListener("click",()=>
{   clearInterval(handleEventChangeBanner);
    console.log("right");
    handleChangeBanner();
    handleEventChangeBanner = setInterval(handleChangeBanner,3000);
})

btnLeft.addEventListener("click",()=>
{   clearInterval(handleEventChangeBanner);
     console.log("left");
    if(current == 0)
        {
            current=lengthImg-1;
            let width = imgs[0].offsetWidth;
            listImages.style.transform = `translateX(${width*-1*current}px)`;
            
        }
        else
        {
            current--;
            let width = imgs[0].offsetWidth;
            listImages.style.transform = `translateX(${width*-1*current}px)`;
            
            
        }
        
        handleEventChangeBanner = setInterval(handleChangeBanner,3000);
}

);

const toggleProducts = document.querySelectorAll('.product')

toggleProducts.forEach(toggleProduct => {
    toggleProduct.addEventListener("click",function()
{
    let productID = toggleProduct.getAttribute("data-id");
        console.log(productID);
        window.location.href = `../ChiTiet/ChiTiet.aspx?idProduct=${productID}`;
})
    
});
//const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

