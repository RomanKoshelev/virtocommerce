﻿angular.module('catalogModule.blades.seoDetail', [])
.controller('seoDetailController', ['$scope', 'categories', 'items', 'dialogService', function ($scope, categories, items, dialogService) {
    $scope.blade.origItem = {};

    $scope.blade.refresh = function (parentRefresh) {
        if (parentRefresh) {
            $scope.blade.isLoading = true;
            $scope.blade.parentBlade.refresh().$promise.then(function (data) {
                $scope.blade.parentEntity = data;
                initializeBlade(data.seoInfos);
            });
        } else {
            initializeBlade($scope.blade.parentEntity.seoInfos);
        }
    }

    function initializeBlade(data) {
        data = data.slice();
        _.each($scope.blade.parentEntity.catalog.languages, function (lang) {
            if (_.every(data, function (seoInfo) { return seoInfo.languageCode.toLowerCase().indexOf(lang.languageCode.toLowerCase()) < 0; })) {
                data.push({ isNew: true, languageCode: lang.languageCode });
            }
        });

        $scope.seoInfos = angular.copy(data);
        $scope.blade.origItem = data;
        $scope.blade.isLoading = false;
    };

    function saveChanges() {
        $scope.blade.isLoading = true;

        var seoInfos = _.filter($scope.seoInfos, function (data) { return isValid(data); });

        if ($scope.blade.seoUrlKeywordType === 0) {
            categories.update({ id: $scope.blade.parentEntity.id, seoInfos: seoInfos }, function () {
                $scope.blade.refresh(true);
            });
        } else if ($scope.blade.seoUrlKeywordType === 1) {
            items.updateitem({ id: $scope.blade.parentEntity.id, seoInfos: seoInfos }, function () {
                $scope.blade.refresh(true);
            });
        }
    };

    function isValid(data) {
        // check required and valid Url requirements
        return data.semanticUrl && $scope.semanticUrlValidator(data.semanticUrl);
    }

    $scope.semanticUrlValidator = function (value) {
        // var pattern = /^\w*$/; // alphanumeric and underscores
        var pattern = /^([a-zA-Z0-9\(\)_\-.]+)*$/;
        return pattern.test(value);
    }

    function isDirty() {
        return !angular.equals($scope.seoInfos, $scope.blade.origItem);
    };

    function closeThisBlade(closeCallback) {
        closeCallback();
    };

    $scope.blade.onClose = function (closeCallback) {
        if (isDirty()) {
            var dialog = {
                id: "confirmItemChange",
                title: "Save changes",
                message: "The SEO information has been modified. Do you want to save changes?"
            };
            dialog.callback = function (needSave) {
                if (needSave) {
                    saveChanges();
                }
                closeThisBlade(closeCallback);
            };
            dialogService.showConfirmationDialog(dialog);
        }
        else {
            closeThisBlade(closeCallback);
        }
    };

    var formScope;
    $scope.setForm = function (form) {
        formScope = form;
    }

    $scope.bladeToolbarCommands = [
        {
            name: "Save", icon: 'icon-floppy',
            executeMethod: function () {
                saveChanges();
            },
            canExecuteMethod: function () {
                return isDirty() && _.every(_.filter($scope.seoInfos, function (data) { return !data.isNew; }), isValid) && _.some($scope.seoInfos, isValid); // isValid formScope && formScope.$valid;
            }
        },
        {
            name: "Reset", icon: 'icon-undo',
            executeMethod: function () {
                angular.copy($scope.blade.origItem, $scope.seoInfos);
            },
            canExecuteMethod: function () {
                return isDirty();
            }
        }
    ];

    $scope.blade.style = 'gray';
    $scope.blade.subtitle = 'SEO information';
    $scope.blade.refresh(false);
}]);
