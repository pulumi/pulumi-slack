// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.slack;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.slack.ConversationArgs;
import com.pulumi.slack.Utilities;
import com.pulumi.slack.inputs.ConversationState;
import java.lang.Boolean;
import java.lang.Integer;
import java.lang.String;
import java.util.List;
import java.util.Optional;
import javax.annotation.Nullable;

/**
 * Manages a Slack channel
 * 
 * ## Required scopes
 * 
 * This resource requires the following scopes:
 * 
 * If using `bot` tokens:
 * 
 * - [channels:read](https://api.slack.com/scopes/channels:read)
 *   (public channels)
 * - [channels:manage](https://api.slack.com/scopes/channels:manage)
 *   (public channels)
 * - [channels:join](https://api.slack.com/scopes/channels:join)
 *   (adopting existing public channels)
 * - [groups:read](https://api.slack.com/scopes/groups:read)
 *   (private channels)
 * - [groups:write](https://api.slack.com/scopes/groups:write)
 *   (private channels)
 * 
 * If using `user` tokens:
 * 
 * - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
 * - [channels:write](https://api.slack.com/scopes/channels:manage) (public channels)
 * - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)
 * - [groups:write](https://api.slack.com/scopes/groups:write) (private channels)
 * 
 * The Slack API methods used by the resource are:
 * 
 * - [conversations.create](https://api.slack.com/methods/conversations.create)
 * - [conversations.join](https://api.slack.com/methods/conversations.join)
 * - [conversations.setTopic](https://api.slack.com/methods/conversations.setTopic)
 * - [conversations.setPurpose](https://api.slack.com/methods/conversations.setPurpose)
 * - [conversations.info](https://api.slack.com/methods/conversations.info)
 * - [conversations.members](https://api.slack.com/methods/conversations.members)
 * - [conversations.kick](https://api.slack.com/methods/conversations.kick)
 * - [conversations.invite](https://api.slack.com/methods/conversations.invite)
 * - [conversations.rename](https://api.slack.com/methods/conversations.rename)
 * - [conversations.archive](https://api.slack.com/methods/conversations.archive)
 * - [conversations.unarchive](https://api.slack.com/methods/conversations.unarchive)
 * 
 * If you get `missing_scope` errors while using this resource check the scopes against
 * the documentation for the methods above.
 * 
 * ## Example Usage
 * 
 * &lt;!--Start PulumiCodeChooser --&gt;
 * ```java
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
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
 *         var test = new Conversation(&#34;test&#34;, ConversationArgs.builder()        
 *             .isPrivate(true)
 *             .permanentMembers()
 *             .topic(&#34;The topic for my channel&#34;)
 *             .build());
 * 
 *     }
 * }
 * ```
 * &lt;!--End PulumiCodeChooser --&gt;
 * 
 * &lt;!--Start PulumiCodeChooser --&gt;
 * ```java
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
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
 *         var nonadmin = new Conversation(&#34;nonadmin&#34;, ConversationArgs.builder()        
 *             .actionOnDestroy(&#34;none&#34;)
 *             .isPrivate(true)
 *             .permanentMembers()
 *             .topic(&#34;The channel won&#39;t be archived on destroy&#34;)
 *             .build());
 * 
 *     }
 * }
 * ```
 * &lt;!--End PulumiCodeChooser --&gt;
 * 
 * &lt;!--Start PulumiCodeChooser --&gt;
 * ```java
 * package generated_program;
 * 
 * import com.pulumi.Context;
 * import com.pulumi.Pulumi;
 * import com.pulumi.core.Output;
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
 *         var adopted = new Conversation(&#34;adopted&#34;, ConversationArgs.builder()        
 *             .actionOnUpdatePermanentMembers(&#34;none&#34;)
 *             .adoptExistingChannel(true)
 *             .permanentMembers()
 *             .topic(&#34;Adopt existing, don&#39;t kick members&#34;)
 *             .build());
 * 
 *     }
 * }
 * ```
 * &lt;!--End PulumiCodeChooser --&gt;
 * 
 * ## Import
 * 
 * `slack_conversation` can be imported using the ID of the conversation/channel, e.g.
 * 
 * ```sh
 * $ pulumi import slack:index/conversation:Conversation my_conversation C023X7QTFHQ
 * ```
 * 
 */
