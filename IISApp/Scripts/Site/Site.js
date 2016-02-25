'use strict';

//define module and dependencies to other modules
angular.module('SiteModule', ['ui.router']);

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

//define ui-router view
angular.module('SiteModule').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
	// For any unmatched url, redirect to /state1
	$urlRouterProvider.otherwise("/state1");

	// Now set up the states
	$stateProvider
		.state('state1', {
			url: "/state1",
			templateUrl: "Home/Test1",
			views: {
				"viewA": { templateUrl: "Home/Test1" }
			}
		})
		.state('state2', {
			url: "/state2",
			templateUrl: "Home/Test2",
			views: {
				"viewA": { templateUrl: "Home/Test2" }
			}
		});
}]);

//define controllers
angular.module('SiteModule').controller('SiteController', ['$scope', '$compile', function ($scope, $compile) {
	console.log("site controller")
	var self = this;
	var result = $compile("<a ui-sref='state1'>State 1</a>")($scope);

	console.log(result);
}]);
