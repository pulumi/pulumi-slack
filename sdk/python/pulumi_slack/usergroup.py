# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities

__all__ = ['UsergroupArgs', 'Usergroup']

@pulumi.input_type
class UsergroupArgs:
    def __init__(__self__, *,
                 channels: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 handle: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        The set of arguments for constructing a Usergroup resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] channels: channel IDs for which the User Group uses as a default.
        :param pulumi.Input[builtins.str] description: a short description of the User Group.
        :param pulumi.Input[builtins.str] handle: a mention handle. Must be unique among channels, users
               and User Groups.
        :param pulumi.Input[builtins.str] name: a name for the User Group. Must be unique among User Groups.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] users: user IDs that represent the entire list of users for the
               User Group.
        """
        if channels is not None:
            pulumi.set(__self__, "channels", channels)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if handle is not None:
            pulumi.set(__self__, "handle", handle)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if users is not None:
            pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter
    def channels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        channel IDs for which the User Group uses as a default.
        """
        return pulumi.get(self, "channels")

    @channels.setter
    def channels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "channels", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a short description of the User Group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def handle(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a mention handle. Must be unique among channels, users
        and User Groups.
        """
        return pulumi.get(self, "handle")

    @handle.setter
    def handle(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "handle", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a name for the User Group. Must be unique among User Groups.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def users(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        user IDs that represent the entire list of users for the
        User Group.
        """
        return pulumi.get(self, "users")

    @users.setter
    def users(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "users", value)


@pulumi.input_type
class _UsergroupState:
    def __init__(__self__, *,
                 channels: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 handle: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None):
        """
        Input properties used for looking up and filtering Usergroup resources.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] channels: channel IDs for which the User Group uses as a default.
        :param pulumi.Input[builtins.str] description: a short description of the User Group.
        :param pulumi.Input[builtins.str] handle: a mention handle. Must be unique among channels, users
               and User Groups.
        :param pulumi.Input[builtins.str] name: a name for the User Group. Must be unique among User Groups.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] users: user IDs that represent the entire list of users for the
               User Group.
        """
        if channels is not None:
            pulumi.set(__self__, "channels", channels)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if handle is not None:
            pulumi.set(__self__, "handle", handle)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if users is not None:
            pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter
    def channels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        channel IDs for which the User Group uses as a default.
        """
        return pulumi.get(self, "channels")

    @channels.setter
    def channels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "channels", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a short description of the User Group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def handle(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a mention handle. Must be unique among channels, users
        and User Groups.
        """
        return pulumi.get(self, "handle")

    @handle.setter
    def handle(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "handle", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        a name for the User Group. Must be unique among User Groups.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def users(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        user IDs that represent the entire list of users for the
        User Group.
        """
        return pulumi.get(self, "users")

    @users.setter
    def users(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "users", value)


class Usergroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 channels: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 handle: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        """
        Manages a Slack User Group.

        ## Required scopes

        This resource requires the following scopes:

        - [usergroups:write](https://api.slack.com/scopes/usergroups:write)
        - [usergroups:read](https://api.slack.com/scopes/usergroups:read)

        The Slack API methods used by the resource are:

        - [usergroups.create](https://api.slack.com/methods/usergroups.create)
        - [usergroups.enable](https://api.slack.com/methods/usergroups.enable)
        - [usergroups.disable](https://api.slack.com/methods/usergroups.disable)
        - [usergroups.update](https://api.slack.com/methods/usergroups.update)
        - [usergroups.list](https://api.slack.com/methods/usergroups.list)
        - [usergroups.users.update](https://api.slack.com/methods/usergroups.users.update)

        If you get `missing_scope` errors while using this resource check the scopes against
        the documentation for the methods above.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_slack as slack

        my_group = slack.Usergroup("my_group",
            name="TestGroup",
            handle="test",
            description="Test user group",
            users=["USER00"],
            channels=["CHANNEL00"])
        ```

        Note that if a channel is removed from the `channels` list users are
        **not** removed from the channel. In order to keep the users in the
        groups and in the channel in sync set `permanent_users` in the channel:

        ```python
        import pulumi
        import pulumi_slack as slack

        my_group = slack.Usergroup("my_group",
            name="TestGroup",
            handle="test",
            description="Test user group",
            users=["USER00"])
        test = slack.Conversation("test",
            name="my-channel",
            topic="The topic for my channel",
            permanent_members=my_group.users,
            is_private=True)
        ```

        ## Import

        `slack_usergroup` can be imported using the ID of the group, e.g.

        ```sh
        $ pulumi import slack:index/usergroup:Usergroup my_group S022GE79E9G
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] channels: channel IDs for which the User Group uses as a default.
        :param pulumi.Input[builtins.str] description: a short description of the User Group.
        :param pulumi.Input[builtins.str] handle: a mention handle. Must be unique among channels, users
               and User Groups.
        :param pulumi.Input[builtins.str] name: a name for the User Group. Must be unique among User Groups.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] users: user IDs that represent the entire list of users for the
               User Group.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[UsergroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a Slack User Group.

        ## Required scopes

        This resource requires the following scopes:

        - [usergroups:write](https://api.slack.com/scopes/usergroups:write)
        - [usergroups:read](https://api.slack.com/scopes/usergroups:read)

        The Slack API methods used by the resource are:

        - [usergroups.create](https://api.slack.com/methods/usergroups.create)
        - [usergroups.enable](https://api.slack.com/methods/usergroups.enable)
        - [usergroups.disable](https://api.slack.com/methods/usergroups.disable)
        - [usergroups.update](https://api.slack.com/methods/usergroups.update)
        - [usergroups.list](https://api.slack.com/methods/usergroups.list)
        - [usergroups.users.update](https://api.slack.com/methods/usergroups.users.update)

        If you get `missing_scope` errors while using this resource check the scopes against
        the documentation for the methods above.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_slack as slack

        my_group = slack.Usergroup("my_group",
            name="TestGroup",
            handle="test",
            description="Test user group",
            users=["USER00"],
            channels=["CHANNEL00"])
        ```

        Note that if a channel is removed from the `channels` list users are
        **not** removed from the channel. In order to keep the users in the
        groups and in the channel in sync set `permanent_users` in the channel:

        ```python
        import pulumi
        import pulumi_slack as slack

        my_group = slack.Usergroup("my_group",
            name="TestGroup",
            handle="test",
            description="Test user group",
            users=["USER00"])
        test = slack.Conversation("test",
            name="my-channel",
            topic="The topic for my channel",
            permanent_members=my_group.users,
            is_private=True)
        ```

        ## Import

        `slack_usergroup` can be imported using the ID of the group, e.g.

        ```sh
        $ pulumi import slack:index/usergroup:Usergroup my_group S022GE79E9G
        ```

        :param str resource_name: The name of the resource.
        :param UsergroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(UsergroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 channels: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 handle: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = UsergroupArgs.__new__(UsergroupArgs)

            __props__.__dict__["channels"] = channels
            __props__.__dict__["description"] = description
            __props__.__dict__["handle"] = handle
            __props__.__dict__["name"] = name
            __props__.__dict__["users"] = users
        super(Usergroup, __self__).__init__(
            'slack:index/usergroup:Usergroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            channels: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            handle: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            users: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None) -> 'Usergroup':
        """
        Get an existing Usergroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] channels: channel IDs for which the User Group uses as a default.
        :param pulumi.Input[builtins.str] description: a short description of the User Group.
        :param pulumi.Input[builtins.str] handle: a mention handle. Must be unique among channels, users
               and User Groups.
        :param pulumi.Input[builtins.str] name: a name for the User Group. Must be unique among User Groups.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] users: user IDs that represent the entire list of users for the
               User Group.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _UsergroupState.__new__(_UsergroupState)

        __props__.__dict__["channels"] = channels
        __props__.__dict__["description"] = description
        __props__.__dict__["handle"] = handle
        __props__.__dict__["name"] = name
        __props__.__dict__["users"] = users
        return Usergroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def channels(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        channel IDs for which the User Group uses as a default.
        """
        return pulumi.get(self, "channels")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        a short description of the User Group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def handle(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        a mention handle. Must be unique among channels, users
        and User Groups.
        """
        return pulumi.get(self, "handle")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        a name for the User Group. Must be unique among User Groups.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def users(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        user IDs that represent the entire list of users for the
        User Group.
        """
        return pulumi.get(self, "users")

