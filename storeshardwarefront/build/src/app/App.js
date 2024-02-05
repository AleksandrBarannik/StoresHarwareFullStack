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
import { Suspense } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { AppRouter } from 'app/providers/Router';
import { Sidebar } from 'widgets/Sidebar/ui/Sidebar';
import { Navbar } from 'widgets/Navbar/ui/Navbar';
function App() {
    return (_jsxs("div", __assign({ className: classNames('app', {}, []) }, { children: [_jsx(Navbar, {}, void 0), _jsx(Suspense, __assign({ fallback: "" }, { children: _jsxs("div", __assign({ className: "content-page" }, { children: [_jsx(Sidebar, {}, void 0), _jsx(AppRouter, {}, void 0)] }), void 0) }), void 0)] }), void 0));
}
export default App;
