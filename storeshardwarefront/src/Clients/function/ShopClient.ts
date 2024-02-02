import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';

export const fetchShops = () => axios.get(responseUrl.Shop);

export const fetchShopById = (id:Number) => axios.get(`${responseUrl.Shop}/${id}`);

export const createShop = (data: object) => axios.post(responseUrl.Shop, data).then((response) => {
    console.log(response.status, response.data);
}).catch((error) => {
    console.log(error);
});
