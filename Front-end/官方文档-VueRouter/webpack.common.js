//  解决:error TS2307: Cannot find module 'source-map'.
//  https://github.com/Microsoft/TypeScript/issues/21942

const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const VueLoaderPlugin = require('vue-loader/lib/plugin')

module.exports = {
    entry: {
        app: './src/main.ts'
    },
    output: {
        filename: '[name].[hash].bundle.js',
        path: path.resolve(__dirname, 'dist')
    },
    //  提取引导模板(extracting boilerplate) 
    //  https://webpack.docschina.org/guides/caching/#%E6%8F%90%E5%8F%96%E5%BC%95%E5%AF%BC%E6%A8%A1%E6%9D%BF-extracting-boilerplate-
    optimization: {
        runtimeChunk: 'single',
        splitChunks: {
            //  防止重复(prevent duplication) 
            //  https://webpack.docschina.org/guides/code-splitting/#%E9%98%B2%E6%AD%A2%E9%87%8D%E5%A4%8D-prevent-duplication-
            chunks: 'all',
            cacheGroups: {
                vendor: {
                    test: /[\\/]node_modules[\\/]/,
                    name: 'vendors',
                    chunks: 'all'
                }
            }
        }
    },
    resolve: {
        extensions: ['.ts', '.tsx', '.js', 'jsx'],
        // alias: {
        //     'vue$': 'vue/dist/vue.esm.js' // 用 webpack 1 时需用 'vue/dist/vue.common.js'
        // }
    },
    plugins: [
        //  清理 /dist 文件夹
        //  https://webpack.docschina.org/guides/output-management/
        new CleanWebpackPlugin(),
        //  管理输出
        //  https://webpack.docschina.org/guides/output-management/
        new HtmlWebpackPlugin({
            title: 'VueRouterDemo',
            template: "src/index.html"
        }),
        new VueLoaderPlugin()
    ],
    module: {
        rules: [
            //  Vue Loader
            //  https://vue-loader.vuejs.org/zh/guide/#%E6%89%8B%E5%8A%A8%E8%AE%BE%E7%BD%AE
            {
                test: /\.vue$/,
                use: [
                    'vue-loader',
                    //  iView Loader
                    //  https://www.iviewui.com/docs/guide/iview-loader
                    {
                        loader: 'iview-loader',
                        options: {
                            prefix: false
                        }
                    }
                ]

            },
            //  Babel
            //  https://www.babeljs.cn/setup.html#installation
            //  https://www.webpackjs.com/loaders/babel-loader/
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader",
                    options: {
                        presets: ['@babel/preset-env'],
                        plugins: [
                            [
                                "import",
                                {
                                    "libraryName": "iview",
                                    "libraryDirectory": "src/components"
                                }
                            ]
                        ]
                    }
                }
            },
            //  加载images图像
            // //  https://webpack.docschina.org/guides/asset-management/#%E5%8A%A0%E8%BD%BD-images-%E5%9B%BE%E5%83%8F
            // {
            //     test: /\.(png|svg|jpg|gif)$/,
            //     include: path.resolve(__dirname, 'src'),
            //     use: [
            //         'file-loader'
            //     ]
            // },
            //  https://github.com/webpack-contrib/url-loader
            {
                test: /\.(png|jpg|gif|svg)$/i,
                include: [
                    path.resolve(__dirname, 'src'),
                    path.resolve(__dirname, 'node_modules/iview/dist/styles/fonts'),
                ],
                use: [
                    {
                        loader: 'url-loader',
                        options: {
                            limit: 8192,
                        },
                    },
                ],
            },
            //  加载fonts字体
            //  https://webpack.docschina.org/guides/asset-management/#%E5%8A%A0%E8%BD%BD-fonts-%E5%AD%97%E4%BD%93
            {
                test: /\.(woff|woff2|eot|ttf|otf)$/,
                include: [
                    path.resolve(__dirname, 'src'),
                    path.resolve(__dirname, 'node_modules/iview/dist/styles/fonts'),
                ],
                use: [
                    'file-loader'
                ]
            },
            //  加载CSV,TSV数据文件
            //  https://webpack.docschina.org/guides/asset-management/#%E5%8A%A0%E8%BD%BD%E6%95%B0%E6%8D%AE
            {
                test: /\.(csv|tsv)$/,
                include: path.resolve(__dirname, 'src'),
                use: [
                    'csv-loader'
                ]
            },
            //  加载XML数据文件
            //  https://webpack.docschina.org/guides/asset-management/#%E5%8A%A0%E8%BD%BD%E6%95%B0%E6%8D%AE
            {
                test: /\.xml$/,
                include: path.resolve(__dirname, 'src'),
                use: [
                    'xml-loader'
                ]
            }
        ]
    }
};