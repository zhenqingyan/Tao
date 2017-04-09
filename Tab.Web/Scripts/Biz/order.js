var order = function () {
    var vueInit = function () {
        var vm = new Vue({
            el: '#app',
            data: {
                percent: 10
            },
            methods: {
                add: function () { },
                minus: function () { },
                del: function () { }

            }
        });
    };
    var init = function () {
        vueInit();
    }
    init();
}();