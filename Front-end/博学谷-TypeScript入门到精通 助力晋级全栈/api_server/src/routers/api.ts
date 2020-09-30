/**
 * RESTful API 举例：
 * 1. 所有的事物都被抽象为资源
 * 2. 每个资源都有一个唯一的资源标识符
 * 3. 对资源的各种操作不会改变资源标识符
 * 4. 所有的操作都是无状态的
 * 
 * GET：    读取数据（Read）
 * POST：   新建（Create）
 * PUT：    更新（Update）
 * PATCH：  更新（Update），部分更新
 * DELETE： 删除（Delete）
 * 
 * POST     /users/     ：创建一个新用户
 * PUT      /users/:id  ：根据 id 更新一个用户数据（全部字段）
 * PATCH    /users/:id  ：根据 id 更新一个用户数据（部分更新）
 * GET      /users/     ：查询所有用户记录
 * GET      /users/:id  ：根据 id 查询一个用户数据
 * DELETE   /users/:id  ：根据 id 删除一个用户
 */

import { Router } from 'express';

const router = Router();

//  用户注册
router.post('/users/register', (req, res, next) => {
    res.send("users.register");
});

//  用户登录
router.post('/users/login', (req, res, next) => {
    res.send("users.login");
});

//  商品列表
router.get('/items/list', (req, res, next) => {
    res.send("items.list");
});

//  商品详情
router.get('/items/:id', (req, res, next) => {
    res.send("items.one");
});

//  创建订单
router.post('/orders/create', (req, res, next) => {
    res.send("orders.create");
});

//  订单列表
router.get('/orders/list', (req, res, next) => {
    res.send("orders.list");
});

//  订单详情
router.get('/orders/:id', (req, res, next) => {
    res.send("orders.one");
});

//  修改订单状态
router.post('/orders/:id/change_status', (req, res, next) => {
    res.send("orders.one.status");
});

export =router;