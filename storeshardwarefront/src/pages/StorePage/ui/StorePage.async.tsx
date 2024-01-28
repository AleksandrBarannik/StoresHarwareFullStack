import { lazy } from 'react';

// Async Import
export const ProductPageAsync = lazy(() => new Promise((resolve) => {
    // @ts-ignore    
    resolve(import('./StorePage'))
}));
