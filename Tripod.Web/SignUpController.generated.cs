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
namespace Tripod.Web.Controllers
{
    public partial class SignUpController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SignUpController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ViewResult SendVerificationEmail()
        {
            return new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.SendVerificationEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ValidateSendVerificationEmail()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateSendVerificationEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyEmailSecret()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyEmailSecret);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ValidateVerifyEmailSecret()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateVerifyEmailSecret);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> CreateLocalMembership()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateLocalMembership);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ValidateCreateLocalMembership()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateCreateLocalMembership);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SignUpController Actions { get { return MVC.SignUp; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "SignUp";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "SignUp";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string SendVerificationEmail = "SendVerificationEmail";
            public readonly string ValidateSendVerificationEmail = "ValidateSendVerificationEmail";
            public readonly string VerifyEmailSecret = "VerifyEmailSecret";
            public readonly string ValidateVerifyEmailSecret = "ValidateVerifyEmailSecret";
            public readonly string CreateLocalMembership = "CreateLocalMembership";
            public readonly string ValidateCreateLocalMembership = "ValidateCreateLocalMembership";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SendVerificationEmail = "SendVerificationEmail";
            public const string ValidateSendVerificationEmail = "ValidateSendVerificationEmail";
            public const string VerifyEmailSecret = "VerifyEmailSecret";
            public const string ValidateVerifyEmailSecret = "ValidateVerifyEmailSecret";
            public const string CreateLocalMembership = "CreateLocalMembership";
            public const string ValidateCreateLocalMembership = "ValidateCreateLocalMembership";
        }


        static readonly ActionParamsClass_SendVerificationEmail s_params_SendVerificationEmail = new ActionParamsClass_SendVerificationEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SendVerificationEmail SendVerificationEmailParams { get { return s_params_SendVerificationEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SendVerificationEmail
        {
            public readonly string returnUrl = "returnUrl";
            public readonly string command = "command";
            public readonly string loginProvider = "loginProvider";
        }
        static readonly ActionParamsClass_ValidateSendVerificationEmail s_params_ValidateSendVerificationEmail = new ActionParamsClass_ValidateSendVerificationEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateSendVerificationEmail ValidateSendVerificationEmailParams { get { return s_params_ValidateSendVerificationEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateSendVerificationEmail
        {
            public readonly string command = "command";
            public readonly string fieldName = "fieldName";
        }
        static readonly ActionParamsClass_VerifyEmailSecret s_params_VerifyEmailSecret = new ActionParamsClass_VerifyEmailSecret();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_VerifyEmailSecret VerifyEmailSecretParams { get { return s_params_VerifyEmailSecret; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_VerifyEmailSecret
        {
            public readonly string ticket = "ticket";
            public readonly string returnUrl = "returnUrl";
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_ValidateVerifyEmailSecret s_params_ValidateVerifyEmailSecret = new ActionParamsClass_ValidateVerifyEmailSecret();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateVerifyEmailSecret ValidateVerifyEmailSecretParams { get { return s_params_ValidateVerifyEmailSecret; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateVerifyEmailSecret
        {
            public readonly string command = "command";
            public readonly string fieldName = "fieldName";
        }
        static readonly ActionParamsClass_CreateLocalMembership s_params_CreateLocalMembership = new ActionParamsClass_CreateLocalMembership();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateLocalMembership CreateLocalMembershipParams { get { return s_params_CreateLocalMembership; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateLocalMembership
        {
            public readonly string token = "token";
            public readonly string returnUrl = "returnUrl";
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_ValidateCreateLocalMembership s_params_ValidateCreateLocalMembership = new ActionParamsClass_ValidateCreateLocalMembership();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateCreateLocalMembership ValidateCreateLocalMembershipParams { get { return s_params_ValidateCreateLocalMembership; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateCreateLocalMembership
        {
            public readonly string command = "command";
            public readonly string fieldName = "fieldName";
        }
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SignUpController : Tripod.Web.Controllers.SignUpController
    {
        public T4MVC_SignUpController() : base(Dummy.Instance) { }

        partial void SendVerificationEmailOverride(T4MVC_System_Web_Mvc_ViewResult callInfo, string returnUrl);

        public override System.Web.Mvc.ViewResult SendVerificationEmail(string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.SendVerificationEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            SendVerificationEmailOverride(callInfo, returnUrl);
            return callInfo;
        }

        partial void SendVerificationEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.SendVerificationEmail command, string returnUrl, string loginProvider);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SendVerificationEmail(Tripod.Domain.Security.SendVerificationEmail command, string returnUrl, string loginProvider)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SendVerificationEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "loginProvider", loginProvider);
            SendVerificationEmailOverride(callInfo, command, returnUrl, loginProvider);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ValidateSendVerificationEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.SendVerificationEmail command, string fieldName);

        public override System.Web.Mvc.ActionResult ValidateSendVerificationEmail(Tripod.Domain.Security.SendVerificationEmail command, string fieldName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateSendVerificationEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fieldName", fieldName);
            ValidateSendVerificationEmailOverride(callInfo, command, fieldName);
            return callInfo;
        }

        partial void VerifyEmailSecretOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ticket, string returnUrl);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyEmailSecret(string ticket, string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyEmailSecret);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ticket", ticket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            VerifyEmailSecretOverride(callInfo, ticket, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void VerifyEmailSecretOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ticket, Tripod.Domain.Security.VerifyEmailSecret command, string returnUrl, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyEmailSecret(string ticket, Tripod.Domain.Security.VerifyEmailSecret command, string returnUrl, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyEmailSecret);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ticket", ticket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            VerifyEmailSecretOverride(callInfo, ticket, command, returnUrl, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ValidateVerifyEmailSecretOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.VerifyEmailSecret command, string fieldName);

        public override System.Web.Mvc.ActionResult ValidateVerifyEmailSecret(Tripod.Domain.Security.VerifyEmailSecret command, string fieldName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateVerifyEmailSecret);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fieldName", fieldName);
            ValidateVerifyEmailSecretOverride(callInfo, command, fieldName);
            return callInfo;
        }

        partial void CreateLocalMembershipOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string token, string returnUrl);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> CreateLocalMembership(string token, string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateLocalMembership);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "token", token);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            CreateLocalMembershipOverride(callInfo, token, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void CreateLocalMembershipOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.CreateLocalMembership command, string returnUrl, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> CreateLocalMembership(Tripod.Domain.Security.CreateLocalMembership command, string returnUrl, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateLocalMembership);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            CreateLocalMembershipOverride(callInfo, command, returnUrl, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ValidateCreateLocalMembershipOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.CreateLocalMembership command, string fieldName);

        public override System.Web.Mvc.ActionResult ValidateCreateLocalMembership(Tripod.Domain.Security.CreateLocalMembership command, string fieldName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateCreateLocalMembership);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fieldName", fieldName);
            ValidateCreateLocalMembershipOverride(callInfo, command, fieldName);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
