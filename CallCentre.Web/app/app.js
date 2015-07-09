(function (angular) {

    "use strict";

    var module = angular.module("CallCentre", ["ngRoute"]);

    var configureRoute = function ($routeProvider, $locationProvider) {
        $routeProvider
            .otherwise({
                redirectTo: "/operators"
            });

        $routeProvider
            .when("/operators", {
                templateUrl: "app/views/operators.html",
                controller: "operatorsCtrl"
            });

        $locationProvider.html5Mode({
            enabled: false,
            requireBase: false
        });
    };

    module.config(["$routeProvider", "$locationProvider", configureRoute]);

})(angular);

