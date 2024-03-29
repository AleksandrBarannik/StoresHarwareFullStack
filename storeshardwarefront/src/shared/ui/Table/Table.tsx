/* eslint-disable react/no-unstable-nested-components */
import React, { FC } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { Button } from 'shared/ui/Button/Button';
import cls from './Table.module.scss';

export interface TableProps {
    className?: string;
    data?: any[];
    column?: any[];
    onEditClick?: () => void;
    onDeleteClick?: () => void;

}

export const Table: FC<TableProps> = (props) => {
    const {
        className,
        data,
        column,
        onDeleteClick,
        onEditClick,
    } = props;

    const TableHeadItem = ({ item }: any) => <th>{item.heading}</th>;
    const TableRow = ({ item, column }: any) => (

        <tr>
            {column.map((columnItem: any) => (
                <td key={columnItem.value}>
                    {' '}
                    {item[`${columnItem.value}`]}
                    {' '}
                </td>
            ))}

            <Button onClick={onEditClick}>Edit</Button>
            <Button onClick={onDeleteClick}>Delete</Button>

        </tr>
    );

    return (
        <table className={classNames(cls.Table, {}, [className])}>
            <thead>
                <tr>
                    {
                        column.map((item, index) => (
                            <TableHeadItem
                                key={item}
                                item={item}
                            />

                        ))
                    }
                </tr>
            </thead>
            <tbody>
                {
                    data.map((item, index) => (
                        <TableRow
                            key={index}
                            item={item}
                            column={column}

                        />
                    ))

                }

            </tbody>
        </table>
    );
};
