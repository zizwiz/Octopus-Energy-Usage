﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnergyUsage.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string API_Key {
            get {
                return ((string)(this["API_Key"]));
            }
            set {
                this["API_Key"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string MPAN {
            get {
                return ((string)(this["MPAN"]));
            }
            set {
                this["MPAN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string MPRN {
            get {
                return ((string)(this["MPRN"]));
            }
            set {
                this["MPRN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string Electric_meter_ser_num {
            get {
                return ((string)(this["Electric_meter_ser_num"]));
            }
            set {
                this["Electric_meter_ser_num"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456")]
        public string Gas_meter_ser_num {
            get {
                return ((string)(this["Gas_meter_ser_num"]));
            }
            set {
                this["Gas_meter_ser_num"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Dual_fuel {
            get {
                return ((bool)(this["Dual_fuel"]));
            }
            set {
                this["Dual_fuel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Electrcity {
            get {
                return ((bool)(this["Electrcity"]));
            }
            set {
                this["Electrcity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Gas {
            get {
                return ((bool)(this["Gas"]));
            }
            set {
                this["Gas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2023-06-25")]
        public global::System.DateTime Date_from {
            get {
                return ((global::System.DateTime)(this["Date_from"]));
            }
            set {
                this["Date_from"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00")]
        public string Hour_from {
            get {
                return ((string)(this["Hour_from"]));
            }
            set {
                this["Hour_from"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00")]
        public string Minutes_from {
            get {
                return ((string)(this["Minutes_from"]));
            }
            set {
                this["Minutes_from"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2023-06-26")]
        public global::System.DateTime Date_to {
            get {
                return ((global::System.DateTime)(this["Date_to"]));
            }
            set {
                this["Date_to"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00")]
        public string Hour_to {
            get {
                return ((string)(this["Hour_to"]));
            }
            set {
                this["Hour_to"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00")]
        public string Minutes_to {
            get {
                return ((string)(this["Minutes_to"]));
            }
            set {
                this["Minutes_to"] = value;
            }
        }
    }
}
