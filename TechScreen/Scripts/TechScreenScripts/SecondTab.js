
var buildItemsArray = function (items) {

    let Items = [];

    items.forEach(function (v, i, a) {
        Items.push(v);
    });

    return Items;
}

angular.module('secondTab', [])
    .controller('secondTabCtrl', secondTabCtrl);

function secondTabCtrl($scope, $http) {
    $scope.moveToLeft = function (RHSItems, LHSItems) {

        let checked = RHSItems.filter(function (v) {
            return (v.IsChecked == true);
        });
        $scope.LHSItems = LHSItems.concat(checked);
        let unchecked = RHSItems.filter(function (v) {
            return (v.IsChecked != true);
        });
        $scope.RHSItems = unchecked;

    };

    $scope.moveToRight = function (LHSItems, RHSItems) {

        let checked = LHSItems.filter(function (v) {
            return (v.IsChecked == true);
        });
        $scope.RHSItems = RHSItems.concat(checked);
        let unchecked = LHSItems.filter(function (v) {
            return (v.IsChecked != true);
        });
        $scope.LHSItems = unchecked;
        
    };

    $scope.downloadData = function () {
        $http.get("/api/SecondTab").then(function success(data, status, headers, config) {
            $scope.LHSItems = buildItemsArray(data.data);
            $scope.RHSItems = [];
        });
    }
}

