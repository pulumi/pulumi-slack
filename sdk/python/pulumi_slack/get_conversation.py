# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins as _builtins
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
    'GetConversationResult',
    'AwaitableGetConversationResult',
    'get_conversation',
    'get_conversation_output',
]

@pulumi.output_type
class GetConversationResult:
    """
    A collection of values returned by getConversation.
    """
    def __init__(__self__, channel_id=None, created=None, creator=None, id=None, is_archived=None, is_ext_shared=None, is_general=None, is_org_shared=None, is_private=None, is_shared=None, name=None, purpose=None, topic=None):
        if channel_id and not isinstance(channel_id, str):
            raise TypeError("Expected argument 'channel_id' to be a str")
        pulumi.set(__self__, "channel_id", channel_id)
        if created and not isinstance(created, int):
            raise TypeError("Expected argument 'created' to be a int")
        pulumi.set(__self__, "created", created)
        if creator and not isinstance(creator, str):
            raise TypeError("Expected argument 'creator' to be a str")
        pulumi.set(__self__, "creator", creator)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if is_archived and not isinstance(is_archived, bool):
            raise TypeError("Expected argument 'is_archived' to be a bool")
        pulumi.set(__self__, "is_archived", is_archived)
        if is_ext_shared and not isinstance(is_ext_shared, bool):
            raise TypeError("Expected argument 'is_ext_shared' to be a bool")
        pulumi.set(__self__, "is_ext_shared", is_ext_shared)
        if is_general and not isinstance(is_general, bool):
            raise TypeError("Expected argument 'is_general' to be a bool")
        pulumi.set(__self__, "is_general", is_general)
        if is_org_shared and not isinstance(is_org_shared, bool):
            raise TypeError("Expected argument 'is_org_shared' to be a bool")
        pulumi.set(__self__, "is_org_shared", is_org_shared)
        if is_private and not isinstance(is_private, bool):
            raise TypeError("Expected argument 'is_private' to be a bool")
        pulumi.set(__self__, "is_private", is_private)
        if is_shared and not isinstance(is_shared, bool):
            raise TypeError("Expected argument 'is_shared' to be a bool")
        pulumi.set(__self__, "is_shared", is_shared)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if purpose and not isinstance(purpose, str):
            raise TypeError("Expected argument 'purpose' to be a str")
        pulumi.set(__self__, "purpose", purpose)
        if topic and not isinstance(topic, str):
            raise TypeError("Expected argument 'topic' to be a str")
        pulumi.set(__self__, "topic", topic)

    @_builtins.property
    @pulumi.getter(name="channelId")
    def channel_id(self) -> Optional[_builtins.str]:
        return pulumi.get(self, "channel_id")

    @_builtins.property
    @pulumi.getter
    def created(self) -> _builtins.int:
        """
        is a unix timestamp.
        """
        return pulumi.get(self, "created")

    @_builtins.property
    @pulumi.getter
    def creator(self) -> _builtins.str:
        """
        is the user ID of the member that created this channel.
        """
        return pulumi.get(self, "creator")

    @_builtins.property
    @pulumi.getter
    def id(self) -> _builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @_builtins.property
    @pulumi.getter(name="isArchived")
    def is_archived(self) -> _builtins.bool:
        """
        indicates a conversation is archived. Frozen in time.
        """
        return pulumi.get(self, "is_archived")

    @_builtins.property
    @pulumi.getter(name="isExtShared")
    def is_ext_shared(self) -> _builtins.bool:
        """
        represents this conversation as being part of a Shared Channel
        with a remote organization.
        """
        return pulumi.get(self, "is_ext_shared")

    @_builtins.property
    @pulumi.getter(name="isGeneral")
    def is_general(self) -> _builtins.bool:
        """
        will be true if this channel is the "general" channel that includes
        all regular team members.
        """
        return pulumi.get(self, "is_general")

    @_builtins.property
    @pulumi.getter(name="isOrgShared")
    def is_org_shared(self) -> _builtins.bool:
        """
        explains whether this shared channel is shared between Enterprise
        Grid workspaces within the same organization.
        """
        return pulumi.get(self, "is_org_shared")

    @_builtins.property
    @pulumi.getter(name="isPrivate")
    def is_private(self) -> Optional[_builtins.bool]:
        """
        means the conversation is privileged between two or more members.
        """
        return pulumi.get(self, "is_private")

    @_builtins.property
    @pulumi.getter(name="isShared")
    def is_shared(self) -> _builtins.bool:
        """
        means the conversation is in some way shared between multiple workspaces.
        """
        return pulumi.get(self, "is_shared")

    @_builtins.property
    @pulumi.getter
    def name(self) -> Optional[_builtins.str]:
        """
        name of the public or private channel.
        """
        return pulumi.get(self, "name")

    @_builtins.property
    @pulumi.getter
    def purpose(self) -> _builtins.str:
        """
        purpose of the channel.
        """
        return pulumi.get(self, "purpose")

    @_builtins.property
    @pulumi.getter
    def topic(self) -> _builtins.str:
        """
        topic for the channel.
        """
        return pulumi.get(self, "topic")


