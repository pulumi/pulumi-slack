// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.slack;

import com.pulumi.core.internal.Codegen;
import java.lang.String;

public final class Config {

    private static final com.pulumi.Config config = com.pulumi.Config.of("slack");
/**
 * The Slack token
 * 
 */
    public String token() {
        return Codegen.stringProp("token").config(config).require();
    }
}
