var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('FreelanceForAll');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);