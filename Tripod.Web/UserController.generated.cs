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
    public partial class UserController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UserController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ChangeUserName()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeUserName);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ValidateChangeUserName()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateChangeUserName);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SendVerificationEmail()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SendVerificationEmail);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RedeemEmailVerification()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedeemEmailVerification);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RejectEmailOwnership()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RejectEmailOwnership);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> UpdateEmailAddress()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateEmailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteEmailAddress()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteEmailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserController Actions { get { return MVC.User; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "User";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "User";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string SettingsIndex = "SettingsIndex";
            public readonly string ChangeUserName = "ChangeUserName";
            public readonly string ValidateChangeUserName = "ValidateChangeUserName";
            public readonly string Emails = "Emails";
            public readonly string SendVerificationEmail = "SendVerificationEmail";
            public readonly string VerifyEmailSecret = "VerifyEmailSecret";
            public readonly string RedeemEmailVerification = "RedeemEmailVerification";
            public readonly string RejectEmailOwnership = "RejectEmailOwnership";
            public readonly string UpdateEmailAddress = "UpdateEmailAddress";
            public readonly string DeleteEmailAddress = "DeleteEmailAddress";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SettingsIndex = "SettingsIndex";
            public const string ChangeUserName = "ChangeUserName";
            public const string ValidateChangeUserName = "ValidateChangeUserName";
            public const string Emails = "Emails";
            public const string SendVerificationEmail = "SendVerificationEmail";
            public const string VerifyEmailSecret = "VerifyEmailSecret";
            public const string RedeemEmailVerification = "RedeemEmailVerification";
            public const string RejectEmailOwnership = "RejectEmailOwnership";
            public const string UpdateEmailAddress = "UpdateEmailAddress";
            public const string DeleteEmailAddress = "DeleteEmailAddress";
        }


        static readonly ActionParamsClass_ChangeUserName s_params_ChangeUserName = new ActionParamsClass_ChangeUserName();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ChangeUserName ChangeUserNameParams { get { return s_params_ChangeUserName; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ChangeUserName
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_ValidateChangeUserName s_params_ValidateChangeUserName = new ActionParamsClass_ValidateChangeUserName();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateChangeUserName ValidateChangeUserNameParams { get { return s_params_ValidateChangeUserName; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateChangeUserName
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_SendVerificationEmail s_params_SendVerificationEmail = new ActionParamsClass_SendVerificationEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SendVerificationEmail SendVerificationEmailParams { get { return s_params_SendVerificationEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SendVerificationEmail
        {
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_VerifyEmailSecret s_params_VerifyEmailSecret = new ActionParamsClass_VerifyEmailSecret();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_VerifyEmailSecret VerifyEmailSecretParams { get { return s_params_VerifyEmailSecret; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_VerifyEmailSecret
        {
            public readonly string ticket = "ticket";
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_RedeemEmailVerification s_params_RedeemEmailVerification = new ActionParamsClass_RedeemEmailVerification();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RedeemEmailVerification RedeemEmailVerificationParams { get { return s_params_RedeemEmailVerification; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RedeemEmailVerification
        {
            public readonly string token = "token";
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_RejectEmailOwnership s_params_RejectEmailOwnership = new ActionParamsClass_RejectEmailOwnership();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RejectEmailOwnership RejectEmailOwnershipParams { get { return s_params_RejectEmailOwnership; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RejectEmailOwnership
        {
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_UpdateEmailAddress s_params_UpdateEmailAddress = new ActionParamsClass_UpdateEmailAddress();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateEmailAddress UpdateEmailAddressParams { get { return s_params_UpdateEmailAddress; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateEmailAddress
        {
            public readonly string emailAddressId = "emailAddressId";
            public readonly string command = "command";
        }
        static readonly ActionParamsClass_DeleteEmailAddress s_params_DeleteEmailAddress = new ActionParamsClass_DeleteEmailAddress();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteEmailAddress DeleteEmailAddressParams { get { return s_params_DeleteEmailAddress; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteEmailAddress
        {
            public readonly string emailAddressId = "emailAddressId";
            public readonly string command = "command";
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
    public partial class T4MVC_UserController : Tripod.Web.Controllers.UserController
    {
        public T4MVC_UserController() : base(Dummy.Instance) { }

        partial void SettingsIndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SettingsIndex()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SettingsIndex);
            SettingsIndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ChangeUserNameOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.ChangeUserName command);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ChangeUserName(Tripod.Domain.Security.ChangeUserName command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeUserName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ChangeUserNameOverride(callInfo, command);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ValidateChangeUserNameOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.ChangeUserName command);

        public override System.Web.Mvc.ActionResult ValidateChangeUserName(Tripod.Domain.Security.ChangeUserName command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateChangeUserName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ValidateChangeUserNameOverride(callInfo, command);
            return callInfo;
        }

        partial void EmailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Emails()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Emails);
            EmailsOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void SendVerificationEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.SendVerificationEmail command);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SendVerificationEmail(Tripod.Domain.Security.SendVerificationEmail command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SendVerificationEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            SendVerificationEmailOverride(callInfo, command);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void VerifyEmailSecretOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ticket);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyEmailSecret(string ticket)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyEmailSecret);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ticket", ticket);
            VerifyEmailSecretOverride(callInfo, ticket);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void VerifyEmailSecretOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.VerifyEmailSecret command, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyEmailSecret(Tripod.Domain.Security.VerifyEmailSecret command, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyEmailSecret);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            VerifyEmailSecretOverride(callInfo, command, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void RedeemEmailVerificationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string token);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RedeemEmailVerification(string token)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedeemEmailVerification);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "token", token);
            RedeemEmailVerificationOverride(callInfo, token);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void RedeemEmailVerificationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.RedeemEmailVerification command, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RedeemEmailVerification(Tripod.Domain.Security.RedeemEmailVerification command, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedeemEmailVerification);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            RedeemEmailVerificationOverride(callInfo, command, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void RejectEmailOwnershipOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.RejectEmailVerification command, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RejectEmailOwnership(Tripod.Domain.Security.RejectEmailVerification command, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RejectEmailOwnership);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            RejectEmailOwnershipOverride(callInfo, command, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void UpdateEmailAddressOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int emailAddressId, Tripod.Domain.Security.UpdateEmailAddress command);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> UpdateEmailAddress(int emailAddressId, Tripod.Domain.Security.UpdateEmailAddress command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateEmailAddress);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddressId", emailAddressId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            UpdateEmailAddressOverride(callInfo, emailAddressId, command);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void DeleteEmailAddressOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int emailAddressId, Tripod.Domain.Security.DeleteEmailAddress command);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteEmailAddress(int emailAddressId, Tripod.Domain.Security.DeleteEmailAddress command)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteEmailAddress);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddressId", emailAddressId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            DeleteEmailAddressOverride(callInfo, emailAddressId, command);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