class AwaitableGetConversationResult(GetConversationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetConversationResult(
            channel_id=self.channel_id,
            created=self.created,
            creator=self.creator,
            id=self.id,
            is_archived=self.is_archived,
            is_ext_shared=self.is_ext_shared,
            is_general=self.is_general,
            is_org_shared=self.is_org_shared,
            is_private=self.is_private,
            is_shared=self.is_shared,
            name=self.name,
            purpose=self.purpose,
            topic=self.topic)


def get_conversation(channel_id: Optional[_builtins.str] = None,
                     is_private: Optional[_builtins.bool] = None,
                     name: Optional[_builtins.str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetConversationResult:
    """
    Use this data source to get information about a Slack conversation for use in other
    resources.

    ## Required scopes

    This resource requires the following scopes:

    - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
    - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)

    The Slack API methods used by the resource are:

    - [conversations.info](https://api.slack.com/methods/conversations.info)
    - [conversations.members](https://api.slack.com/methods/conversations.members)

    If you get `missing_scope` errors while using this resource check the scopes against
    the documentation for the methods above.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_slack as slack

    test = slack.get_conversation(channel_id="my-channel")
    test_name = slack.get_conversation(name="my-channel-name")
    ```


    :param _builtins.str channel_id: The ID of the channel
    :param _builtins.bool is_private: The conversation is privileged between two or more members
           
           Either `channel_id` or `name` must be provided. `is_private` only works in conjunction
           with `name`.
    :param _builtins.str name: The name of the public or private channel
    """
    __args__ = dict()
    __args__['channelId'] = channel_id
    __args__['isPrivate'] = is_private
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('slack:index/getConversation:getConversation', __args__, opts=opts, typ=GetConversationResult).value

    return AwaitableGetConversationResult(
        channel_id=pulumi.get(__ret__, 'channel_id'),
        created=pulumi.get(__ret__, 'created'),
        creator=pulumi.get(__ret__, 'creator'),
        id=pulumi.get(__ret__, 'id'),
        is_archived=pulumi.get(__ret__, 'is_archived'),
        is_ext_shared=pulumi.get(__ret__, 'is_ext_shared'),
        is_general=pulumi.get(__ret__, 'is_general'),
        is_org_shared=pulumi.get(__ret__, 'is_org_shared'),
        is_private=pulumi.get(__ret__, 'is_private'),
        is_shared=pulumi.get(__ret__, 'is_shared'),
        name=pulumi.get(__ret__, 'name'),
        purpose=pulumi.get(__ret__, 'purpose'),
        topic=pulumi.get(__ret__, 'topic'))
def get_conversation_output(channel_id: Optional[pulumi.Input[Optional[_builtins.str]]] = None,
                            is_private: Optional[pulumi.Input[Optional[_builtins.bool]]] = None,
                            name: Optional[pulumi.Input[Optional[_builtins.str]]] = None,
                            opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetConversationResult]:
    """
    Use this data source to get information about a Slack conversation for use in other
    resources.

    ## Required scopes

    This resource requires the following scopes:

    - [channels:read](https://api.slack.com/scopes/channels:read) (public channels)
    - [groups:read](https://api.slack.com/scopes/groups:read) (private channels)

    The Slack API methods used by the resource are:

    - [conversations.info](https://api.slack.com/methods/conversations.info)
    - [conversations.members](https://api.slack.com/methods/conversations.members)

    If you get `missing_scope` errors while using this resource check the scopes against
    the documentation for the methods above.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_slack as slack

    test = slack.get_conversation(channel_id="my-channel")
    test_name = slack.get_conversation(name="my-channel-name")
    ```


    :param _builtins.str channel_id: The ID of the channel
    :param _builtins.bool is_private: The conversation is privileged between two or more members
           
           Either `channel_id` or `name` must be provided. `is_private` only works in conjunction
           with `name`.
    :param _builtins.str name: The name of the public or private channel
    """
    __args__ = dict()
    __args__['channelId'] = channel_id
    __args__['isPrivate'] = is_private
    __args__['name'] = name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('slack:index/getConversation:getConversation', __args__, opts=opts, typ=GetConversationResult)
    return __ret__.apply(lambda __response__: GetConversationResult(
        channel_id=pulumi.get(__response__, 'channel_id'),
        created=pulumi.get(__response__, 'created'),
        creator=pulumi.get(__response__, 'creator'),
        id=pulumi.get(__response__, 'id'),
        is_archived=pulumi.get(__response__, 'is_archived'),
        is_ext_shared=pulumi.get(__response__, 'is_ext_shared'),
        is_general=pulumi.get(__response__, 'is_general'),
        is_org_shared=pulumi.get(__response__, 'is_org_shared'),
        is_private=pulumi.get(__response__, 'is_private'),
        is_shared=pulumi.get(__response__, 'is_shared'),
        name=pulumi.get(__response__, 'name'),
        purpose=pulumi.get(__response__, 'purpose'),
        topic=pulumi.get(__response__, 'topic')))
