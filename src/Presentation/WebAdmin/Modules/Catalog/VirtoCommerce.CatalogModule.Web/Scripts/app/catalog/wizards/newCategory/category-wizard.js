﻿angular.module('catalogModule.wizards.categoryWizard', [])
.controller('newCategoryWizardController', ['$scope', 'bladeNavigationService', 'dialogService', 'categories', function ($scope, bladeNavigationService, dialogService, categories) {
    $scope.create = function () {
        $scope.blade.currentEntity.$update(null, function (data) {
            $scope.bladeClose();

            var categoryListBlade = $scope.blade.parentBlade;
            // categoryListBlade.showCategoryBlade(data.id, data, data.name);
            categoryListBlade.setSelectedItem(data);
            categoryListBlade.refresh();
        });
    }

    $scope.openBlade = function (type) {
        $scope.blade.onClose(function () {
            var newBlade = null;
            switch (type) {
                case 'properties':
                    newBlade = {
                        id: "categoryPropertyDetail",
                        currentEntityId: $scope.blade.currentEntityId,
                        currentEntity: $scope.blade.currentEntity,
                        title: $scope.blade.title,
                        subtitle: 'Category properties',
                        controller: 'categoryPropertyController',
                        //controller: 'newProductWizardPropertiesController',
                        //isNew: true,
                        template: 'Modules/Catalog/VirtoCommerce.CatalogModule.Web/Scripts/app/catalog/blades/category-property-detail.tpl.html'
                    };
                    break;
                case 'seo':
                    newBlade = {
                        id: "seoDetail",
                        seoUrlKeywordType: 0,
                        parentEntity: $scope.blade.currentEntity,
                        title: $scope.blade.title,
                        controller: 'seoDetailController',
                        //controller: 'newProductSeoDetailController',
                        //seoInfos: $scope.blade.item.seoInfos,
                        template: 'Modules/Catalog/VirtoCommerce.CatalogModule.Web/Scripts/app/catalog/blades/seo-detail.tpl.html'
                    };
                    break;
            }

            if (newBlade != null) {
                bladeNavigationService.showBlade(newBlade, $scope.blade);
            }
        });
    }

    $scope.setForm = function (form) {
        $scope.formScope = form;
    }


    $scope.blade.onClose = function (closeCallback) {
        closeChildrenBlades();
        closeCallback();
    };

    function closeChildrenBlades() {
        angular.forEach($scope.blade.childrenBlades.slice(), function (child) {
            bladeNavigationService.closeBlade(child);
        });
    }

    $scope.blade.isLoading = false;
}]);


