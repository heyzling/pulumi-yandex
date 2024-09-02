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
    'GetAlbVirtualHostResult',
    'AwaitableGetAlbVirtualHostResult',
    'get_alb_virtual_host',
    'get_alb_virtual_host_output',
]

@pulumi.output_type
class GetAlbVirtualHostResult:
    """
    A collection of values returned by getAlbVirtualHost.
    """
    def __init__(__self__, authorities=None, http_router_id=None, id=None, modify_request_headers=None, modify_response_headers=None, name=None, route_options=None, routes=None, virtual_host_id=None):
        if authorities and not isinstance(authorities, list):
            raise TypeError("Expected argument 'authorities' to be a list")
        pulumi.set(__self__, "authorities", authorities)
        if http_router_id and not isinstance(http_router_id, str):
            raise TypeError("Expected argument 'http_router_id' to be a str")
        pulumi.set(__self__, "http_router_id", http_router_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if modify_request_headers and not isinstance(modify_request_headers, list):
            raise TypeError("Expected argument 'modify_request_headers' to be a list")
        pulumi.set(__self__, "modify_request_headers", modify_request_headers)
        if modify_response_headers and not isinstance(modify_response_headers, list):
            raise TypeError("Expected argument 'modify_response_headers' to be a list")
        pulumi.set(__self__, "modify_response_headers", modify_response_headers)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if route_options and not isinstance(route_options, list):
            raise TypeError("Expected argument 'route_options' to be a list")
        pulumi.set(__self__, "route_options", route_options)
        if routes and not isinstance(routes, list):
            raise TypeError("Expected argument 'routes' to be a list")
        pulumi.set(__self__, "routes", routes)
        if virtual_host_id and not isinstance(virtual_host_id, str):
            raise TypeError("Expected argument 'virtual_host_id' to be a str")
        pulumi.set(__self__, "virtual_host_id", virtual_host_id)

    @property
    @pulumi.getter
    def authorities(self) -> Sequence[str]:
        return pulumi.get(self, "authorities")

    @property
    @pulumi.getter(name="httpRouterId")
    def http_router_id(self) -> str:
        return pulumi.get(self, "http_router_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="modifyRequestHeaders")
    def modify_request_headers(self) -> Sequence['outputs.GetAlbVirtualHostModifyRequestHeaderResult']:
        return pulumi.get(self, "modify_request_headers")

    @property
    @pulumi.getter(name="modifyResponseHeaders")
    def modify_response_headers(self) -> Sequence['outputs.GetAlbVirtualHostModifyResponseHeaderResult']:
        return pulumi.get(self, "modify_response_headers")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="routeOptions")
    def route_options(self) -> Sequence['outputs.GetAlbVirtualHostRouteOptionResult']:
        return pulumi.get(self, "route_options")

    @property
    @pulumi.getter
    def routes(self) -> Sequence['outputs.GetAlbVirtualHostRouteResult']:
        return pulumi.get(self, "routes")

    @property
    @pulumi.getter(name="virtualHostId")
    def virtual_host_id(self) -> str:
        return pulumi.get(self, "virtual_host_id")


class AwaitableGetAlbVirtualHostResult(GetAlbVirtualHostResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlbVirtualHostResult(
            authorities=self.authorities,
            http_router_id=self.http_router_id,
            id=self.id,
            modify_request_headers=self.modify_request_headers,
            modify_response_headers=self.modify_response_headers,
            name=self.name,
            route_options=self.route_options,
            routes=self.routes,
            virtual_host_id=self.virtual_host_id)


def get_alb_virtual_host(http_router_id: Optional[str] = None,
                         name: Optional[str] = None,
                         virtual_host_id: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlbVirtualHostResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['httpRouterId'] = http_router_id
    __args__['name'] = name
    __args__['virtualHostId'] = virtual_host_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getAlbVirtualHost:getAlbVirtualHost', __args__, opts=opts, typ=GetAlbVirtualHostResult).value

    return AwaitableGetAlbVirtualHostResult(
        authorities=pulumi.get(__ret__, 'authorities'),
        http_router_id=pulumi.get(__ret__, 'http_router_id'),
        id=pulumi.get(__ret__, 'id'),
        modify_request_headers=pulumi.get(__ret__, 'modify_request_headers'),
        modify_response_headers=pulumi.get(__ret__, 'modify_response_headers'),
        name=pulumi.get(__ret__, 'name'),
        route_options=pulumi.get(__ret__, 'route_options'),
        routes=pulumi.get(__ret__, 'routes'),
        virtual_host_id=pulumi.get(__ret__, 'virtual_host_id'))


@_utilities.lift_output_func(get_alb_virtual_host)
def get_alb_virtual_host_output(http_router_id: Optional[pulumi.Input[Optional[str]]] = None,
                                name: Optional[pulumi.Input[Optional[str]]] = None,
                                virtual_host_id: Optional[pulumi.Input[Optional[str]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAlbVirtualHostResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
