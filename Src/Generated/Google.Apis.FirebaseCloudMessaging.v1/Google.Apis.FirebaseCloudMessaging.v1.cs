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
 *   Firebase Cloud Messaging API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://firebase.google.com/docs/cloud-messaging'>Firebase Cloud Messaging API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20190610 (1621)
 *      <tr><th>API Docs
 *          <td><a href='https://firebase.google.com/docs/cloud-messaging'>
 *              https://firebase.google.com/docs/cloud-messaging</a>
 *      <tr><th>Discovery Name<td>fcm
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Firebase Cloud Messaging API can be found at
 * <a href='https://firebase.google.com/docs/cloud-messaging'>https://firebase.google.com/docs/cloud-messaging</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.FirebaseCloudMessaging.v1
{
    /// <summary>The FirebaseCloudMessaging Service.</summary>
    public class FirebaseCloudMessagingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseCloudMessagingService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseCloudMessagingService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "fcm"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://fcm.googleapis.com/"; }
        #else
            get { return "https://fcm.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://fcm.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Cloud Messaging API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Cloud Messaging API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        private readonly ProjectsResource projects;

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects
        {
            get { return projects; }
        }
    }

    ///<summary>A base abstract class for FirebaseCloudMessaging requests.</summary>
    public abstract class FirebaseCloudMessagingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new FirebaseCloudMessagingBaseServiceRequest instance.</summary>
        protected FirebaseCloudMessagingBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

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

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes FirebaseCloudMessaging parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            messages = new MessagesResource(service);

        }

        private readonly MessagesResource messages;

        /// <summary>Gets the Messages resource.</summary>
        public virtual MessagesResource Messages
        {
            get { return messages; }
        }

        /// <summary>The "messages" collection of methods.</summary>
        public class MessagesResource
        {
            private const string Resource = "messages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MessagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Send a message to specified target (a registration token, topic or condition).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. It contains the Firebase project id (i.e. the unique identifier for your Firebase
            /// project), in the format of `projects/{project_id}`. For legacy support, the numeric project number with no padding
            /// is also supported in the format of `projects/{project_number}`.</param>
            public virtual SendRequest Send(Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest body, string parent)
            {
                return new SendRequest(service, body, parent);
            }

            /// <summary>Send a message to specified target (a registration token, topic or condition).</summary>
            public class SendRequest : FirebaseCloudMessagingBaseServiceRequest<Google.Apis.FirebaseCloudMessaging.v1.Data.Message>
            {
                /// <summary>Constructs a new Send request.</summary>
                public SendRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. It contains the Firebase project id (i.e. the unique identifier for your Firebase
                /// project), in the format of `projects/{project_id}`. For legacy support, the numeric project number
                /// with no padding is also supported in the format of `projects/{project_number}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() { return Body; }

                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "send"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "POST"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/{+parent}/messages:send"; }
                }

                /// <summary>Initializes Send parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                }

            }
        }
    }
}

namespace Google.Apis.FirebaseCloudMessaging.v1.Data
{    

    /// <summary>Android specific options for messages sent through [FCM connection
    /// server](https://goo.gl/4GLdUl).</summary>
    public class AndroidConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An identifier of a group of messages that can be collapsed, so that only the last message gets sent
        /// when delivery can be resumed. A maximum of 4 different collapse keys is allowed at any given time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapseKey")]
        public virtual string CollapseKey { get; set; } 

        /// <summary>Arbitrary key/value payload. If present, it will override
        /// google.firebase.fcm.v1.Message.data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string,string> Data { get; set; } 

        /// <summary>Options for features provided by the FCM SDK for Android.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual AndroidFcmOptions FcmOptions { get; set; } 

        /// <summary>Notification to send to android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual AndroidNotification Notification { get; set; } 

        /// <summary>Message priority. Can take "normal" and "high" values. For more information, see [Setting the
        /// priority of a message](https://goo.gl/GjONJv).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; } 

        /// <summary>Package name of the application where the registration token must match in order to receive the
        /// message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedPackageName")]
        public virtual string RestrictedPackageName { get; set; } 

        /// <summary>How long (in seconds) the message should be kept in FCM storage if the device is offline. The
        /// maximum time to live supported is 4 weeks, and the default value is 4 weeks if not set. Set it to 0 if want
        /// to send the message immediately. In JSON format, the Duration type is encoded as a string rather than an
        /// object, where the string ends in the suffix "s" (indicating seconds) and is preceded by the number of
        /// seconds, with nanoseconds expressed as fractional seconds. For example, 3 seconds with 0 nanoseconds should
        /// be encoded in JSON format as "3s", while 3 seconds and 1 nanosecond should be expressed in JSON format as
        /// "3.000000001s". The ttl will be rounded down to the nearest second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options for features provided by the FCM SDK for Android.</summary>
    public class AndroidFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label that the message's analytics data will be associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Notification to send to android devices.</summary>
    public class AndroidNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notification's body text. If present, it will override
        /// google.firebase.fcm.v1.Notification.body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; } 

        /// <summary>Variable string values to be used in place of the format specifiers in body_loc_key to use to
        /// localize the body text to the user's current localization. See [Formatting and
        /// Styling](https://goo.gl/MalYE3) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLocArgs")]
        public virtual System.Collections.Generic.IList<string> BodyLocArgs { get; set; } 

        /// <summary>The key to the body string in the app's string resources to use to localize the body text to the
        /// user's current localization. See [String Resources](https://goo.gl/NdFZGI) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLocKey")]
        public virtual string BodyLocKey { get; set; } 

