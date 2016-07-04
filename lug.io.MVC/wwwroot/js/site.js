﻿// Global namespace (name of our app)
lug = {};

function extend(base, sub) {
    // Avoid instantiating the base class just to setup inheritance
    // See https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/create
    // for a polyfill
    // Also, do a recursive merge of two prototypes, so we don't overwrite 
    // the existing prototype, but still maintain the inheritance chain
    var origProto = sub.prototype;
    sub.prototype = Object.create(base.prototype);
    for (var key in origProto) {
        sub.prototype[key] = origProto[key];
    }
    // Remember the constructor property was set wrong, let's fix it
    sub.prototype.constructor = sub;
    // In ECMAScript5+ (all modern browsers), you can make the constructor property
    // non-enumerable if you define it like this instead
    Object.defineProperty(sub.prototype, 'constructor', {
        enumerable: false,
        value: sub
    });
}

var base = {};
var VmBase = (function () {
    var VmBase = function (data) {
        console.log(this);
        var _this = this;
        this.data = data;
        this.mapInitData(data);
        this.setupBindings();
        this.setNewItem();
        //this.WindowLocation(window.location.pathname + window.location.hash);
    };

    VmBase.prototype.setupBindings = function () { };

    VmBase.prototype.mapInitData = function (data) {
        ko.mapping.fromJS(data, data.KOMapping, this);
    };

    VmBase.prototype.setNewItem = function () {
        console.log(this.ItemDetail);
        //this.NewItemDetail = mapper.toJs(this.ItemDetail);
    };


    // setup SignIn Method 
    VmBase.prototype.SignOut = function () {
        $.ajax({
            method: "POST",
            url: "/Account/LogOff"
        })
			.done(function (data) {
			    location.reload();
			});
    };

    return VmBase;
})();



// Modules / AggregateRoots
// Function that is called to init VM for Home Route
var Home =
    (function () {
        function Home(data) {
            VmBase.call(this, data); // call base constructor

            this.data = data;
            ko.applyBindings(this);
            $('.hideUnbound').removeClass('hideUnbound');



            // setup SignIn Method 
            VmBase.prototype.Register = function () {
                // this == LoginForm (see base VM;; C#)
                var myForm = ko.toJS(this);
                myForm.returnUrl = "";


                // todo: loading icon...
                $.ajax({
                    method: "POST",
                    url: "/Account/Register",
                    data: myForm
                })
				.done(function (data) {
				    // todo: check to see if we received a SimpleModelState back...
				    ko.mapping.fromJS(data, {}, _self.User);
				})
				.fail(function (data) {
				    console.log("Die silently...");
				    console.log(data);
				});
            };

            // setup SignIn Method 
            var _self = this;
            this.SignIn = function () {

                var myForm = ko.toJS(_self.LoginForm);
                myForm.returnUrl = "";

                $.ajax({
                    method: "POST",
                    url: "/Account/Login",
                    data: myForm
                })
			.done(function (data) {
			    // todo: check to see if we received a SimpleModelState back...
			    ko.mapping.fromJS(data, {}, _self.User);
			})
			.fail(function (data) {
			    console.log("Die silently...");
			    console.log(data);
			});
            };
        }

        return Home;
    })(base.VmBase);
lug.Home = Home;


// Function that is called to init VM for Recipe Route
var Recipe =
    (function () {
        function Recipe(data) {
            VmBase.call(this, data); // call base constructor

            this.data = data;
            ko.applyBindings(this);
            $('.hideUnbound').removeClass('hideUnbound');
        }

        return Recipe;
    })(base.VmBase);
lug.Recipe = Recipe;

// Setup the prototype chain the right way
extend(VmBase, Recipe);