class GoodsItem {
    constructor(title, price, img) {
        this.title = title;
        this.price = price;
        this.img = img;
    }
    render() {
        return `<div class="goods-item"><img class="goods-item-img" src="img/${this.img}" alt="{title}"><h3>${this.title}</h3><p>${this.price}</p><button class="btn">Добавить</button></div>`;
    }
}

class GoodsList {
    constructor() {
        this.goods = [];
    }

    fetchGoods() {
        this.goods = [
            {
                title: 'Shirt',
                price: 150,
                img: "phone1.jpg"
            },
            {
                title: 'Socks',
                price: 50,
                img: "phone2.jpg"
            },
            {
                title: 'Jacket',
                price: 350,
                img: "phone3.jpg"
            },
            {
                title: 'Shoes',
                price: 250,
                img: "phone1.jpg"
            },
        ];
    }

    render() {
        let listHtml = '';
        this.goods.forEach(good => {
            const goodItem = new GoodsItem(good.title, good.price, good.img);
            listHtml += goodItem.render();
        });
        listHtml += `<div class="clr"></div>`;
        document.querySelector('.goods-list').innerHTML = listHtml;
    }

    sum() {
        let sum = 0;
        this.goods.forEach(c => sum += c.price);
        return sum;
    }
}

class CartItem {
    constructor(goodsItem, count) {
        this.good = goodsItem;
        this.count = count;
    }
}

class Cart {
    constructor() {
        this.items = [];
    }

    find(goodsItem) {
        return this.items.find((c, i, arr) => c.good === goodsItem);
    }

    add(goodsItem, count) {
        let exist = this.find(goodsItem);
        if (exist == undefined || exist == null)
            this.items.push(new CartItem(goodsItem, count));
        else
            exist.count += count;
    }
}

const list = new GoodsList();
list.fetchGoods();
list.render();
//console.log(list.sum());

let cart = new Cart();
cart.add(list.goods[0], 3);
cart.add(list.goods[0], 2);
cart.add(list.goods[0], 4);
cart.add(list.goods[1], 17);

//console.log(cart.find(list.goods[0]));
//console.log(cart.find(list.goods[1]));
