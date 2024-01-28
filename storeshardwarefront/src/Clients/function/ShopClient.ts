import axios from "axios"
import { responseUrl } from "shared/config/ResponseConfig/ResponseConfig"

export const fetchShops = () => {
    return axios.get(responseUrl.Shop);     
}

export const fetchShopById = (id:Number) => {
    return axios.get(`${responseUrl.Shop}/${id}`);
}

