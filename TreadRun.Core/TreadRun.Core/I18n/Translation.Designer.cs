﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreadRun.Core.I18n {
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
    internal class Translation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Translation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TreadRun.Core.I18n.Translation", typeof(Translation).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device {0} created.
        /// </summary>
        internal static string DeviceCreated {
            get {
                return ResourceManager.GetString("DeviceCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Devicename.
        /// </summary>
        internal static string DeviceName {
            get {
                return ResourceManager.GetString("DeviceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Devicetype.
        /// </summary>
        internal static string DeviceType {
            get {
                return ResourceManager.GetString("DeviceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device gets calibrated....
        /// </summary>
        internal static string IsBusyCalibrating {
            get {
                return ResourceManager.GetString("IsBusyCalibrating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialized.
        /// </summary>
        internal static string IsInitialized {
            get {
                return ResourceManager.GetString("IsInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not initialized.
        /// </summary>
        internal static string IsNotInitialized {
            get {
                return ResourceManager.GetString("IsNotInitialized", resourceCulture);
            }
        }
    }
}
