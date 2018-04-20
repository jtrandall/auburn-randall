angular.module('mainApp', ['ngMaterial', 'ngRoute'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'pages/home.html',
                controller: 'MainCtrl',
                controllerAs: 'ctrl'
            })

            .when('/category', {
                templateUrl: 'pages/category.html',
                controller: 'CategoryCtrl',
                controllerAs: 'ctrl'
            })
            .otherwise({
                redirectTo: '/'
            });
    }]);