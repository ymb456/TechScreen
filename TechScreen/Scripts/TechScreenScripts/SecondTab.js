angular.module('secondTab', [])
    .controller('secondTabCtrl', secondTabCtrl);

function secondTabCtrl($scope, $http) {
    $scope.downloadData = function () {
        $http.get("/api/SecondTab").then(function success(data, status, headers, config) {
            $scope.Items = data.data;
        });
    }
}