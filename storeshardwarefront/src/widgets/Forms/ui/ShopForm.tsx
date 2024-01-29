import { FormEvent, useCallback, useState } from "react";
import useInput from "app/hooks/useInput";
import { FormInput } from "shared/ui/FormInput/FormInput";
import { Modal } from "shared/ui/Modal/Modal";
import { Button } from "shared/ui/Button/Button";

export interface inputType
{
    value: string;
    setError: (value:boolean) => void;
}
export const ShopForm = () => {


    const [modalData, setModalWindow] = useState(false);
    const onToggleModal = useCallback(() => {
        setModalWindow((prev) => !prev);
    }, []);

    const shopInput = useInput('');
    const nameInput = useInput('');
    const phoneInput = useInput('');
    const adressInput = useInput('');

    const handleSubmit = (e: FormEvent) => {
        e.preventDefault();
        validateInput(shopInput);
        validateInput(nameInput);
        validateInput(phoneInput);
        validateInput(adressInput);
    };

    const validateInput = (input: inputType) => {
        if (!input.value.trim()) {
            input.setError(true)
        }
        else {
            input.setError(false)
        }
    }

    return (
        <div>
            <Button onClick={onToggleModal}>
                Create Shop
            </Button>
            <Modal
                isOpen={modalData}
                onClose={onToggleModal}
            >
                <form onSubmit={handleSubmit}>
                    <FormInput
                        type='number'
                        label='ShopId'
                        name='ShopId'
                        placeholder='Enter new ShopId'
                        {...shopInput}

                    />

                    <FormInput
                        type='text'
                        label='ShopName'
                        name='ShopName'
                        placeholder='Enter new name shop'
                        {...nameInput}

                    />
                    <FormInput
                        type='PhoneNumber'
                        label='Phone'
                        name='Phone'
                        placeholder='Enter new phone number'
                        {...phoneInput}

                    />

                    <FormInput
                        type='text'
                        label='Adress'
                        name='Adress'
                        placeholder='Enter new adress for  shop'
                        {...adressInput}

                    />


                </form>
            </Modal>
            

                    
        </div>

        
    );
}