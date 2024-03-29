// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.slack.inputs;

import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GetUserPlainArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetUserPlainArgs Empty = new GetUserPlainArgs();

    /**
     * The email of the user
     * 
     * The data source expects exactly one of these fields, you can&#39;t set both.
     * 
     */
    @Import(name="email")
    private @Nullable String email;

    /**
     * @return The email of the user
     * 
     * The data source expects exactly one of these fields, you can&#39;t set both.
     * 
     */
    public Optional<String> email() {
        return Optional.ofNullable(this.email);
    }

    /**
     * The name of the user
     * 
     */
    @Import(name="name")
    private @Nullable String name;

    /**
     * @return The name of the user
     * 
     */
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }

    private GetUserPlainArgs() {}

    private GetUserPlainArgs(GetUserPlainArgs $) {
        this.email = $.email;
        this.name = $.name;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetUserPlainArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetUserPlainArgs $;

        public Builder() {
            $ = new GetUserPlainArgs();
        }

        public Builder(GetUserPlainArgs defaults) {
            $ = new GetUserPlainArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param email The email of the user
         * 
         * The data source expects exactly one of these fields, you can&#39;t set both.
         * 
         * @return builder
         * 
         */
        public Builder email(@Nullable String email) {
            $.email = email;
            return this;
        }

        /**
         * @param name The name of the user
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable String name) {
            $.name = name;
            return this;
        }

        public GetUserPlainArgs build() {
            return $;
        }
    }

}
