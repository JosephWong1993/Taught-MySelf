var webpack = require('webpack');
var WebpackMerge = require('webpack-merge'); //  用于合并两个webpack的配置文件
var ExtractTextPlugin = require('extract-text-webpack-plugin');
var htmlWebpackPlugin = require('html-webpack-plugin'); //  用来
const {
    VueLoaderPlugin
} = require('vue-loader');
var WebpackBaseConfig = require('./webpack.config.js');

//  清空基本配置的插件列表
WebpackBaseConfig.plugins = [];

module.exports = WebpackMerge(WebpackBaseConfig, {
    output: {
        publicPath: '/dist',
        //  将入口文件重命名为带有20位hash值的唯一文件
        filename: '[name].[hash].js',
        chunkFilename: '[name].chunk.js'
    },
    plugins: [
        new VueLoaderPlugin(),
        //  提取css,并重命名为带有20位hash值的唯一文件
        new ExtractTextPlugin({
            filename: '[name].[hash].css',
            allChunks: true
        }),
        //  定义当前node环境为生产环境
        new webpack.DefinePlugin({
            'process.env': {
                NODE_ENV: 'production'
            }
        }),
        //  提取模版,并保存入口html文件
        new htmlWebpackPlugin({
            filename: '../index_prod.html',
            template: './index.ejs',
            inject: false
        })
    ]
});