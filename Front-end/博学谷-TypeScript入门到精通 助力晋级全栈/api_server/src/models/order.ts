//  订单模型
let rows = [];

class Order {
    id: number;
    order_no: string;
    items: any[];
    user: number;
    amount: number;
    status: string;
    create_time: Date;
    constructor(items: any[], user: number, status: string = 'handling') {
        this.items = items;
        this.user = user;
        this.amount = 0;
        items.forEach(i => this.amount += i.quantity * i.unit_price);
        this.create_time = new Date();
        this.order_no = '' + Date.now();
        this.status = status;
        this.id = rows.length + 1;
    }

    save() {
        let order = {
            id: this.id,
            order_no: this.order_no,
            items: this.items,
            user: this.user,
            amount: this.amount,
            status: this.status,
            create_time: this.create_time
        };
        rows.push(order);
        return true;
    }

    static getList() {
        return rows;
    }

    static getById(id: number) {
        for (let row of rows) {
            if (row.id === id) {
                return row;
            }
        }
        return null;
    }
    static changeStatus(id: number, status: string) {
        for (let row of rows) {
            if (row.id === id) {
                row.status = status;
                return row;
            }
        }
        return null;
    }
}

export = Order;