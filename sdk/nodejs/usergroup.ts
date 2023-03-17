// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Manages a Slack User Group.
 *
 * ## Required scopes
 *
 * This resource requires the following scopes:
 *
 * - [usergroups:write](https://api.slack.com/scopes/usergroups:write)
 * - [usergroups:read](https://api.slack.com/scopes/usergroups:read)
 *
 * The Slack API methods used by the resource are:
 *
 * - [usergroups.create](https://api.slack.com/methods/usergroups.create)
 * - [usergroups.enable](https://api.slack.com/methods/usergroups.enable)
 * - [usergroups.disable](https://api.slack.com/methods/usergroups.disable)
 * - [usergroups.update](https://api.slack.com/methods/usergroups.update)
 * - [usergroups.list](https://api.slack.com/methods/usergroups.list)
 * - [usergroups.users.update](https://api.slack.com/methods/usergroups.users.update)
 *
 * If you get `missingScope` errors while using this resource check the scopes against
 * the documentation for the methods above.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as slack from "@pulumi/slack";
 *
 * const myGroup = new slack.Usergroup("myGroup", {
 *     channels: ["CHANNEL00"],
 *     description: "Test user group",
 *     handle: "test",
 *     users: ["USER00"],
 * });
 * ```
 *
 * Note that if a channel is removed from the `channels` list users are
 * **not** removed from the channel. In order to keep the users in the
 * groups and in the channel in sync set `permanentUsers` in the channel:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as slack from "@pulumi/slack";
 *
 * const myGroup = new slack.Usergroup("myGroup", {
 *     handle: "test",
 *     description: "Test user group",
 *     users: ["USER00"],
 * });
 * const test = new slack.Conversation("test", {
 *     topic: "The topic for my channel",
 *     permanentMembers: myGroup.users,
 *     isPrivate: true,
 * });
 * ```
 *
 * ## Import
 *
 * `slack_usergroup` can be imported using the ID of the group, e.g.
 *
 * ```sh
 *  $ pulumi import slack:index/usergroup:Usergroup my_group S022GE79E9G
 * ```
 */
export class Usergroup extends pulumi.CustomResource {
    /**
     * Get an existing Usergroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UsergroupState, opts?: pulumi.CustomResourceOptions): Usergroup {
        return new Usergroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'slack:index/usergroup:Usergroup';

    /**
     * Returns true if the given object is an instance of Usergroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Usergroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Usergroup.__pulumiType;
    }

    /**
     * channel IDs for which the User Group uses as a default.
     */
    public readonly channels!: pulumi.Output<string[] | undefined>;
    /**
     * a short description of the User Group.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * a mention handle. Must be unique among channels, users
     * and User Groups.
     */
    public readonly handle!: pulumi.Output<string | undefined>;
    /**
     * a name for the User Group. Must be unique among User Groups.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * user IDs that represent the entire list of users for the
     * User Group.
     */
    public readonly users!: pulumi.Output<string[] | undefined>;

    /**
     * Create a Usergroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: UsergroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UsergroupArgs | UsergroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UsergroupState | undefined;
            resourceInputs["channels"] = state ? state.channels : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["handle"] = state ? state.handle : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["users"] = state ? state.users : undefined;
        } else {
            const args = argsOrState as UsergroupArgs | undefined;
            resourceInputs["channels"] = args ? args.channels : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["handle"] = args ? args.handle : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["users"] = args ? args.users : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Usergroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Usergroup resources.
 */
export interface UsergroupState {
    /**
     * channel IDs for which the User Group uses as a default.
     */
    channels?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * a short description of the User Group.
     */
    description?: pulumi.Input<string>;
    /**
     * a mention handle. Must be unique among channels, users
     * and User Groups.
     */
    handle?: pulumi.Input<string>;
    /**
     * a name for the User Group. Must be unique among User Groups.
     */
    name?: pulumi.Input<string>;
    /**
     * user IDs that represent the entire list of users for the
     * User Group.
     */
    users?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a Usergroup resource.
 */
export interface UsergroupArgs {
    /**
     * channel IDs for which the User Group uses as a default.
     */
    channels?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * a short description of the User Group.
     */
    description?: pulumi.Input<string>;
    /**
     * a mention handle. Must be unique among channels, users
     * and User Groups.
     */
    handle?: pulumi.Input<string>;
    /**
     * a name for the User Group. Must be unique among User Groups.
     */
    name?: pulumi.Input<string>;
    /**
     * user IDs that represent the entire list of users for the
     * User Group.
     */
    users?: pulumi.Input<pulumi.Input<string>[]>;
}
