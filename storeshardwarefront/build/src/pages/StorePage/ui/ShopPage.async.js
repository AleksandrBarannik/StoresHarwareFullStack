import { lazy } from 'react';
// Async Import
export var ShopPageAsync = lazy(function () { return new Promise(function (resolve) {
    // @ts-ignore
    resolve(import('./ShopPage'));
}); });
