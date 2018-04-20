angular.module('mainApp').controller('CategoryCtrl', ['NavigationStateService', function (NavigationStateService) {
    var self = this;

    self.categoryId = NavigationStateService.referenceId;
}]);