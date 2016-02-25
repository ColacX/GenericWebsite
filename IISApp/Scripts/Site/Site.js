'use strict';

//define module and dependencies to other modules
angular.module('SiteModule', []);

//define translations
angular.module('SiteModule').config(function ($translateProvider) {

	$translateProvider.translations('en', {
		HEADLINE: 'Hello there, This is my awesome app!',
		INTRO_TEXT: 'And it has i18n support!'
	});

	$translateProvider.translations('de', {
		HEADLINE: 'Hey, das ist meine großartige App!',
		INTRO_TEXT: 'Und sie untersützt mehrere Sprachen!'
	});

	$translateProvider.translations('sv', {
		HEADLINE: 'Hejsan detta är min awesome app!',
		INTRO_TEXT: 'Und sie untersützt mehrere Sprachen!'
	});

	//$translateProvider.preferredLanguage('de');
	//$translateProvider.preferredLanguage('en');
	$translateProvider.preferredLanguage('sv');
});

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
