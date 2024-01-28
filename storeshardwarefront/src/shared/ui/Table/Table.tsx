import React, { FC } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { Button } from 'shared/ui/Button/Button';
import cls from './Table.module.scss';
export interface ProductProps {
    className?: string;
    data?: any[];
    column?: any[];
    onEditClick: () => void;
    onDeleteClick: () => void;

}

export const Table: FC<ProductProps> = (props) => {

    const {
        className,
        data,
        column,
        onDeleteClick,
        onEditClick        
    } = props;

    const TableHeadItem = ({ item }: any) => <th>{item.heading}</th>
    const TableRow = ({ item, column }: any) => (

        <tr>
            {column.map((columnItem: any, index: any) => {
                return (
                    <td> {item[`${columnItem.value}`]} </td>
                )
            })}

            <Button onClick={onEditClick}>Edit</Button>
            <Button onClick={onDeleteClick}>Delete</Button>                           
            
        </tr>
    )

    return (
        <table className={classNames(cls.Table, {}, [className])}>
            <thead>
                <tr>
                    {
                        column.map((item, index) =>
                            <TableHeadItem
                                item={item}
                            />
                        )
                    }
                </tr>
            </thead>
            <tbody>
                {
                    data.map((item, index) =>
                        <TableRow
                            item={item}
                            column={column}

                        />
                        
                    )
                    
                }
                
            </tbody>
        </table>
    );
}
