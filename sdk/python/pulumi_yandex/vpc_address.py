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

__all__ = ['VpcAddressArgs', 'VpcAddress']

@pulumi.input_type
class VpcAddressArgs:
    def __init__(__self__, *,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_records: Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]] = None,
                 external_ipv4_address: Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a VpcAddress resource.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the address from accidental deletion.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when
               you create the resource.
        :param pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]] dns_records: DNS record specification of address
        :param pulumi.Input['VpcAddressExternalIpv4AddressArgs'] external_ipv4_address: spec of IP v4 address
        :param pulumi.Input[str] folder_id: ID of the folder that the resource belongs to. If it
               is not provided, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to apply to this resource. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the address. Provided by the client when the address is created.
        """
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dns_records is not None:
            pulumi.set(__self__, "dns_records", dns_records)
        if external_ipv4_address is not None:
            pulumi.set(__self__, "external_ipv4_address", external_ipv4_address)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag that protects the address from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of this resource. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="dnsRecords")
    def dns_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]]:
        """
        DNS record specification of address
        """
        return pulumi.get(self, "dns_records")

    @dns_records.setter
    def dns_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]]):
        pulumi.set(self, "dns_records", value)

    @property
    @pulumi.getter(name="externalIpv4Address")
    def external_ipv4_address(self) -> Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']]:
        """
        spec of IP v4 address
        """
        return pulumi.get(self, "external_ipv4_address")

    @external_ipv4_address.setter
    def external_ipv4_address(self, value: Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']]):
        pulumi.set(self, "external_ipv4_address", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder that the resource belongs to. If it
        is not provided, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to apply to this resource. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the address. Provided by the client when the address is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _VpcAddressState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_records: Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]] = None,
                 external_ipv4_address: Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 reserved: Optional[pulumi.Input[bool]] = None,
                 used: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering VpcAddress resources.
        :param pulumi.Input[str] created_at: Creation timestamp of the key.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the address from accidental deletion.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when
               you create the resource.
        :param pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]] dns_records: DNS record specification of address
        :param pulumi.Input['VpcAddressExternalIpv4AddressArgs'] external_ipv4_address: spec of IP v4 address
        :param pulumi.Input[str] folder_id: ID of the folder that the resource belongs to. If it
               is not provided, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to apply to this resource. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the address. Provided by the client when the address is created.
        :param pulumi.Input[bool] reserved: `false` means that address is ephemeral.
        :param pulumi.Input[bool] used: `true` if address is used.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dns_records is not None:
            pulumi.set(__self__, "dns_records", dns_records)
        if external_ipv4_address is not None:
            pulumi.set(__self__, "external_ipv4_address", external_ipv4_address)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if reserved is not None:
            pulumi.set(__self__, "reserved", reserved)
        if used is not None:
            pulumi.set(__self__, "used", used)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        Creation timestamp of the key.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag that protects the address from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of this resource. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="dnsRecords")
    def dns_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]]:
        """
        DNS record specification of address
        """
        return pulumi.get(self, "dns_records")

    @dns_records.setter
    def dns_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcAddressDnsRecordArgs']]]]):
        pulumi.set(self, "dns_records", value)

    @property
    @pulumi.getter(name="externalIpv4Address")
    def external_ipv4_address(self) -> Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']]:
        """
        spec of IP v4 address
        """
        return pulumi.get(self, "external_ipv4_address")

    @external_ipv4_address.setter
    def external_ipv4_address(self, value: Optional[pulumi.Input['VpcAddressExternalIpv4AddressArgs']]):
        pulumi.set(self, "external_ipv4_address", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder that the resource belongs to. If it
        is not provided, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to apply to this resource. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the address. Provided by the client when the address is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def reserved(self) -> Optional[pulumi.Input[bool]]:
        """
        `false` means that address is ephemeral.
        """
        return pulumi.get(self, "reserved")

    @reserved.setter
    def reserved(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "reserved", value)

    @property
    @pulumi.getter
    def used(self) -> Optional[pulumi.Input[bool]]:
        """
        `true` if address is used.
        """
        return pulumi.get(self, "used")

    @used.setter
    def used(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "used", value)


class VpcAddress(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcAddressDnsRecordArgs']]]]] = None,
                 external_ipv4_address: Optional[pulumi.Input[pulumi.InputType['VpcAddressExternalIpv4AddressArgs']]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Manages a address within the Yandex.Cloud. You can only create a reserved (static) address via this resource. An ephemeral address could be obtained via implicit creation at a compute instance creation only. For more information, see [the official documentation](https://cloud.yandex.com/docs/vpc/concepts/address).

        * How-to Guides
            * [Cloud Networking](https://cloud.yandex.com/docs/vpc/)
            * [VPC Addressing](https://cloud.yandex.com/docs/vpc/concepts/address)

        ## Example Usage

        ### External ipv4 address

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        addr = yandex.VpcAddress("addr", external_ipv4_address=yandex.VpcAddressExternalIpv4AddressArgs(
            zone_id="ru-central1-a",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ### Address with DDoS protection

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        vpnaddr = yandex.VpcAddress("vpnaddr", external_ipv4_address=yandex.VpcAddressExternalIpv4AddressArgs(
            ddos_protection_provider="qrator",
            zone_id="ru-central1-a",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A address can be imported using the `id` of the resource, e.g.

        ```sh
        $ pulumi import yandex:index/vpcAddress:VpcAddress addr address_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the address from accidental deletion.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when
               you create the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcAddressDnsRecordArgs']]]] dns_records: DNS record specification of address
        :param pulumi.Input[pulumi.InputType['VpcAddressExternalIpv4AddressArgs']] external_ipv4_address: spec of IP v4 address
        :param pulumi.Input[str] folder_id: ID of the folder that the resource belongs to. If it
               is not provided, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to apply to this resource. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the address. Provided by the client when the address is created.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[VpcAddressArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a address within the Yandex.Cloud. You can only create a reserved (static) address via this resource. An ephemeral address could be obtained via implicit creation at a compute instance creation only. For more information, see [the official documentation](https://cloud.yandex.com/docs/vpc/concepts/address).

        * How-to Guides
            * [Cloud Networking](https://cloud.yandex.com/docs/vpc/)
            * [VPC Addressing](https://cloud.yandex.com/docs/vpc/concepts/address)

        ## Example Usage

        ### External ipv4 address

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        addr = yandex.VpcAddress("addr", external_ipv4_address=yandex.VpcAddressExternalIpv4AddressArgs(
            zone_id="ru-central1-a",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ### Address with DDoS protection

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        vpnaddr = yandex.VpcAddress("vpnaddr", external_ipv4_address=yandex.VpcAddressExternalIpv4AddressArgs(
            ddos_protection_provider="qrator",
            zone_id="ru-central1-a",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A address can be imported using the `id` of the resource, e.g.

        ```sh
        $ pulumi import yandex:index/vpcAddress:VpcAddress addr address_id
        ```

        :param str resource_name: The name of the resource.
        :param VpcAddressArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpcAddressArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcAddressDnsRecordArgs']]]]] = None,
                 external_ipv4_address: Optional[pulumi.Input[pulumi.InputType['VpcAddressExternalIpv4AddressArgs']]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpcAddressArgs.__new__(VpcAddressArgs)

            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["description"] = description
            __props__.__dict__["dns_records"] = dns_records
            __props__.__dict__["external_ipv4_address"] = external_ipv4_address
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            __props__.__dict__["created_at"] = None
            __props__.__dict__["reserved"] = None
            __props__.__dict__["used"] = None
        super(VpcAddress, __self__).__init__(
            'yandex:index/vpcAddress:VpcAddress',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            dns_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcAddressDnsRecordArgs']]]]] = None,
            external_ipv4_address: Optional[pulumi.Input[pulumi.InputType['VpcAddressExternalIpv4AddressArgs']]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            reserved: Optional[pulumi.Input[bool]] = None,
            used: Optional[pulumi.Input[bool]] = None) -> 'VpcAddress':
        """
        Get an existing VpcAddress resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_at: Creation timestamp of the key.
        :param pulumi.Input[bool] deletion_protection: Flag that protects the address from accidental deletion.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when
               you create the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcAddressDnsRecordArgs']]]] dns_records: DNS record specification of address
        :param pulumi.Input[pulumi.InputType['VpcAddressExternalIpv4AddressArgs']] external_ipv4_address: spec of IP v4 address
        :param pulumi.Input[str] folder_id: ID of the folder that the resource belongs to. If it
               is not provided, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to apply to this resource. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the address. Provided by the client when the address is created.
        :param pulumi.Input[bool] reserved: `false` means that address is ephemeral.
        :param pulumi.Input[bool] used: `true` if address is used.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VpcAddressState.__new__(_VpcAddressState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["description"] = description
        __props__.__dict__["dns_records"] = dns_records
        __props__.__dict__["external_ipv4_address"] = external_ipv4_address
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["reserved"] = reserved
        __props__.__dict__["used"] = used
        return VpcAddress(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Creation timestamp of the key.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[bool]:
        """
        Flag that protects the address from accidental deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        An optional description of this resource. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="dnsRecords")
    def dns_records(self) -> pulumi.Output[Optional[Sequence['outputs.VpcAddressDnsRecord']]]:
        """
        DNS record specification of address
        """
        return pulumi.get(self, "dns_records")

    @property
    @pulumi.getter(name="externalIpv4Address")
    def external_ipv4_address(self) -> pulumi.Output[Optional['outputs.VpcAddressExternalIpv4Address']]:
        """
        spec of IP v4 address
        """
        return pulumi.get(self, "external_ipv4_address")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        ID of the folder that the resource belongs to. If it
        is not provided, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Labels to apply to this resource. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the address. Provided by the client when the address is created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def reserved(self) -> pulumi.Output[bool]:
        """
        `false` means that address is ephemeral.
        """
        return pulumi.get(self, "reserved")

    @property
    @pulumi.getter
    def used(self) -> pulumi.Output[bool]:
        """
        `true` if address is used.
        """
        return pulumi.get(self, "used")

