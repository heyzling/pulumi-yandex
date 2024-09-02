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
    'GetIotCoreBrokerResult',
    'AwaitableGetIotCoreBrokerResult',
    'get_iot_core_broker',
    'get_iot_core_broker_output',
]

@pulumi.output_type
class GetIotCoreBrokerResult:
    """
    A collection of values returned by getIotCoreBroker.
    """
    def __init__(__self__, broker_id=None, certificates=None, created_at=None, description=None, folder_id=None, id=None, labels=None, log_options=None, name=None):
        if broker_id and not isinstance(broker_id, str):
            raise TypeError("Expected argument 'broker_id' to be a str")
        pulumi.set(__self__, "broker_id", broker_id)
        if certificates and not isinstance(certificates, list):
            raise TypeError("Expected argument 'certificates' to be a list")
        pulumi.set(__self__, "certificates", certificates)
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
        if log_options and not isinstance(log_options, list):
            raise TypeError("Expected argument 'log_options' to be a list")
        pulumi.set(__self__, "log_options", log_options)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="brokerId")
    def broker_id(self) -> Optional[str]:
        return pulumi.get(self, "broker_id")

    @property
    @pulumi.getter
    def certificates(self) -> Sequence[str]:
        return pulumi.get(self, "certificates")

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
    def folder_id(self) -> Optional[str]:
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
    @pulumi.getter(name="logOptions")
    def log_options(self) -> Sequence['outputs.GetIotCoreBrokerLogOptionResult']:
        return pulumi.get(self, "log_options")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")


class AwaitableGetIotCoreBrokerResult(GetIotCoreBrokerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIotCoreBrokerResult(
            broker_id=self.broker_id,
            certificates=self.certificates,
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            log_options=self.log_options,
            name=self.name)


def get_iot_core_broker(broker_id: Optional[str] = None,
                        folder_id: Optional[str] = None,
                        name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIotCoreBrokerResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['brokerId'] = broker_id
    __args__['folderId'] = folder_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getIotCoreBroker:getIotCoreBroker', __args__, opts=opts, typ=GetIotCoreBrokerResult).value

    return AwaitableGetIotCoreBrokerResult(
        broker_id=pulumi.get(__ret__, 'broker_id'),
        certificates=pulumi.get(__ret__, 'certificates'),
        created_at=pulumi.get(__ret__, 'created_at'),
        description=pulumi.get(__ret__, 'description'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        id=pulumi.get(__ret__, 'id'),
        labels=pulumi.get(__ret__, 'labels'),
        log_options=pulumi.get(__ret__, 'log_options'),
        name=pulumi.get(__ret__, 'name'))


@_utilities.lift_output_func(get_iot_core_broker)
def get_iot_core_broker_output(broker_id: Optional[pulumi.Input[Optional[str]]] = None,
                               folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                               name: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIotCoreBrokerResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...