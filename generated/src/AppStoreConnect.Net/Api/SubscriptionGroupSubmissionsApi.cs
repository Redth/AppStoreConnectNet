/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using AppStoreConnect.Client;
using AppStoreConnect.Model;

namespace AppStoreConnect.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionGroupSubmissionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <returns>SubscriptionGroupSubmissionResponse</returns>
        SubscriptionGroupSubmissionResponse SubscriptionGroupSubmissionsCreateInstance(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <returns>ApiResponse of SubscriptionGroupSubmissionResponse</returns>
        ApiResponse<SubscriptionGroupSubmissionResponse> SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionGroupSubmissionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionGroupSubmissionResponse</returns>
        System.Threading.Tasks.Task<SubscriptionGroupSubmissionResponse> SubscriptionGroupSubmissionsCreateInstanceAsync(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionGroupSubmissionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionGroupSubmissionResponse>> SubscriptionGroupSubmissionsCreateInstanceWithHttpInfoAsync(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionGroupSubmissionsApi : ISubscriptionGroupSubmissionsApiSync, ISubscriptionGroupSubmissionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionGroupSubmissionsApi : IDisposable, ISubscriptionGroupSubmissionsApi
    {
        private AppStoreConnect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SubscriptionGroupSubmissionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SubscriptionGroupSubmissionsApi(string basePath)
        {
            this.Configuration = AppStoreConnect.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Client.GlobalConfiguration.Instance,
                new AppStoreConnect.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new AppStoreConnect.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = AppStoreConnect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SubscriptionGroupSubmissionsApi(AppStoreConnect.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AppStoreConnect.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new AppStoreConnect.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = AppStoreConnect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SubscriptionGroupSubmissionsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SubscriptionGroupSubmissionsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = AppStoreConnect.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Client.GlobalConfiguration.Instance,
                new AppStoreConnect.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new AppStoreConnect.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = AppStoreConnect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SubscriptionGroupSubmissionsApi(HttpClient client, AppStoreConnect.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = AppStoreConnect.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new AppStoreConnect.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = AppStoreConnect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubmissionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SubscriptionGroupSubmissionsApi(AppStoreConnect.Client.ISynchronousClient client, AppStoreConnect.Client.IAsynchronousClient asyncClient, AppStoreConnect.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AppStoreConnect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public AppStoreConnect.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AppStoreConnect.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AppStoreConnect.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AppStoreConnect.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AppStoreConnect.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <returns>SubscriptionGroupSubmissionResponse</returns>
        public SubscriptionGroupSubmissionResponse SubscriptionGroupSubmissionsCreateInstance(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest)
        {
            AppStoreConnect.Client.ApiResponse<SubscriptionGroupSubmissionResponse> localVarResponse = SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo(subscriptionGroupSubmissionCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <returns>ApiResponse of SubscriptionGroupSubmissionResponse</returns>
        public AppStoreConnect.Client.ApiResponse<SubscriptionGroupSubmissionResponse> SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest)
        {
            // verify the required parameter 'subscriptionGroupSubmissionCreateRequest' is set
            if (subscriptionGroupSubmissionCreateRequest == null)
                throw new AppStoreConnect.Client.ApiException(400, "Missing required parameter 'subscriptionGroupSubmissionCreateRequest' when calling SubscriptionGroupSubmissionsApi->SubscriptionGroupSubmissionsCreateInstance");

            AppStoreConnect.Client.RequestOptions localVarRequestOptions = new AppStoreConnect.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AppStoreConnect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AppStoreConnect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = subscriptionGroupSubmissionCreateRequest;

            // authentication (itc-bearer-token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SubscriptionGroupSubmissionResponse>("/v1/subscriptionGroupSubmissions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubscriptionGroupSubmissionsCreateInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionGroupSubmissionResponse</returns>
        public async System.Threading.Tasks.Task<SubscriptionGroupSubmissionResponse> SubscriptionGroupSubmissionsCreateInstanceAsync(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AppStoreConnect.Client.ApiResponse<SubscriptionGroupSubmissionResponse> localVarResponse = await SubscriptionGroupSubmissionsCreateInstanceWithHttpInfoAsync(subscriptionGroupSubmissionCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionGroupSubmissionCreateRequest">SubscriptionGroupSubmission representation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionGroupSubmissionResponse)</returns>
        public async System.Threading.Tasks.Task<AppStoreConnect.Client.ApiResponse<SubscriptionGroupSubmissionResponse>> SubscriptionGroupSubmissionsCreateInstanceWithHttpInfoAsync(SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'subscriptionGroupSubmissionCreateRequest' is set
            if (subscriptionGroupSubmissionCreateRequest == null)
                throw new AppStoreConnect.Client.ApiException(400, "Missing required parameter 'subscriptionGroupSubmissionCreateRequest' when calling SubscriptionGroupSubmissionsApi->SubscriptionGroupSubmissionsCreateInstance");


            AppStoreConnect.Client.RequestOptions localVarRequestOptions = new AppStoreConnect.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = AppStoreConnect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AppStoreConnect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = subscriptionGroupSubmissionCreateRequest;

            // authentication (itc-bearer-token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<SubscriptionGroupSubmissionResponse>("/v1/subscriptionGroupSubmissions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubscriptionGroupSubmissionsCreateInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
