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

__all__ = ['CdnOriginGroupArgs', 'CdnOriginGroup']

@pulumi.input_type
class CdnOriginGroupArgs:
    def __init__(__self__, *,
                 origins: pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]],
                 folder_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 use_next: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a CdnOriginGroup resource.
        :param pulumi.Input[str] name: CDN Origin Group name used to define device.
        :param pulumi.Input[bool] use_next: If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        pulumi.set(__self__, "origins", origins)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if use_next is not None:
            pulumi.set(__self__, "use_next", use_next)

    @property
    @pulumi.getter
    def origins(self) -> pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]]:
        return pulumi.get(self, "origins")

    @origins.setter
    def origins(self, value: pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]]):
        pulumi.set(self, "origins", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        CDN Origin Group name used to define device.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="useNext")
    def use_next(self) -> Optional[pulumi.Input[bool]]:
        """
        If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        return pulumi.get(self, "use_next")

    @use_next.setter
    def use_next(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "use_next", value)


@pulumi.input_type
class _CdnOriginGroupState:
    def __init__(__self__, *,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 origins: Optional[pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]]] = None,
                 use_next: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering CdnOriginGroup resources.
        :param pulumi.Input[str] name: CDN Origin Group name used to define device.
        :param pulumi.Input[bool] use_next: If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if origins is not None:
            pulumi.set(__self__, "origins", origins)
        if use_next is not None:
            pulumi.set(__self__, "use_next", use_next)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        CDN Origin Group name used to define device.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def origins(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]]]:
        return pulumi.get(self, "origins")

    @origins.setter
    def origins(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CdnOriginGroupOriginArgs']]]]):
        pulumi.set(self, "origins", value)

    @property
    @pulumi.getter(name="useNext")
    def use_next(self) -> Optional[pulumi.Input[bool]]:
        """
        If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        return pulumi.get(self, "use_next")

    @use_next.setter
    def use_next(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "use_next", value)


class CdnOriginGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 origins: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CdnOriginGroupOriginArgs']]]]] = None,
                 use_next: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Allows management of [Yandex.Cloud CDN Origin Groups](https://cloud.yandex.ru/docs/cdn/concepts/origins).

        > **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id <folder-id> --type gcore```

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_group = yandex.CdnOriginGroup("myGroup",
            origins=[
                yandex.CdnOriginGroupOriginArgs(
                    source="ya.ru",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    source="yandex.ru",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    source="goo.gl",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    backup=False,
                    source="amazon.com",
                ),
            ],
            use_next=True)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A origin group can be imported using any of these accepted formats:

        ```sh
        $ pulumi import yandex:index/cdnOriginGroup:CdnOriginGroup default origin_group_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: CDN Origin Group name used to define device.
        :param pulumi.Input[bool] use_next: If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CdnOriginGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Allows management of [Yandex.Cloud CDN Origin Groups](https://cloud.yandex.ru/docs/cdn/concepts/origins).

        > **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id <folder-id> --type gcore```

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_group = yandex.CdnOriginGroup("myGroup",
            origins=[
                yandex.CdnOriginGroupOriginArgs(
                    source="ya.ru",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    source="yandex.ru",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    source="goo.gl",
                ),
                yandex.CdnOriginGroupOriginArgs(
                    backup=False,
                    source="amazon.com",
                ),
            ],
            use_next=True)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        A origin group can be imported using any of these accepted formats:

        ```sh
        $ pulumi import yandex:index/cdnOriginGroup:CdnOriginGroup default origin_group_id
        ```

        :param str resource_name: The name of the resource.
        :param CdnOriginGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CdnOriginGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 origins: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CdnOriginGroupOriginArgs']]]]] = None,
                 use_next: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CdnOriginGroupArgs.__new__(CdnOriginGroupArgs)

            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["name"] = name
            if origins is None and not opts.urn:
                raise TypeError("Missing required property 'origins'")
            __props__.__dict__["origins"] = origins
            __props__.__dict__["use_next"] = use_next
        super(CdnOriginGroup, __self__).__init__(
            'yandex:index/cdnOriginGroup:CdnOriginGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            origins: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CdnOriginGroupOriginArgs']]]]] = None,
            use_next: Optional[pulumi.Input[bool]] = None) -> 'CdnOriginGroup':
        """
        Get an existing CdnOriginGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: CDN Origin Group name used to define device.
        :param pulumi.Input[bool] use_next: If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CdnOriginGroupState.__new__(_CdnOriginGroupState)

        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["name"] = name
        __props__.__dict__["origins"] = origins
        __props__.__dict__["use_next"] = use_next
        return CdnOriginGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        CDN Origin Group name used to define device.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def origins(self) -> pulumi.Output[Sequence['outputs.CdnOriginGroupOrigin']]:
        return pulumi.get(self, "origins")

    @property
    @pulumi.getter(name="useNext")
    def use_next(self) -> pulumi.Output[Optional[bool]]:
        """
        If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
        """
        return pulumi.get(self, "use_next")

