// return all resolve
export function buildResolves(options) {
    return {
        extensions: ['.tsx', '.ts', '.js'],
        // Absolute Path prefer(���������)
        preferAbsolute: true,
        modules: [options.paths.src, 'node_modules'],
        // public MainFiles for each module
        mainFiles: ['index'],
        alias: {},
    };
}
