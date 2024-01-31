import React, { Suspense, useEffect, useState } from 'react';
import { classNames } from 'shared/lib/classNames/classNames';
import { AppRouter } from 'app/providers/Router';
import { Sidebar } from 'widgets/Sidebar/ui/Sidebar';
import { Navbar } from 'widgets/Navbar/ui/Navbar';

function App() {
    return (
        <div className={classNames('app', {}, [])}>
            <Navbar />
            <Suspense fallback="">
                <div className="content-page">
                    <Sidebar />
                    <AppRouter />
                </div>
            </Suspense>
        </div>
    );
}

export default App;
