// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC
{
    public class SecurityController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string SignIn = "SignIn";
                public readonly string SignUpEmail = "SignUpEmail";
                public readonly string SignUpSecret = "SignUpSecret";
                public readonly string SignUpUser = "SignUpUser";
            }
            public readonly string SignIn = "~/Views/Security/SignIn.cshtml";
            public readonly string SignUpEmail = "~/Views/Security/SignUpEmail.cshtml";
            public readonly string SignUpSecret = "~/Views/Security/SignUpSecret.cshtml";
            public readonly string SignUpUser = "~/Views/Security/SignUpUser.cshtml";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591