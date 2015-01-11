app.controller('AdminAdEditController',
    function ($scope, $routeParams, $location, adminService, adsService, notifyService, categoriesService, townsService) {
        $scope.id = $routeParams.id;
        $scope.categories = categoriesService.getCategories();
        $scope.towns = townsService.getTowns();
        $scope.adData = {};

        adminService.getAdInfo(
            $scope.id,
            function success(data) {
                notifyService.showInfo("Ad info loaded successfully");
                $scope.ad = data;
            },
            function error(err) {
                notifyService.showError("Cannot load add info", err);
            }
        );

        $scope.editAd = function(params) {
            if($scope.adData.changeimage == true) {
                params.changeimage = true;
                params.imageDataUrl = $scope.adData.imageDataUrl;
            }

            adminService.editAd(
                params,
                function success(data) {
                    notifyService.showInfo('Successfully edited the ad');
                    $location.path('/admin/ads');
                },
                function error(err) {
                    notifyService.showError("Cannot edit the ad", err);
                }
            );
        };

        $scope.deleteImage = function() {
            $scope.adData.changeimage = true;
            $scope.adData.imageDataUrl = '';
            notifyService.showInfo('The image was deleted successfully');
        };

        $scope.fileSelected = function(fileInputField) {
            $scope.adData.imageDataUrl = '';
            var file = fileInputField.files[0];
            if (file.type.match(/image\/.*/)) {
                $scope.adData.changeimage = true;
                var reader = new FileReader();
                reader.onload = function() {
                    $scope.adData.imageDataUrl = reader.result;
                    $(".image-box").html("<img src='" + reader.result + "'>");
                };
                reader.readAsDataURL(file);
            } else {
                $(".image-box").html("<p>This file type is not supported!</p>");
            }
        };

        $scope.cancel = function() {
            $location.path('/admin/ads');
        };
    }
);

