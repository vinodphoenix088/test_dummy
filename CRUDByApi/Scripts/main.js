
var App = angular.module('mymodule', []);

App.service('myservice', function ($http) {
    this.crud = function (originalStudent) {
        return $http.post('api/master/crud', originalStudent);
    };

});



App.controller("mycontroller", function ($scope, myservice) {

        //$scope.originalStudent = {
        //    firstName: 'firstName',
        //    lastName: 'lastName',
        //    gender: 'gender',
        //    trainingType: 'online'
        //};
    
    $scope.submitStudnetForm = function (student)
        {
        myservice.crud(student).then(function (res) {
                alert(res.data);
            });
        };

    
});