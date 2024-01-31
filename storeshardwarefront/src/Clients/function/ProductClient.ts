import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';

export const fetchProducts = () => axios.get(responseUrl.Product);
