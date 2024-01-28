                Для использование webpack Надо:

1) Запустить PowerShell от имени администратора
2) Ввести:  Set-ExecutionPolicy RemoteSigned
3) Ввести Y для подтверждения

                 Все что нужно установить:

npm i -D webpack@5.69.1 webpack-cli@4.10.0 @types/webpack@5.28.0
npm i -D html-webpack-plugin@5.5.0
npm  i -D typescript@4.5.5 ts-loader@9.2.6

    // Для возможности создания webpack.config.ts
npm  i -D  ts-node@10.5.0 webpack-dev-server@4.7.4  @types/node@17.0.21
npm  i -D  webpack-dev-server@4.7.4 @types/webpack-dev-server@4.7.2

    // React; React_Types
npm i react@17.0.2 react-dom@17.0.2
npm i react-router-dom@6.2.1
npm i -D @types/react@17.0.39  @types/react-dom@17.0.11
npm i -D @types/react-router-dom@5.3.3

     // Для автоматического обновления
    // в браузере после изменения в коде омпонента
npm i -D react-refresh@0.12.0
npm i -D @pmmmwh/react-refresh-webpack-plugin@0.5.5

    // CSS
npm install  sass-loader@12.6.0 sass@1.49.9  style-loader@3.3.1  css-loader@6.6.0  --save-dev

    // Для разделения стилей в отдельныый файл(при сборке)
npm install --save-dev mini-css-extract-plugin@2.5.3

    // Для работы с svg файлами
npm install  @svgr/webpack@6.2.1 --save-dev

    // Работа с файлами jpeg;png;jpg;gif;
npm install file-loader@6.2.0  --save-dev

    // Для работы с переключением языков
npm install react-i18next@11.15.5  i18next@21.6.11  --save
npm install i18next-browser-languagedetector@6.1.3 --save
    // Для асинхронной подгрузки нужного языка
npm install i18next-http-backend@1.3.2 --save


npm i -D babel-loader@8.2.3 @babel/core@7.17.5
npm i -D  babel-plugin-i18next-extract@0.8.3
npm i -D @babel/preset-env@7.16.11

      // CodStyle;error for ts;js;
npm i -D  eslint@8.10.0
npm i -D  eslint-plugin-react@7.29.2
npm i -D  eslint-plugin-react-hooks@4.3.0
npm i -D  eslint-plugin-jsx-a11y@6.5.1
npm i -D  eslint-plugin-import@2.25.4
npm i -D  eslint-plugin-i18next@5.1.2
npm i -D  eslint-config-airbnb@19.0.4

    // Инициализация eslint
    // Лучше скопировать файл настроек .eslintrc.js

npm init @eslint/config
    // Для исправления всех проблем в коде
eslint "**/*.{ts,tsx}" --fix

    // codeStyle для SCSS
npm i -D stylelint@14.5.3 stylelint-config-standard-scss@3.0.0

    //Jest  Для тестирования JS
npm i -D jest@27.5.1
npm i --save-dev @types/jest@27.4.1
npm i -D @babel/preset-typescript@7.16.7
npm i -D @babel/preset-react@7.16.7

    //React Testing Library
npm i -D @testing-library/react@12.1.3
npm i -D @testing-library/jest-dom@5.16.2
npm i -D identity-obj-proxy@3.0.0
npm i -D regenerator-runtime@0.13.9

     //StoryBook (ScreenShot tests) + LOKI
npx sb init --builder webpack5
npm i -D loki
npm i -D reg-cli@0.17.6 //для  нормального сравнения скрин тестов


    // ИНициализация и запуск тестов
npx loki init --config ./config/storybook (указываем где лежит конфиг если не в корне)
npx loki test  // запуск тестов


    // Анализирует размер бандла и все что с ним связано
npm i -D webpack-bundle-analyzer@4.5.0
npm i -D @types/webpack-bundle-analyzer@4.4.1























