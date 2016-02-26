'use strict';
console.log("Site.js");

//define module and dependencies to other modules
angular.module('SiteModule', ['ui.router', 'ngTouch', 'ui.bootstrap', 'ui.bootstrap.carousel']);

//define services
angular.module('SiteModule').service('TestService', ['$log', function ($log) {

}]);

//define directives
angular.module('SiteModule').directive('smTestDirective', ['$document', function ($document) {
	return {
		link: function (scope, element, attributes, controller) {
		}
	};
}]);

//define controllers
angular.module('SiteModule').controller('SiteController', ['$scope', '$compile', function ($scope, $compile) {
	var self = this;
}]);

angular.module('SiteModule').controller('NewsController', ['$scope', '$compile', function ($scope, $compile) {
	var self = this;

	$scope.list = [{
		id: 23,
		html: "hello <img src=''/>",
	}];
}]);

angular.module('SiteModule').controller('GalleryController', ['$scope', '$compile', function ($scope, $compile) {
	var self = this;

	$scope.SwipeLeft = function () {
		console.log("swipeleft");
	};

	$scope.Slides = [{
		active: true
	},
	{
		active: false
	},
	{
		active: false
	},
	{
		active: false
	}];
}]);
