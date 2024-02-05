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
import { useState } from 'react';
import { postRequestShop } from 'Clients';
// return state && post functions;
var useRequestShop = function () {
    var _a = useState({
        shopId: '',
        name: '',
        phone: '',
        adress: '',
    }), createState = _a[0], setCreatState = _a[1];
    var handleChange = function (e) {
        var _a;
        // eslint-disable-next-line prefer-destructuring
        var value = e.target.value;
        setCreatState(__assign(__assign({}, createState), (_a = {}, _a[e.target.name] = value, _a)));
    };
    var postHandleSubmit = function (e) {
        e.preventDefault();
        var shopData = {
            shopId: createState.shopId,
            name: createState.name,
            phone: createState.phone,
            adress: createState.adress,
        };
        postRequestShop(shopData);
    };
    return {
        createState: createState,
        handleChange: handleChange,
        postHandleSubmit: postHandleSubmit,
    };
};
export default useRequestShop;
