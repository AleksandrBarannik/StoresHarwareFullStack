import { jsx as _jsx, jsxs as _jsxs } from "react/jsx-runtime";
import { useCallback, useEffect, useState } from 'react';
import { Table } from 'shared/ui/Table/Table';
import { getRequestProducts } from 'Clients/function/ProductClient';
export var ProductPage = function () {
    var _a = useState([]), productState = _a[0], setProductState = _a[1];
    useEffect(function () {
        getRequestProducts().then(function (res) {
            // console.log(res.data.result);
            setProductState(res.data.result);
        });
    }, [setProductState]);
    var onEditProduct = useCallback(function () {
        console.log('Button Edit ProductPage Click');
    }, []);
    var onDeleteProduct = useCallback(function () {
        console.log('Button Delete ProductPage Click');
    }, []);
    var column = [
        { heading: 'ProductId', value: 'productId' },
        { heading: 'ProductName', value: 'productName' },
        { heading: 'ProductModel', value: 'productModel' },
        { heading: 'ProductDescription', value: 'productDescription' },
        { heading: 'Price', value: 'price' },
    ];
    return (_jsxs("div", { children: [_jsx("h1", { children: "List of Products" }, void 0), _jsx(Table, { data: productState, column: column, onEditClick: onEditProduct, onDeleteClick: onDeleteProduct }, void 0)] }, void 0));
};
