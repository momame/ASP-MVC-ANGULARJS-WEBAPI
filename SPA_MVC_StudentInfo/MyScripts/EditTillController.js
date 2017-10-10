app.controller("EditTillController", function ($scope, $location, ShareData, SPACRUDService) {
    getTill();

    function getTill() {        
        var promiseGetTill = SPACRUDService.getTill(ShareData.value);

        promiseGetTill.then(function (pl)
        {
            console.log(pl);
            $scope.Till = pl.data;
        },
              function (errorPl) {
                  $scope.error = 'failure loading Till', errorPl;
              });
    }

    $scope.save = function () {
        var Till = {
            TillPrinterID: $scope.Till.tillPrinterID,
            TillPrintingName: $scope.Till.tillPrintingName,
            UpdateBy: 'mo',
            CreatedBy: 'system',
            CreatedDTS: '2017/05/05',
            UpdateDTS: '2017/05/05',
        }; 

        var promisePutTill = SPACRUDService.put($scope.Till.tillPrinterID, Till);
        promisePutTill.then(function (pl)
        {
            $location.path("/showtills");
        },
              function (errorPl) {
                  $scope.error = 'failure loading Till', errorPl;
              });
    };

});