// Copyright 2022, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package slack

import (
	"fmt"
	"path/filepath"

	"github.com/pablovarela/terraform-provider-slack/slack"
	"github.com/pulumi/pulumi-slack/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "slack"
	// modules:
	mainMod = "index" // the slack module
)

func Provider() tfbridge.ProviderInfo {
	p := shimv2.NewProvider(slack.Provider())

	prov := tfbridge.ProviderInfo{
		P:           p,
		Name:        "slack",
		DisplayName: "Slack",
		Publisher:   "Pulumi",
		Description: "A Pulumi package for managing Slack workspaces.",
		Keywords:    []string{"pulumi", "slack", "category/utility"},
		License:     "Apache-2.0",
		Homepage:    "https://www.pulumi.com",
		Repository:  "https://github.com/pulumi/pulumi-slack",
		GitHubOrg:   "pablovarela",
		Config:      map[string]*tfbridge.SchemaInfo{},
		Resources: map[string]*tfbridge.ResourceInfo{
			"slack_conversation": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Conversation")},
			"slack_usergroup":    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Usergroup")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"slack_conversation": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getConversation")},
			"slack_user":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUser")},
			"slack_usergroup":    {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUsergroup")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pulumi/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
