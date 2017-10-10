app.controller('AddTillController', function ($scope, SPACRUDService, $http) {
    //$scope.ID = 0;
     
    $scope.save = function () {
        
        var Till = {
            //TillPrinterID: $scope.TillPrinterID,
            TillPrintingName: $scope.TillPrintingName,
            UpdateBy: 'mo',
            CreatedBy: 'system',
            CreatedDTS: '2017/05/05',
            UpdateDTS: '2017/05/05',
            //Line1DateEn: $scope.Line1DateEn,
        };

        var promisePost = SPACRUDService.post(Till);
        
        promisePost.then(function (pl) {
            
            alert("Till Saved Successfully.");
        },
              function (errorPl) {
                  $scope.error = 'failure loading Till', errorPl;
              });

    };

});