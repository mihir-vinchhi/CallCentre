///<reference path="~/bower_components/angular/angular.js"/>
///<reference path="~/bower_components/angular-mocks/angular-mocks.js"/>
///<reference path="~/bower_components/angular-route/angular-route.min.js"/>
///<reference path="~/app/app.js"/>
///<reference path="~/app/services/operators-service.js"/>

describe("operators service", function () {

    "use strict";

    var $log;

    beforeEach(module("CallCentre"));

    beforeEach(function () {
        $log = {
            error: function (message) { }
        };

        module(function ($provide) {
            $provide.value("$log", $log);
        });
    });

    it("should log error on request failure", inject(function (operatorsService, $httpBackend) {
        $httpBackend
            .whenGET("/api/Operators")
            .respond(404, "Not found");

        spyOn($log, "error");

        operatorsService.executeQuery();

        $httpBackend.flush();

        expect($log.error).toHaveBeenCalledWith("Not found");
    }));

});