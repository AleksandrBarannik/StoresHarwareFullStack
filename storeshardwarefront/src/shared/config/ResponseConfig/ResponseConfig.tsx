
const portApi = 7001;

export enum ResponseType {
    PRODUCT = 'Product',
    SHOP = 'Shop',    
    PRODUCTCATEGORY = 'ProductCat',    
}

// url to Response
export const responseUrl: Record<ResponseType, string> = {
    [ResponseType.PRODUCT]: `https://localhost:${portApi}/api/${ResponseType.PRODUCT}`,
    [ResponseType.SHOP]: `https://localhost:${portApi}/api/${ResponseType.SHOP}`,
    [ResponseType.PRODUCTCATEGORY]: `https://localhost:${portApi}/api/${ResponseType.PRODUCTCATEGORY}`,
}

