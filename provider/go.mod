module github.com/pulumi/pulumi-slack/provider

go 1.16

replace (
	github.com/hashicorp/go-getter v1.5.0 => github.com/hashicorp/go-getter v1.4.0
	github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20211230170131-3a7c83bfab87
)

require (
	github.com/hashicorp/terraform-plugin-sdk v1.9.1 // indirect
	github.com/pablovarela/terraform-provider-slack v1.1.20
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.22.1
	github.com/pulumi/pulumi/sdk/v3 v3.32.1 // indirect
)
