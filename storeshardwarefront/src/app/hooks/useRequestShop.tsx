import { ChangeEvent, FormEvent, useState } from 'react';
import { createShop } from 'Clients';

// return state && post functions;
const useRequestShop = () => {
    const [createState, setCreatState] = useState(
        {
            shopId: '',
            name: '',
            phone: '',
            adress: '',
        },
    );

    const fillDataShop = () => {
        const shopData = {
            shopId: createState.shopId,
            name: createState.name,
            phone: createState.phone,
            adress: createState.adress,
        };
        return shopData;
    };

    const handleChange = (e: ChangeEvent<HTMLInputElement>) => {
        // eslint-disable-next-line prefer-destructuring
        const value = e.target.value;
        setCreatState({
            ...createState,
            [e.target.name]: value,
        });
    };

    const postHandleSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const dataCreatingShop = fillDataShop();

        createShop(dataCreatingShop).then((response) => {
            console.log(response.status, response.data);
        }).catch((error) => {
            console.log(error);
        });
    };

    return {
        createState,
        handleChange,
        postHandleSubmit,
    };
};
export default useRequestShop;
