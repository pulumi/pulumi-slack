// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package slack

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-slack/sdk/go/slack/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to get information about a user for use in other
// resources.
//
// ## Required scopes
//
// This resource requires the following scopes:
//
// - [users:read](https://api.slack.com/scopes/users:read)
// - [users:read.email](https://api.slack.com/scopes/users:read.email)
//
// The Slack API methods used by the resource are:
//
// - [users.lookupByEmail](https://api.slack.com/methods/users.lookupByEmail)
// - [users.list](https://api.slack.com/methods/users.list)
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
//			_, err := slack.GetUser(ctx, &slack.GetUserArgs{
//				Name: pulumi.StringRef("my-user"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = slack.GetUser(ctx, &slack.GetUserArgs{
//				Email: pulumi.StringRef("my-user@example.com"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetUser(ctx *pulumi.Context, args *GetUserArgs, opts ...pulumi.InvokeOption) (*GetUserResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetUserResult
	err := ctx.Invoke("slack:index/getUser:getUser", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getUser.
type GetUserArgs struct {
	// The email of the user
	//
	// The data source expects exactly one of these fields, you can't set both.
	Email *string `pulumi:"email"`
	// The name of the user
	Name *string `pulumi:"name"`
}

// A collection of values returned by getUser.
type GetUserResult struct {
	Email *string `pulumi:"email"`
	// The provider-assigned unique ID for this managed resource.
	Id   string  `pulumi:"id"`
	Name *string `pulumi:"name"`
}

func GetUserOutput(ctx *pulumi.Context, args GetUserOutputArgs, opts ...pulumi.InvokeOption) GetUserResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetUserResultOutput, error) {
			args := v.(GetUserArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("slack:index/getUser:getUser", args, GetUserResultOutput{}, options).(GetUserResultOutput), nil
		}).(GetUserResultOutput)
}

// A collection of arguments for invoking getUser.
type GetUserOutputArgs struct {
	// The email of the user
	//
	// The data source expects exactly one of these fields, you can't set both.
	Email pulumi.StringPtrInput `pulumi:"email"`
	// The name of the user
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (GetUserOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUserArgs)(nil)).Elem()
}

// A collection of values returned by getUser.
type GetUserResultOutput struct{ *pulumi.OutputState }

func (GetUserResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUserResult)(nil)).Elem()
}

func (o GetUserResultOutput) ToGetUserResultOutput() GetUserResultOutput {
	return o
}

func (o GetUserResultOutput) ToGetUserResultOutputWithContext(ctx context.Context) GetUserResultOutput {
	return o
}

func (o GetUserResultOutput) Email() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetUserResult) *string { return v.Email }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetUserResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetUserResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetUserResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetUserResultOutput{})
}
