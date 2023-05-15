/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Pages/**/*.cshtml",
        "./node_modules/flowbite/**/*.js"
    ],
    plugins: [
        require('flowbite/plugin')
    ],
    theme: {
        container: {
            center: true
        },
        extend: {},
    },
    plugins: [],
}

