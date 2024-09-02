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

__all__ = ['MdbPostgresqlDatabaseArgs', 'MdbPostgresqlDatabase']

@pulumi.input_type
class MdbPostgresqlDatabaseArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 owner: pulumi.Input[str],
                 deletion_protection: Optional[pulumi.Input[str]] = None,
                 extensions: Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]] = None,
                 lc_collate: Optional[pulumi.Input[str]] = None,
                 lc_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 template_db: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a MdbPostgresqlDatabase resource.
        :param pulumi.Input[str] owner: Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        :param pulumi.Input[str] deletion_protection: Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        :param pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]] extensions: Set of database extensions. The structure is documented below
        :param pulumi.Input[str] lc_collate: POSIX locale for string sorting order. Forbidden to change in an existing database.
        :param pulumi.Input[str] lc_type: POSIX locale for character classification. Forbidden to change in an existing database.
        :param pulumi.Input[str] name: The name of the database.
        :param pulumi.Input[str] template_db: Name of the template database.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "owner", owner)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if extensions is not None:
            pulumi.set(__self__, "extensions", extensions)
        if lc_collate is not None:
            pulumi.set(__self__, "lc_collate", lc_collate)
        if lc_type is not None:
            pulumi.set(__self__, "lc_type", lc_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if template_db is not None:
            pulumi.set(__self__, "template_db", template_db)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Input[str]:
        """
        Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: pulumi.Input[str]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[str]]:
        """
        Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def extensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]]:
        """
        Set of database extensions. The structure is documented below
        """
        return pulumi.get(self, "extensions")

    @extensions.setter
    def extensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]]):
        pulumi.set(self, "extensions", value)

    @property
    @pulumi.getter(name="lcCollate")
    def lc_collate(self) -> Optional[pulumi.Input[str]]:
        """
        POSIX locale for string sorting order. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_collate")

    @lc_collate.setter
    def lc_collate(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "lc_collate", value)

    @property
    @pulumi.getter(name="lcType")
    def lc_type(self) -> Optional[pulumi.Input[str]]:
        """
        POSIX locale for character classification. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_type")

    @lc_type.setter
    def lc_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "lc_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the database.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="templateDb")
    def template_db(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the template database.
        """
        return pulumi.get(self, "template_db")

    @template_db.setter
    def template_db(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_db", value)


@pulumi.input_type
class _MdbPostgresqlDatabaseState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[str]] = None,
                 extensions: Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]] = None,
                 lc_collate: Optional[pulumi.Input[str]] = None,
                 lc_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 template_db: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering MdbPostgresqlDatabase resources.
        :param pulumi.Input[str] deletion_protection: Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        :param pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]] extensions: Set of database extensions. The structure is documented below
        :param pulumi.Input[str] lc_collate: POSIX locale for string sorting order. Forbidden to change in an existing database.
        :param pulumi.Input[str] lc_type: POSIX locale for character classification. Forbidden to change in an existing database.
        :param pulumi.Input[str] name: The name of the database.
        :param pulumi.Input[str] owner: Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        :param pulumi.Input[str] template_db: Name of the template database.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if extensions is not None:
            pulumi.set(__self__, "extensions", extensions)
        if lc_collate is not None:
            pulumi.set(__self__, "lc_collate", lc_collate)
        if lc_type is not None:
            pulumi.set(__self__, "lc_type", lc_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if template_db is not None:
            pulumi.set(__self__, "template_db", template_db)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[str]]:
        """
        Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def extensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]]:
        """
        Set of database extensions. The structure is documented below
        """
        return pulumi.get(self, "extensions")

    @extensions.setter
    def extensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbPostgresqlDatabaseExtensionArgs']]]]):
        pulumi.set(self, "extensions", value)

    @property
    @pulumi.getter(name="lcCollate")
    def lc_collate(self) -> Optional[pulumi.Input[str]]:
        """
        POSIX locale for string sorting order. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_collate")

    @lc_collate.setter
    def lc_collate(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "lc_collate", value)

    @property
    @pulumi.getter(name="lcType")
    def lc_type(self) -> Optional[pulumi.Input[str]]:
        """
        POSIX locale for character classification. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_type")

    @lc_type.setter
    def lc_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "lc_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the database.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="templateDb")
    def template_db(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the template database.
        """
        return pulumi.get(self, "template_db")

    @template_db.setter
    def template_db(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_db", value)


class MdbPostgresqlDatabase(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[str]] = None,
                 extensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbPostgresqlDatabaseExtensionArgs']]]]] = None,
                 lc_collate: Optional[pulumi.Input[str]] = None,
                 lc_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 template_db: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Manages a PostgreSQL database within the Yandex.Cloud. For more information, see
        [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo_vpc_network = yandex.VpcNetwork("fooVpcNetwork")
        foo_vpc_subnet = yandex.VpcSubnet("fooVpcSubnet",
            zone="ru-central1-a",
            network_id=foo_vpc_network.id,
            v4_cidr_blocks=["10.5.0.0/24"])
        foo_mdb_postgresql_cluster = yandex.MdbPostgresqlCluster("fooMdbPostgresqlCluster",
            environment="PRESTABLE",
            network_id=foo_vpc_network.id,
            config=yandex.MdbPostgresqlClusterConfigArgs(
                version="15",
                resources=yandex.MdbPostgresqlClusterConfigResourcesArgs(
                    resource_preset_id="s2.micro",
                    disk_type_id="network-ssd",
                    disk_size=16,
                ),
            ),
            hosts=[yandex.MdbPostgresqlClusterHostArgs(
                zone="ru-central1-a",
                subnet_id=foo_vpc_subnet.id,
            )])
        foo_mdb_postgresql_database = yandex.MdbPostgresqlDatabase("fooMdbPostgresqlDatabase",
            cluster_id=foo_mdb_postgresql_cluster.id,
            owner=yandex_mdb_postgresql_user["alice"]["name"],
            lc_collate="en_US.UTF-8",
            lc_type="en_US.UTF-8",
            extensions=[
                yandex.MdbPostgresqlDatabaseExtensionArgs(
                    name="uuid-ossp",
                ),
                yandex.MdbPostgresqlDatabaseExtensionArgs(
                    name="xml2",
                ),
            ])
        foo_mdb_postgresql_user = yandex.MdbPostgresqlUser("fooMdbPostgresqlUser",
            cluster_id=foo_mdb_postgresql_cluster.id,
            password="password")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A PostgreSQL database can be imported using the following format:

        ```sh
        $ pulumi import yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase foo {{cluster_id}}:{{database_name}}
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] deletion_protection: Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbPostgresqlDatabaseExtensionArgs']]]] extensions: Set of database extensions. The structure is documented below
        :param pulumi.Input[str] lc_collate: POSIX locale for string sorting order. Forbidden to change in an existing database.
        :param pulumi.Input[str] lc_type: POSIX locale for character classification. Forbidden to change in an existing database.
        :param pulumi.Input[str] name: The name of the database.
        :param pulumi.Input[str] owner: Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        :param pulumi.Input[str] template_db: Name of the template database.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MdbPostgresqlDatabaseArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a PostgreSQL database within the Yandex.Cloud. For more information, see
        [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        foo_vpc_network = yandex.VpcNetwork("fooVpcNetwork")
        foo_vpc_subnet = yandex.VpcSubnet("fooVpcSubnet",
            zone="ru-central1-a",
            network_id=foo_vpc_network.id,
            v4_cidr_blocks=["10.5.0.0/24"])
        foo_mdb_postgresql_cluster = yandex.MdbPostgresqlCluster("fooMdbPostgresqlCluster",
            environment="PRESTABLE",
            network_id=foo_vpc_network.id,
            config=yandex.MdbPostgresqlClusterConfigArgs(
                version="15",
                resources=yandex.MdbPostgresqlClusterConfigResourcesArgs(
                    resource_preset_id="s2.micro",
                    disk_type_id="network-ssd",
                    disk_size=16,
                ),
            ),
            hosts=[yandex.MdbPostgresqlClusterHostArgs(
                zone="ru-central1-a",
                subnet_id=foo_vpc_subnet.id,
            )])
        foo_mdb_postgresql_database = yandex.MdbPostgresqlDatabase("fooMdbPostgresqlDatabase",
            cluster_id=foo_mdb_postgresql_cluster.id,
            owner=yandex_mdb_postgresql_user["alice"]["name"],
            lc_collate="en_US.UTF-8",
            lc_type="en_US.UTF-8",
            extensions=[
                yandex.MdbPostgresqlDatabaseExtensionArgs(
                    name="uuid-ossp",
                ),
                yandex.MdbPostgresqlDatabaseExtensionArgs(
                    name="xml2",
                ),
            ])
        foo_mdb_postgresql_user = yandex.MdbPostgresqlUser("fooMdbPostgresqlUser",
            cluster_id=foo_mdb_postgresql_cluster.id,
            password="password")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A PostgreSQL database can be imported using the following format:

        ```sh
        $ pulumi import yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase foo {{cluster_id}}:{{database_name}}
        ```

        :param str resource_name: The name of the resource.
        :param MdbPostgresqlDatabaseArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MdbPostgresqlDatabaseArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[str]] = None,
                 extensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbPostgresqlDatabaseExtensionArgs']]]]] = None,
                 lc_collate: Optional[pulumi.Input[str]] = None,
                 lc_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 template_db: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MdbPostgresqlDatabaseArgs.__new__(MdbPostgresqlDatabaseArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["extensions"] = extensions
            __props__.__dict__["lc_collate"] = lc_collate
            __props__.__dict__["lc_type"] = lc_type
            __props__.__dict__["name"] = name
            if owner is None and not opts.urn:
                raise TypeError("Missing required property 'owner'")
            __props__.__dict__["owner"] = owner
            __props__.__dict__["template_db"] = template_db
        super(MdbPostgresqlDatabase, __self__).__init__(
            'yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[str]] = None,
            extensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbPostgresqlDatabaseExtensionArgs']]]]] = None,
            lc_collate: Optional[pulumi.Input[str]] = None,
            lc_type: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            owner: Optional[pulumi.Input[str]] = None,
            template_db: Optional[pulumi.Input[str]] = None) -> 'MdbPostgresqlDatabase':
        """
        Get an existing MdbPostgresqlDatabase resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] deletion_protection: Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbPostgresqlDatabaseExtensionArgs']]]] extensions: Set of database extensions. The structure is documented below
        :param pulumi.Input[str] lc_collate: POSIX locale for string sorting order. Forbidden to change in an existing database.
        :param pulumi.Input[str] lc_type: POSIX locale for character classification. Forbidden to change in an existing database.
        :param pulumi.Input[str] name: The name of the database.
        :param pulumi.Input[str] owner: Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        :param pulumi.Input[str] template_db: Name of the template database.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MdbPostgresqlDatabaseState.__new__(_MdbPostgresqlDatabaseState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["extensions"] = extensions
        __props__.__dict__["lc_collate"] = lc_collate
        __props__.__dict__["lc_type"] = lc_type
        __props__.__dict__["name"] = name
        __props__.__dict__["owner"] = owner
        __props__.__dict__["template_db"] = template_db
        return MdbPostgresqlDatabase(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[Optional[str]]:
        """
        Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def extensions(self) -> pulumi.Output[Optional[Sequence['outputs.MdbPostgresqlDatabaseExtension']]]:
        """
        Set of database extensions. The structure is documented below
        """
        return pulumi.get(self, "extensions")

    @property
    @pulumi.getter(name="lcCollate")
    def lc_collate(self) -> pulumi.Output[Optional[str]]:
        """
        POSIX locale for string sorting order. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_collate")

    @property
    @pulumi.getter(name="lcType")
    def lc_type(self) -> pulumi.Output[Optional[str]]:
        """
        POSIX locale for character classification. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "lc_type")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the database.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[str]:
        """
        Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="templateDb")
    def template_db(self) -> pulumi.Output[Optional[str]]:
        """
        Name of the template database.
        """
        return pulumi.get(self, "template_db")
