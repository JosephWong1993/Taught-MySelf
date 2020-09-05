const path = require('path');
const HtmlWebpackPlugin = require("html-webpack-plugin");
const CleanWebpackPlugin = require("clean-webpack-plugin");
const WorkboxPlugin = require("workbox-webpack-plugin");

module.exports = {
    entry: {
        app: "./src/index.js",
        print: "./src/print.js",
    },
    plugins: [
        new CleanWebpackPlugin(["dist"]),
        new HtmlWebpackPlugin({
            // title: "Output Management"
            title: 'Progressive Web Application'
        }),
        new WorkboxPlugin.GenerateSW({
            //  这些选项帮助ServiceWorkers快速启用
            //  不允许遗留任何"旧的"ServiceWorkers
            clientsClaim: true,
            skipWaiting: true
        })
    ],
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, "dist"),
    },
}