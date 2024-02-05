import { buildCssLoader } from './loaders/buildCssLoader';
// return all loaders (write all loaders)
export function buildLoaders(_a) {
    var isDev = _a.isDev;
    // for work SVG files
    var svgLoader = {
        test: /\.svg$/,
        use: ['@svgr/webpack'],
    };
    // For work witch SCSS;CSS
    var cssLoader = buildCssLoader(isDev);
    var typescriptLoader = {
        test: /\.tsx?$/,
        use: 'ts-loader',
        exclude: /node_modules/, // ����������
    };
    // for work  PNG;JPEG;Gif files
    var fileLoader = {
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
