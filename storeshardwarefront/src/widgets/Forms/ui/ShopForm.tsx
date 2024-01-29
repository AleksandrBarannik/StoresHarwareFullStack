import { FormEvent } from "react";
import useInput from "app/hooks/useInput";
import { FormInput } from "shared/ui/FormInput/FormInput";
import { Button } from "shared/ui/Button/Button";

export interface inputType
{
    value: string;
    setError: (value:boolean) => void;
}
interface FormProps {
    className?: string;
    onSendClick?: () => void;
    onGetClick?: () => void;
    

}

export const ShopForm = (props:FormProps) => {

    const {
        className,
        onSendClick,
        onGetClick
    } = props

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
                <Button onClick={onSendClick}> SendForm</Button>
                <Button onClick={onGetClick}> GetDataByID</Button>

                </form>          
            

                    
        </div>

        
    );
}