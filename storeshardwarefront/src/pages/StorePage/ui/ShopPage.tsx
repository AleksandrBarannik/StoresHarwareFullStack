import React, {
    ChangeEvent,
    useCallback, useEffect, useState,
} from 'react';
import { Table } from 'shared/ui/Table/Table';
import { fetchShops, fetchShopById, createShop } from 'Clients/function/ShopClient';
import { Button } from 'shared/ui/Button/Button';
import { Modal } from 'shared/ui/Modal/Modal';
import { FormInput } from 'shared/ui/FormInput/FormInput';


export const ShopPage = () => {
    const shopID = 1;

    const [shopState, setShopState] = useState([]);
    const [shopStateById, setShopStateById] = useState([]);
    const [modalData, setModalWindow] = useState(false);

    const [createData, setCreateData] = useState(
        {
            shopId: 4,
            name: 'Test',
            phone: 4,
            adress: 'Test',
        },
    );

    useEffect(() => {
        fetchShops().then((res) => {
            // console.log(res.data.result);
            setShopState(res.data.result);
        });
    }, [setShopState]);

    useEffect(() => {
        fetchShopById(shopID).then((res) => {
            // console.log(res.data.result);
            setShopStateById(res.data.result);
        });
    }, [setShopStateById]);

    const onToggleModal = useCallback(() => {
        setModalWindow((prev) => !prev);
    }, []);

    const handleChange = (e: ChangeEvent<HTMLInputElement>) => {
        const { value } = e.target;
        setCreateData({
            ...createData,
            [e.target.name]: value,
        });
    };

    const handleSubmit = (e:ChangeEvent<HTMLFormElement>) => {
        e.preventDefault();
        const shopData = {
            shopId: createData.shopId,
            name: createData.name,
            phone: createData.phone,
            adress: createData.adress,
        };
        createShop(shopData);
    };

    const columns = Object.keys(shopState[0] ?? {}).map((key) => ({

        heading: key,
        value: key,
    }));

    return (
        <div>
            <h1>List of Shops</h1>
            <Button onClick={onToggleModal}>
                Create
            </Button>

            <Table
                data={shopState}
                column={columns}
            />

            <Modal
                isOpen={modalData}
                onClose={onToggleModal}
            >
                <form onSubmit={handleSubmit}>

                    <FormInput
                        type="number"
                        label="ShopId"
                        name="ShopId"
                        placeholder="Enter new ShopId"
                        value={createData.shopId}
                        onChange={handleChange}
                    />

                    <FormInput
                        type="text"
                        label="ShopName"
                        name="ShopName"
                        placeholder="Enter new name shop"
                        value={createData.name}
                        onChange={handleChange}

                    />
                    <FormInput
                        type="PhoneNumber"
                        label="Phone"
                        name="Phone"
                        placeholder="Enter new phone number"
                        value={createData.phone}
                        onChange={handleChange}
                    />

                    <FormInput
                        type="text"
                        label="Adress"
                        name="Adress"
                        placeholder="Enter new adress for  shop"
                        value={createData.adress}
                        onChange={handleChange}

                    />
                    <button type="submit">Send</button>

                </form>
            </Modal>            

        </div>
    );
};
