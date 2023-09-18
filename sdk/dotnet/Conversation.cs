// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Slack
{
    /// <summary>
    /// Manages a Slack channel
    /// 
    /// ## Required scopes
    /// 
    /// This resource requires the following scopes:
    /// 
    /// If using `bot` tokens:
    /// 
    /// - [channels:read](https://api.slack.com/scopes/channels:read)
    ///   (public channels)
    /// - [channels:manage](https://api.slack.com/scopes/channels:manage)
    ///   (public channels)
    /// - [channels:join](https://api.slack.com/scopes/channels:join)
    ///   (adopting existing public channels)
    /// - [groups:read](https://api.slack.com/scopes/groups:read)
    ///   (private channels)
    /// - [groups:write](https://api.slack.com/scopes/groups:write)
    ///   (private channels)
    /// 
    /// If using `user` tokens:
    /// 
    /// - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
    /// - [channels:write](https://api.slack.com/scopes/channels:manage) (public channels)
    /// - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)
    /// - [groups:write](https://api.slack.com/scopes/groups:write) (private channels)
    /// 
    /// The Slack API methods used by the resource are:
    /// 
    /// - [conversations.create](https://api.slack.com/methods/conversations.create)
    /// - [conversations.join](https://api.slack.com/methods/conversations.join)
    /// - [conversations.setTopic](https://api.slack.com/methods/conversations.setTopic)
    /// - [conversations.setPurpose](https://api.slack.com/methods/conversations.setPurpose)
    /// - [conversations.info](https://api.slack.com/methods/conversations.info)
    /// - [conversations.members](https://api.slack.com/methods/conversations.members)
    /// - [conversations.kick](https://api.slack.com/methods/conversations.kick)
    /// - [conversations.invite](https://api.slack.com/methods/conversations.invite)
    /// - [conversations.rename](https://api.slack.com/methods/conversations.rename)
    /// - [conversations.archive](https://api.slack.com/methods/conversations.archive)
    /// - [conversations.unarchive](https://api.slack.com/methods/conversations.unarchive)
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
    ///     var test = new Slack.Conversation("test", new()
    ///     {
    ///         IsPrivate = true,
    ///         PermanentMembers = new[] {},
    ///         Topic = "The topic for my channel",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Slack = Pulumi.Slack;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var nonadmin = new Slack.Conversation("nonadmin", new()
    ///     {
    ///         ActionOnDestroy = "none",
    ///         IsPrivate = true,
    ///         PermanentMembers = new[] {},
    ///         Topic = "The channel won't be archived on destroy",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Slack = Pulumi.Slack;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var adopted = new Slack.Conversation("adopted", new()
    ///     {
    ///         ActionOnUpdatePermanentMembers = "none",
    ///         AdoptExistingChannel = true,
    ///         PermanentMembers = new[] {},
    ///         Topic = "Adopt existing, don't kick members",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// `slack_conversation` can be imported using the ID of the conversation/channel, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import slack:index/conversation:Conversation my_conversation C023X7QTFHQ
    /// ```
    /// </summary>
    [SlackResourceType("slack:index/conversation:Conversation")]
    public partial class Conversation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// indicates whether the
        /// conversation should be archived or left behind on destroy. Valid values are
        /// `archive | none`. Note that when set to `none` the conversation will be left
        /// as it is  and as a result any subsequent runs of pulumi up with the same
        /// name  will fail.
        /// </summary>
        [Output("actionOnDestroy")]
        public Output<string?> ActionOnDestroy { get; private set; } = null!;

        /// <summary>
        /// indicate
        /// whether the members should be kick of the channel when removed from
        /// `permanent_members`. When set to `none` the user are never kicked, this prevent
        /// a side effect on public channels where user that joined the channel are kicked.
        /// </summary>
        [Output("actionOnUpdatePermanentMembers")]
        public Output<string?> ActionOnUpdatePermanentMembers { get; private set; } = null!;

        [Output("adoptExistingChannel")]
        public Output<bool?> AdoptExistingChannel { get; private set; } = null!;

        /// <summary>
        /// is a unix timestamp.
        /// </summary>
        [Output("created")]
        public Output<int> Created { get; private set; } = null!;

        /// <summary>
        /// is the user ID of the member that created this channel.
        /// </summary>
        [Output("creator")]
        public Output<string> Creator { get; private set; } = null!;

        /// <summary>
        /// indicates a conversation is archived. Frozen in time.
        /// </summary>
        [Output("isArchived")]
        public Output<bool?> IsArchived { get; private set; } = null!;

        /// <summary>
        /// represents this conversation as being part of a Shared Channel
        /// with a remote organization.
        /// </summary>
        [Output("isExtShared")]
        public Output<bool> IsExtShared { get; private set; } = null!;

        /// <summary>
        /// will be true if this channel is the "general" channel that includes
        /// all regular team members.
        /// </summary>
        [Output("isGeneral")]
        public Output<bool> IsGeneral { get; private set; } = null!;

        /// <summary>
        /// explains whether this shared channel is shared between Enterprise
        /// Grid workspaces within the same organization.
        /// </summary>
        [Output("isOrgShared")]
        public Output<bool> IsOrgShared { get; private set; } = null!;

        /// <summary>
        /// create a private channel instead of a public one.
        /// </summary>
        [Output("isPrivate")]
        public Output<bool> IsPrivate { get; private set; } = null!;

        /// <summary>
        /// means the conversation is in some way shared between multiple workspaces.
        /// </summary>
        [Output("isShared")]
        public Output<bool> IsShared { get; private set; } = null!;

        /// <summary>
        /// name of the public or private channel.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// user IDs to add to the channel.
        /// </summary>
        [Output("permanentMembers")]
        public Output<ImmutableArray<string>> PermanentMembers { get; private set; } = null!;

        /// <summary>
        /// purpose of the channel.
        /// </summary>
        [Output("purpose")]
        public Output<string?> Purpose { get; private set; } = null!;

        /// <summary>
        /// topic for the channel.
        /// </summary>
        [Output("topic")]
        public Output<string?> Topic { get; private set; } = null!;


        /// <summary>
        /// Create a Conversation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Conversation(string name, ConversationArgs args, CustomResourceOptions? options = null)
            : base("slack:index/conversation:Conversation", name, args ?? new ConversationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Conversation(string name, Input<string> id, ConversationState? state = null, CustomResourceOptions? options = null)
            : base("slack:index/conversation:Conversation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Conversation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Conversation Get(string name, Input<string> id, ConversationState? state = null, CustomResourceOptions? options = null)
        {
            return new Conversation(name, id, state, options);
        }
    }

    public sealed class ConversationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// indicates whether the
        /// conversation should be archived or left behind on destroy. Valid values are
        /// `archive | none`. Note that when set to `none` the conversation will be left
        /// as it is  and as a result any subsequent runs of pulumi up with the same
        /// name  will fail.
        /// </summary>
        [Input("actionOnDestroy")]
        public Input<string>? ActionOnDestroy { get; set; }

        /// <summary>
        /// indicate
        /// whether the members should be kick of the channel when removed from
        /// `permanent_members`. When set to `none` the user are never kicked, this prevent
        /// a side effect on public channels where user that joined the channel are kicked.
        /// </summary>
        [Input("actionOnUpdatePermanentMembers")]
        public Input<string>? ActionOnUpdatePermanentMembers { get; set; }

        [Input("adoptExistingChannel")]
        public Input<bool>? AdoptExistingChannel { get; set; }

        /// <summary>
        /// indicates a conversation is archived. Frozen in time.
        /// </summary>
        [Input("isArchived")]
        public Input<bool>? IsArchived { get; set; }

        /// <summary>
        /// create a private channel instead of a public one.
        /// </summary>
        [Input("isPrivate", required: true)]
        public Input<bool> IsPrivate { get; set; } = null!;

        /// <summary>
        /// name of the public or private channel.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("permanentMembers")]
        private InputList<string>? _permanentMembers;

        /// <summary>
        /// user IDs to add to the channel.
        /// </summary>
        public InputList<string> PermanentMembers
        {
            get => _permanentMembers ?? (_permanentMembers = new InputList<string>());
            set => _permanentMembers = value;
        }

        /// <summary>
        /// purpose of the channel.
        /// </summary>
        [Input("purpose")]
        public Input<string>? Purpose { get; set; }

        /// <summary>
        /// topic for the channel.
        /// </summary>
        [Input("topic")]
        public Input<string>? Topic { get; set; }

        public ConversationArgs()
        {
        }
        public static new ConversationArgs Empty => new ConversationArgs();
    }

    public sealed class ConversationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// indicates whether the
        /// conversation should be archived or left behind on destroy. Valid values are
        /// `archive | none`. Note that when set to `none` the conversation will be left
        /// as it is  and as a result any subsequent runs of pulumi up with the same
        /// name  will fail.
        /// </summary>
        [Input("actionOnDestroy")]
        public Input<string>? ActionOnDestroy { get; set; }

        /// <summary>
        /// indicate
        /// whether the members should be kick of the channel when removed from
        /// `permanent_members`. When set to `none` the user are never kicked, this prevent
        /// a side effect on public channels where user that joined the channel are kicked.
        /// </summary>
        [Input("actionOnUpdatePermanentMembers")]
        public Input<string>? ActionOnUpdatePermanentMembers { get; set; }

        [Input("adoptExistingChannel")]
        public Input<bool>? AdoptExistingChannel { get; set; }

        /// <summary>
        /// is a unix timestamp.
        /// </summary>
        [Input("created")]
        public Input<int>? Created { get; set; }

        /// <summary>
        /// is the user ID of the member that created this channel.
        /// </summary>
        [Input("creator")]
        public Input<string>? Creator { get; set; }

        /// <summary>
        /// indicates a conversation is archived. Frozen in time.
        /// </summary>
        [Input("isArchived")]
        public Input<bool>? IsArchived { get; set; }

        /// <summary>
        /// represents this conversation as being part of a Shared Channel
        /// with a remote organization.
        /// </summary>
        [Input("isExtShared")]
        public Input<bool>? IsExtShared { get; set; }

        /// <summary>
        /// will be true if this channel is the "general" channel that includes
        /// all regular team members.
        /// </summary>
        [Input("isGeneral")]
        public Input<bool>? IsGeneral { get; set; }

        /// <summary>
        /// explains whether this shared channel is shared between Enterprise
        /// Grid workspaces within the same organization.
        /// </summary>
        [Input("isOrgShared")]
        public Input<bool>? IsOrgShared { get; set; }

        /// <summary>
        /// create a private channel instead of a public one.
        /// </summary>
        [Input("isPrivate")]
        public Input<bool>? IsPrivate { get; set; }

        /// <summary>
        /// means the conversation is in some way shared between multiple workspaces.
        /// </summary>
        [Input("isShared")]
        public Input<bool>? IsShared { get; set; }

        /// <summary>
        /// name of the public or private channel.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("permanentMembers")]
        private InputList<string>? _permanentMembers;

        /// <summary>
        /// user IDs to add to the channel.
        /// </summary>
        public InputList<string> PermanentMembers
        {
            get => _permanentMembers ?? (_permanentMembers = new InputList<string>());
            set => _permanentMembers = value;
        }

        /// <summary>
        /// purpose of the channel.
        /// </summary>
        [Input("purpose")]
        public Input<string>? Purpose { get; set; }

        /// <summary>
        /// topic for the channel.
        /// </summary>
        [Input("topic")]
        public Input<string>? Topic { get; set; }

        public ConversationState()
        {
        }
        public static new ConversationState Empty => new ConversationState();
    }
}
