module.exports = {
    context: __dirname + "/app",
    entry: "./app.tsx",
    output: {
        path: __dirname + "/wwwroot",
        filename: "appBundle.js"
    },
    resolve: {
        extensions: ['', '.webpack.js', '.web.js', '.ts', '.js']
    },
    module: {
        loaders: [
            { test: /\.tsx?$/, loader: 'ts-loader', exclude: /node_modules/ }
        ]
    },
    dev: {
        hot: true
    }
}