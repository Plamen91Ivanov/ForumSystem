// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.if (document.readyState == 'loading') {
document.addEventListener('DOMContentLoaded', ready)
}else {
    ready()
}

function ready() {

    var removeCardItemButton = document.getElementsByClassName('btn-danger');
    console.log(removeCardItemButton);
    for (var i = 0; i < removeCardItemButton.length; i++) {
        var button = removeCardItemButton[i]
        button.addEventListener('click', removeCartItem)
    }
    var quantityInputs = document.getElementsByClassName('cart-quantity-input')
    for (var i = 0; i < quantityInputs.length; i++) {
        var input = quantityInputs[i]
        input.addEventListener('change', quantityChanged)
    }

    var addToCartButtons = document.getElementsByClassName('shop-item-button')
    for (let i = 0; i < addToCartButtons.length; i++) {
        var button = addToCartButtons[i]
        button.addEventListener('click', addToCardClicked)
        console.log('addToCardClicked')
    }


    document.getElementsByClassName('btn-purchase')[0].addEventListener('click', purchaseClicked)
}


function purchaseClicked() {
    alert('Thank you for your purchase')
    var cartItems = document.getElementsByClassName('cart-items')[0]
    while (cartItems.hasChildNodes()) {
        cartItems.removeChild(cartItems.firstChild)
    }
    updateCartTotal()
}

function addToCardClicked(event) {
    var button = event.target
    var shopItem = button.parentElement.parentElement
    var title = shopItem.getElementsByClassName('shop-item-title')[0].innerText
    var price = shopItem.getElementsByClassName('shop-item-price')[0].innerText
    var imageSrc = shopItem.getElementsByClassName('shop-item-image')[0].src
    var protein = shopItem.getElementsByClassName('shop-item-protein')[0].innerText
    var fat = shopItem.getElementsByClassName('shop-item-fat')[0].innerText
    addItemToCard(title, price, imageSrc, protein, fat)
    updateCartTotal()
}

function addItemToCard(title, price, imageSrc, protein, fat) {
    var cartRow = document.createElement('div')
    cartRow.classList.add('cart-row')
    var cartItems = document.getElementsByClassName('cart-items')[0]
    var cartItemNames = cartItems.getElementsByClassName('cart-item-title')
    for (let i = 0; i < cartItemNames.length; i++) {
        if (cartItemNames[i].innerHTML == title) {
            alert('This item is already added to the cart')
            return
        }

    }
    var cartRowContent = `<div class="cart-item cart-column">
    <img class="cart-item-image" src="${imageSrc}" width="100" height="100">
    <span class="cart-item-title">${title}</span>
</div>
<span class="cart-price cart-column">${price}</span>  
<span class="cart-protein cart-column">${protein}</span>
<span class="cart-fat cart-column">${fat}</span>
<div class="cart-quantity cart-column">
    <input class="cart-quantity-input" type="number" value="1">
    <button class="btn btn-danger" type="button">REMOVE</button>
</div>`
    cartRow.innerHTML = cartRowContent
    cartItems.append(cartRow)
    cartRow.getElementsByClassName('btn-danger')[0].addEventListener('click', removeCartItem)
    cartRow.getElementsByClassName('cart-quantity')[0].addEventListener('change', quantityChanged)
}

function removeCartItem(event) {
    var buttonClicked = event.target
    buttonClicked.parentElement.parentElement.remove()
    updateCartTotal()
}

function quantityChanged(event) {
    var input = event.target
    if (isNaN(input.value) || input.value <= 0) {
        input.value = 1
    }
    updateCartTotal()
}


function updateCartTotal() {
    var cartItemContainer = document.getElementsByClassName('cart-items')[0]
    var cartRows = cartItemContainer.getElementsByClassName('cart-row')
    var total = 0
    var totalProtein = 0
    var totalFat = 0
    for (var i = 0; i < cartRows.length; i++) {
        var cartRow = cartRows[i]
        var priceElement = cartRow.getElementsByClassName('cart-price')[0]
        var quantityElement = cartRow.getElementsByClassName('cart-quantity-input')[0]
        var proteinElement = cartRow.getElementsByClassName('cart-protein')[0]
        var fatElement = cartRow.getElementsByClassName('cart-fat')[0]

        var price = parseFloat(priceElement.innerText.replace('$', ''))

        var quantity = quantityElement.value
        total = total + (price * quantity)
        totalProtein = totalProtein + parseFloat(proteinElement.innerText)
        totalFat = totalFat + parseFloat(fatElement.innerText)
    }
    total = Math.round(total * 100) / 100

    document.getElementsByClassName('cart-total-price')[0].innerText = '$' + total
    document.getElementsByClassName('cart-total-protein')[0].innerText = totalProtein
    document.getElementsByClassName('cart-total-fat')[0].innerText = totalFat
}