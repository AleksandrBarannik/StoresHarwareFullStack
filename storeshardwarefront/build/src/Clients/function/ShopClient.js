import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';
export var getRequestShops = function () { return axios.get(responseUrl.Shop); };
export var getRequestShopById = function (id) { return axios.get("".concat(responseUrl.Shop, "/").concat(id)); };
export var postRequestShop = function (data) { return axios.post(responseUrl.Shop, data)
    .then(function (response) {
    console.log(response.status, response.data);
}).catch(function (error) {
    console.log(error);
}); };
var deleteRequestShop = function (id) { return axios.delete("".concat(responseUrl.Shop, "/").concat(id))
    .then(function (response) {
    console.log('Resource deleted successfully:', response.data);
})
    .catch(function (error) {
    console.error('Error deleting resource:', error);
}); };
