const path = require('path');

module.exports = {
    entry: './src/ts/index.ts',
    
    devtool: 'inline-source-map',
    module: {
        rules: [
            {
                test:/\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/
            }
        ]
    },
    mode : 'development',
    plugins: [new HtmlWebpackPlugin({
        template: 'app/index.html'
    })
],
    resolve: {
        extensions: [ '.tsx', '.ts', '.js']
    },
    
    output: {
        filename : 'bundle.js',
        path: path.resolve(__dirname, 'dist')
    }
};