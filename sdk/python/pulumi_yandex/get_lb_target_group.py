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
    'GetLbTargetGroupResult',
    'AwaitableGetLbTargetGroupResult',
    'get_lb_target_group',
    'get_lb_target_group_output',
]

@pulumi.output_type
class GetLbTargetGroupResult:
    """
    A collection of values returned by getLbTargetGroup.
    """
    def __init__(__self__, created_at=None, description=None, folder_id=None, id=None, labels=None, name=None, target_group_id=None, targets=None):
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
        if target_group_id and not isinstance(target_group_id, str):
            raise TypeError("Expected argument 'target_group_id' to be a str")
        pulumi.set(__self__, "target_group_id", target_group_id)
        if targets and not isinstance(targets, list):
            raise TypeError("Expected argument 'targets' to be a list")
        pulumi.set(__self__, "targets", targets)

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
    def labels(self) -> Mapping[str, str]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="targetGroupId")
    def target_group_id(self) -> str:
        return pulumi.get(self, "target_group_id")

    @property
    @pulumi.getter
    def targets(self) -> Sequence['outputs.GetLbTargetGroupTargetResult']:
        return pulumi.get(self, "targets")


class AwaitableGetLbTargetGroupResult(GetLbTargetGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLbTargetGroupResult(
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            target_group_id=self.target_group_id,
            targets=self.targets)


def get_lb_target_group(folder_id: Optional[str] = None,
                        name: Optional[str] = None,
                        target_group_id: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLbTargetGroupResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['targetGroupId'] = target_group_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getLbTargetGroup:getLbTargetGroup', __args__, opts=opts, typ=GetLbTargetGroupResult).value

    return AwaitableGetLbTargetGroupResult(
        created_at=pulumi.get(__ret__, 'created_at'),
        description=pulumi.get(__ret__, 'description'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        id=pulumi.get(__ret__, 'id'),
        labels=pulumi.get(__ret__, 'labels'),
        name=pulumi.get(__ret__, 'name'),
        target_group_id=pulumi.get(__ret__, 'target_group_id'),
        targets=pulumi.get(__ret__, 'targets'))


@_utilities.lift_output_func(get_lb_target_group)
def get_lb_target_group_output(folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                               name: Optional[pulumi.Input[Optional[str]]] = None,
                               target_group_id: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetLbTargetGroupResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
