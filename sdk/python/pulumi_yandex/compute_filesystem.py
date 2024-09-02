# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ComputeFilesystemArgs', 'ComputeFilesystem']

@pulumi.input_type
class ComputeFilesystemArgs:
    def __init__(__self__, *,
                 block_size: Optional[pulumi.Input[int]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ComputeFilesystem resource.
        :param pulumi.Input[int] block_size: Block size of the filesystem, specified in bytes.
        :param pulumi.Input[str] description: Description of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[str] folder_id: The ID of the folder that the filesystem belongs to. If it is not provided, the default 
               provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
               see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        :param pulumi.Input[str] name: Name of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[int] size: Size of the filesystem, specified in GB.
        :param pulumi.Input[str] type: Type of filesystem to create. Type `network-hdd` is set by default.
        :param pulumi.Input[str] zone: Availability zone where the filesystem will reside.
        """
        if block_size is not None:
            pulumi.set(__self__, "block_size", block_size)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="blockSize")
    def block_size(self) -> Optional[pulumi.Input[int]]:
        """
        Block size of the filesystem, specified in bytes.
        """
        return pulumi.get(self, "block_size")

    @block_size.setter
    def block_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "block_size", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder that the filesystem belongs to. If it is not provided, the default 
        provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
        see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def size(self) -> Optional[pulumi.Input[int]]:
        """
        Size of the filesystem, specified in GB.
        """
        return pulumi.get(self, "size")

    @size.setter
    def size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "size", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of filesystem to create. Type `network-hdd` is set by default.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        Availability zone where the filesystem will reside.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


@pulumi.input_type
class _ComputeFilesystemState:
    def __init__(__self__, *,
                 block_size: Optional[pulumi.Input[int]] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[int]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ComputeFilesystem resources.
        :param pulumi.Input[int] block_size: Block size of the filesystem, specified in bytes.
        :param pulumi.Input[str] created_at: Creation timestamp of the filesystem.
        :param pulumi.Input[str] description: Description of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[str] folder_id: The ID of the folder that the filesystem belongs to. If it is not provided, the default 
               provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
               see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        :param pulumi.Input[str] name: Name of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[int] size: Size of the filesystem, specified in GB.
        :param pulumi.Input[str] status: The status of the filesystem.
        :param pulumi.Input[str] type: Type of filesystem to create. Type `network-hdd` is set by default.
        :param pulumi.Input[str] zone: Availability zone where the filesystem will reside.
        """
        if block_size is not None:
            pulumi.set(__self__, "block_size", block_size)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="blockSize")
    def block_size(self) -> Optional[pulumi.Input[int]]:
        """
        Block size of the filesystem, specified in bytes.
        """
        return pulumi.get(self, "block_size")

    @block_size.setter
    def block_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "block_size", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        Creation timestamp of the filesystem.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder that the filesystem belongs to. If it is not provided, the default 
        provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
        see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def size(self) -> Optional[pulumi.Input[int]]:
        """
        Size of the filesystem, specified in GB.
        """
        return pulumi.get(self, "size")

    @size.setter
    def size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "size", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the filesystem.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of filesystem to create. Type `network-hdd` is set by default.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        Availability zone where the filesystem will reside.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


class ComputeFilesystem(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 block_size: Optional[pulumi.Input[int]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        File storage is a virtual file system that can be attached to multiple Compute Cloud VMs in the same availability zone.

        Users can share files in storage and use them from different VMs.

        Storage is attached to a VM through the [Filesystem in Userspace](https://en.wikipedia.org/wiki/Filesystem_in_Userspace) (FUSE) interface as a [virtiofs](https://www.kernel.org/doc/html/latest/filesystems/virtiofs.html) device that is not linked to the host file system directly.

        For more information about filesystems in Yandex.Cloud, see:

        * [Documentation](https://cloud.yandex.com/docs/compute/concepts/filesystem)
        * How-to Guides
            * [Attach filesystem to a VM](https://cloud.yandex.com/en-ru/docs/compute/operations/filesystem/attach-to-vm)
            * [Detach filesystem from VM](https://cloud.yandex.com/en-ru/docs/compute/operations/filesystem/detach-from-vm)

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        default = yandex.ComputeFilesystem("default",
            labels={
                "environment": "test",
            },
            size=10,
            type="network-ssd",
            zone="ru-central1-a")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A filesystem can be imported using any of these accepted formats:

        ```sh
        $ pulumi import yandex:index/computeFilesystem:ComputeFilesystem default filesystem_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] block_size: Block size of the filesystem, specified in bytes.
        :param pulumi.Input[str] description: Description of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[str] folder_id: The ID of the folder that the filesystem belongs to. If it is not provided, the default 
               provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
               see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        :param pulumi.Input[str] name: Name of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[int] size: Size of the filesystem, specified in GB.
        :param pulumi.Input[str] type: Type of filesystem to create. Type `network-hdd` is set by default.
        :param pulumi.Input[str] zone: Availability zone where the filesystem will reside.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ComputeFilesystemArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        File storage is a virtual file system that can be attached to multiple Compute Cloud VMs in the same availability zone.

        Users can share files in storage and use them from different VMs.

        Storage is attached to a VM through the [Filesystem in Userspace](https://en.wikipedia.org/wiki/Filesystem_in_Userspace) (FUSE) interface as a [virtiofs](https://www.kernel.org/doc/html/latest/filesystems/virtiofs.html) device that is not linked to the host file system directly.

        For more information about filesystems in Yandex.Cloud, see:

        * [Documentation](https://cloud.yandex.com/docs/compute/concepts/filesystem)
        * How-to Guides
            * [Attach filesystem to a VM](https://cloud.yandex.com/en-ru/docs/compute/operations/filesystem/attach-to-vm)
            * [Detach filesystem from VM](https://cloud.yandex.com/en-ru/docs/compute/operations/filesystem/detach-from-vm)

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        default = yandex.ComputeFilesystem("default",
            labels={
                "environment": "test",
            },
            size=10,
            type="network-ssd",
            zone="ru-central1-a")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A filesystem can be imported using any of these accepted formats:

        ```sh
        $ pulumi import yandex:index/computeFilesystem:ComputeFilesystem default filesystem_id
        ```

        :param str resource_name: The name of the resource.
        :param ComputeFilesystemArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ComputeFilesystemArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 block_size: Optional[pulumi.Input[int]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ComputeFilesystemArgs.__new__(ComputeFilesystemArgs)

            __props__.__dict__["block_size"] = block_size
            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            __props__.__dict__["size"] = size
            __props__.__dict__["type"] = type
            __props__.__dict__["zone"] = zone
            __props__.__dict__["created_at"] = None
            __props__.__dict__["status"] = None
        super(ComputeFilesystem, __self__).__init__(
            'yandex:index/computeFilesystem:ComputeFilesystem',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            block_size: Optional[pulumi.Input[int]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            size: Optional[pulumi.Input[int]] = None,
            status: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None,
            zone: Optional[pulumi.Input[str]] = None) -> 'ComputeFilesystem':
        """
        Get an existing ComputeFilesystem resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] block_size: Block size of the filesystem, specified in bytes.
        :param pulumi.Input[str] created_at: Creation timestamp of the filesystem.
        :param pulumi.Input[str] description: Description of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[str] folder_id: The ID of the folder that the filesystem belongs to. If it is not provided, the default 
               provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
               see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        :param pulumi.Input[str] name: Name of the filesystem. Provide this property when you create a resource.
        :param pulumi.Input[int] size: Size of the filesystem, specified in GB.
        :param pulumi.Input[str] status: The status of the filesystem.
        :param pulumi.Input[str] type: Type of filesystem to create. Type `network-hdd` is set by default.
        :param pulumi.Input[str] zone: Availability zone where the filesystem will reside.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ComputeFilesystemState.__new__(_ComputeFilesystemState)

        __props__.__dict__["block_size"] = block_size
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["size"] = size
        __props__.__dict__["status"] = status
        __props__.__dict__["type"] = type
        __props__.__dict__["zone"] = zone
        return ComputeFilesystem(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="blockSize")
    def block_size(self) -> pulumi.Output[Optional[int]]:
        """
        Block size of the filesystem, specified in bytes.
        """
        return pulumi.get(self, "block_size")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Creation timestamp of the filesystem.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        The ID of the folder that the filesystem belongs to. If it is not provided, the default 
        provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Labels to assign to this filesystem. A list of key/value pairs. For details about the concept, 
        see [documentation](https://cloud.yandex.com/docs/overview/concepts/services#labels).
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the filesystem. Provide this property when you create a resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def size(self) -> pulumi.Output[Optional[int]]:
        """
        Size of the filesystem, specified in GB.
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the filesystem.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Type of filesystem to create. Type `network-hdd` is set by default.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[str]:
        """
        Availability zone where the filesystem will reside.
        """
        return pulumi.get(self, "zone")

