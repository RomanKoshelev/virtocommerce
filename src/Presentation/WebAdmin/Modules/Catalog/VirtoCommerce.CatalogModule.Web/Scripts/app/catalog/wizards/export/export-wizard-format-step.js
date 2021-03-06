﻿angular.module('catalogModule.wizards.exportWizard')
.controller('exportFormatController', ['$scope', function ($scope) {
    $scope.blade.refresh = function () {
        $scope.list = [
            { name: "Csv" }
        ];

        var found = _.find($scope.list, function (xx) { return xx.name === $scope.blade.parentBlade.currentEntity.format; });
        if (found) {
            found.selected = true;
        }
    };

    $scope.select = function (data) {
        $scope.blade.parentBlade.currentEntity.format = data.name;
        $scope.bladeClose();
    }

    $scope.blade.refresh();
    $scope.blade.isLoading = false;
}]);