        /// <summary>The [notification's channel
        /// id](https://developer.android.com/guide/topics/ui/notifiers/notifications#ManageChannels) (new in Android
        /// O). The app must create a channel with this channel ID before any notification with this channel ID is
        /// received. If you don't send this channel ID in the request, or if the channel ID provided has not yet been
        /// created by the app, FCM uses the channel ID specified in the app manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; } 

        /// <summary>The action associated with a user click on the notification. If specified, an activity with a
        /// matching intent filter is launched when a user clicks on the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickAction")]
        public virtual string ClickAction { get; set; } 

        /// <summary>The notification's icon color, expressed in #rrggbb format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; } 

        /// <summary>The notification's icon. Sets the notification icon to myicon for drawable resource myicon. If you
        /// don't send this key in the request, FCM displays the launcher icon specified in your app manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; } 

        /// <summary>The sound to play when the device receives the notification. Supports "default" or the filename of
        /// a sound resource bundled in the app. Sound files must reside in /res/raw/.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sound")]
        public virtual string Sound { get; set; } 

        /// <summary>Identifier used to replace existing notifications in the notification drawer. If not specified,
        /// each request creates a new notification. If specified and a notification with the same tag is already being
        /// shown, the new notification replaces the existing one in the notification drawer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; } 

        /// <summary>The notification's title. If present, it will override
        /// google.firebase.fcm.v1.Notification.title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Variable string values to be used in place of the format specifiers in title_loc_key to use to
        /// localize the title text to the user's current localization. See [Formatting and
        /// Styling](https://goo.gl/MalYE3) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleLocArgs")]
        public virtual System.Collections.Generic.IList<string> TitleLocArgs { get; set; } 

        /// <summary>The key to the title string in the app's string resources to use to localize the title text to the
        /// user's current localization. See [String Resources](https://goo.gl/NdFZGI) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleLocKey")]
        public virtual string TitleLocKey { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>[Apple Push Notification Service](https://goo.gl/MXRTPa) specific options.</summary>
    public class ApnsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for features provided by the FCM SDK for iOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual ApnsFcmOptions FcmOptions { get; set; } 

        /// <summary>HTTP request headers defined in Apple Push Notification Service. Refer to [APNs request
        /// headers](https://goo.gl/C6Yhia) for supported headers, e.g. "apns-priority": "10".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string,string> Headers { get; set; } 

        /// <summary>APNs payload as a JSON object, including both `aps` dictionary and custom payload. See [Payload Key
        /// Reference](https://goo.gl/32Pl5W). If present, it overrides google.firebase.fcm.v1.Notification.title and
        /// google.firebase.fcm.v1.Notification.body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options for features provided by the FCM SDK for iOS.</summary>
    public class ApnsFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label that the message's analytics data will be associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Platform independent options for features provided by the FCM SDKs.</summary>
    public class FcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label that the message's analytics data will be associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Message to send by Firebase Cloud Messaging Service.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Android specific options for messages sent through [FCM connection
        /// server](https://goo.gl/4GLdUl).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("android")]
        public virtual AndroidConfig Android { get; set; } 

        /// <summary>Input only. [Apple Push Notification Service](https://goo.gl/MXRTPa) specific options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apns")]
        public virtual ApnsConfig Apns { get; set; } 

        /// <summary>Condition to send a message to, e.g. "'foo' in topics && 'bar' in topics".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>Input only. Arbitrary key/value payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string,string> Data { get; set; } 

        /// <summary>Input only. Template for FCM SDK feature options to use across all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual FcmOptions FcmOptions { get; set; } 

        /// <summary>Output Only. The identifier of the message sent, in the format of
        /// `projects/messages/{message_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Input only. Basic notification template to use across all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual Notification Notification { get; set; } 

        /// <summary>Registration token to send a message to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; } 

        /// <summary>Topic name to send a message to, e.g. "weather". Note: "/topics/" prefix should not be
        /// provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; } 

        /// <summary>Input only. [Webpush protocol](https://tools.ietf.org/html/rfc8030) options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webpush")]
        public virtual WebpushConfig Webpush { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Basic notification template to use across all platforms.</summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notification's body text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; } 

        /// <summary>The notification's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request to send a message to specified target.</summary>
    public class SendMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Message to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; } 

        /// <summary>Flag for testing the request without actually delivering the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>[Webpush protocol](https://tools.ietf.org/html/rfc8030) options.</summary>
    public class WebpushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arbitrary key/value payload. If present, it will override
        /// google.firebase.fcm.v1.Message.data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string,string> Data { get; set; } 

        /// <summary>Options for features provided by the FCM SDK for Web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual WebpushFcmOptions FcmOptions { get; set; } 

        /// <summary>HTTP headers defined in webpush protocol. Refer to [Webpush
        /// protocol](https://tools.ietf.org/html/rfc8030#section-5) for supported headers, e.g. "TTL": "15".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string,string> Headers { get; set; } 

        /// <summary>Web Notification options as a JSON object. Supports Notification instance properties as defined in
        /// [Web Notification API](https://developer.mozilla.org/en-US/docs/Web/API/Notification). If present, "title"
        /// and "body" fields override [google.firebase.fcm.v1.Notification.title] and
        /// [google.firebase.fcm.v1.Notification.body].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual System.Collections.Generic.IDictionary<string,object> Notification { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options for features provided by the FCM SDK for Web.</summary>
    public class WebpushFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The link to open when the user clicks on the notification. For all URL values, HTTPS is
        /// required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
