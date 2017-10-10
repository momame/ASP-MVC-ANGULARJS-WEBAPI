app.controller('ShowTillsController', function ($scope,$http, $location, SPACRUDService, ShareData) {
    loadAllTillsRecords();

    function loadAllTillsRecords()
    {
        var promiseGetTill = SPACRUDService.getTills();

        //Read all Tills
        
        promiseGetTill.then(function (pl) {
            $scope.Tills = pl.data;
            console.log($scope.Tills);
        },
              function (errorPl) {
                  $scope.error =  errorPl;
              });
    }

    //To Edit till Information
    $scope.editTill = function (TillPrinterID) {
        ShareData.value = TillPrinterID;
        //console.log(ShareData.value);
        $location.path("/editTill");
    }

    //To Delete a till
    $scope.deleteTill = function (TillPrinterID) {
        ShareData.value = TillPrinterID;
        $location.path("/deleteTill");
    }
});