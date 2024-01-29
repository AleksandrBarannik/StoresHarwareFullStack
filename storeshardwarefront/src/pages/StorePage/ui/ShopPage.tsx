import React, {  useCallback, useEffect, useState } from 'react';
import { Table } from 'shared/ui/Table/Table';
import { fetchShops, fetchShopById } from 'Clients/function/ShopClient';
import { ShopForm } from 'widgets/Forms/ui/ShopForm'



export const ShopPage = () => {
    const shopID = 1;

    const [shopState, setShopState] = useState([]);
    const [shopStateById, setShopStateById] = useState([]);

   
    
    useEffect(() => {
        fetchShops().then(res => {
            //console.log(res.data.result);
            setShopState(res.data.result);
        });

    }, [setShopState])   

    /*
    useEffect(() => {
        fetchShopById(shopID).then(res => {
            console.log(res.data.result);
            setShopStateById(res.data.result);
            
        });

    }, [setShopStateById]) 
    */



    const onEditStore = useCallback(() => {
        <ShopForm></ShopForm>
    }, []);

    const onDeleteStore = useCallback(() => {
        console.log('Button Delete StorePage Click')
    }, []);     


    const column = [
        { heading: 'ShopId ', value: 'shopId' },
        { heading: 'Name', value: 'name' },
        { heading: 'Phone', value: 'phone' },
        { heading: 'Adress', value: 'adress' }        
    ]    

    
    


    return (
        <div>
            <h1>List of Shops</h1>
            <ShopForm></ShopForm>
            <Table
                data={shopState}
                column={ column }
                onEditClick={ onEditStore }
                onDeleteClick= { onDeleteStore }
            />       
            
                       
        </div>
    );
};