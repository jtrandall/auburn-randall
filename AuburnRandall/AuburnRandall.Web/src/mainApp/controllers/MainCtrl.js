angular.module('mainApp').controller('MainCtrl', ['$window', 'PageService', function ($window, PageService) {
    var self = this;

    self.pages = {};

    initialize();

    self.navigate = function (selectedPage) {
        $window.open(selectedPage.url, '_self');
    }

    function initialize() {
        PageService.getPages().then(function (pages) {
            self.pages = pages;
        });
    }
}]);