import webpack, { ResolveOptions } from 'webpack';
import { BuildOptions } from './types/config';

// return all resolve
export function buildResolves(options: BuildOptions): ResolveOptions {
    return {
        extensions: ['.tsx', '.ts', '.js'],

        // Absolute Path prefer(приоритет)
        preferAbsolute: true,
        modules: [options.paths.src, 'node_modules'],

        // public MainFiles for each module
        mainFiles: ['index'],
        alias: {},
    };
}
