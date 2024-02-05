import { jsx as _jsx, jsxs as _jsxs } from "react/jsx-runtime";
import { useCallback } from 'react';
import { Table } from 'shared/ui/Table/Table';
export var MainPage = function () {
    var onEditData = useCallback(function () {
        console.log('Button Edit MainPage Click');
    }, []);
    var onDeleteData = useCallback(function () {
        console.log('Button Delete MainPage Click');
    }, []);
    var dataTable = [
        {
            ProductId: 1,
            ProductName: 'Iphone11',
            ProductModel: '11Pro_256Gb',
            ShopName: 'TestDNS',
            ProductDescription: '11Pro_256Gb',
            Price: 65000,
        },
    ];
    var column = [
        { heading: 'ProductId', value: 'ProductId' },
        { heading: 'ProductName', value: 'ProductName' },
        { heading: 'ProductModel', value: 'ProductModel' },
        { heading: 'ProductDescription', value: 'ProductDescription' },
        { heading: 'Price', value: 'Price' },
        { heading: 'ShopName', value: 'ShopName' },
    ];
    return (_jsxs("div", { children: [_jsx("h1", { children: "Main page" }, void 0), _jsx("div", { children: _jsx(Table, { data: dataTable, column: column, onEditClick: onEditData, onDeleteClick: onDeleteData }, void 0) }, void 0)] }, void 0));
};
