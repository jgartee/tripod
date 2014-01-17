'use strict';
var App;
(function (App) {
    (function (Security) {
        (function (SignUp) {
            (function (Form) {
                var Controller = (function () {
                    function Controller(scope) {
                        this.scope = scope;
                        this.emailAddress = '';
                        this.isExpectingEmail = false;
                        scope.vm = this;
                    }
                    Controller.prototype.emailAddressInputGroupValidationAddOnCssClass = function () {
                        return this.scope.signUpCtrb.emailAddress.hasFeedback() ? null : 'hide';
                    };

                    Controller.prototype.isEmailAddressRequiredError = function () {
                        return this.scope.signUpForm.emailAddress.$error.required && this.scope.signUpCtrb.emailAddress.hasError;
                    };

                    Controller.prototype.isEmailAddressPatternError = function () {
                        return this.scope.signUpForm.emailAddress.$error.email && this.scope.signUpCtrb.emailAddress.hasError;
                    };

                    Controller.prototype.isEmailAddressServerError = function () {
                        return this.scope.signUpForm.emailAddress.$error.server && this.scope.signUpCtrb.emailAddress.hasError;
                    };

                    Controller.prototype.isExpectingEmailError = function () {
                        return this.scope.signUpCtrb.isExpectingEmail.hasError;
                    };

                    Controller.prototype.isExpectingEmailRequiredError = function () {
                        return this.scope.signUpForm.isExpectingEmail.$error.required && this.isExpectingEmailError();
                    };

                    Controller.prototype.isExpectingEmailServerError = function () {
                        return this.scope.signUpForm.isExpectingEmail.$error.server && this.isExpectingEmailError();
                    };
                    Controller.$inject = ['$scope'];
                    return Controller;
                })();
                Form.Controller = Controller;

                Form.moduleName = 'sign-up-form';

                Form.ngModule = angular.module(Form.moduleName, [App.Modules.Tripod.moduleName]);
            })(SignUp.Form || (SignUp.Form = {}));
            var Form = SignUp.Form;
        })(Security.SignUp || (Security.SignUp = {}));
        var SignUp = Security.SignUp;
    })(App.Security || (App.Security = {}));
    var Security = App.Security;
})(App || (App = {}));
