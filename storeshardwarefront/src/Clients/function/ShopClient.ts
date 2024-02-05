import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';

export const getShops = () => axios.get(responseUrl.Shop);

export const getShop = (id:Number) => axios.get(`${responseUrl.Shop}/${id}`);

export const createShop = (data: object) => axios.post(responseUrl.Shop, data);

export const deleteShop = (id: number) => axios.delete(`${responseUrl.Shop}/${id}`);
