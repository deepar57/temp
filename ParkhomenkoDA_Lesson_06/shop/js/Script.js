var allItems = [
    {
        id: 1,
        title: 'Яблоки',
        price: 100
	},
    {
        id: 2,
        title: 'Груши',
        price: 150
	},
    {
        id: 3,
        title: 'Бананы',
        price: 120
	},
    {
        id: 4,
        title: 'Персики',
        price: 200
	},
    {
        id: 5,
        title: 'Сливы',
        price: 90
	},
];

var cartItems = [];

renderItems();

function renderItems() {
    let catalog = document.querySelector('.catalogContent');
    let itemTemplate = document.getElementById('itemTemplate').content;

    let newItem;

    for (item of allItems) {
        newItem = itemTemplate.cloneNode(true);
        console.log(newItem);
        newItem.querySelector('.title').innerText = item.title;
        newItem.querySelector('.price').innerText = item.price;
        newItem.querySelector('.add').setAttribute('addId', item.id);
        newItem.querySelector('.add').onclick = add_onclick;
        catalog.appendChild(newItem);
    }

};

function add_onclick(event) {
    if (event.target.classList.contains('add')) {
        let id = event.target.getAttribute('addId');
        let item = first(allItems, it => it.id == id);
        let cartItem = first(cartItems, it => it.item.id == id);
        if (cartItem == null) {
            cartItem = {
                item: item,
                count: 1
            };
            cartItems.push(cartItem);
        } else {
            cartItem.count++;
        }

        let cartItemEl = document.querySelector('.cartContent .cartItem' + id);

        if (cartItemEl == null) {
            let cartItemTemplate = document.getElementById('cartItemTemplate').content.cloneNode(true);
            cartItemTemplate.querySelector('.cartItem').classList.add('cartItem' + id);
            cartItemTemplate.querySelector('.title').innerText = item.title;
            cartItemTemplate.querySelector('.price').innerText = item.price;
            let footer = document.querySelector('.cartContent .footer');
            footer.parentNode.insertBefore(cartItemTemplate, footer);
            cartItemEl = document.querySelector('.cartContent .cartItem' + id);
        }

        cartItemEl.querySelector('.count').innerText = cartItem.count;
        cartItemEl.querySelector('.cost').innerText = item.price * cartItem.count;

        let cost = 0;
        for (cartItem of cartItems) {
            cost += cartItem.item.price * cartItem.count;
        }

        document.querySelector('.cartContent .footer .cost').innerText = cost;
    }

}


function first(items, fun) {
    for (item of items) {
        if (fun(item))
            return item;
    }
    return null;
}
