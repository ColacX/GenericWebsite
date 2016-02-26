'use strict';

console.log("Site.js");

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
	
	//define the states
	$stateProvider
		.state('state1', {
			url: "/state1",
			views: {
				"mainView": { templateUrl: "/Phone/Home/Test1" }
			}
		})
		.state('state2', {
			url: "/state2",
			views: {
				"mainView": { templateUrl: "/Phone/Home/Test2" }
			}
		});
	
	//do not do redirects it gets too complicated
	//define redirects
	//$urlRouterProvider.when("", "/");
	//$urlRouterProvider.otherwise("oops");
}]);

////preload templates into cache
//angular.module('SiteModule').run(function ($templateCache) {
//	$templateCache.put("Test2", 'This is the content of the template');
//});

//define controllers
angular.module('SiteModule').controller('SiteController', ['$scope', '$compile', function ($scope, $compile) {
	var self = this;
}]);

