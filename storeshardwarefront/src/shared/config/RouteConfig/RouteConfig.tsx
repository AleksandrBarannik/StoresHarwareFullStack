import { MainPage } from 'pages/MainPage';
import { ShopPage } from 'pages/StorePage';
import { ProductPage } from 'pages/ProductPage';
import { RouteProps } from 'react-router-dom';

// Names Pages
export enum AppRoutes {
    MAIN = 'main',
    SHOP = 'shop',
    PRODUCT = 'product',
}

// Paths to Pages
export const RoutePath: Record<AppRoutes, string> = {
    [AppRoutes.MAIN]: '/',
    [AppRoutes.SHOP]: '/shop',
    [AppRoutes.PRODUCT]: '/product',
};

export const routeConfig: Record<AppRoutes, RouteProps> = {

    [AppRoutes.MAIN]: {
        path: RoutePath.main,
        element: <MainPage />,
    },

    [AppRoutes.SHOP]: {
        path: RoutePath.shop,
        element: <ShopPage />,
    },

    [AppRoutes.PRODUCT]: {
        path: RoutePath.product,
        element: <ProductPage />,
    },
};
