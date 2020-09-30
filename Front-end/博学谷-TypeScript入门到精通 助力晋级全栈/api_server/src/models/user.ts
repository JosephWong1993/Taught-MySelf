//  用户模型
let rows = [];

class User {
    id: number;
    username: string;
    password: string;
    role: string;
    constructor(username: string, password: string, role: string = 'customer') {
        this.username = username;
        this.password = password;
        this.role = role;
        this.id = rows.length + 1;
    }

    save() {
        rows.push({
            id: this.id,
            username: this.username,
            password: this.password,
            role: this.role
        });
        return true;
    }

    static getList() {
        return rows;
    }

    static login(username: string, password: string) {
        for (let row of rows) {
            if (row.username === username && row.password === password) {
                return row;
            }
        }
        return null;
    }
}

export =User;