import { ChangeEvent, FormEvent, useState } from 'react';
import { createShop } from 'Clients/function/ShopClient';
import { FormInput } from 'shared/ui/FormInput/FormInput';

// FORM  fo POst  PUT Delete Methods for Table Shop
export const ShopForm = () => {
    const [createState, setCreatState] = useState(
        {
            shopId: '',
            name: '',
            phone: '',
            adress: '',
        },
    );

    const handleChange = (e: ChangeEvent<HTMLInputElement>) => {
        // eslint-disable-next-line prefer-destructuring
        const value = e.target.value;
        setCreatState({
            ...createState,
            [e.target.name]: value,
        });
    };

    const handleSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const shopData = {
            shopId: createState.shopId,
            name: createState.name,
            phone: createState.phone,
            adress: createState.adress,
        };
        createShop(shopData);
    };

    return (
        <form onSubmit={handleSubmit}>

            <FormInput
                type="number"
                label="ShopId"
                name="shopId"
                placeholder="Enter new ShopId"
                onChange={handleChange}
                value={createState.shopId}

            />

            <FormInput
                type="text"
                label="ShopName"
                name="name"
                placeholder="Enter new name shop"
                onChange={handleChange}
                value={createState.name}

            />
            <FormInput
                type="number"
                label="Phone"
                name="phone"
                placeholder="Enter new phone number"
                onChange={handleChange}
                value={createState.phone}

            />

            <FormInput
                type="text"
                label="Adress"
                name="adress"
                placeholder="Enter new adress for  shop"
                onChange={handleChange}
                value={createState.adress}

            />
            <button type="submit">Send</button>
        </form>
    );
};
