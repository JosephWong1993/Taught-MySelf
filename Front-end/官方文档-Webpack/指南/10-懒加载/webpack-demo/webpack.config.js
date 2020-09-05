const path = require('path');
const HtmlWebpackPlugin = require("html-webpack-plugin");
const CleanWebpackPlugin = require("clean-webpack-plugin");

module.exports = {
    entry: {
        index: "./src/index.js",
    },
    plugins: [
        new CleanWebpackPlugin(["dist"]),
        new HtmlWebpackPlugin({
            title: "Code Splitting"
        })
    ],
    output: {
        filename: '[name].bundle.js',
        chunkFilename: "[name].bundle.js",
        path: path.resolve(__dirname, "dist"),
    },
};