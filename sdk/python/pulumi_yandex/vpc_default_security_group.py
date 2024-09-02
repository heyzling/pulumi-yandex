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

__all__ = ['VpcDefaultSecurityGroupArgs', 'VpcDefaultSecurityGroup']

@pulumi.input_type
class VpcDefaultSecurityGroupArgs:
    def __init__(__self__, *,
                 network_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 egresses: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 ingresses: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a VpcDefaultSecurityGroup resource.
        :param pulumi.Input[str] network_id: ID of the network this security group belongs to.
        :param pulumi.Input[str] description: Description of the security group.
        :param pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]] egresses: A list of egress rules. The structure is documented below.
        :param pulumi.Input[str] folder_id: ID of the folder this security group belongs to.
        :param pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]] ingresses: A list of ingress rules.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this security group.
        """
        pulumi.set(__self__, "network_id", network_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if egresses is not None:
            pulumi.set(__self__, "egresses", egresses)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if ingresses is not None:
            pulumi.set(__self__, "ingresses", ingresses)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Input[str]:
        """
        ID of the network this security group belongs to.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the security group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def egresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]]:
        """
        A list of egress rules. The structure is documented below.
        """
        return pulumi.get(self, "egresses")

    @egresses.setter
    def egresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]]):
        pulumi.set(self, "egresses", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder this security group belongs to.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def ingresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]]:
        """
        A list of ingress rules.
        """
        return pulumi.get(self, "ingresses")

    @ingresses.setter
    def ingresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]]):
        pulumi.set(self, "ingresses", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this security group.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)


