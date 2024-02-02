/* eslint-disable comma-dangle */
/* eslint-disable prefer-destructuring */
import React, {
    useCallback, useEffect, useState,
} from 'react';
import { Table } from 'shared/ui/Table/Table';
import { fetchShops, fetchShopById } from 'Clients/function/ShopClient';
import { Button } from 'shared/ui/Button/Button';
import { Modal } from 'shared/ui/Modal/Modal';
import { ShopForm } from 'widgets/Forms';

export const ShopPage = () => {
    const shopID = 1;

    const [shopState, setShopState] = useState([]);
    const [shopStateById, setShopStateById] = useState([]);
    const [modalData, setModalWindow] = useState(false);

    useEffect(() => {
        fetchShops().then((res) => {
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
                <ShopForm />
            </Modal>
        </div>
    );
};
