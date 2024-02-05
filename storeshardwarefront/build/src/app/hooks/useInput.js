import { useState } from 'react';
var useInput = function (initialValue) {
    var _a = useState(initialValue), value = _a[0], setValue = _a[1];
    var _b = useState(false), error = _b[0], setError = _b[1];
    var handleChange = function (e) {
        setValue(e.target.value);
    };
    return {
        value: value,
        error: error,
        onChange: handleChange,
        setError: setError,
    };
};
export default useInput;
