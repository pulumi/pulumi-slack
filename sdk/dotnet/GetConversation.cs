// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Slack.GetConversation.Invoke(new()
        ///     {
        ///         ChannelId = "my-channel",
        ///     });
        /// 
        ///     var test_name = Slack.GetConversation.Invoke(new()
        ///     {
        ///         Name = "my-channel-name",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetConversationResult> InvokeAsync(GetConversationArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetConversationResult>("slack:index/getConversation:getConversation", args ?? new GetConversationArgs(), options.WithDefaults());

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
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Slack.GetConversation.Invoke(new()
        ///     {
        ///         ChannelId = "my-channel",
        ///     });
        /// 
        ///     var test_name = Slack.GetConversation.Invoke(new()
        ///     {
        ///         Name = "my-channel-name",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetConversationResult> Invoke(GetConversationInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetConversationResult>("slack:index/getConversation:getConversation", args ?? new GetConversationInvokeArgs(), options.WithDefaults());

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
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Slack.GetConversation.Invoke(new()
        ///     {
        ///         ChannelId = "my-channel",
        ///     });
        /// 
        ///     var test_name = Slack.GetConversation.Invoke(new()
        ///     {
        ///         Name = "my-channel-name",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetConversationResult> Invoke(GetConversationInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetConversationResult>("slack:index/getConversation:getConversation", args ?? new GetConversationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConversationArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the channel
        /// </summary>
        [Input("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// The conversation is privileged between two or more members
        /// 
        /// Either `channel_id` or `name` must be provided. `is_private` only works in conjunction
        /// with `name`.
        /// </summary>
        [Input("isPrivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// The name of the public or private channel
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetConversationArgs()
        {
        }
        public static new GetConversationArgs Empty => new GetConversationArgs();
    }

    public sealed class GetConversationInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the channel
        /// </summary>
        [Input("channelId")]
        public Input<string>? ChannelId { get; set; }

        /// <summary>
        /// The conversation is privileged between two or more members
        /// 
        /// Either `channel_id` or `name` must be provided. `is_private` only works in conjunction
        /// with `name`.
        /// </summary>
        [Input("isPrivate")]
        public Input<bool>? IsPrivate { get; set; }

        /// <summary>
        /// The name of the public or private channel
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetConversationInvokeArgs()
        {
        }
        public static new GetConversationInvokeArgs Empty => new GetConversationInvokeArgs();
    }


    [OutputType]
    public sealed class GetConversationResult
    {
        public readonly string? ChannelId;
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
        public readonly bool? IsPrivate;
        /// <summary>
        /// means the conversation is in some way shared between multiple workspaces.
        /// </summary>
        public readonly bool IsShared;
        /// <summary>
        /// name of the public or private channel.
        /// </summary>
        public readonly string? Name;
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
            string? channelId,

            int created,

            string creator,

            string id,

            bool isArchived,

            bool isExtShared,

            bool isGeneral,

            bool isOrgShared,

            bool? isPrivate,

            bool isShared,

            string? name,

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
