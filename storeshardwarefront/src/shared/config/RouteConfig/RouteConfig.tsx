import { MainPage } from 'pages/MainPage';
import { StorePage } from 'pages/StorePage';
import { ProductPage } from 'pages/ProductPage';
import { RouteProps } from 'react-router-dom';

// Names Pages
export enum AppRoutes {
    MAIN = 'main',
    STORE = 'store',
    PRODUCT = 'product',
}

// Paths to Pages
export const RoutePath: Record<AppRoutes, string> = {
    [AppRoutes.MAIN]: '/',
    [AppRoutes.STORE]: '/store',
    [AppRoutes.PRODUCT]: '/product',
}

export const routeConfig: Record<AppRoutes, RouteProps> = {

    [AppRoutes.MAIN]: {
        path: RoutePath.main,
        element: <MainPage />,
    },

    [AppRoutes.STORE]: {
        path: RoutePath.store,
        element: <StorePage />,
    },

    [AppRoutes.PRODUCT]: {
        path: RoutePath.product,
        element: <ProductPage />,
    },
};
