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
import { FormInput } from 'shared/ui/FormInput/FormInput';
import useRequestShop from 'app/hooks/useRequestShop';
// FORM  fo POst  PUT Delete Methods for Table Shop
export var ShopForm = function () {
    var _a = useRequestShop(), createState = _a.createState, postHandleSubmit = _a.postHandleSubmit, handleChange = _a.handleChange;
    return (_jsxs("form", __assign({ onSubmit: postHandleSubmit }, { children: [_jsx(FormInput, { type: "number", label: "ShopId", name: "shopId", placeholder: "Enter new ShopId", onChange: handleChange, value: createState.shopId }, void 0), _jsx(FormInput, { type: "text", label: "ShopName", name: "name", placeholder: "Enter new name shop", onChange: handleChange, value: createState.name }, void 0), _jsx(FormInput, { type: "number", label: "Phone", name: "phone", placeholder: "Enter new phone number", onChange: handleChange, value: createState.phone }, void 0), _jsx(FormInput, { type: "text", label: "Adress", name: "adress", placeholder: "Enter new adress for  shop", onChange: handleChange, value: createState.adress }, void 0), _jsx("button", __assign({ type: "submit" }, { children: "Send" }), void 0)] }), void 0));
};
