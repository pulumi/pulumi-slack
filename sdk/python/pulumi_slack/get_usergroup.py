# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

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

__all__ = [
    'GetUsergroupResult',
    'AwaitableGetUsergroupResult',
    'get_usergroup',
    'get_usergroup_output',
]

@pulumi.output_type
class GetUsergroupResult:
    """
    A collection of values returned by getUsergroup.
    """
    def __init__(__self__, channels=None, description=None, handle=None, id=None, name=None, usergroup_id=None, users=None):
        if channels and not isinstance(channels, list):
            raise TypeError("Expected argument 'channels' to be a list")
        pulumi.set(__self__, "channels", channels)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if handle and not isinstance(handle, str):
            raise TypeError("Expected argument 'handle' to be a str")
        pulumi.set(__self__, "handle", handle)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if usergroup_id and not isinstance(usergroup_id, str):
            raise TypeError("Expected argument 'usergroup_id' to be a str")
        pulumi.set(__self__, "usergroup_id", usergroup_id)
        if users and not isinstance(users, list):
            raise TypeError("Expected argument 'users' to be a list")
        pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter
    def channels(self) -> Sequence[str]:
        """
        The channel IDs for which the User Group uses as a default.
        """
        return pulumi.get(self, "channels")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The short description of the User Group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def handle(self) -> str:
        """
        The mention handle.
        """
        return pulumi.get(self, "handle")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="usergroupId")
    def usergroup_id(self) -> Optional[str]:
        return pulumi.get(self, "usergroup_id")

    @property
    @pulumi.getter
    def users(self) -> Sequence[str]:
        """
        The user IDs that represent the entire list of users for the
        User Group.
        """
        return pulumi.get(self, "users")


class AwaitableGetUsergroupResult(GetUsergroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUsergroupResult(
            channels=self.channels,
            description=self.description,
            handle=self.handle,
            id=self.id,
            name=self.name,
            usergroup_id=self.usergroup_id,
            users=self.users)


def get_usergroup(name: Optional[str] = None,
                  usergroup_id: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUsergroupResult:
    """
    Use this data source to get information about a usergroups for use in other
    resources. The data source returns enabled groups only.

    ## Required scopes

    This resource requires the following scopes:

    - [usergroups:read](https://api.slack.com/scopes/usergroups:read)

    The Slack API methods used by the resource are:

    - [usergroups.list](https://api.slack.com/methods/usergroups.list)

    If you get `missing_scope` errors while using this resource check the scopes against
    the documentation for the methods above.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_slack as slack

    by_name = slack.get_usergroup(name="my-usergroup")
    by_id = slack.get_usergroup(usergroup_id="USERGROUP00")
    ```


    :param str name: The name of the usergroup
    :param str usergroup_id: The id of the usergroup
           
           The data source expects exactly one of these fields, you can't set both.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['usergroupId'] = usergroup_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('slack:index/getUsergroup:getUsergroup', __args__, opts=opts, typ=GetUsergroupResult).value

    return AwaitableGetUsergroupResult(
        channels=pulumi.get(__ret__, 'channels'),
        description=pulumi.get(__ret__, 'description'),
        handle=pulumi.get(__ret__, 'handle'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        usergroup_id=pulumi.get(__ret__, 'usergroup_id'),
        users=pulumi.get(__ret__, 'users'))
def get_usergroup_output(name: Optional[pulumi.Input[Optional[str]]] = None,
                         usergroup_id: Optional[pulumi.Input[Optional[str]]] = None,
                         opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetUsergroupResult]:
    """
    Use this data source to get information about a usergroups for use in other
    resources. The data source returns enabled groups only.

    ## Required scopes

    This resource requires the following scopes:

    - [usergroups:read](https://api.slack.com/scopes/usergroups:read)

    The Slack API methods used by the resource are:

    - [usergroups.list](https://api.slack.com/methods/usergroups.list)

    If you get `missing_scope` errors while using this resource check the scopes against
    the documentation for the methods above.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_slack as slack

    by_name = slack.get_usergroup(name="my-usergroup")
    by_id = slack.get_usergroup(usergroup_id="USERGROUP00")
    ```


    :param str name: The name of the usergroup
    :param str usergroup_id: The id of the usergroup
           
           The data source expects exactly one of these fields, you can't set both.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['usergroupId'] = usergroup_id
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('slack:index/getUsergroup:getUsergroup', __args__, opts=opts, typ=GetUsergroupResult)
    return __ret__.apply(lambda __response__: GetUsergroupResult(
        channels=pulumi.get(__response__, 'channels'),
        description=pulumi.get(__response__, 'description'),
        handle=pulumi.get(__response__, 'handle'),
        id=pulumi.get(__response__, 'id'),
        name=pulumi.get(__response__, 'name'),
        usergroup_id=pulumi.get(__response__, 'usergroup_id'),
        users=pulumi.get(__response__, 'users')))
