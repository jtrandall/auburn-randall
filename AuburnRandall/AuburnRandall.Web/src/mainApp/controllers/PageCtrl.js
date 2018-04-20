angular.module('mainApp').controller('PageCtrl', ['NavigationStateService', function (NavigationStateService) {
    var self = this;

    self.pageId = NavigationStateService.pageId;
}]);