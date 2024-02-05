var _a, _b;
import { jsx as _jsx } from "react/jsx-runtime";
import { MainPage } from 'pages/MainPage';
import { ShopPage } from 'pages/StorePage';
import { ProductPage } from 'pages/ProductPage';
// Names Pages
export var AppRoutes;
(function (AppRoutes) {
    AppRoutes["MAIN"] = "main";
    AppRoutes["SHOP"] = "shop";
    AppRoutes["PRODUCT"] = "product";
})(AppRoutes || (AppRoutes = {}));
// Paths to Pages
export var RoutePath = (_a = {},
    _a[AppRoutes.MAIN] = '/',
    _a[AppRoutes.SHOP] = '/shop',
    _a[AppRoutes.PRODUCT] = '/product',
    _a);
export var routeConfig = (_b = {},
    _b[AppRoutes.MAIN] = {
        path: RoutePath.main,
        element: _jsx(MainPage, {}, void 0),
    },
    _b[AppRoutes.SHOP] = {
        path: RoutePath.shop,
        element: _jsx(ShopPage, {}, void 0),
    },
    _b[AppRoutes.PRODUCT] = {
        path: RoutePath.product,
        element: _jsx(ProductPage, {}, void 0),
    },
    _b);
