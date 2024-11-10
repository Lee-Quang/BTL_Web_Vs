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
// Bấm chỉnh sửa từng sản phẩm

function Minus(idCart) {
    fetch("../GioHang/GioHang.aspx", {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded"
        },
        body: `idCart=${idCart}&action=minus`
    })
        .then(response => response.text())
        .then(data => {
            if (data !== "") {
                console.log("Trừ số lượng sản phẩm thành công");
                location.reload();
            }
        })
        .catch(error => console.error('Error sending data: ' + error));
}

function Plus(idCart) {
    fetch("../GioHang/GioHang.aspx", {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded"
        },
        body: `idCart=${idCart}&action=plus`
    })
        .then(response => response.text())
        .then(data => {
            if (data !== "") {
                console.log("Trừ số lượng sản phẩm thành công");
                location.reload();
            }
        })
        .catch(error => console.error('Error sending data: ' + error));
}

function Delete(idCart) {
    fetch("../GioHang/GioHang.aspx", {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded"
        },
        body: `idCart=${idCart}&action=delete`
    })
        .then(response => response.text())
        .then(data => {
            if (data !== "") {
                console.log("Trừ số lượng sản phẩm thành công");
                location.reload();
            }
        })
        .catch(error => console.error('Error sending data: ' + error));
}

const handleMinus = (idCart) => {
    var soLuong_int = 0;
    const soLuong_sps = document.querySelectorAll(".soLuong_sp");
    soLuong_sps.forEach(soLuong_sp => {
        if (soLuong_sp.getAttribute("data-id") === idCart.toString()) {
            let soLuong_value = soLuong_sp.innerHTML;
            soLuong_int = parseInt(soLuong_value, 10);
            if (soLuong_int > 1) {
                Minus(idCart);
            }
            else {
                if (confirm("Bạn có muốn xoá sản phẩm này không?")) {
                    Delete(idCart);
                }
                else {
                    return;
                }
            }
        }
    })
    console.log(idCart + " " + soLuong_int + " đã bấm" + typeof (soLuong_sp.getAttribute("data-id")) + " " + typeof( idCart));
    
}

const handlePlus = (idCart) => {
    Plus(idCart);
}

const handleDelete = (idCart) => {
    if (confirm("Bạn có muốn xoá sản phẩm này không?")) {
        Delete(idCart);
    }
    else {
        return;
    }
}
    
