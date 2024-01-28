import HTMLWebpackPlugin from 'html-webpack-plugin';
import webpack from 'webpack';
import MiniCssExtractPlugin from 'mini-css-extract-plugin';
import { BuildOptions, BuildPath } from './types/config';

// return all Plugins for webpack
export function buildPlugins({ paths, isDev }: BuildOptions): webpack.WebpackPluginInstance[] {
    const plugins = [

        // for automatic add Html in build on our template
        new HTMLWebpackPlugin({
            template: paths.html,
        }),

        // for progress build in %
        new webpack.ProgressPlugin(),

        // for מעהוכüםûץ Css files in build
        new MiniCssExtractPlugin({
            filename: 'css/[name].[contenthash:8].css',
            chunkFilename: 'css/[name].[contenthash:8].css', // for async
        }),

        // for transfer global variables in app
        new webpack.DefinePlugin({
            // For TS __IS_DEV__ create in app/types/global.ts
            __IS_DEV__: JSON.stringify(isDev),
        }),
    ];

    if (isDev) {
        plugins.push(new webpack.HotModuleReplacementPlugin());        
    }

    return plugins;
}
