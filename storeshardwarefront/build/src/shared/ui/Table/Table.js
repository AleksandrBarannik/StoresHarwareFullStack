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
import { Button } from 'shared/ui/Button/Button';
import cls from './Table.module.scss';
export var Table = function (props) {
    var className = props.className, data = props.data, column = props.column, onDeleteClick = props.onDeleteClick, onEditClick = props.onEditClick;
    var TableHeadItem = function (_a) {
        var item = _a.item;
        return _jsx("th", { children: item.heading }, void 0);
    };
    var TableRow = function (_a) {
        var item = _a.item, column = _a.column;
        return (_jsxs("tr", { children: [column.map(function (columnItem, index) { return (_jsxs("td", { children: [' ', item["".concat(columnItem.value)], ' '] }, columnItem.value)); }), _jsx(Button, __assign({ onClick: onEditClick }, { children: "Edit" }), void 0), _jsx(Button, __assign({ onClick: onDeleteClick }, { children: "Delete" }), void 0)] }, void 0));
    };
    return (_jsxs("table", __assign({ className: classNames(cls.Table, {}, [className]) }, { children: [_jsx("thead", { children: _jsx("tr", { children: column.map(function (item, index) { return (_jsx(TableHeadItem, { item: item }, index)); }) }, void 0) }, void 0), _jsx("tbody", { children: data.map(function (item, index) { return (_jsx(TableRow, { item: item, column: column }, index)); }) }, void 0)] }), void 0));
};
