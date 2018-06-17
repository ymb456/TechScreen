angular.module('TechScreenApp', [])
    .controller('FirstTabCtrl', function ($scope, $http) {
        $scope.answered = false;
        $scope.title = "loading question...";
        $scope.options = [];
        $scope.correctAnswer = false;
        $scope.working = false;

        $scope.answer = function () {
            return $scope.correctAnswer ? 'correct' : 'incorrect';
        };
    });

angular.module('showcase.angularWay', [])
    .controller('AngularWayCtrl', AngularWayCtrl).directive('myPostRepeatDirective', function () {
        return function ($scope, element, attrs) {
            if ($scope.$last) {
                $('#example').DataTable();
                $('#master_table').show();
            }
        };
    });

function AngularWayCtrl($scope, $http) {
    angular.element(document).ready(function () {
    });
    $scope.downloadData = function () {
        $http.get("/api/FirstTab").then(function success(data, status, headers, config) {
            $scope.persons = data.data;
        });
    }




}