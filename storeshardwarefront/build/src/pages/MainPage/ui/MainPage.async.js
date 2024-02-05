import { lazy } from 'react';
// Async Import
export var MainPageAsync = lazy(function () { return new Promise(function (resolve) {
    // @ts-ignore
    resolve(import('./MainPage'));
}); });
