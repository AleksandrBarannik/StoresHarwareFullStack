import webpack from 'webpack';
import { BuildOptions } from './types/config';
import { buildCssLoader } from './loaders/buildCssLoader';

// return all loaders (write all loaders)
export function buildLoaders({ isDev }: BuildOptions): webpack.RuleSetRule[] {
    // for work SVG files
    const svgLoader = {
        test: /\.svg$/,
        use: ['@svgr/webpack'],
    };    

    // For work witch SCSS;CSS
    const cssLoader = buildCssLoader(isDev);

    const typescriptLoader = {
        test: /\.tsx?$/,
        use: 'ts-loader',
        exclude: /node_modules/, // Исключение
    };

    // for work  PNG;JPEG;Gif files
    const fileLoader = {
        test: /\.(png|jpe?g|gif)$/i,
        use: [
            {
                loader: 'file-loader',
            },
        ],
    };

    return [
        fileLoader,
        svgLoader,       
        typescriptLoader,
        cssLoader,
    ];
}
