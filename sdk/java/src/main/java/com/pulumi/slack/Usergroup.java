// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.slack;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.slack.UsergroupArgs;
import com.pulumi.slack.Utilities;
import com.pulumi.slack.inputs.UsergroupState;
import java.lang.String;
import java.util.List;
import java.util.Optional;
import javax.annotation.Nullable;

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
 * If you get `missing_scope` errors while using this resource check the scopes against
 * the documentation for the methods above.
 * 
 * ## Example Usage
 * 
 * &lt;!--Start PulumiCodeChooser --&gt;
 * <pre>
 * {@code
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
 * import com.pulumi.slack.Usergroup;
 * import com.pulumi.slack.UsergroupArgs;
 * import java.util.List;
 * import java.util.ArrayList;
 * import java.util.Map;
 * import java.io.File;
 * import java.nio.file.Files;
 * import java.nio.file.Paths;
 * 
 * public class App {
 *     public static void main(String[] args) {
 *         Pulumi.run(App::stack);
 *     }
 * 
 *     public static void stack(Context ctx) {
 *         var myGroup = new Usergroup("myGroup", UsergroupArgs.builder()
 *             .name("TestGroup")
 *             .handle("test")
 *             .description("Test user group")
 *             .users("USER00")
 *             .channels("CHANNEL00")
 *             .build());
 * 
 *     }
 * }
 * }
 * </pre>
 * &lt;!--End PulumiCodeChooser --&gt;
 * 
 * Note that if a channel is removed from the `channels` list users are
 * **not** removed from the channel. In order to keep the users in the
 * groups and in the channel in sync set `permanent_users` in the channel:
 * 
 * &lt;!--Start PulumiCodeChooser --&gt;
 * <pre>
 * {@code
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
 * import com.pulumi.slack.Usergroup;
 * import com.pulumi.slack.UsergroupArgs;
 * import com.pulumi.slack.Conversation;
 * import com.pulumi.slack.ConversationArgs;
 * import java.util.List;
 * import java.util.ArrayList;
 * import java.util.Map;
 * import java.io.File;
 * import java.nio.file.Files;
 * import java.nio.file.Paths;
 * 
 * public class App {
 *     public static void main(String[] args) {
 *         Pulumi.run(App::stack);
 *     }
 * 
 *     public static void stack(Context ctx) {
 *         var myGroup = new Usergroup("myGroup", UsergroupArgs.builder()
 *             .name("TestGroup")
 *             .handle("test")
 *             .description("Test user group")
 *             .users("USER00")
 *             .build());
 * 
 *         var test = new Conversation("test", ConversationArgs.builder()
 *             .name("my-channel")
 *             .topic("The topic for my channel")
 *             .permanentMembers(myGroup.users())
 *             .isPrivate(true)
 *             .build());
 * 
 *     }
 * }
 * }
 * </pre>
 * &lt;!--End PulumiCodeChooser --&gt;
 * 
 * ## Import
 * 
 * `slack_usergroup` can be imported using the ID of the group, e.g.
 * 
 * ```sh
 * $ pulumi import slack:index/usergroup:Usergroup my_group S022GE79E9G
 * ```
 * 
 */
@ResourceType(type="slack:index/usergroup:Usergroup")
public class Usergroup extends com.pulumi.resources.CustomResource {
    /**
     * channel IDs for which the User Group uses as a default.
     * 
     */
    @Export(name="channels", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> channels;

    /**
     * @return channel IDs for which the User Group uses as a default.
     * 
     */
    public Output<Optional<List<String>>> channels() {
        return Codegen.optional(this.channels);
    }
    /**
     * a short description of the User Group.
     * 
     */
    @Export(name="description", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> description;

    /**
     * @return a short description of the User Group.
     * 
     */
    public Output<Optional<String>> description() {
        return Codegen.optional(this.description);
    }
    /**
     * a mention handle. Must be unique among channels, users
     * and User Groups.
     * 
     */
    @Export(name="handle", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> handle;

    /**
     * @return a mention handle. Must be unique among channels, users
     * and User Groups.
     * 
     */
    public Output<Optional<String>> handle() {
        return Codegen.optional(this.handle);
    }
    /**
     * a name for the User Group. Must be unique among User Groups.
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return a name for the User Group. Must be unique among User Groups.
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * user IDs that represent the entire list of users for the
     * User Group.
     * 
     */
    @Export(name="users", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> users;

    /**
     * @return user IDs that represent the entire list of users for the
     * User Group.
     * 
     */
    public Output<Optional<List<String>>> users() {
        return Codegen.optional(this.users);
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public Usergroup(java.lang.String name) {
        this(name, UsergroupArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public Usergroup(java.lang.String name, @Nullable UsergroupArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public Usergroup(java.lang.String name, @Nullable UsergroupArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("slack:index/usergroup:Usergroup", name, makeArgs(args, options), makeResourceOptions(options, Codegen.empty()), false);
    }

    private Usergroup(java.lang.String name, Output<java.lang.String> id, @Nullable UsergroupState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("slack:index/usergroup:Usergroup", name, state, makeResourceOptions(options, id), false);
    }

    private static UsergroupArgs makeArgs(@Nullable UsergroupArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        if (options != null && options.getUrn().isPresent()) {
            return null;
        }
        return args == null ? UsergroupArgs.Empty : args;
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<java.lang.String> id) {
        var defaultOptions = com.pulumi.resources.CustomResourceOptions.builder()
            .version(Utilities.getVersion())
            .build();
        return com.pulumi.resources.CustomResourceOptions.merge(defaultOptions, options, id);
    }

    /**
     * Get an existing Host resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state
     * @param options Optional settings to control the behavior of the CustomResource.
     */
    public static Usergroup get(java.lang.String name, Output<java.lang.String> id, @Nullable UsergroupState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new Usergroup(name, id, state, options);
    }
}
