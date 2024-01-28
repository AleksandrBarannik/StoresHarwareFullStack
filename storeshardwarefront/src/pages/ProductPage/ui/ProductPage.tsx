import React, { useCallback, useEffect, useState } from 'react';
import { Table } from 'shared/ui/Table/Table';
import {fetchProducts} from 'Clients/function/ProductClient';



export const ProductPage = () => {

    const [productState, setProductState] = useState([]);

    useEffect(() => {
        fetchProducts().then(res => {
            //console.log(res.data.result);
            setProductState(res.data.result);
        });             
        
    }, [setProductState])


    const onEditProduct = useCallback(() => {
       console.log('Button Edit ProductPage Click')
    }, []);

    const onDeleteProduct = useCallback(() => {
        console.log('Button Delete ProductPage Click')
    }, []);  
    

    const column = [
        { heading: 'ProductId', value:'productId' },
        { heading: 'ProductName', value:'productName' },
        { heading: 'ProductModel', value: 'productModel' },
        { heading: 'ProductDescription', value:'productDescription' },
        { heading: 'Price', value: 'price' }       
    ]


    return (
        <div>
            <h1>List of Products</h1>            
            <Table
                data= { productState }
                column= { column }
                onEditClick= { onEditProduct }
                onDeleteClick= {onDeleteProduct}
            />
        </div>
    );
};