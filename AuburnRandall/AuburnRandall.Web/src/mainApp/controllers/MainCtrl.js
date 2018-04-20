angular.module('mainApp').controller('MainCtrl', ['$location', 'CategoryService', 'NavigationStateService', function ($location, CategoryService, NavigationStateService) {
    var self = this;

    self.categories = {};

    initialize();

    self.navigate = function (selected) {
        NavigationStateService.referenceId = selected.id;

        $location.path('/category');
    }

    function initialize() {
        CategoryService.getCategories().then(function (categories) {
            self.categories = categories;
        });
    }
}]);