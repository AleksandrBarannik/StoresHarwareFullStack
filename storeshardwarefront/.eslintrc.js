module.exports = {
    env: {
        browser: true,
        es2021: true,
        jest: true,
    },
    extends: ['plugin:react/recommended', 'airbnb'],
    parser: '@typescript-eslint/parser',
    parserOptions: {
        ecmaFeatures: {
            jsx: true,
        },
        ecmaVersion: 'latest',
        sourceType: 'module',
    },
    plugins: [
        'react',
        '@typescript-eslint',       
        'react-hooks',
    ],

    rules: {
    /* 2- run rules; 4 -  отступы в пробелах */
        'react/jsx-indent': [2, 4],
        'react/jsx-indent-props': [2, 4],
        indent: [2, 4],
        'react/jsx-filename-extension': [2, { extensions: ['.js', '.jsx', '.tsx'] }],
        'import/no-unresolved': 'off',
        'import/prefer-default-export': 'off', // отключает предпочтение дефолтному экспорту
        'no-unused-vars': 'warn', // Предупреждение на неизпольз. переменные
        'react/require-default-props': 'off',
        'react/react-in-jsx-scope': 'off',
        'react/jsx-props-no-spreading': 'warn', // Предупрежение что используем spread(...) с pops
        'react/function-component-definition': 'off', // отключение предпочтения function  стрелочкной функции
        'no-shadow': 'off',
        'import/extensions': 'off', // отключение ошибки что нет  расширений(.ts) в импортах
        'import/no-extraneous-dependencies': 'off',
        'no-underscore-dangle': 'off',        
        'jsx-a11y/no-static-element-interactions': 'off', // Временнно отключаем отвечает за семантику
        'jsx-a11y/click-events-have-key-events': 'off',
        'react-hooks/rules-of-hooks': 'error', // Проверка правил в хуках
        'react-hooks/exhaustive-deps': 'error', // Проверка массива зависимостей

    },
    globals: {
        __IS_DEV__: true,
    }   
};
