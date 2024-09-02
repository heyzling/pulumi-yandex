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
from ._inputs import *

__all__ = ['LbNetworkLoadBalancerArgs', 'LbNetworkLoadBalancer']

@pulumi.input_type
class LbNetworkLoadBalancerArgs:
    def __init__(__self__, *,
                 attached_target_groups: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a LbNetworkLoadBalancer resource.
        :param pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]] attached_target_groups: An AttachedTargetGroup resource. The structure is documented below.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the network load balancer from accidental deletion.
        :param pulumi.Input[str] description: An optional description of the network load balancer. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this network load balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]] listeners: Listener specification that will be used by a network load balancer. The structure is documented below.
        :param pulumi.Input[str] name: Name of the network load balancer. Provided by the client when the network load balancer is created.
        :param pulumi.Input[str] region_id: ID of the availability zone where the network load balancer resides.
               If omitted, default region is being used.
        :param pulumi.Input[str] type: Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        if attached_target_groups is not None:
            pulumi.set(__self__, "attached_target_groups", attached_target_groups)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if listeners is not None:
            pulumi.set(__self__, "listeners", listeners)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if region_id is not None:
            pulumi.set(__self__, "region_id", region_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="attachedTargetGroups")
    def attached_target_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]:
        """
        An AttachedTargetGroup resource. The structure is documented below.
        """
        return pulumi.get(self, "attached_target_groups")

    @attached_target_groups.setter
    def attached_target_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]):
        pulumi.set(self, "attached_target_groups", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag that protects the network load balancer from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the network load balancer. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this network load balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def listeners(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]]:
        """
        Listener specification that will be used by a network load balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @listeners.setter
    def listeners(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]]):
        pulumi.set(self, "listeners", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the network load balancer. Provided by the client when the network load balancer is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the availability zone where the network load balancer resides.
        If omitted, default region is being used.
        """
        return pulumi.get(self, "region_id")

    @region_id.setter
    def region_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region_id", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class _LbNetworkLoadBalancerState:
    def __init__(__self__, *,
                 attached_target_groups: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering LbNetworkLoadBalancer resources.
        :param pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]] attached_target_groups: An AttachedTargetGroup resource. The structure is documented below.
        :param pulumi.Input[str] created_at: The network load balancer creation timestamp.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the network load balancer from accidental deletion.
        :param pulumi.Input[str] description: An optional description of the network load balancer. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this network load balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]] listeners: Listener specification that will be used by a network load balancer. The structure is documented below.
        :param pulumi.Input[str] name: Name of the network load balancer. Provided by the client when the network load balancer is created.
        :param pulumi.Input[str] region_id: ID of the availability zone where the network load balancer resides.
               If omitted, default region is being used.
        :param pulumi.Input[str] type: Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        if attached_target_groups is not None:
            pulumi.set(__self__, "attached_target_groups", attached_target_groups)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if listeners is not None:
            pulumi.set(__self__, "listeners", listeners)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if region_id is not None:
            pulumi.set(__self__, "region_id", region_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="attachedTargetGroups")
    def attached_target_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]:
        """
        An AttachedTargetGroup resource. The structure is documented below.
        """
        return pulumi.get(self, "attached_target_groups")

    @attached_target_groups.setter
    def attached_target_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]):
        pulumi.set(self, "attached_target_groups", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        The network load balancer creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag that protects the network load balancer from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the network load balancer. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this network load balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def listeners(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]]:
        """
        Listener specification that will be used by a network load balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @listeners.setter
    def listeners(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LbNetworkLoadBalancerListenerArgs']]]]):
        pulumi.set(self, "listeners", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the network load balancer. Provided by the client when the network load balancer is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the availability zone where the network load balancer resides.
        If omitted, default region is being used.
        """
        return pulumi.get(self, "region_id")

    @region_id.setter
    def region_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region_id", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


