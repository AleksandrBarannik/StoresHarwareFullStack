import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';

export const getRequestProducts = () => axios.get(responseUrl.Product);
