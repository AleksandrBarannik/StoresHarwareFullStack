import { ChangeEvent, FormEvent, useState } from 'react';
import { FormInput } from 'shared/ui/FormInput/FormInput';

interface FormProps {
    onChange: (e: ChangeEvent<HTMLInputElement>) => void;
    onSubmit: (e: FormEvent<HTMLFormElement>) => void;
    state: { // name columns in DB
        // вопрос как сделать количество динамическим в зависимости от количества колонок в БД
        value1: string;
        value2: string;
        value3: string;
        value4: string;
    }
}

// FORM  fo POst  PUT Delete Methods for Table Shop
export const ShopForm = (props : FormProps) => {
    const
        {
            onChange,
            onSubmit,
            state,
        } = props;

    return (
        <form onSubmit={onSubmit}>

            <FormInput
                type="number"
                label="ShopId"
                name="shopId"
                placeholder="Enter new ShopId"
                onChange={onChange}
                value={state.value1}

            />

            <FormInput
                type="text"
                label="ShopName"
                name="name"
                placeholder="Enter new name shop"
                onChange={onChange}
                value={state.value2}

            />
            <FormInput
                type="number"
                label="Phone"
                name="phone"
                placeholder="Enter new phone number"
                onChange={onChange}
                value={state.value3}

            />

            <FormInput
                type="text"
                label="Adress"
                name="adress"
                placeholder="Enter new adress for  shop"
                onChange={onChange}
                value={state.value4}

            />
            <button type="submit">Send</button>
        </form>
    );
};
