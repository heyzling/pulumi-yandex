# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetOrganizationmanagerGroupResult',
    'AwaitableGetOrganizationmanagerGroupResult',
    'get_organizationmanager_group',
    'get_organizationmanager_group_output',
]

@pulumi.output_type
class GetOrganizationmanagerGroupResult:
    """
    A collection of values returned by getOrganizationmanagerGroup.
    """
    def __init__(__self__, created_at=None, description=None, group_id=None, id=None, members=None, name=None, organization_id=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if members and not isinstance(members, list):
            raise TypeError("Expected argument 'members' to be a list")
        pulumi.set(__self__, "members", members)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if organization_id and not isinstance(organization_id, str):
            raise TypeError("Expected argument 'organization_id' to be a str")
        pulumi.set(__self__, "organization_id", organization_id)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> str:
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def members(self) -> Sequence['outputs.GetOrganizationmanagerGroupMemberResult']:
        return pulumi.get(self, "members")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> Optional[str]:
        return pulumi.get(self, "organization_id")


class AwaitableGetOrganizationmanagerGroupResult(GetOrganizationmanagerGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetOrganizationmanagerGroupResult(
            created_at=self.created_at,
            description=self.description,
            group_id=self.group_id,
            id=self.id,
            members=self.members,
            name=self.name,
            organization_id=self.organization_id)


def get_organizationmanager_group(group_id: Optional[str] = None,
                                  name: Optional[str] = None,
                                  organization_id: Optional[str] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetOrganizationmanagerGroupResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['groupId'] = group_id
    __args__['name'] = name
    __args__['organizationId'] = organization_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getOrganizationmanagerGroup:getOrganizationmanagerGroup', __args__, opts=opts, typ=GetOrganizationmanagerGroupResult).value

    return AwaitableGetOrganizationmanagerGroupResult(
        created_at=pulumi.get(__ret__, 'created_at'),
        description=pulumi.get(__ret__, 'description'),
        group_id=pulumi.get(__ret__, 'group_id'),
        id=pulumi.get(__ret__, 'id'),
        members=pulumi.get(__ret__, 'members'),
        name=pulumi.get(__ret__, 'name'),
        organization_id=pulumi.get(__ret__, 'organization_id'))


@_utilities.lift_output_func(get_organizationmanager_group)
def get_organizationmanager_group_output(group_id: Optional[pulumi.Input[Optional[str]]] = None,
                                         name: Optional[pulumi.Input[Optional[str]]] = None,
                                         organization_id: Optional[pulumi.Input[Optional[str]]] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetOrganizationmanagerGroupResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
