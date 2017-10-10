var app = angular.module("ApplicationModule", ["ngRoute"]);

app.factory("ShareData", function () {
    return { value: 0 }
});

//Showing Routing
app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
   // debugger;
    $routeProvider.when('/showtills',
                    {
                        templateUrl: 'TillPrinters/ShowTills',
                        controller: 'ShowTillsController'
                    });

    $routeProvider.when('/addtill',
                    {
                        templateUrl: 'TillPrinters/AddTill',
                        controller: 'AddTillController'
                    });
    $routeProvider.when('/editTill',
                    {
                        templateUrl: 'TillPrinters/EditTill',
                        controller: 'EditTillController'
                    });

    $routeProvider.when('/deleteTill',
                        {
                            templateUrl: 'ManageStudentInfo/DeleteStudent',
                            controller: 'DeleteStudentController'
                        });
    $routeProvider.otherwise(
                        {
                            redirectTo: '/'
                        });
    
    $locationProvider.html5Mode(true).hashPrefix('!')
}]);