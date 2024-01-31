import { lazy } from 'react';

// Async Import
export const ShopPageAsync = lazy(() => new Promise((resolve) => {
    // @ts-ignore
    resolve(import('./ShopPage'));
}));
