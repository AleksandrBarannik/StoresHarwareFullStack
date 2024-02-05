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
import cls from './FormInput.module.scss';
export var FormInput = function (props) {
    var type = props.type, className = props.className, label = props.label, value = props.value, name = props.name, placeholder = props.placeholder, disabled = props.disabled, onChange = props.onChange;
    return (_jsxs("div", __assign({ className: classNames(cls.inputWrapper, {}, [className]) }, { children: [_jsx("label", __assign({ htmlFor: label }, { children: label }), void 0), _jsx("input", { type: type, id: label, defaultValue: value, name: name, placeholder: placeholder, onChange: onChange, disabled: disabled }, void 0)] }), void 0));
};
