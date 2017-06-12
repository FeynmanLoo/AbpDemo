var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('AbpDemo');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);