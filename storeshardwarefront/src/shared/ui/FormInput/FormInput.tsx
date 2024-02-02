import { classNames } from 'shared/lib/classNames/classNames';
import { ChangeEvent, FC } from 'react';
import cls from './FormInput.module.scss';

interface InputProps {
    type: 'text' | 'number';
    className?: string;
    label: string;
    value: string | number;
    name: string;
    placeholder?: string,
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
        disabled,
        onChange,
    } = props;

    return (
        <div className={classNames(cls.inputWrapper, {}, [className])}>
            <label htmlFor={label}>{ label }</label>
            <input
                type={type}
                id={label}
                defaultValue={value}
                name={name}
                placeholder={placeholder}
                onChange={onChange}
                disabled={disabled}
            />
        </div>
    );
};
