import { ReactNode } from 'react';
import { createPortal } from 'react-dom';

interface PortalProps {
    children: ReactNode; // object to teleport
    element?: HTMLElement; // указанная point to teleport

}
// for teleport element in указанную point
export const Portal = (props : PortalProps) => {
    const {
        children,
        element = document.body,
    } = props;

    return createPortal(children, element);
};
