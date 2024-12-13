// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Slack
{
    public static class GetUser
    {
        /// <summary>
        /// Use this data source to get information about a user for use in other
        /// resources.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [users:read](https://api.slack.com/scopes/users:read)
        /// - [users:read.email](https://api.slack.com/scopes/users:read.email)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [users.lookupByEmail](https://api.slack.com/methods/users.lookupByEmail)
        /// - [users.list](https://api.slack.com/methods/users.list)
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
        ///     var byName = Slack.GetUser.Invoke(new()
        ///     {
        ///         Name = "my-user",
        ///     });
        /// 
        ///     var byEmail = Slack.GetUser.Invoke(new()
        ///     {
        ///         Email = "my-user@example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetUserResult> InvokeAsync(GetUserArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("slack:index/getUser:getUser", args ?? new GetUserArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about a user for use in other
        /// resources.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [users:read](https://api.slack.com/scopes/users:read)
        /// - [users:read.email](https://api.slack.com/scopes/users:read.email)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [users.lookupByEmail](https://api.slack.com/methods/users.lookupByEmail)
        /// - [users.list](https://api.slack.com/methods/users.list)
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
        ///     var byName = Slack.GetUser.Invoke(new()
        ///     {
        ///         Name = "my-user",
        ///     });
        /// 
        ///     var byEmail = Slack.GetUser.Invoke(new()
        ///     {
        ///         Email = "my-user@example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserResult>("slack:index/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about a user for use in other
        /// resources.
        /// 
        /// ## Required scopes
        /// 
        /// This resource requires the following scopes:
        /// 
        /// - [users:read](https://api.slack.com/scopes/users:read)
        /// - [users:read.email](https://api.slack.com/scopes/users:read.email)
        /// 
        /// The Slack API methods used by the resource are:
        /// 
        /// - [users.lookupByEmail](https://api.slack.com/methods/users.lookupByEmail)
        /// - [users.list](https://api.slack.com/methods/users.list)
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
        ///     var byName = Slack.GetUser.Invoke(new()
        ///     {
        ///         Name = "my-user",
        ///     });
        /// 
        ///     var byEmail = Slack.GetUser.Invoke(new()
        ///     {
        ///         Email = "my-user@example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserResult>("slack:index/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The email of the user
        /// 
        /// The data source expects exactly one of these fields, you can't set both.
        /// </summary>
        [Input("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetUserArgs()
        {
        }
        public static new GetUserArgs Empty => new GetUserArgs();
    }

    public sealed class GetUserInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The email of the user
        /// 
        /// The data source expects exactly one of these fields, you can't set both.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetUserInvokeArgs()
        {
        }
        public static new GetUserInvokeArgs Empty => new GetUserInvokeArgs();
    }


    [OutputType]
    public sealed class GetUserResult
    {
        public readonly string? Email;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;

        [OutputConstructor]
        private GetUserResult(
            string? email,

            string id,

            string? name)
        {
            Email = email;
            Id = id;
            Name = name;
        }
    }
}
