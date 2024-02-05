export function buildDevServer(options) {
    return {
        port: options.port,
        open: true,
        // to go to the path: /about ; ets
        historyApiFallback: true,
        hot: true,
    };
}
