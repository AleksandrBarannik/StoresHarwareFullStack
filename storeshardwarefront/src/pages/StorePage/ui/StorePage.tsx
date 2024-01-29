import React, {  useCallback, useEffect, useState } from 'react';
import { Table } from 'shared/ui/Table/Table';
import { fetchShops, fetchShopById } from 'Clients/function/ShopClient';
import { ShopForm } from 'widgets/Forms/ui/ShopForm'
import { Modal } from '../../../shared/ui/Modal/Modal';



export const StorePage = () => {
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
        console.log('Button Edit StorePage Click')
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
            <h1>Shop Page</h1>
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