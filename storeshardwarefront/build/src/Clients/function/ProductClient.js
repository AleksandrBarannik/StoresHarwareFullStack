import axios from 'axios';
import { responseUrl } from 'shared/config/ResponseConfig/ResponseConfig';
export var getRequestProducts = function () { return axios.get(responseUrl.Product); };
