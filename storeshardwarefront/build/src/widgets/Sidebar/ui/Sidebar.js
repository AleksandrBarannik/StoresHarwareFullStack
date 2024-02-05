var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
import { jsx as _jsx, jsxs as _jsxs } from "react/jsx-runtime";
import { classNames } from 'shared/lib/classNames/classNames';
import { useState } from 'react';
import { Button, ButtonSize, ButtonTheme } from 'shared/ui/Button/Button';
import { AppLink, AppLinkTheme } from 'shared/ui/AppLink/AppLink';
import { RoutePath } from 'shared/config/routeConfig/routeConfig';
import ProductIcon from 'shared/assets/icons/product-20-20.svg';
import ShopIcon from 'shared/assets/icons/shop-20-20.svg';
import MainIcon from 'shared/assets/icons/main-20-20.svg';
import cls from './Sidebar.module.scss';
export var Sidebar = function (_a) {
    var _b;
    var className = _a.className;
    var _c = useState(false), collapsed = _c[0], setCollapsed = _c[1];
    var onToggle = (function () {
        setCollapsed(function (prev) { return !prev; });
    });
    return (_jsxs("div", __assign({ "data-testid": "sidebar", className: classNames(cls.Sidebar, (_b = {}, _b[cls.collapsed] = collapsed, _b), [className]) }, { children: [_jsx(Button, __assign({ onClick: onToggle, className: cls.collapseBtn, theme: ButtonTheme.BACKGROUND, size: ButtonSize.L, square: true }, { children: collapsed ? '>' : '<' }), void 0), _jsxs("div", __assign({ className: cls.items }, { children: [_jsxs(AppLink, __assign({ theme: AppLinkTheme.SECONDARY, to: RoutePath.main, className: cls.item }, { children: [_jsx(MainIcon, { className: cls.icon }, void 0), _jsx("span", __assign({ className: cls.link }, { children: "Main Page" }), void 0)] }), void 0), _jsxs(AppLink, __assign({ theme: AppLinkTheme.SECONDARY, to: RoutePath.product, className: cls.item }, { children: [_jsx(ProductIcon, { className: cls.icon }, void 0), _jsx("span", __assign({ className: cls.link }, { children: "Products" }), void 0)] }), void 0), _jsxs(AppLink, __assign({ theme: AppLinkTheme.SECONDARY, to: RoutePath.shop, className: cls.item }, { children: [_jsx(ShopIcon, { className: cls.icon }, void 0), _jsx("span", __assign({ className: cls.link }, { children: "Stores" }), void 0)] }), void 0)] }), void 0)] }), void 0));
};
