// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Slack
{
    public static class GetConversation
    {
        /// <summary>
        /// Use this data source to get information about a Slack conversation for use in other
        /// resources.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
        /// - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [conversations.info](https://api.slack.com/methods/conversations.info)
        /// - [conversations.members](https://api.slack.com/methods/conversations.members)
        /// 
        /// If you get `missing_scope` errors while using this resource check the scopes against
        /// the documentation for the methods above.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var test = Output.Create(Slack.GetConversation.InvokeAsync(new Slack.GetConversationArgs
        ///         {
        ///             ChannelId = "my-channel",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetConversationResult> InvokeAsync(GetConversationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConversationResult>("slack:index/getConversation:getConversation", args ?? new GetConversationArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about a Slack conversation for use in other
        /// resources.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
        /// - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [conversations.info](https://api.slack.com/methods/conversations.info)
        /// - [conversations.members](https://api.slack.com/methods/conversations.members)
        /// 
        /// If you get `missing_scope` errors while using this resource check the scopes against
        /// the documentation for the methods above.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var test = Output.Create(Slack.GetConversation.InvokeAsync(new Slack.GetConversationArgs
        ///         {
        ///             ChannelId = "my-channel",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetConversationResult> Invoke(GetConversationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConversationResult>("slack:index/getConversation:getConversation", args ?? new GetConversationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConversationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the channel
        /// </summary>
        [Input("channelId", required: true)]
        public string ChannelId { get; set; } = null!;

        public GetConversationArgs()
        {
        }
    }

    public sealed class GetConversationInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the channel
        /// </summary>
        [Input("channelId", required: true)]
        public Input<string> ChannelId { get; set; } = null!;

        public GetConversationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConversationResult
    {
        public readonly string ChannelId;
        /// <summary>
        /// is a unix timestamp.
        /// </summary>
        public readonly int Created;
        /// <summary>
        /// is the user ID of the member that created this channel.
        /// </summary>
        public readonly string Creator;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// indicates a conversation is archived. Frozen in time.
        /// </summary>
        public readonly bool IsArchived;
        /// <summary>
        /// represents this conversation as being part of a Shared Channel
        /// with a remote organization.
        /// </summary>
        public readonly bool IsExtShared;
        /// <summary>
        /// will be true if this channel is the "general" channel that includes
        /// all regular team members.
        /// </summary>
        public readonly bool IsGeneral;
        /// <summary>
        /// explains whether this shared channel is shared between Enterprise
        /// Grid workspaces within the same organization.
        /// </summary>
        public readonly bool IsOrgShared;
        /// <summary>
        /// means the conversation is privileged between two or more members.
        /// </summary>
        public readonly bool IsPrivate;
        /// <summary>
        /// means the conversation is in some way shared between multiple workspaces.
        /// </summary>
        public readonly bool IsShared;
        /// <summary>
        /// name of the public or private channel.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// purpose of the channel.
        /// </summary>
        public readonly string Purpose;
        /// <summary>
        /// topic for the channel.
        /// </summary>
        public readonly string Topic;

        [OutputConstructor]
        private GetConversationResult(
            string channelId,

            int created,

            string creator,

            string id,

            bool isArchived,

            bool isExtShared,

            bool isGeneral,

            bool isOrgShared,

            bool isPrivate,

            bool isShared,

            string name,

            string purpose,

            string topic)
        {
            ChannelId = channelId;
            Created = created;
            Creator = creator;
            Id = id;
            IsArchived = isArchived;
            IsExtShared = isExtShared;
            IsGeneral = isGeneral;
            IsOrgShared = isOrgShared;
            IsPrivate = isPrivate;
            IsShared = isShared;
            Name = name;
            Purpose = purpose;
            Topic = topic;
        }
    }
}