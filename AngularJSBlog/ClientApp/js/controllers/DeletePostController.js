/* Setup blank page controller */

angular.module('MetronicApp').controller('DeletePostController', ['$rootScope', '$scope', '$http', '$location', '$stateParams', 'settings', function ($rootScope, $scope, $http, $location, $stateParams, settings) {
    alert("Uyarı: DeletePostController a Giriş Yapıldı");
    $http({ method: "get", url: "/api/posts?id=" + $stateParams.id }).then(function (response) {
        $scope.Id = $stateParams.id;
        $scope.Name = response.data.Name;
        $scope.Body = response.data.Body;
        $scope.PublishDate = response.data.PublishDate;
        $scope.IsPublished = response.data.IsPublished;
        
        // ..
    });
    
    $scope.Delete2 = function () {
        $http({ method: "delete", url: "/api/posts", data: { Id:$scope.Id, Name: $scope.Name, Body: $scope.Body, PublishDate: $scope.PublishDate, IsPublished: $scope.IsPublished } }).then(function (response) {
            $location.path("/posts");
        }, function (response) {
            alert("Yazı silinirken bir hata oluştu");
        });
    };

    $scope.$on('$viewContentLoaded', function () {
        
        // initialize core components
        App.initAjax();

        

        // set default layout mode
        $rootScope.settings.layout.pageContentWhite = true;
        $rootScope.settings.layout.pageBodySolid = false;
        $rootScope.settings.layout.pageSidebarClosed = false;
    });
}]);