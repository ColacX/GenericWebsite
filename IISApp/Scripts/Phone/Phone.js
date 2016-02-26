'use strict';
console.log("Phone.js");

//define ui-router view
angular.module('SiteModule').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

	//define the states
	$stateProvider
		.state('news', {
			url: "/news",
			views: {
				"mainView": { templateUrl: "/Phone/Home/News" }
			}
		})
		.state('gallery', {
			url: "/gallery",
			views: {
				"mainView": { templateUrl: "/Phone/Home/Gallery" }
			}
		})
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

