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
import { jsx as _jsx } from "react/jsx-runtime";
import { Suspense } from 'react';
import { Route, Routes } from 'react-router-dom';
import { routeConfig } from 'shared/config/routeConfig/routeConfig';
import { PageLoader } from 'widgets/PageLoader/ui/PageLoader';
var AppRouter = function () { return (
// Suspense ���������� �������� �� ��������� ������������ ����������
_jsx(Routes, { children: Object.values(routeConfig).map(function (_a) {
        var path = _a.path, element = _a.element;
        return (_jsx(Route, { path: (path), element: (_jsx(Suspense, __assign({ fallback: _jsx(PageLoader, {}, void 0) }, { children: _jsx("div", __assign({ className: "page-wrapper" }, { children: element }), void 0) }), void 0)) }, path));
    }) }, void 0)); };
export default AppRouter;
