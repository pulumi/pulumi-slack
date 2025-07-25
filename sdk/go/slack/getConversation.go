// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package slack

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-slack/sdk/go/slack/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to get information about a Slack conversation for use in other
// resources.
//
// ## Required scopes
//
// This resource requires the following scopes:
//
// - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
// - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)
//
// The Slack API methods used by the resource are:
//
// - [conversations.info](https://api.slack.com/methods/conversations.info)
// - [conversations.members](https://api.slack.com/methods/conversations.members)
//
// If you get `missingScope` errors while using this resource check the scopes against
// the documentation for the methods above.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-slack/sdk/go/slack"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := slack.LookupConversation(ctx, &slack.LookupConversationArgs{
//				ChannelId: pulumi.StringRef("my-channel"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = slack.LookupConversation(ctx, &slack.LookupConversationArgs{
//				Name: pulumi.StringRef("my-channel-name"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupConversation(ctx *pulumi.Context, args *LookupConversationArgs, opts ...pulumi.InvokeOption) (*LookupConversationResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupConversationResult
	err := ctx.Invoke("slack:index/getConversation:getConversation", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getConversation.
type LookupConversationArgs struct {
	// The ID of the channel
	ChannelId *string `pulumi:"channelId"`
	// The conversation is privileged between two or more members
	//
	// Either `channelId` or `name` must be provided. `isPrivate` only works in conjunction
	// with `name`.
	IsPrivate *bool `pulumi:"isPrivate"`
	// The name of the public or private channel
	Name *string `pulumi:"name"`
}

// A collection of values returned by getConversation.
type LookupConversationResult struct {
	ChannelId *string `pulumi:"channelId"`
	// is a unix timestamp.
	Created int `pulumi:"created"`
	// is the user ID of the member that created this channel.
	Creator string `pulumi:"creator"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// indicates a conversation is archived. Frozen in time.
	IsArchived bool `pulumi:"isArchived"`
	// represents this conversation as being part of a Shared Channel
	// with a remote organization.
	IsExtShared bool `pulumi:"isExtShared"`
	// will be true if this channel is the "general" channel that includes
	// all regular team members.
	IsGeneral bool `pulumi:"isGeneral"`
	// explains whether this shared channel is shared between Enterprise
	// Grid workspaces within the same organization.
	IsOrgShared bool `pulumi:"isOrgShared"`
	// means the conversation is privileged between two or more members.
	IsPrivate *bool `pulumi:"isPrivate"`
	// means the conversation is in some way shared between multiple workspaces.
	IsShared bool `pulumi:"isShared"`
	// name of the public or private channel.
	Name *string `pulumi:"name"`
	// purpose of the channel.
	Purpose string `pulumi:"purpose"`
	// topic for the channel.
	Topic string `pulumi:"topic"`
}

func LookupConversationOutput(ctx *pulumi.Context, args LookupConversationOutputArgs, opts ...pulumi.InvokeOption) LookupConversationResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupConversationResultOutput, error) {
			args := v.(LookupConversationArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("slack:index/getConversation:getConversation", args, LookupConversationResultOutput{}, options).(LookupConversationResultOutput), nil
		}).(LookupConversationResultOutput)
}

// A collection of arguments for invoking getConversation.
type LookupConversationOutputArgs struct {
	// The ID of the channel
	ChannelId pulumi.StringPtrInput `pulumi:"channelId"`
	// The conversation is privileged between two or more members
	//
	// Either `channelId` or `name` must be provided. `isPrivate` only works in conjunction
	// with `name`.
	IsPrivate pulumi.BoolPtrInput `pulumi:"isPrivate"`
	// The name of the public or private channel
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupConversationOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConversationArgs)(nil)).Elem()
}

// A collection of values returned by getConversation.
type LookupConversationResultOutput struct{ *pulumi.OutputState }

func (LookupConversationResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConversationResult)(nil)).Elem()
}

func (o LookupConversationResultOutput) ToLookupConversationResultOutput() LookupConversationResultOutput {
	return o
}

func (o LookupConversationResultOutput) ToLookupConversationResultOutputWithContext(ctx context.Context) LookupConversationResultOutput {
	return o
}

func (o LookupConversationResultOutput) ChannelId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConversationResult) *string { return v.ChannelId }).(pulumi.StringPtrOutput)
}

// is a unix timestamp.
func (o LookupConversationResultOutput) Created() pulumi.IntOutput {
	return o.ApplyT(func(v LookupConversationResult) int { return v.Created }).(pulumi.IntOutput)
}

// is the user ID of the member that created this channel.
func (o LookupConversationResultOutput) Creator() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConversationResult) string { return v.Creator }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupConversationResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConversationResult) string { return v.Id }).(pulumi.StringOutput)
}

// indicates a conversation is archived. Frozen in time.
func (o LookupConversationResultOutput) IsArchived() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupConversationResult) bool { return v.IsArchived }).(pulumi.BoolOutput)
}

// represents this conversation as being part of a Shared Channel
// with a remote organization.
func (o LookupConversationResultOutput) IsExtShared() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupConversationResult) bool { return v.IsExtShared }).(pulumi.BoolOutput)
}

// will be true if this channel is the "general" channel that includes
// all regular team members.
func (o LookupConversationResultOutput) IsGeneral() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupConversationResult) bool { return v.IsGeneral }).(pulumi.BoolOutput)
}

// explains whether this shared channel is shared between Enterprise
// Grid workspaces within the same organization.
func (o LookupConversationResultOutput) IsOrgShared() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupConversationResult) bool { return v.IsOrgShared }).(pulumi.BoolOutput)
}

// means the conversation is privileged between two or more members.
func (o LookupConversationResultOutput) IsPrivate() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupConversationResult) *bool { return v.IsPrivate }).(pulumi.BoolPtrOutput)
}

// means the conversation is in some way shared between multiple workspaces.
func (o LookupConversationResultOutput) IsShared() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupConversationResult) bool { return v.IsShared }).(pulumi.BoolOutput)
}

// name of the public or private channel.
func (o LookupConversationResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConversationResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// purpose of the channel.
func (o LookupConversationResultOutput) Purpose() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConversationResult) string { return v.Purpose }).(pulumi.StringOutput)
}

// topic for the channel.
func (o LookupConversationResultOutput) Topic() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConversationResult) string { return v.Topic }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupConversationResultOutput{})
}
