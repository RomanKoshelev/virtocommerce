﻿angular.module('catalogModule.wizards.associationWizard.associationGroupNew', [])
.controller('associationGroupNewController', ['$scope', function ($scope) {

    $scope.setForm = function (form) {
        $scope.formScope = form;
    }

    $scope.saveChanges = function () {
        $scope.blade.parentBlade.setSelected($scope.blade.name);
    }

    $scope.$on('$destroy', function () {
        $scope.blade.parentBlade.isNewGroup = false;
    });

    $scope.blade.name = null;
    $scope.blade.isLoading = false;
}]);
