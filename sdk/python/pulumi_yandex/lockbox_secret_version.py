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

__all__ = ['LockboxSecretVersionArgs', 'LockboxSecretVersion']

@pulumi.input_type
class LockboxSecretVersionArgs:
    def __init__(__self__, *,
                 entries: pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]],
                 secret_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a LockboxSecretVersion resource.
        :param pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]] entries: List of entries in the Yandex Cloud Lockbox secret version.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               
               The `entries` block contains:
        """
        pulumi.set(__self__, "entries", entries)
        pulumi.set(__self__, "secret_id", secret_id)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def entries(self) -> pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]]:
        """
        List of entries in the Yandex Cloud Lockbox secret version.
        """
        return pulumi.get(self, "entries")

    @entries.setter
    def entries(self, value: pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]]):
        pulumi.set(self, "entries", value)

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> pulumi.Input[str]:
        """
        The Yandex Cloud Lockbox secret ID where to add the version.
        """
        return pulumi.get(self, "secret_id")

    @secret_id.setter
    def secret_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "secret_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The Yandex Cloud Lockbox secret version description.

        The `entries` block contains:
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class _LockboxSecretVersionState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 entries: Optional[pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering LockboxSecretVersion resources.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               
               The `entries` block contains:
        :param pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]] entries: List of entries in the Yandex Cloud Lockbox secret version.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if entries is not None:
            pulumi.set(__self__, "entries", entries)
        if secret_id is not None:
            pulumi.set(__self__, "secret_id", secret_id)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The Yandex Cloud Lockbox secret version description.

        The `entries` block contains:
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def entries(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]]]:
        """
        List of entries in the Yandex Cloud Lockbox secret version.
        """
        return pulumi.get(self, "entries")

    @entries.setter
    def entries(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LockboxSecretVersionEntryArgs']]]]):
        pulumi.set(self, "entries", value)

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Yandex Cloud Lockbox secret ID where to add the version.
        """
        return pulumi.get(self, "secret_id")

    @secret_id.setter
    def secret_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret_id", value)


class LockboxSecretVersion(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 entries: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LockboxSecretVersionEntryArgs']]]]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Yandex Cloud Lockbox secret version resource. For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_secret = yandex.LockboxSecret("mySecret")
        my_version = yandex.LockboxSecretVersion("myVersion",
            secret_id=my_secret.id,
            entries=[
                yandex.LockboxSecretVersionEntryArgs(
                    key="key1",
                    text_value="value1",
                ),
                yandex.LockboxSecretVersionEntryArgs(
                    key="k2",
                    command=yandex.LockboxSecretVersionEntryCommandArgs(
                        path="my_secret_generator.sh",
                    ),
                ),
            ])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               
               The `entries` block contains:
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LockboxSecretVersionEntryArgs']]]] entries: List of entries in the Yandex Cloud Lockbox secret version.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LockboxSecretVersionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Yandex Cloud Lockbox secret version resource. For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_secret = yandex.LockboxSecret("mySecret")
        my_version = yandex.LockboxSecretVersion("myVersion",
            secret_id=my_secret.id,
            entries=[
                yandex.LockboxSecretVersionEntryArgs(
                    key="key1",
                    text_value="value1",
                ),
                yandex.LockboxSecretVersionEntryArgs(
                    key="k2",
                    command=yandex.LockboxSecretVersionEntryCommandArgs(
                        path="my_secret_generator.sh",
                    ),
                ),
            ])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param LockboxSecretVersionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LockboxSecretVersionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 entries: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LockboxSecretVersionEntryArgs']]]]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LockboxSecretVersionArgs.__new__(LockboxSecretVersionArgs)

            __props__.__dict__["description"] = description
            if entries is None and not opts.urn:
                raise TypeError("Missing required property 'entries'")
            __props__.__dict__["entries"] = entries
            if secret_id is None and not opts.urn:
                raise TypeError("Missing required property 'secret_id'")
            __props__.__dict__["secret_id"] = secret_id
        super(LockboxSecretVersion, __self__).__init__(
            'yandex:index/lockboxSecretVersion:LockboxSecretVersion',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            entries: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LockboxSecretVersionEntryArgs']]]]] = None,
            secret_id: Optional[pulumi.Input[str]] = None) -> 'LockboxSecretVersion':
        """
        Get an existing LockboxSecretVersion resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               
               The `entries` block contains:
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LockboxSecretVersionEntryArgs']]]] entries: List of entries in the Yandex Cloud Lockbox secret version.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LockboxSecretVersionState.__new__(_LockboxSecretVersionState)

        __props__.__dict__["description"] = description
        __props__.__dict__["entries"] = entries
        __props__.__dict__["secret_id"] = secret_id
        return LockboxSecretVersion(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The Yandex Cloud Lockbox secret version description.

        The `entries` block contains:
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def entries(self) -> pulumi.Output[Sequence['outputs.LockboxSecretVersionEntry']]:
        """
        List of entries in the Yandex Cloud Lockbox secret version.
        """
        return pulumi.get(self, "entries")

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> pulumi.Output[str]:
        """
        The Yandex Cloud Lockbox secret ID where to add the version.
        """
        return pulumi.get(self, "secret_id")
