// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.40.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   PageSpeed Insights API Version v5
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/speed/docs/insights/v5/get-started'>PageSpeed Insights API</a>
 *      <tr><th>API Version<td>v5
 *      <tr><th>API Rev<td>20190507 (1587)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/speed/docs/insights/v5/get-started'>
 *              https://developers.google.com/speed/docs/insights/v5/get-started</a>
 *      <tr><th>Discovery Name<td>pagespeedonline
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using PageSpeed Insights API can be found at
 * <a href='https://developers.google.com/speed/docs/insights/v5/get-started'>https://developers.google.com/speed/docs/insights/v5/get-started</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Pagespeedonline.v5
{
    /// <summary>The Pagespeedonline Service.</summary>
    public class PagespeedonlineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v5";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PagespeedonlineService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PagespeedonlineService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            pagespeedapi = new PagespeedapiResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "pagespeedonline"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://www.googleapis.com/pagespeedonline/v5/"; }
        #else
            get { return "https://www.googleapis.com/pagespeedonline/v5/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "pagespeedonline/v5/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch/pagespeedonline/v5"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch/pagespeedonline/v5"; }
        }
        #endif





        private readonly PagespeedapiResource pagespeedapi;

        /// <summary>Gets the Pagespeedapi resource.</summary>
        public virtual PagespeedapiResource Pagespeedapi
        {
            get { return pagespeedapi; }
        }
    }

    ///<summary>A base abstract class for Pagespeedonline requests.</summary>
    public abstract class PagespeedonlineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new PagespeedonlineBaseServiceRequest instance.</summary>
        protected PagespeedonlineBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Pagespeedonline parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "pagespeedapi" collection of methods.</summary>
    public class PagespeedapiResource
    {
        private const string Resource = "pagespeedapi";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PagespeedapiResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Runs PageSpeed analysis on the page at the specified URL, and returns PageSpeed scores, a list of
        /// suggestions to make that page faster, and other information.</summary>
        /// <param name="url">The URL to fetch and analyze</param>
        public virtual RunpagespeedRequest Runpagespeed(string url)
        {
            return new RunpagespeedRequest(service, url);
        }

        /// <summary>Runs PageSpeed analysis on the page at the specified URL, and returns PageSpeed scores, a list of
        /// suggestions to make that page faster, and other information.</summary>
        public class RunpagespeedRequest : PagespeedonlineBaseServiceRequest<Google.Apis.Pagespeedonline.v5.Data.PagespeedApiPagespeedResponseV5>
        {
            /// <summary>Constructs a new Runpagespeed request.</summary>
            public RunpagespeedRequest(Google.Apis.Services.IClientService service, string url)
                : base(service)
            {
                Url = url;
                InitParameters();
            }


            /// <summary>The URL to fetch and analyze</summary>
            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; private set; }

            /// <summary>A Lighthouse category to run; if none are given, only Performance category will be
            /// run</summary>
            [Google.Apis.Util.RequestParameterAttribute("category", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CategoryEnum> Category { get; set; }

            /// <summary>A Lighthouse category to run; if none are given, only Performance category will be
            /// run</summary>
            public enum CategoryEnum
            {
                [Google.Apis.Util.StringValueAttribute("accessibility")]
                Accessibility,
                [Google.Apis.Util.StringValueAttribute("best-practices")]
                BestPractices,
                [Google.Apis.Util.StringValueAttribute("performance")]
                Performance,
                [Google.Apis.Util.StringValueAttribute("pwa")]
                Pwa,
                [Google.Apis.Util.StringValueAttribute("seo")]
                Seo,
            }

            /// <summary>The locale used to localize formatted results</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>The analysis strategy (desktop or mobile) to use, and desktop is the default</summary>
            [Google.Apis.Util.RequestParameterAttribute("strategy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StrategyEnum> Strategy { get; set; }

            /// <summary>The analysis strategy (desktop or mobile) to use, and desktop is the default</summary>
            public enum StrategyEnum
            {
                /// <summary>Fetch and analyze the URL for desktop browsers</summary>
                [Google.Apis.Util.StringValueAttribute("desktop")]
                Desktop,
                /// <summary>Fetch and analyze the URL for mobile devices</summary>
                [Google.Apis.Util.StringValueAttribute("mobile")]
                Mobile,
            }

            /// <summary>Campaign name for analytics.</summary>
            [Google.Apis.Util.RequestParameterAttribute("utm_campaign", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UtmCampaign { get; set; }

            /// <summary>Campaign source for analytics.</summary>
            [Google.Apis.Util.RequestParameterAttribute("utm_source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UtmSource { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "runpagespeed"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "runPagespeed"; }
            }

            /// <summary>Initializes Runpagespeed parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "url", new Google.Apis.Discovery.Parameter
                    {
                        Name = "url",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(?i)http(s)?://.*",
                    });
                RequestParameters.Add(
                    "category", new Google.Apis.Discovery.Parameter
                    {
                        Name = "category",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z]+((_|-)[a-zA-Z]+)?",
                    });
                RequestParameters.Add(
                    "strategy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "strategy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "utm_campaign", new Google.Apis.Discovery.Parameter
                    {
                        Name = "utm_campaign",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "utm_source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "utm_source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Pagespeedonline.v5.Data
{    

    public class LighthouseAuditResultV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Freeform details section of the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string,object> Details { get; set; } 

        /// <summary>The value that should be displayed on the UI for this audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayValue")]
        public virtual string DisplayValue { get; set; } 

        /// <summary>An error message from a thrown error inside the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; } 

        /// <summary>An explanation of the errors in the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; } 

        /// <summary>The audit's id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual object Score { get; set; } 

        /// <summary>The enumerated score display mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreDisplayMode")]
        public virtual string ScoreDisplayMode { get; set; } 

        /// <summary>The human readable title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual object Warnings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LighthouseCategoryV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of references to all the audit members of this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditRefs")]
        public virtual System.Collections.Generic.IList<LighthouseCategoryV5.AuditRefsData> AuditRefs { get; set; } 

        /// <summary>A more detailed description of the category and its importance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The string identifier of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>A description for the manual audits in the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualDescription")]
        public virtual string ManualDescription { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual object Score { get; set; } 

        /// <summary>The human-friendly name of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class AuditRefsData
        {
            /// <summary>The category group that the audit belongs to (optional).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("group")]
            public virtual string Group { get; set; } 

            /// <summary>The audit ref id.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The weight this audit's score has on the overall category score.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("weight")]
            public virtual System.Nullable<double> Weight { get; set; } 

        }
    }    

    public class LighthouseResultV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of audits in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audits")]
        public virtual System.Collections.Generic.IDictionary<string,LighthouseAuditResultV5> Audits { get; set; } 

        /// <summary>Map of categories in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual LighthouseResultV5.CategoriesData Categories { get; set; } 

        /// <summary>Map of category groups in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryGroups")]
        public virtual System.Collections.Generic.IDictionary<string,LighthouseResultV5.CategoryGroupsDataElement> CategoryGroups { get; set; } 

        /// <summary>The configuration settings for this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSettings")]
        public virtual LighthouseResultV5.ConfigSettingsData ConfigSettings { get; set; } 

        /// <summary>Environment settings that were used when making this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual LighthouseResultV5.EnvironmentData Environment { get; set; } 

        /// <summary>The time that this run was fetched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchTime")]
        public virtual string FetchTime { get; set; } 

        /// <summary>The final resolved url that was audited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrl")]
        public virtual string FinalUrl { get; set; } 

        /// <summary>The internationalization strings that are required to render the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("i18n")]
        public virtual LighthouseResultV5.I18nData I18n { get; set; } 

        /// <summary>The lighthouse version that was used to generate this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lighthouseVersion")]
        public virtual string LighthouseVersion { get; set; } 

        /// <summary>The original requested url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedUrl")]
        public virtual string RequestedUrl { get; set; } 

        /// <summary>List of all run warnings in the LHR. Will always output to at least `[]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runWarnings")]
        public virtual System.Collections.Generic.IList<object> RunWarnings { get; set; } 

        /// <summary>A top-level error message that, if present, indicates a serious enough problem that this Lighthouse
        /// result may need to be discarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeError")]
        public virtual LighthouseResultV5.RuntimeErrorData RuntimeError { get; set; } 

        /// <summary>The Stack Pack advice strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackPacks")]
        public virtual System.Collections.Generic.IList<LighthouseResultV5.StackPacksData> StackPacks { get; set; } 

        /// <summary>Timing information for this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual LighthouseResultV5.TimingData Timing { get; set; } 

        /// <summary>The user agent that was used to run this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>Map of categories in the LHR.</summary>
        public class CategoriesData
        {
            /// <summary>The accessibility category, containing all accessibility related audits.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accessibility")]
            public virtual LighthouseCategoryV5 Accessibility { get; set; } 

            /// <summary>The best practices category, containing all web best practice related audits.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("best-practices")]
            public virtual LighthouseCategoryV5 BestPractices { get; set; } 

            /// <summary>The performance category, containing all performance related audits.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("performance")]
            public virtual LighthouseCategoryV5 Performance { get; set; } 

            /// <summary>The Progressive-Web-App (PWA) category, containing all pwa related audits.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("pwa")]
            public virtual LighthouseCategoryV5 Pwa { get; set; } 

            /// <summary>The Search-Engine-Optimization (SEO) category, containing all seo related audits.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("seo")]
            public virtual LighthouseCategoryV5 Seo { get; set; } 

        }    

        /// <summary>A grouping contained in a category that groups similar audits together.</summary>
        public class CategoryGroupsDataElement
        {
            /// <summary>An optional human readable description of the category group.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; } 

            /// <summary>The title of the category group.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; } 

        }    

        /// <summary>The configuration settings for this LHR.</summary>
        public class ConfigSettingsData
        {
            /// <summary>The form factor the emulation should use.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("emulatedFormFactor")]
            public virtual string EmulatedFormFactor { get; set; } 

            /// <summary>The locale setting.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("locale")]
            public virtual string Locale { get; set; } 

            [Newtonsoft.Json.JsonPropertyAttribute("onlyCategories")]
            public virtual object OnlyCategories { get; set; } 

        }    

        /// <summary>Environment settings that were used when making this LHR.</summary>
        public class EnvironmentData
        {
            /// <summary>The benchmark index number that indicates rough device class.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("benchmarkIndex")]
            public virtual System.Nullable<double> BenchmarkIndex { get; set; } 

            /// <summary>The user agent string of the version of Chrome used.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("hostUserAgent")]
            public virtual string HostUserAgent { get; set; } 

            /// <summary>The user agent string that was sent over the network.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("networkUserAgent")]
            public virtual string NetworkUserAgent { get; set; } 

        }    

        /// <summary>The internationalization strings that are required to render the LHR.</summary>
        public class I18nData
        {
            /// <summary>Internationalized strings that are formatted to the locale in configSettings.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rendererFormattedStrings")]
            public virtual I18nData.RendererFormattedStringsData RendererFormattedStrings { get; set; } 

            

            /// <summary>Internationalized strings that are formatted to the locale in configSettings.</summary>
            public class RendererFormattedStringsData
            {
                /// <summary>The tooltip text on an expandable chevron icon.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("auditGroupExpandTooltip")]
                public virtual string AuditGroupExpandTooltip { get; set; } 

                /// <summary>The label for the initial request in a critical request chain.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("crcInitialNavigation")]
                public virtual string CrcInitialNavigation { get; set; } 

                /// <summary>The label for values shown in the summary of critical request chains.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("crcLongestDurationLabel")]
                public virtual string CrcLongestDurationLabel { get; set; } 

                /// <summary>The label shown next to an audit or metric that has had an error.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("errorLabel")]
                public virtual string ErrorLabel { get; set; } 

                /// <summary>The error string shown next to an erroring audit.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("errorMissingAuditInfo")]
                public virtual string ErrorMissingAuditInfo { get; set; } 

                /// <summary>The title of the lab data performance category.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("labDataTitle")]
                public virtual string LabDataTitle { get; set; } 

                /// <summary>The disclaimer shown under performance explaning that the network can vary.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lsPerformanceCategoryDescription")]
                public virtual string LsPerformanceCategoryDescription { get; set; } 

                /// <summary>The heading shown above a list of audits that were not computerd in the run.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("manualAuditsGroupTitle")]
                public virtual string ManualAuditsGroupTitle { get; set; } 

                /// <summary>The heading shown above a list of audits that do not apply to a page.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("notApplicableAuditsGroupTitle")]
                public virtual string NotApplicableAuditsGroupTitle { get; set; } 

                /// <summary>The heading for the estimated page load savings opportunity of an audit.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("opportunityResourceColumnLabel")]
                public virtual string OpportunityResourceColumnLabel { get; set; } 

                /// <summary>The heading for the estimated page load savings of opportunity audits.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("opportunitySavingsColumnLabel")]
                public virtual string OpportunitySavingsColumnLabel { get; set; } 

                /// <summary>The heading that is shown above a list of audits that are passing.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("passedAuditsGroupTitle")]
                public virtual string PassedAuditsGroupTitle { get; set; } 

                /// <summary>The label that explains the score gauges scale (0-49, 50-89, 90-100).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("scorescaleLabel")]
                public virtual string ScorescaleLabel { get; set; } 

                /// <summary>The label shown preceding important warnings that may have invalidated an entire
                /// report.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("toplevelWarningsMessage")]
                public virtual string ToplevelWarningsMessage { get; set; } 

                /// <summary>The disclaimer shown below a performance metric value.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("varianceDisclaimer")]
                public virtual string VarianceDisclaimer { get; set; } 

                /// <summary>The label shown above a bulleted list of warnings.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("warningHeader")]
                public virtual string WarningHeader { get; set; } 

            }
        }    

        /// <summary>A top-level error message that, if present, indicates a serious enough problem that this Lighthouse
        /// result may need to be discarded.</summary>
        public class RuntimeErrorData
        {
            /// <summary>The enumerated Lighthouse Error code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; } 

            /// <summary>A human readable message explaining the error code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; } 

        }    

        public class StackPacksData
        {
            /// <summary>The stack pack advice strings.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("descriptions")]
            public virtual System.Collections.Generic.IDictionary<string,string> Descriptions { get; set; } 

            /// <summary>The stack pack icon data uri.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("iconDataURL")]
            public virtual string IconDataURL { get; set; } 

            /// <summary>The stack pack id.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; } 

            /// <summary>The stack pack title.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; } 

        }    

        /// <summary>Timing information for this LHR.</summary>
        public class TimingData
        {
            /// <summary>The total duration of Lighthouse's run.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("total")]
            public virtual System.Nullable<double> Total { get; set; } 

        }
    }    

    public class PagespeedApiLoadingExperienceV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The url, pattern or origin which the metrics are on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("initial_url")]
        public virtual string InitialUrl { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IDictionary<string,PagespeedApiLoadingExperienceV5.MetricsDataElement> Metrics { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("overall_category")]
        public virtual string OverallCategory { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>The type of the metric.</summary>
        public class MetricsDataElement
        {
            [Newtonsoft.Json.JsonPropertyAttribute("category")]
            public virtual string Category { get; set; } 

            [Newtonsoft.Json.JsonPropertyAttribute("distributions")]
            public virtual System.Collections.Generic.IList<MetricsDataElement.DistributionsData> Distributions { get; set; } 

            [Newtonsoft.Json.JsonPropertyAttribute("percentile")]
            public virtual System.Nullable<int> Percentile { get; set; } 

            

            public class DistributionsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("max")]
                public virtual System.Nullable<int> Max { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("min")]
                public virtual System.Nullable<int> Min { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("proportion")]
                public virtual System.Nullable<double> Proportion { get; set; } 

            }
        }
    }    

    public class PagespeedApiPagespeedResponseV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The UTC timestamp of this analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisUTCTimestamp")]
        public virtual string AnalysisUTCTimestamp { get; set; } 

        /// <summary>The captcha verify result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captchaResult")]
        public virtual string CaptchaResult { get; set; } 

        /// <summary>Canonicalized and final URL for the document, after following page redirects (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Kind of result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Lighthouse response for the audit url as an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lighthouseResult")]
        public virtual LighthouseResultV5 LighthouseResult { get; set; } 

        /// <summary>Metrics of end users' page loading experience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadingExperience")]
        public virtual PagespeedApiLoadingExperienceV5 LoadingExperience { get; set; } 

        /// <summary>Metrics of the aggregated page loading experience of the origin</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originLoadingExperience")]
        public virtual PagespeedApiLoadingExperienceV5 OriginLoadingExperience { get; set; } 

        /// <summary>The version of PageSpeed used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual PagespeedApiPagespeedResponseV5.VersionData Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>The version of PageSpeed used to generate these results.</summary>
        public class VersionData
        {
            /// <summary>The major version number of PageSpeed used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("major")]
            public virtual System.Nullable<int> Major { get; set; } 

            /// <summary>The minor version number of PageSpeed used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minor")]
            public virtual System.Nullable<int> Minor { get; set; } 

        }
    }
}
