/* eslint-disable comma-dangle */
/* eslint-disable prefer-destructuring */
import React, {
    useCallback, useEffect, useState,
} from 'react';
import { Table } from 'shared/ui/Table/Table';
import { getShops, getShop, deleteShop } from 'Clients/function/ShopClient';
import { Button } from 'shared/ui/Button/Button';
import { Modal } from 'shared/ui/Modal/Modal';
import { ShopForm } from 'widgets/Forms';
import useRequestShop from 'app/hooks/useRequestShop';

export const ShopPage = () => {
    const [modalData, setModalWindow] = useState(false);

    const [shopState, setShopState] = useState([]);
    const [shopStateById, setShopStateById] = useState([]);

    const { createState, handleChange, postHandleSubmit } = useRequestShop();

    const onToggleModal = useCallback(() => {
        setModalWindow((prev) => !prev);
    }, []);

    useEffect(() => {
        getShops().then((res) => {
            setShopState(res.data.result);
        });
    }, [setShopState]);

    useEffect(() => {
        getShop(1).then((res) => {
            // console.log(res.data.result);
            setShopStateById(res.data.result);
        });
    }, [setShopStateById]);

    const deleteClick = useCallback(() => {
        // как достать индекс из таблицы?
        deleteShop(4)
            .then((response) => {
                console.log('Resource deleted successfully:', response.data);
            })
            .catch((error) => {
                console.error('Error deleting resource:', error);
            });
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
                onDeleteClick={deleteClick}
            />

            <Modal
                isOpen={modalData}
                onClose={onToggleModal}
            >
                <ShopForm
                    onChange={handleChange}
                    onSubmit={postHandleSubmit}
                    state={{
                        value1: createState.shopId,
                        value2: createState.name,
                        value3: createState.phone,
                        value4: createState.adress
                    }}

                />
            </Modal>
        </div>
    );
};