@pulumi.input_type
class _VpcDefaultSecurityGroupState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 egresses: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 ingresses: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering VpcDefaultSecurityGroup resources.
        :param pulumi.Input[str] created_at: Creation timestamp of this security group.
        :param pulumi.Input[str] description: Description of the security group.
        :param pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]] egresses: A list of egress rules. The structure is documented below.
        :param pulumi.Input[str] folder_id: ID of the folder this security group belongs to.
        :param pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]] ingresses: A list of ingress rules.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this security group.
        :param pulumi.Input[str] name: Name of this security group.
        :param pulumi.Input[str] network_id: ID of the network this security group belongs to.
        :param pulumi.Input[str] status: Status of this security group.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if egresses is not None:
            pulumi.set(__self__, "egresses", egresses)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if ingresses is not None:
            pulumi.set(__self__, "ingresses", ingresses)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        Creation timestamp of this security group.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the security group.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def egresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]]:
        """
        A list of egress rules. The structure is documented below.
        """
        return pulumi.get(self, "egresses")

    @egresses.setter
    def egresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupEgressArgs']]]]):
        pulumi.set(self, "egresses", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder this security group belongs to.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def ingresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]]:
        """
        A list of ingress rules.
        """
        return pulumi.get(self, "ingresses")

    @ingresses.setter
    def ingresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcDefaultSecurityGroupIngressArgs']]]]):
        pulumi.set(self, "ingresses", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this security group.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of this security group.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the network this security group belongs to.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of this security group.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class VpcDefaultSecurityGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 egresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupEgressArgs']]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 ingresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupIngressArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        lab_net = yandex.VpcNetwork("lab-net")
        default_sg = yandex.VpcDefaultSecurityGroup("default-sg",
            description="description for default security group",
            egresses=[
                yandex.VpcDefaultSecurityGroupEgressArgs(
                    description="rule2 description",
                    from_port=8090,
                    protocol="ANY",
                    to_port=8099,
                    v4_cidr_blocks=[
                        "10.0.1.0/24",
                        "10.0.2.0/24",
                    ],
                ),
                yandex.VpcDefaultSecurityGroupEgressArgs(
                    description="rule3 description",
                    from_port=8090,
                    protocol="UDP",
                    to_port=8099,
                    v4_cidr_blocks=["10.0.1.0/24"],
                ),
            ],
            ingresses=[yandex.VpcDefaultSecurityGroupIngressArgs(
                description="rule1 description",
                port=8080,
                protocol="TCP",
                v4_cidr_blocks=[
                    "10.0.1.0/24",
                    "10.0.2.0/24",
                ],
            )],
            labels={
                "my-label": "my-label-value",
            },
            network_id=lab_net.id)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the security group.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupEgressArgs']]]] egresses: A list of egress rules. The structure is documented below.
        :param pulumi.Input[str] folder_id: ID of the folder this security group belongs to.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupIngressArgs']]]] ingresses: A list of ingress rules.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this security group.
        :param pulumi.Input[str] network_id: ID of the network this security group belongs to.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VpcDefaultSecurityGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        lab_net = yandex.VpcNetwork("lab-net")
        default_sg = yandex.VpcDefaultSecurityGroup("default-sg",
            description="description for default security group",
            egresses=[
                yandex.VpcDefaultSecurityGroupEgressArgs(
                    description="rule2 description",
                    from_port=8090,
                    protocol="ANY",
                    to_port=8099,
                    v4_cidr_blocks=[
                        "10.0.1.0/24",
                        "10.0.2.0/24",
                    ],
                ),
                yandex.VpcDefaultSecurityGroupEgressArgs(
                    description="rule3 description",
                    from_port=8090,
                    protocol="UDP",
                    to_port=8099,
                    v4_cidr_blocks=["10.0.1.0/24"],
                ),
            ],
            ingresses=[yandex.VpcDefaultSecurityGroupIngressArgs(
                description="rule1 description",
                port=8080,
                protocol="TCP",
                v4_cidr_blocks=[
                    "10.0.1.0/24",
                    "10.0.2.0/24",
                ],
            )],
            labels={
                "my-label": "my-label-value",
            },
            network_id=lab_net.id)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param VpcDefaultSecurityGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpcDefaultSecurityGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 egresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupEgressArgs']]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 ingresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupIngressArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpcDefaultSecurityGroupArgs.__new__(VpcDefaultSecurityGroupArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["egresses"] = egresses
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["ingresses"] = ingresses
            __props__.__dict__["labels"] = labels
            if network_id is None and not opts.urn:
                raise TypeError("Missing required property 'network_id'")
            __props__.__dict__["network_id"] = network_id
            __props__.__dict__["created_at"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["status"] = None
        super(VpcDefaultSecurityGroup, __self__).__init__(
            'yandex:index/vpcDefaultSecurityGroup:VpcDefaultSecurityGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            egresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupEgressArgs']]]]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            ingresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupIngressArgs']]]]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network_id: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'VpcDefaultSecurityGroup':
        """
        Get an existing VpcDefaultSecurityGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_at: Creation timestamp of this security group.
        :param pulumi.Input[str] description: Description of the security group.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupEgressArgs']]]] egresses: A list of egress rules. The structure is documented below.
        :param pulumi.Input[str] folder_id: ID of the folder this security group belongs to.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcDefaultSecurityGroupIngressArgs']]]] ingresses: A list of ingress rules.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this security group.
        :param pulumi.Input[str] name: Name of this security group.
        :param pulumi.Input[str] network_id: ID of the network this security group belongs to.
        :param pulumi.Input[str] status: Status of this security group.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VpcDefaultSecurityGroupState.__new__(_VpcDefaultSecurityGroupState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["description"] = description
        __props__.__dict__["egresses"] = egresses
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["ingresses"] = ingresses
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["network_id"] = network_id
        __props__.__dict__["status"] = status
        return VpcDefaultSecurityGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Creation timestamp of this security group.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the security group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def egresses(self) -> pulumi.Output[Sequence['outputs.VpcDefaultSecurityGroupEgress']]:
        """
        A list of egress rules. The structure is documented below.
        """
        return pulumi.get(self, "egresses")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        ID of the folder this security group belongs to.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def ingresses(self) -> pulumi.Output[Sequence['outputs.VpcDefaultSecurityGroupIngress']]:
        """
        A list of ingress rules.
        """
        return pulumi.get(self, "ingresses")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Labels to assign to this security group.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of this security group.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Output[str]:
        """
        ID of the network this security group belongs to.
        """
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status of this security group.
        """
        return pulumi.get(self, "status")