class LbNetworkLoadBalancer(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 attached_target_groups: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerListenerArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Creates a network load balancer in the specified folder using the data specified in the config.
        For more information, see [the official documentation](https://cloud.yandex.com/docs/load-balancer/concepts).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo = yandex.LbNetworkLoadBalancer("foo",
            attached_target_groups=[yandex.LbNetworkLoadBalancerAttachedTargetGroupArgs(
                healthchecks=[yandex.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs(
                    http_options=yandex.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsArgs(
                        path="/ping",
                        port=8080,
                    ),
                    name="http",
                )],
                target_group_id=yandex_lb_target_group["my-target-group"]["id"],
            )],
            listeners=[yandex.LbNetworkLoadBalancerListenerArgs(
                external_address_spec=yandex.LbNetworkLoadBalancerListenerExternalAddressSpecArgs(
                    ip_version="ipv4",
                ),
                name="my-listener",
                port=8080,
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A network load balancer can be imported using the `id` of the resource, e.g.:

        ```sh
        $ pulumi import yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer default network_load_balancer_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]] attached_target_groups: An AttachedTargetGroup resource. The structure is documented below.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the network load balancer from accidental deletion.
        :param pulumi.Input[str] description: An optional description of the network load balancer. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this network load balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerListenerArgs']]]] listeners: Listener specification that will be used by a network load balancer. The structure is documented below.
        :param pulumi.Input[str] name: Name of the network load balancer. Provided by the client when the network load balancer is created.
        :param pulumi.Input[str] region_id: ID of the availability zone where the network load balancer resides.
               If omitted, default region is being used.
        :param pulumi.Input[str] type: Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[LbNetworkLoadBalancerArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates a network load balancer in the specified folder using the data specified in the config.
        For more information, see [the official documentation](https://cloud.yandex.com/docs/load-balancer/concepts).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo = yandex.LbNetworkLoadBalancer("foo",
            attached_target_groups=[yandex.LbNetworkLoadBalancerAttachedTargetGroupArgs(
                healthchecks=[yandex.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs(
                    http_options=yandex.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsArgs(
                        path="/ping",
                        port=8080,
                    ),
                    name="http",
                )],
                target_group_id=yandex_lb_target_group["my-target-group"]["id"],
            )],
            listeners=[yandex.LbNetworkLoadBalancerListenerArgs(
                external_address_spec=yandex.LbNetworkLoadBalancerListenerExternalAddressSpecArgs(
                    ip_version="ipv4",
                ),
                name="my-listener",
                port=8080,
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A network load balancer can be imported using the `id` of the resource, e.g.:

        ```sh
        $ pulumi import yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer default network_load_balancer_id
        ```

        :param str resource_name: The name of the resource.
        :param LbNetworkLoadBalancerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LbNetworkLoadBalancerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 attached_target_groups: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerListenerArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LbNetworkLoadBalancerArgs.__new__(LbNetworkLoadBalancerArgs)

            __props__.__dict__["attached_target_groups"] = attached_target_groups
            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["listeners"] = listeners
            __props__.__dict__["name"] = name
            __props__.__dict__["region_id"] = region_id
            __props__.__dict__["type"] = type
            __props__.__dict__["created_at"] = None
        super(LbNetworkLoadBalancer, __self__).__init__(
            'yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            attached_target_groups: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerListenerArgs']]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            region_id: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'LbNetworkLoadBalancer':
        """
        Get an existing LbNetworkLoadBalancer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerAttachedTargetGroupArgs']]]] attached_target_groups: An AttachedTargetGroup resource. The structure is documented below.
        :param pulumi.Input[str] created_at: The network load balancer creation timestamp.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the network load balancer from accidental deletion.
        :param pulumi.Input[str] description: An optional description of the network load balancer. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this network load balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LbNetworkLoadBalancerListenerArgs']]]] listeners: Listener specification that will be used by a network load balancer. The structure is documented below.
        :param pulumi.Input[str] name: Name of the network load balancer. Provided by the client when the network load balancer is created.
        :param pulumi.Input[str] region_id: ID of the availability zone where the network load balancer resides.
               If omitted, default region is being used.
        :param pulumi.Input[str] type: Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LbNetworkLoadBalancerState.__new__(_LbNetworkLoadBalancerState)

        __props__.__dict__["attached_target_groups"] = attached_target_groups
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["listeners"] = listeners
        __props__.__dict__["name"] = name
        __props__.__dict__["region_id"] = region_id
        __props__.__dict__["type"] = type
        return LbNetworkLoadBalancer(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="attachedTargetGroups")
    def attached_target_groups(self) -> pulumi.Output[Optional[Sequence['outputs.LbNetworkLoadBalancerAttachedTargetGroup']]]:
        """
        An AttachedTargetGroup resource. The structure is documented below.
        """
        return pulumi.get(self, "attached_target_groups")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The network load balancer creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[bool]:
        """
        Flag that protects the network load balancer from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        An optional description of the network load balancer. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Labels to assign to this network load balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def listeners(self) -> pulumi.Output[Optional[Sequence['outputs.LbNetworkLoadBalancerListener']]]:
        """
        Listener specification that will be used by a network load balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the network load balancer. Provided by the client when the network load balancer is created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> pulumi.Output[str]:
        """
        ID of the availability zone where the network load balancer resides.
        If omitted, default region is being used.
        """
        return pulumi.get(self, "region_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Type of the network load balancer. Must be one of 'external' or 'internal'. The default is 'external'.
        """
        return pulumi.get(self, "type")

