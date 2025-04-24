0061:TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs:00:1:14=5D5B9604:16=47d21313:0030:TempPE:000000000:2:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0034:packages.config:0BAC:1:14=5D5B984A:16=47d21313:﻿<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Antlr" version="3.5.0.2" targetFramework="net45" />
  <package id="bootstrap" version="3.3.7" targetFramework="net45" />
  <package id="jQuery" version="3.3.1" targetFramework="net45" />
  <package id="jQuery.Validation" version="1.17.0" targetFramework="net45" />
  <package id="Microsoft.AspNet.Cors" version="5.0.0" targetFramework="net45" />
  <package id="Microsoft.AspNet.Mvc" version="5.2.4" targetFramework="net45" />
  <package id="Microsoft.AspNet.Mvc.zh-Hans" version="5.2.4" targetFramework="net45" />
  <package id="Microsoft.AspNet.Razor" version="3.2.4" targetFramework="net45" />
  <package id="Microsoft.AspNet.Razor.zh-Hans" version="3.2.4" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.Core" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.Core.zh-Hans" version="2.2.2" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.JS" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.SystemWeb" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.SystemWeb.zh-Hans" version="2.2.2" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.zh-Hans" version="2.2.2" targetFramework="net45" />
  <package id="Microsoft.AspNet.Web.Optimization" version="1.1.3" targetFramework="net45" />
  <package id="Microsoft.AspNet.Web.Optimization.zh-Hans" version="1.1.3" targetFramework="net45" />
  <package id="Microsoft.AspNet.WebPages" version="3.2.4" targetFramework="net45" />
  <package id="Microsoft.AspNet.WebPages.zh-Hans" version="3.2.4" targetFramework="net45" />
  <package id="Microsoft.CodeDom.Providers.DotNetCompilerPlatform" version="2.0.0" targetFramework="net45" />
  <package id="Microsoft.jQuery.Unobtrusive.Validation" version="3.2.4" targetFramework="net45" />
  <package id="Microsoft.Owin" version="4.0.1" targetFramework="net45" />
  <package id="Microsoft.Owin.Cors" version="4.0.1" targetFramework="net45" />
  <package id="Microsoft.Owin.Host.SystemWeb" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Host.SystemWeb.zh-Hans" version="4.0.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Security" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Security.zh-Hans" version="4.0.0" targetFramework="net45" />
  <package id="Microsoft.Owin.zh-Hans" version="4.0.0" targetFramework="net45" />
  <package id="Microsoft.Web.Infrastructure" version="1.0.0.0" targetFramework="net45" />
  <package id="Modernizr" version="2.8.3" targetFramework="net45" />
  <package id="Newtonsoft.Json" version="11.0.1" targetFramework="net45" />
  <package id="Owin" version="1.0" targetFramework="net45" />
  <package id="WebGrease" version="1.6.0" targetFramework="net45" />
