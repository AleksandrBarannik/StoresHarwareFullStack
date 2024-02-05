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
import { useCallback, useState } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { Modal } from 'shared/ui/Modal/Modal';
import { Button, ButtonTheme } from 'shared/ui/Button/Button';
import cls from './Navbar.module.scss';
// Navigation panel with links to page
export function Navbar(_a) {
    var className = _a.className;
    var _b = useState(false), modalData = _b[0], setModalWindow = _b[1];
    var onToggleModal = useCallback(function () {
        setModalWindow(function (prev) { return !prev; });
    }, []);
    return (_jsxs("div", __assign({ className: classNames(cls.navbar, {}, [className]) }, { children: [_jsx(Button, __assign({ theme: ButtonTheme.CLEAR, className: cls.links, onClick: onToggleModal }, { children: "OpenModalWindow" }), void 0), _jsx(Modal, __assign({ isOpen: modalData, onClose: onToggleModal }, { children: "MODAL FORM TESTING" }), void 0)] }), void 0));
}
