// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Slack
{
    public static class GetUsergroup
    {
        /// <summary>
        /// Use this data source to get information about a usergroups for use in other
        /// resources. The data source returns enabled groups only.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [usergroups:read](https://api.slack.com/scopes/usergroups:read)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [usergroups.list](https://api.slack.com/methods/usergroups.list)
        /// 
        /// If you get `missing_scope` errors while using this resource check the scopes against
        /// the documentation for the methods above.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var byName = Slack.GetUsergroup.Invoke(new()
        ///     {
        ///         Name = "my-usergroup",
        ///     });
        /// 
        ///     var byId = Slack.GetUsergroup.Invoke(new()
        ///     {
        ///         UsergroupId = "USERGROUP00",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetUsergroupResult> InvokeAsync(GetUsergroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUsergroupResult>("slack:index/getUsergroup:getUsergroup", args ?? new GetUsergroupArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about a usergroups for use in other
        /// resources. The data source returns enabled groups only.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [usergroups:read](https://api.slack.com/scopes/usergroups:read)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [usergroups.list](https://api.slack.com/methods/usergroups.list)
        /// 
        /// If you get `missing_scope` errors while using this resource check the scopes against
        /// the documentation for the methods above.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Slack = Pulumi.Slack;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var byName = Slack.GetUsergroup.Invoke(new()
        ///     {
        ///         Name = "my-usergroup",
        ///     });
        /// 
        ///     var byId = Slack.GetUsergroup.Invoke(new()
        ///     {
        ///         UsergroupId = "USERGROUP00",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetUsergroupResult> Invoke(GetUsergroupInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetUsergroupResult>("slack:index/getUsergroup:getUsergroup", args ?? new GetUsergroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUsergroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the usergroup
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The id of the usergroup
        /// </summary>
        [Input("usergroupId")]
        public string? UsergroupId { get; set; }

        public GetUsergroupArgs()
        {
        }
        public static new GetUsergroupArgs Empty => new GetUsergroupArgs();
    }

    public sealed class GetUsergroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the usergroup
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The id of the usergroup
        /// </summary>
        [Input("usergroupId")]
        public Input<string>? UsergroupId { get; set; }

        public GetUsergroupInvokeArgs()
        {
        }
        public static new GetUsergroupInvokeArgs Empty => new GetUsergroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetUsergroupResult
    {
        /// <summary>
        /// The channel IDs for which the User Group uses as a default.
        /// </summary>
        public readonly ImmutableArray<string> Channels;
        /// <summary>
        /// The short description of the User Group.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The mention handle.
        /// </summary>
        public readonly string Handle;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly string? UsergroupId;
        /// <summary>
        /// The user IDs that represent the entire list of users for the
        /// User Group.
        /// </summary>
        public readonly ImmutableArray<string> Users;

        [OutputConstructor]
        private GetUsergroupResult(
            ImmutableArray<string> channels,

            string description,

            string handle,

            string id,

            string? name,

            string? usergroupId,

            ImmutableArray<string> users)
        {
            Channels = channels;
            Description = description;
            Handle = handle;
            Id = id;
            Name = name;
            UsergroupId = usergroupId;
            Users = users;
        }
    }
}
