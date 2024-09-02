# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetResourcemanagerCloudResult',
    'AwaitableGetResourcemanagerCloudResult',
    'get_resourcemanager_cloud',
    'get_resourcemanager_cloud_output',
]

@pulumi.output_type
class GetResourcemanagerCloudResult:
    """
    A collection of values returned by getResourcemanagerCloud.
    """
    def __init__(__self__, cloud_id=None, created_at=None, description=None, id=None, name=None):
        if cloud_id and not isinstance(cloud_id, str):
            raise TypeError("Expected argument 'cloud_id' to be a str")
        pulumi.set(__self__, "cloud_id", cloud_id)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="cloudId")
    def cloud_id(self) -> str:
        return pulumi.get(self, "cloud_id")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")


class AwaitableGetResourcemanagerCloudResult(GetResourcemanagerCloudResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetResourcemanagerCloudResult(
            cloud_id=self.cloud_id,
            created_at=self.created_at,
            description=self.description,
            id=self.id,
            name=self.name)


def get_resourcemanager_cloud(cloud_id: Optional[str] = None,
                              description: Optional[str] = None,
                              name: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetResourcemanagerCloudResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['cloudId'] = cloud_id
    __args__['description'] = description
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getResourcemanagerCloud:getResourcemanagerCloud', __args__, opts=opts, typ=GetResourcemanagerCloudResult).value

    return AwaitableGetResourcemanagerCloudResult(
        cloud_id=pulumi.get(__ret__, 'cloud_id'),
        created_at=pulumi.get(__ret__, 'created_at'),
        description=pulumi.get(__ret__, 'description'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'))


@_utilities.lift_output_func(get_resourcemanager_cloud)
def get_resourcemanager_cloud_output(cloud_id: Optional[pulumi.Input[Optional[str]]] = None,
                                     description: Optional[pulumi.Input[Optional[str]]] = None,
                                     name: Optional[pulumi.Input[Optional[str]]] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetResourcemanagerCloudResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
