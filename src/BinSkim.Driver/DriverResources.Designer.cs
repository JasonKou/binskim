﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.BinSkim {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DriverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DriverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.BinSkim.DriverResources", typeof(DriverResources).Assembly);
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
        ///   Looks up a localized string similar to Analyzing {0}....
        /// </summary>
        internal static string Analyzing {
            get {
                return ResourceManager.GetString("Analyzing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised attempting to create output file &apos;{0}&apos;. Exception information:
        ///{1}.
        /// </summary>
        internal static string ExceptionCreatingLogFile {
            get {
                return ResourceManager.GetString("ExceptionCreatingLogFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised attempting to load analysis target &apos;{0}&apos;. Exception information:
        ///{1}.
        /// </summary>
        internal static string ExceptionLoadingAnalysisTarget {
            get {
                return ResourceManager.GetString("ExceptionLoadingAnalysisTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzer paths specified.
        /// </summary>
        internal static string NoAnalyzerPathsSpecified {
            get {
                return ResourceManager.GetString("NoAnalyzerPathsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application exited unexpectedly..
        /// </summary>
        internal static string UnexpectedApplicationExit {
            get {
                return ResourceManager.GetString("UnexpectedApplicationExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception was raised attempting to determine whether &apos;{0}&apos; is a valid analysis target for check &apos;{1}&apos; (which has been disabled for the remainder of the analysis). The exception may have resulted from a problem related to parsing image metadata and not specific to the rule, however. Exception information:
        ///{2}.
        /// </summary>
        internal static string UnhandledExceptionCheckingApplicability {
            get {
                return ResourceManager.GetString("UnhandledExceptionCheckingApplicability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception was raised initializing check &apos;{0}&apos; (which has been disabled for the remainder of the analysis). Exception information:
        ///{1}.
        /// </summary>
        internal static string UnhandledExceptionInitializingRule {
            get {
                return ResourceManager.GetString("UnhandledExceptionInitializingRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised attempting to load Roslyn analyzer &apos;{0}&apos;. Exception information:
        ///{1}.
        /// </summary>
        internal static string UnhandledExceptionLoadingRoslynAnalyzer {
            get {
                return ResourceManager.GetString("UnhandledExceptionLoadingRoslynAnalyzer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception was raised analyzing &apos;{0}&apos; for check &apos;{1}&apos; (which has been disabled for the remainder of the analysis). The exception may have resulted from a problem related to parsing image metadata and not specific to the rule, however. Exception information:
        ///{2}.
        /// </summary>
        internal static string UnhandledRuleExceptionAnalyzingTarget {
            get {
                return ResourceManager.GetString("UnhandledRuleExceptionAnalyzingTarget", resourceCulture);
            }
        }
    }
}
