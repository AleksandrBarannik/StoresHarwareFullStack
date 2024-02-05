import { lazy } from 'react';
// Async Import
export var ProductPageAsync = lazy(function () { return new Promise(function (resolve) {
    // @ts-ignore
    resolve(import('./ProductPage'));
}); });
