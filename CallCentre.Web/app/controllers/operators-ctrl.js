(function (angular) {

    "use strict";

    var operatorsCtrl = function ($scope, operatorsService) {
        operatorsService.executeQuery()
            .success(function(response) {
                $scope.operators = response.operators;
            });
    };

    operatorsCtrl.$inject = ["$scope", "operatorsService"];

    angular.module("CallCentre").controller("operatorsCtrl", operatorsCtrl);

})(angular);
