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
    'GetResourcemanagerFolderResult',
    'AwaitableGetResourcemanagerFolderResult',
    'get_resourcemanager_folder',
    'get_resourcemanager_folder_output',
]

@pulumi.output_type
class GetResourcemanagerFolderResult:
    """
    A collection of values returned by getResourcemanagerFolder.
    """
    def __init__(__self__, cloud_id=None, created_at=None, description=None, folder_id=None, id=None, labels=None, name=None, status=None):
        if cloud_id and not isinstance(cloud_id, str):
            raise TypeError("Expected argument 'cloud_id' to be a str")
        pulumi.set(__self__, "cloud_id", cloud_id)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

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
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")


class AwaitableGetResourcemanagerFolderResult(GetResourcemanagerFolderResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetResourcemanagerFolderResult(
            cloud_id=self.cloud_id,
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            status=self.status)


def get_resourcemanager_folder(cloud_id: Optional[str] = None,
                               folder_id: Optional[str] = None,
                               labels: Optional[Mapping[str, str]] = None,
                               name: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetResourcemanagerFolderResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['cloudId'] = cloud_id
    __args__['folderId'] = folder_id
    __args__['labels'] = labels
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getResourcemanagerFolder:getResourcemanagerFolder', __args__, opts=opts, typ=GetResourcemanagerFolderResult).value

    return AwaitableGetResourcemanagerFolderResult(
        cloud_id=pulumi.get(__ret__, 'cloud_id'),
        created_at=pulumi.get(__ret__, 'created_at'),
        description=pulumi.get(__ret__, 'description'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        id=pulumi.get(__ret__, 'id'),
        labels=pulumi.get(__ret__, 'labels'),
        name=pulumi.get(__ret__, 'name'),
        status=pulumi.get(__ret__, 'status'))


@_utilities.lift_output_func(get_resourcemanager_folder)
def get_resourcemanager_folder_output(cloud_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      labels: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                                      name: Optional[pulumi.Input[Optional[str]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetResourcemanagerFolderResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
