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
    'GetIamServiceAgentResult',
    'AwaitableGetIamServiceAgentResult',
    'get_iam_service_agent',
    'get_iam_service_agent_output',
]

@pulumi.output_type
class GetIamServiceAgentResult:
    """
    A collection of values returned by getIamServiceAgent.
    """
    def __init__(__self__, cloud_id=None, id=None, microservice_id=None, service_id=None):
        if cloud_id and not isinstance(cloud_id, str):
            raise TypeError("Expected argument 'cloud_id' to be a str")
        pulumi.set(__self__, "cloud_id", cloud_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if microservice_id and not isinstance(microservice_id, str):
            raise TypeError("Expected argument 'microservice_id' to be a str")
        pulumi.set(__self__, "microservice_id", microservice_id)
        if service_id and not isinstance(service_id, str):
            raise TypeError("Expected argument 'service_id' to be a str")
        pulumi.set(__self__, "service_id", service_id)

    @property
    @pulumi.getter(name="cloudId")
    def cloud_id(self) -> str:
        return pulumi.get(self, "cloud_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="microserviceId")
    def microservice_id(self) -> str:
        return pulumi.get(self, "microservice_id")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> str:
        return pulumi.get(self, "service_id")


class AwaitableGetIamServiceAgentResult(GetIamServiceAgentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIamServiceAgentResult(
            cloud_id=self.cloud_id,
            id=self.id,
            microservice_id=self.microservice_id,
            service_id=self.service_id)


def get_iam_service_agent(cloud_id: Optional[str] = None,
                          microservice_id: Optional[str] = None,
                          service_id: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIamServiceAgentResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['cloudId'] = cloud_id
    __args__['microserviceId'] = microservice_id
    __args__['serviceId'] = service_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getIamServiceAgent:getIamServiceAgent', __args__, opts=opts, typ=GetIamServiceAgentResult).value

    return AwaitableGetIamServiceAgentResult(
        cloud_id=pulumi.get(__ret__, 'cloud_id'),
        id=pulumi.get(__ret__, 'id'),
        microservice_id=pulumi.get(__ret__, 'microservice_id'),
        service_id=pulumi.get(__ret__, 'service_id'))


@_utilities.lift_output_func(get_iam_service_agent)
def get_iam_service_agent_output(cloud_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 microservice_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 service_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIamServiceAgentResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
