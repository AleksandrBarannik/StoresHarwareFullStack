import { render } from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from 'app/App';
import 'app/styles/Index.scss';


render(
    <BrowserRouter>          
                <App />          
       
    </BrowserRouter>,
    document.getElementById('root'),
);
