var webpack = require('webpack');
var config = {
    entry: "./app/index.js",
    resolve: {
        extensions: ['.ts', '.js']
    },
    output: {
        path: __dirname + '/dist',
        filename: 'bundle.js',
    },
};
module.exports = config;
//# sourceMappingURL=webpack.config.js.map