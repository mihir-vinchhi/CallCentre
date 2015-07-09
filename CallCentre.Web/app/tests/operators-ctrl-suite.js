///<reference path="~/bower_components/angular/angular.js"/>
///<reference path="~/bower_components/angular-mocks/angular-mocks.js"/>
///<reference path="~/bower_components/angular-route/angular-route.min.js"/>
///<reference path="~/app/app.js"/>
///<reference path="~/app/services/operators-service.js"/>
///<reference path="~/app/controllers/operators-ctrl.js"/>

describe("operators with status", function () {

    "use strict";

    beforeEach(module("OperatorStatusList"));

    it("should display list of operators with thier status", inject(function($rootScope, $controller, $httpBackend) {
        var $scope = $rootScope.$new();
        
        var operators = [
            {
                id: 1,
                name: "Tom",
                extension: 101,
                callStatus: 1,
                callStatusText: "on call"
            },
            {
                id: 2,
                name: "Betty",
                extension: 102,
                callStatus: 0,
                callStatusText: "available"
            }
        ];

        $httpBackend
            .whenGET("/api/Operators")
            .respond({ "operators": operators });

        $controller("operatorsCtrl", { "$scope": $scope });

        $httpBackend.flush();

        var operatorsResult = $scope.operators;

        expect(operatorsResult).toBeDefined();
        expect(operatorsResult.length).toBe(2);

        expect(operatorsResult[0].id).toBe(1);
        expect(operatorsResult[0].name).toBe("Tom");
        expect(operatorsResult[0].extension).toBe(101);
        expect(operatorsResult[0].callStatus).toBe(1);
        expect(operatorsResult[0].callStatusText).toBe("on call");

        expect(operatorsResult[1].id).toBe(2);
        expect(operatorsResult[1].name).toBe("Betty");
        expect(operatorsResult[1].extension).toBe(102);
        expect(operatorsResult[1].callStatus).toBe(0);
        expect(operatorsResult[1].callStatusText).toBe("available");
    }));

});