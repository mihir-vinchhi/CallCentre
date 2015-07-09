(function (angular) {

    "use strict";

    // service to execute query api
    var operatorsService = function($http, $log) {
        return {
            executeQuery: function() {
                return $http.get("/api/Operators")
                    .error(function(error) {
                        // log error on console in case request fails
                        $log.error(error);
                    });
            }
        };
    };

    angular.module("CallCentre")
        .service("operatorsService", ["$http", "$log", operatorsService]);

})(angular);