//API Server
import express from 'express';
import cors from 'cors';

import config = require("./config.json")

const app = express();

app.use(async (req, res, next) => {
    console.log(`received ${req.method} : ${req.path}`);
    await next();
})

app.use(cors()) //处理跨域
app.use(express.json());    //处理json数据
app.use(express.urlencoded({
    extended: true
}));
app.use(express.static('./static'));    //静态资源文件处理

app.get('/*', (req, res, next) => {
    res.send("hello world.\n");
});

app.listen(config.port, () => {
    console.log(`API Server is on ${config.port}...`);
});