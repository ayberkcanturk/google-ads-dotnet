// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/shared_criterion_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage shared criteria.
  /// </summary>
  public static partial class SharedCriterionService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.SharedCriterionService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest> __Marshaller_google_ads_googleads_v0_services_GetSharedCriterionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion> __Marshaller_google_ads_googleads_v0_resources_SharedCriterion = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest> __Marshaller_google_ads_googleads_v0_services_MutateSharedCriteriaRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse> __Marshaller_google_ads_googleads_v0_services_MutateSharedCriteriaResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest, global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion> __Method_GetSharedCriterion = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest, global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSharedCriterion",
        __Marshaller_google_ads_googleads_v0_services_GetSharedCriterionRequest,
        __Marshaller_google_ads_googleads_v0_resources_SharedCriterion);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest, global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse> __Method_MutateSharedCriteria = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest, global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateSharedCriteria",
        __Marshaller_google_ads_googleads_v0_services_MutateSharedCriteriaRequest,
        __Marshaller_google_ads_googleads_v0_services_MutateSharedCriteriaResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.SharedCriterionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SharedCriterionService</summary>
    public abstract partial class SharedCriterionServiceBase
    {
      /// <summary>
      /// Returns the requested shared criterion in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion> GetSharedCriterion(global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes shared criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse> MutateSharedCriteria(global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SharedCriterionService</summary>
    public partial class SharedCriterionServiceClient : grpc::ClientBase<SharedCriterionServiceClient>
    {
      /// <summary>Creates a new client for SharedCriterionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SharedCriterionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SharedCriterionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SharedCriterionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SharedCriterionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SharedCriterionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested shared criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion GetSharedCriterion(global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSharedCriterion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested shared criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion GetSharedCriterion(global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSharedCriterion, null, options, request);
      }
      /// <summary>
      /// Returns the requested shared criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion> GetSharedCriterionAsync(global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSharedCriterionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested shared criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.SharedCriterion> GetSharedCriterionAsync(global::Google.Ads.GoogleAds.V0.Services.GetSharedCriterionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSharedCriterion, null, options, request);
      }
      /// <summary>
      /// Creates or removes shared criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse MutateSharedCriteria(global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateSharedCriteria(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes shared criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse MutateSharedCriteria(global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateSharedCriteria, null, options, request);
      }
      /// <summary>
      /// Creates or removes shared criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateSharedCriteriaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes shared criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(global::Google.Ads.GoogleAds.V0.Services.MutateSharedCriteriaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateSharedCriteria, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SharedCriterionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SharedCriterionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SharedCriterionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSharedCriterion, serviceImpl.GetSharedCriterion)
          .AddMethod(__Method_MutateSharedCriteria, serviceImpl.MutateSharedCriteria).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SharedCriterionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSharedCriterion, serviceImpl.GetSharedCriterion);
      serviceBinder.AddMethod(__Method_MutateSharedCriteria, serviceImpl.MutateSharedCriteria);
    }

  }
}
#endregion
