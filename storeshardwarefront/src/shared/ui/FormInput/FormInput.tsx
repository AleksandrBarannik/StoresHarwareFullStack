import { classNames } from 'shared/lib/classNames/classNames';
import { ChangeEvent, FC, useContext } from 'react';
import cls from './FormInput.module.scss';


interface InputProps {
    type: 'text' | 'number' | 'PhoneNumber' ;
    className?: string;
    label: string;
    value: string | number;
    name: string;
    placeholder?: string,
    error?: boolean,
    disabled?: boolean;
    onChange?: (e: ChangeEvent<HTMLInputElement>) => void;
    
}
export const FormInput: FC<InputProps> = (props) => {
    const {
        type,
        className,
        label,
        value,              
        name,
        placeholder,
        error,
        disabled,
        onChange,
    } = props;

    

    return (
        <div className={classNames(cls.inputWrapper, {}, [className])}>
            <label htmlFor={ label }>{ label }</label>
            <input
                type={type}
                id={label}
                value={value}
                name={name}
                placeholder={placeholder}
                onChange={onChange}
                disabled={disabled}                
            />
            {error &&
                <p className={classNames(cls.error, {}, [className])}>Input field can not be empty</p>}
        </div>
    )
}
