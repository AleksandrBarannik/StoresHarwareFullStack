import { jsx as _jsx } from "react/jsx-runtime";
import { render } from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from 'app/App';
import 'app/styles/Index.scss';
render(_jsx(BrowserRouter, { children: _jsx(App, {}, void 0) }, void 0), document.getElementById('root'));
