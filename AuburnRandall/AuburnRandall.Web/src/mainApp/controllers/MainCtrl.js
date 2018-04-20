angular.module('mainApp').controller('MainCtrl', ['$location', 'PageService', 'NavigationStateService', function ($location, PageService, NavigationStateService) {
    var self = this;

    self.pages = {};

    initialize();

    self.navigate = function (selectedPage) {
        NavigationStateService.pageId = selectedPage.id;

        $location.path('/page');
    }

    function initialize() {
        PageService.getPages().then(function (pages) {
            self.pages = pages;
        });
    }
}]);