</packages>0034:Properties:000000000:2:14=48041e4b:16=47d21313:0034:AssemblyInfo.cs:0536:1:14=5D5B9604:16=47d21313:﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息是通过以下项进行控制的
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("SignalRGroupChat")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SignalRGroupChat")]
[assembly: AssemblyCopyright("版权所有(C)  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 将使此程序集中的类型
// 对 COM 组件不可见。如果需要
// 从 COM 访问此程序集中的某个类型，请针对该类型将 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于 typelib 的 ID
[assembly: Guid("528a910b-ffc9-4eff-aadd-276c0a1355c2")]

// 程序集的版本信息由下列四个值组成:
//
//      主版本
//      次版本
//      内部版本号
//      修订版本
//
// 你可以指定所有值，也可以让修订版本和内部版本号采用默认值，
// 方法是按如下所示使用 "*":
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
0023:.:0:3:14=48041e4b:16=47d21313:0031:Scripts:000000000:2:14=48041e4b:16=47d21313:0033:bootstrap.js:01104B:1:14=5D5B9605:16=47d21313:/*!
 * Bootstrap v3.3.7 (http://getbootstrap.com)
 * Copyright 2011-2016 Twitter, Inc.
 * Licensed under the MIT license
 */

if (typeof jQuery === 'undefined') {
  throw new Error('Bootstrap\'s JavaScript requires jQuery')
}

+function ($) {
  'use strict';
  var version = $.fn.jquery.split(' ')[0].split('.')
  if ((version[0] < 2 && version[1] < 9) || (version[0] == 1 && version[1] == 9 && version[2] < 1) || (version[0] > 3)) {
    throw new Error('Bootstrap\'s JavaScript requires jQuery version 1.9.1 or higher, but lower than version 4')
  }
}(jQuery);

/* ========================================================================
 * Bootstrap: transition.js v3.3.7
 * http://getbootstrap.com/javascript/#transitions
 * ========================================================================
 * Copyright 2011-2016 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 * ======================================================================== */


+function ($) {
  'use strict';

  // CSS TRANSITION SUPPORT (Shoutout: http://www.modernizr.com/)
  // ============================================================

  function transitionEnd() {
    var el = document.createElement('bootstrap')

    var transEndEventNames = {
      WebkitTransition : 'webkitTransitionEnd',
      MozTransition    : 'transitionend',
      OTransition      : 'oTransitionEnd otransitionend',
      transition       : 'transitionend'
    }

    for (var name in transEndEventNames) {
      if (el.style[name] !== undefined) {
        return { end: transEndEventNames[name] }
      }
    }

    return false // explicit for ie8 (  ._.)
  }

  // http://blog.alexmaccaw.com/css-transitions
  $.fn.emulateTransitionEnd = function (duration) {
    var called = false
    var $el = this
    $(this).one('bsTransitionEnd', function () { called = true })
    var callback = function () { if (!called) $($el).trigger($.support.transition.end) }
    setTimeout(callback, duration)
    return this
  }

  $(function () {
    $.support.transition = transitionEnd()

    if (!$.support.transition) return

    $.event.special.bsTransitionEnd = {
      bindType: $.support.transition.end,
      delegateType: $.support.transition.end,
      handle: function (e) {
        if ($(e.target).is(this)) return e.handleObj.handler.apply(this, arguments)
      }
    }
  })

}(jQuery);

/* ========================================================================
 * Bootstrap: alert.js v3.3.7
 * http://getbootstrap.com/javascript/#alerts
 * ========================================================================
 * Copyright 2011-2016 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 * ======================================================================== */


+function ($) {
  'use strict';

  // ALERT CLASS DEFINITION
  // ======================

  var dismiss = '[data-dismiss="alert"]'
  var Alert   = function (el) {
    $(el).on('click', dismiss, this.close)
  }

  Alert.VERSION = '3.3.7'

  Alert.TRANSITION_DURATION = 150

  Alert.prototype.close = function (e) {
    var $this    = $(this)
    var selector = $this.attr('data-target')

    if (!selector) {
      selector = $this.attr('href')
      selector = selector && selector.replace(/.*(?=#[^\s]*$)/, '') // strip for ie7
    }

    var $parent = $(selector === '#' ? [] : selector)

    if (e) e.preventDefault()

    if (!$parent.length) {
      $parent = $this.closest('.alert')
    }

    $parent.trigger(e = $.Event('close.bs.alert'))

    if (e.isDefaultPrevented()) return

    $parent.removeClass('in')

    function removeElement() {
      // detach from parent, fire event then clean up data
      $parent.detach().trigger('closed.bs.alert').remove()
    }

    $.support.transition && $parent.hasClass('fade') ?
      $parent
        .one('bsTransitionEnd', removeElement)
        .emulateTransitionEnd(Alert.TRANSITION_DURATION) :
      removeElement()
  }


  // ALERT PLUGIN DEFINITION
  // =======================

  function Plugin(option) {
    return this.each(function () {
      var $this = $(this)
      var data  = $this.data('bs.alert')

      if (!data) $this.data('bs.alert', (data = new Alert(this)))
      if (typeof option == 