angular.module('mainApp').factory('CategoryService', ['$http', function ($http) {
    var factory = {};

    factory.getCategories = function () {
        return $http.get('/api/category')
            .then(function (response) {
                return response.data;
            });
    }

    return factory;
}]);