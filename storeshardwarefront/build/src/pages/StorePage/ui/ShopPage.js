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
/* eslint-disable comma-dangle */
/* eslint-disable prefer-destructuring */
import { useCallback, useEffect, useState, } from 'react';
import { Table } from 'shared/ui/Table/Table';
import { getRequestShops, getRequestShopById } from 'Clients/function/ShopClient';
import { Button } from 'shared/ui/Button/Button';
import { Modal } from 'shared/ui/Modal/Modal';
import { ShopForm } from 'widgets/Forms';
export var ShopPage = function () {
    var _a;
    var shopID = 1;
    var _b = useState([]), shopState = _b[0], setShopState = _b[1];
    var _c = useState([]), shopStateById = _c[0], setShopStateById = _c[1];
    var _d = useState(false), modalData = _d[0], setModalWindow = _d[1];
    useEffect(function () {
        getRequestShops().then(function (res) {
            setShopState(res.data.result);
        });
    }, [setShopState]);
    useEffect(function () {
        getRequestShopById(shopID).then(function (res) {
            // console.log(res.data.result);
            setShopStateById(res.data.result);
        });
    }, [setShopStateById]);
    var onToggleModal = useCallback(function () {
        setModalWindow(function (prev) { return !prev; });
    }, []);
    var columns = Object.keys((_a = shopState[0]) !== null && _a !== void 0 ? _a : {}).map(function (key) { return ({
        heading: key,
        value: key,
    }); });
    return (_jsxs("div", { children: [_jsx("h1", { children: "List of Shops" }, void 0), _jsx(Button, __assign({ onClick: onToggleModal }, { children: "Create" }), void 0), _jsx(Table, { data: shopState, column: columns }, void 0), _jsx(Modal, __assign({ isOpen: modalData, onClose: onToggleModal }, { children: _jsx(ShopForm, {}, void 0) }), void 0)] }, void 0));
};
