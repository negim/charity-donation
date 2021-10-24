﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUI.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebUI.Localization.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This user name is already taken..
        /// </summary>
        public static string DuplicateUserName {
            get {
                return ResourceManager.GetString("DuplicateUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        public static string emailName {
            get {
                return ResourceManager.GetString("emailName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} is required..
        /// </summary>
        public static string fieldCannotBeEmpty {
            get {
                return ResourceManager.GetString("fieldCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} must be at least {2} and at max {1} characters long..
        /// </summary>
        public static string fieldLength {
            get {
                return ResourceManager.GetString("fieldLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name.
        /// </summary>
        public static string firstName {
            get {
                return ResourceManager.GetString("firstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not a valid e-mail address..
        /// </summary>
        public static string invalidEmail {
            get {
                return ResourceManager.GetString("invalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieudana próba logowania!.
        /// </summary>
        public static string invalidLoginAttempt {
            get {
                return ResourceManager.GetString("invalidLoginAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name.
        /// </summary>
        public static string lastName {
            get {
                return ResourceManager.GetString("lastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message.
        /// </summary>
        public static string message {
            get {
                return ResourceManager.GetString("message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string passwordName {
            get {
                return ResourceManager.GetString("passwordName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password requires at least one digit..
        /// </summary>
        public static string PasswordRequiresDigit {
            get {
                return ResourceManager.GetString("PasswordRequiresDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords must have at least one non alphanumeric character..
        /// </summary>
        public static string PasswordRequiresNonAlphanumeric {
            get {
                return ResourceManager.GetString("PasswordRequiresNonAlphanumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password and confirmation password do not match..
        /// </summary>
        public static string passwordsMustMatch {
            get {
                return ResourceManager.GetString("passwordsMustMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remember me?.
        /// </summary>
        public static string rememberMe {
            get {
                return ResourceManager.GetString("rememberMe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm password.
        /// </summary>
        public static string repeatPasswordName {
            get {
                return ResourceManager.GetString("repeatPasswordName", resourceCulture);
            }
        }
    }
}