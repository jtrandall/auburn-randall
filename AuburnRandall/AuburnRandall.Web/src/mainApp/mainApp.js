angular.module('mainApp', ['ngMaterial', 'ngRoute'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'pages/home.html',
                controller: 'MainCtrl',
                controllerAs: 'ctrl'
            })

            .when('/page', {
                templateUrl: 'pages/page.html',
                controller: 'PageCtrl',
                controllerAs: 'ctrl'
            })
            .otherwise({
                redirectTo: '/'
            });
    }]);