(function (angular) {

    "use strict";

    var operatorsService = function($http, $log) {
        return {
            executeQuery: function() {
                return $http.get("/api/Operators")
                    .error(function(error) {
                        $log.error(error);
                    });
            }
        };
    };

    angular.module("OperatorStatusList")
        .service("operatorsService", ["$http", "$log", operatorsService]);

})(angular);