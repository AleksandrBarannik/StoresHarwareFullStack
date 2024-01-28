import { classNames } from 'shared/lib/classNames/classNames';
import React, { useState } from 'react';
import { Button, ButtonSize, ButtonTheme } from 'shared/ui/Button/Button';
import { AppLink, AppLinkTheme } from 'shared/ui/AppLink/AppLink';
import { RoutePath } from 'shared/config/routeConfig/routeConfig';
import ProductIcon from 'shared/assets/icons/about-20-20.svg';
import StoreIcon from 'shared/assets/icons/about-20-20.svg';
import MainIcon from 'shared/assets/icons/main-20-20.svg';
import cls from './Sidebar.module.scss';

interface SidebarProps {
    className?: string;

}
// Боковая панель которую можно свернуть
// Развернуть как на ютубе
// Содержит  компоненты переключатель тем и языков
export const Sidebar = ({ className }: SidebarProps) => {
    const [collapsed, setCollapsed] = useState(false);    

    const onToggle = (() => {
        setCollapsed((prev) => !prev);
    });

    return (
        <div
            data-testid="sidebar"
            className={classNames(cls.Sidebar, { [cls.collapsed]: collapsed }, [className])}
        >

            {/* eslint-disable-next-line react/button-has-type */}
            <Button
                onClick={onToggle}
                className={cls.collapseBtn}
                theme={ButtonTheme.BACKGROUND}
                size={ButtonSize.L}
                square
            >
                {collapsed ? '>' : '<'}
            </Button>

            <div className={cls.items}>

                <AppLink
                    theme={AppLinkTheme.SECONDARY}
                    to={RoutePath.main}
                    className={cls.item}
                >
                    <MainIcon className={cls.icon} />
                    <span className={cls.link}>
                        Main Page
                    </span>
                </AppLink>

                <AppLink
                    theme={AppLinkTheme.SECONDARY}
                    to={RoutePath.product}
                    className={cls.item}
                >
                    <ProductIcon className={cls.icon} />
                    <span className={cls.link}>
                        Products
                    </span>
                </AppLink>

                <AppLink
                    theme={AppLinkTheme.SECONDARY}
                    to={RoutePath.store}
                    className={cls.item}
                >
                    <StoreIcon className={cls.icon} />
                    <span className={cls.link}>
                        Stores
                    </span>
                </AppLink>

            </div>          

        </div>
    );
};


