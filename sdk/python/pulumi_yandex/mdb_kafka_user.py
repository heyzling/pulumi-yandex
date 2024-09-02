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

__all__ = ['MdbKafkaUserArgs', 'MdbKafkaUser']

@pulumi.input_type
class MdbKafkaUserArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 password: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]] = None):
        """
        The set of arguments for constructing a MdbKafkaUser resource.
        :param pulumi.Input[str] password: The password of the user.
        :param pulumi.Input[str] name: The name of the user.
        :param pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]] permissions: Set of permissions granted to the user. The structure is documented below.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "password", password)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def password(self) -> pulumi.Input[str]:
        """
        The password of the user.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: pulumi.Input[str]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the user.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]]:
        """
        Set of permissions granted to the user. The structure is documented below.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]]):
        pulumi.set(self, "permissions", value)


@pulumi.input_type
class _MdbKafkaUserState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]] = None):
        """
        Input properties used for looking up and filtering MdbKafkaUser resources.
        :param pulumi.Input[str] name: The name of the user.
        :param pulumi.Input[str] password: The password of the user.
        :param pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]] permissions: Set of permissions granted to the user. The structure is documented below.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the user.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        The password of the user.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]]:
        """
        Set of permissions granted to the user. The structure is documented below.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbKafkaUserPermissionArgs']]]]):
        pulumi.set(self, "permissions", value)


class MdbKafkaUser(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbKafkaUserPermissionArgs']]]]] = None,
                 __props__=None):
        """
        Manages a user of a Kafka cluster within the Yandex.Cloud. For more information, see
        [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo = yandex.MdbKafkaCluster("foo",
            network_id="c64vs98keiqc7f24pvkd",
            config=yandex.MdbKafkaClusterConfigArgs(
                version="2.8",
                zones=["ru-central1-a"],
                kafka=yandex.MdbKafkaClusterConfigKafkaArgs(
                    resources=yandex.MdbKafkaClusterConfigKafkaResourcesArgs(
                        resource_preset_id="s2.micro",
                        disk_type_id="network-hdd",
                        disk_size=16,
                    ),
                ),
            ))
        events = yandex.MdbKafkaTopic("events",
            cluster_id=foo.id,
            partitions=4,
            replication_factor=1)
        user_events = yandex.MdbKafkaUser("userEvents",
            cluster_id=foo.id,
            password="pass1231232332",
            permissions=[
                yandex.MdbKafkaUserPermissionArgs(
                    topic_name="events",
                    role="ACCESS_ROLE_CONSUMER",
                    allow_hosts=[
                        "host1.db.yandex.net",
                        "host2.db.yandex.net",
                    ],
                ),
                yandex.MdbKafkaUserPermissionArgs(
                    topic_name="events",
                    role="ACCESS_ROLE_PRODUCER",
                ),
            ])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        Kafka user can be imported using following format:

        ```sh
        $ pulumi import yandex:index/mdbKafkaUser:MdbKafkaUser foo {{cluster_id}}:{{user_name}}
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the user.
        :param pulumi.Input[str] password: The password of the user.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbKafkaUserPermissionArgs']]]] permissions: Set of permissions granted to the user. The structure is documented below.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MdbKafkaUserArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a user of a Kafka cluster within the Yandex.Cloud. For more information, see
        [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo = yandex.MdbKafkaCluster("foo",
            network_id="c64vs98keiqc7f24pvkd",
            config=yandex.MdbKafkaClusterConfigArgs(
                version="2.8",
                zones=["ru-central1-a"],
                kafka=yandex.MdbKafkaClusterConfigKafkaArgs(
                    resources=yandex.MdbKafkaClusterConfigKafkaResourcesArgs(
                        resource_preset_id="s2.micro",
                        disk_type_id="network-hdd",
                        disk_size=16,
                    ),
                ),
            ))
        events = yandex.MdbKafkaTopic("events",
            cluster_id=foo.id,
            partitions=4,
            replication_factor=1)
        user_events = yandex.MdbKafkaUser("userEvents",
            cluster_id=foo.id,
            password="pass1231232332",
            permissions=[
                yandex.MdbKafkaUserPermissionArgs(
                    topic_name="events",
                    role="ACCESS_ROLE_CONSUMER",
                    allow_hosts=[
                        "host1.db.yandex.net",
                        "host2.db.yandex.net",
                    ],
                ),
                yandex.MdbKafkaUserPermissionArgs(
                    topic_name="events",
                    role="ACCESS_ROLE_PRODUCER",
                ),
            ])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        Kafka user can be imported using following format:

        ```sh
        $ pulumi import yandex:index/mdbKafkaUser:MdbKafkaUser foo {{cluster_id}}:{{user_name}}
        ```

        :param str resource_name: The name of the resource.
        :param MdbKafkaUserArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MdbKafkaUserArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbKafkaUserPermissionArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MdbKafkaUserArgs.__new__(MdbKafkaUserArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            __props__.__dict__["name"] = name
            if password is None and not opts.urn:
                raise TypeError("Missing required property 'password'")
            __props__.__dict__["password"] = None if password is None else pulumi.Output.secret(password)
            __props__.__dict__["permissions"] = permissions
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["password"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(MdbKafkaUser, __self__).__init__(
            'yandex:index/mdbKafkaUser:MdbKafkaUser',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbKafkaUserPermissionArgs']]]]] = None) -> 'MdbKafkaUser':
        """
        Get an existing MdbKafkaUser resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the user.
        :param pulumi.Input[str] password: The password of the user.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbKafkaUserPermissionArgs']]]] permissions: Set of permissions granted to the user. The structure is documented below.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MdbKafkaUserState.__new__(_MdbKafkaUserState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["name"] = name
        __props__.__dict__["password"] = password
        __props__.__dict__["permissions"] = permissions
        return MdbKafkaUser(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the user.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        The password of the user.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Optional[Sequence['outputs.MdbKafkaUserPermission']]]:
        """
        Set of permissions granted to the user. The structure is documented below.
        """
        return pulumi.get(self, "permissions")

