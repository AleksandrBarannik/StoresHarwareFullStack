import { lazy } from 'react';

// Async Import
export const MainPageAsync = lazy(() => new Promise((resolve) => {
    // @ts-ignore    
    resolve(import('./MainPage'))
}));
