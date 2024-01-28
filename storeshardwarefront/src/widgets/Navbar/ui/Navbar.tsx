import React, { useCallback, useState } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { Modal } from 'shared/ui/Modal/Modal';
import { Button, ButtonTheme } from 'shared/ui/Button/Button';
import cls from './Navbar.module.scss';

interface NavbarProps {
    className?: string;

}
// Navigation panel with links to page
export function Navbar({ className } : NavbarProps) {   
    const [modalData, setModalWindow] = useState(false);

    const onToggleModal = useCallback(() => {
        setModalWindow((prev) => !prev);
    }, []);
    return (
        <div className={classNames(cls.navbar, {}, [className])}>

            <Button
                theme={ButtonTheme.CLEAR}
                className={cls.links}
                onClick={onToggleModal}
            >
                OpenModalWindow
            </Button>
            <Modal
                isOpen={modalData}
                onClose={onToggleModal}

            >
                {/* eslint-disable-next-line i18next/no-literal-string */}
                {/* eslint-disable-next-line i18next/no-literal-string */}
                MODAL FORM TESTING 
            </Modal>

        </div>
    );
}
