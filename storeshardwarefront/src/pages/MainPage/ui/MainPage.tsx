import React, { useCallback } from 'react';
import { Table } from 'shared/ui/Table/Table';
import { Button } from 'shared/ui/Button/Button';

export const MainPage = () => {

    const onEditData = useCallback(() => {
        console.log('Button Edit MainPage Click')
    }, []);

    const onDeleteData = useCallback(() => {
        console.log('Button Delete MainPage Click')
    }, []);

    const dataTable = [
        {
            'ProductId': 1,
            'ProductName': 'Iphone11',
            'ProductModel': '11Pro_256Gb',
            'ShopName': 'TestDNS',
            'ProductDescription': '11Pro_256Gb',
            'Price': 65000
        },
    ]

    const column = [
        { heading: 'ProductId', value: 'ProductId' },
        { heading: 'ProductName', value: 'ProductName' },
        { heading: 'ProductModel', value: 'ProductModel' },
        { heading: 'ProductDescription', value: 'ProductDescription' },
        { heading: 'Price', value: 'Price' },
        { heading: 'ShopName', value: 'ShopName' },
    ]

    return (
        <div>
            <h1>Main page</h1>
            <Button>GetData</Button>
            <div>
                <Table
                    data={dataTable}
                    column={column}
                    onEditClick={onEditData}
                    onDeleteClick={onDeleteData}

                />
            </div>
        </div>
    );
};