@ResourceType(type="slack:index/conversation:Conversation")
public class Conversation extends com.pulumi.resources.CustomResource {
    /**
     * indicates whether the
     * conversation should be archived or left behind on destroy. Valid values are
     * `archive | none`. Note that when set to `none` the conversation will be left
     * as it is  and as a result any subsequent runs of pulumi up with the same
     * name  will fail.
     * 
     */
    @Export(name="actionOnDestroy", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> actionOnDestroy;

    /**
     * @return indicates whether the
     * conversation should be archived or left behind on destroy. Valid values are
     * `archive | none`. Note that when set to `none` the conversation will be left
     * as it is  and as a result any subsequent runs of pulumi up with the same
     * name  will fail.
     * 
     */
    public Output<Optional<String>> actionOnDestroy() {
        return Codegen.optional(this.actionOnDestroy);
    }
    /**
     * indicate
     * whether the members should be kick of the channel when removed from
     * `permanent_members`. When set to `none` the user are never kicked, this prevent
     * a side effect on public channels where user that joined the channel are kicked.
     * 
     */
    @Export(name="actionOnUpdatePermanentMembers", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> actionOnUpdatePermanentMembers;

    /**
     * @return indicate
     * whether the members should be kick of the channel when removed from
     * `permanent_members`. When set to `none` the user are never kicked, this prevent
     * a side effect on public channels where user that joined the channel are kicked.
     * 
     */
    public Output<Optional<String>> actionOnUpdatePermanentMembers() {
        return Codegen.optional(this.actionOnUpdatePermanentMembers);
    }
    @Export(name="adoptExistingChannel", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> adoptExistingChannel;

    public Output<Optional<Boolean>> adoptExistingChannel() {
        return Codegen.optional(this.adoptExistingChannel);
    }
    /**
     * is a unix timestamp.
     * 
     */
    @Export(name="created", refs={Integer.class}, tree="[0]")
    private Output<Integer> created;

    /**
     * @return is a unix timestamp.
     * 
     */
    public Output<Integer> created() {
        return this.created;
    }
    /**
     * is the user ID of the member that created this channel.
     * 
     */
    @Export(name="creator", refs={String.class}, tree="[0]")
    private Output<String> creator;

    /**
     * @return is the user ID of the member that created this channel.
     * 
     */
    public Output<String> creator() {
        return this.creator;
    }
    /**
     * indicates a conversation is archived. Frozen in time.
     * 
     */
    @Export(name="isArchived", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> isArchived;

    /**
     * @return indicates a conversation is archived. Frozen in time.
     * 
     */
    public Output<Optional<Boolean>> isArchived() {
        return Codegen.optional(this.isArchived);
    }
    /**
     * represents this conversation as being part of a Shared Channel
     * with a remote organization.
     * 
     */
    @Export(name="isExtShared", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> isExtShared;

    /**
     * @return represents this conversation as being part of a Shared Channel
     * with a remote organization.
     * 
     */
    public Output<Boolean> isExtShared() {
        return this.isExtShared;
    }
    /**
     * will be true if this channel is the &#34;general&#34; channel that includes
     * all regular team members.
     * 
     */
    @Export(name="isGeneral", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> isGeneral;

    /**
     * @return will be true if this channel is the &#34;general&#34; channel that includes
     * all regular team members.
     * 
     */
    public Output<Boolean> isGeneral() {
        return this.isGeneral;
    }
    /**
     * explains whether this shared channel is shared between Enterprise
     * Grid workspaces within the same organization.
     * 
     */
    @Export(name="isOrgShared", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> isOrgShared;

    /**
     * @return explains whether this shared channel is shared between Enterprise
     * Grid workspaces within the same organization.
     * 
     */
    public Output<Boolean> isOrgShared() {
        return this.isOrgShared;
    }
    /**
     * create a private channel instead of a public one.
     * 
     */
    @Export(name="isPrivate", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> isPrivate;

    /**
     * @return create a private channel instead of a public one.
     * 
     */
    public Output<Boolean> isPrivate() {
        return this.isPrivate;
    }
    /**
     * means the conversation is in some way shared between multiple workspaces.
     * 
     */
    @Export(name="isShared", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> isShared;

    /**
     * @return means the conversation is in some way shared between multiple workspaces.
     * 
     */
    public Output<Boolean> isShared() {
        return this.isShared;
    }
    /**
     * name of the public or private channel.
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return name of the public or private channel.
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * user IDs to add to the channel.
     * 
     */
    @Export(name="permanentMembers", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> permanentMembers;

    /**
     * @return user IDs to add to the channel.
     * 
     */
    public Output<Optional<List<String>>> permanentMembers() {
        return Codegen.optional(this.permanentMembers);
    }
    /**
     * purpose of the channel.
     * 
     */
    @Export(name="purpose", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> purpose;

    /**
     * @return purpose of the channel.
     * 
     */
    public Output<Optional<String>> purpose() {
        return Codegen.optional(this.purpose);
    }
    /**
     * topic for the channel.
     * 
     */
    @Export(name="topic", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> topic;

    /**
     * @return topic for the channel.
     * 
     */
    public Output<Optional<String>> topic() {
        return Codegen.optional(this.topic);
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public Conversation(String name) {
        this(name, ConversationArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public Conversation(String name, ConversationArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public Conversation(String name, ConversationArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("slack:index/conversation:Conversation", name, args == null ? ConversationArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private Conversation(String name, Output<String> id, @Nullable ConversationState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("slack:index/conversation:Conversation", name, state, makeResourceOptions(options, id));
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<String> id) {
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
    public static Conversation get(String name, Output<String> id, @Nullable ConversationState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new Conversation(name, id, state, options);
    }
}
