app.service("SPACRUDService", function ($http) {

    //Read all Tills
    this.getTills = function () {

        return $http.get("/api/TillPrintersAPI");
    };

    //Function to create new Till
    this.post = function (Till) {
        
        var request = $http({
            method: "post",
            url: "/api/TillPrintersAPI",
            data: Till
        });
        
        return request;
    };

    //Fundction to Read Till by Till ID
    this.getTill = function (id) {
        return $http.get("/api/TillPrintersAPI/" + id);
    };

    //Edit Till By ID 
    this.put = function (id, Till) {
        var request = $http({
            method: "put",
            url: "/api/TillPrintersAPI/" + id,
            data: Till
        });
        return request;
    };

    //Delete Till By Till ID
    this.delete = function (id) {
        var request = $http({
            method: "delete",
            url: "/api/TillPrintersAPI/" + id
        });
        return request;
    };
});








