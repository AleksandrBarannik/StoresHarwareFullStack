var _a;
var portApi = 7001;
export var ResponseType;
(function (ResponseType) {
    ResponseType["PRODUCT"] = "Product";
    ResponseType["SHOP"] = "Shop";
    ResponseType["PRODUCTCATEGORY"] = "ProductCat";
})(ResponseType || (ResponseType = {}));
// url to Response
export var responseUrl = (_a = {},
    _a[ResponseType.PRODUCT] = "https://localhost:".concat(portApi, "/api/").concat(ResponseType.PRODUCT),
    _a[ResponseType.SHOP] = "https://localhost:".concat(portApi, "/api/").concat(ResponseType.SHOP),
    _a[ResponseType.PRODUCTCATEGORY] = "https://localhost:".concat(portApi, "/api/").concat(ResponseType.PRODUCTCATEGORY),
    _a);
