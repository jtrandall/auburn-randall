angular.module('mainApp').factory('PageService', ['$http', function ($http) {
    var factory = {};

    factory.getPages = function () {
        return $http.get('/api/page')
            .then(function (response) {
                return response.data;
            });
    }

    return factory;
}]);