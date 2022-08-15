// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.slack;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;


public final class ProviderArgs extends com.pulumi.resources.ResourceArgs {

    public static final ProviderArgs Empty = new ProviderArgs();

    /**
     * The Slack token
     * 
     */
    @Import(name="token", required=true)
    private Output<String> token;

    /**
     * @return The Slack token
     * 
     */
    public Output<String> token() {
        return this.token;
    }

    private ProviderArgs() {}

    private ProviderArgs(ProviderArgs $) {
        this.token = $.token;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(ProviderArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private ProviderArgs $;

        public Builder() {
            $ = new ProviderArgs();
        }

        public Builder(ProviderArgs defaults) {
            $ = new ProviderArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param token The Slack token
         * 
         * @return builder
         * 
         */
        public Builder token(Output<String> token) {
            $.token = token;
            return this;
        }

        /**
         * @param token The Slack token
         * 
         * @return builder
         * 
         */
        public Builder token(String token) {
            return token(Output.of(token));
        }

        public ProviderArgs build() {
            $.token = Objects.requireNonNull($.token, "expected parameter 'token' to be non-null");
            return $;
        }
    }

}
