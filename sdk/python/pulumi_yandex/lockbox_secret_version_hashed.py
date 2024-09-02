# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['LockboxSecretVersionHashedArgs', 'LockboxSecretVersionHashed']

@pulumi.input_type
class LockboxSecretVersionHashedArgs:
    def __init__(__self__, *,
                 secret_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 key1: Optional[pulumi.Input[str]] = None,
                 key10: Optional[pulumi.Input[str]] = None,
                 key2: Optional[pulumi.Input[str]] = None,
                 key3: Optional[pulumi.Input[str]] = None,
                 key4: Optional[pulumi.Input[str]] = None,
                 key5: Optional[pulumi.Input[str]] = None,
                 key6: Optional[pulumi.Input[str]] = None,
                 key7: Optional[pulumi.Input[str]] = None,
                 key8: Optional[pulumi.Input[str]] = None,
                 key9: Optional[pulumi.Input[str]] = None,
                 text_value1: Optional[pulumi.Input[str]] = None,
                 text_value10: Optional[pulumi.Input[str]] = None,
                 text_value2: Optional[pulumi.Input[str]] = None,
                 text_value3: Optional[pulumi.Input[str]] = None,
                 text_value4: Optional[pulumi.Input[str]] = None,
                 text_value5: Optional[pulumi.Input[str]] = None,
                 text_value6: Optional[pulumi.Input[str]] = None,
                 text_value7: Optional[pulumi.Input[str]] = None,
                 text_value8: Optional[pulumi.Input[str]] = None,
                 text_value9: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a LockboxSecretVersionHashed resource.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
               * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
               
               The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
               If you need a second entry, use `key_2`/`text_value_2`, and so on.
        """
        pulumi.set(__self__, "secret_id", secret_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if key1 is not None:
            pulumi.set(__self__, "key1", key1)
        if key10 is not None:
            pulumi.set(__self__, "key10", key10)
        if key2 is not None:
            pulumi.set(__self__, "key2", key2)
        if key3 is not None:
            pulumi.set(__self__, "key3", key3)
        if key4 is not None:
            pulumi.set(__self__, "key4", key4)
        if key5 is not None:
            pulumi.set(__self__, "key5", key5)
        if key6 is not None:
            pulumi.set(__self__, "key6", key6)
        if key7 is not None:
            pulumi.set(__self__, "key7", key7)
        if key8 is not None:
            pulumi.set(__self__, "key8", key8)
        if key9 is not None:
            pulumi.set(__self__, "key9", key9)
        if text_value1 is not None:
            pulumi.set(__self__, "text_value1", text_value1)
        if text_value10 is not None:
            pulumi.set(__self__, "text_value10", text_value10)
        if text_value2 is not None:
            pulumi.set(__self__, "text_value2", text_value2)
        if text_value3 is not None:
            pulumi.set(__self__, "text_value3", text_value3)
        if text_value4 is not None:
            pulumi.set(__self__, "text_value4", text_value4)
        if text_value5 is not None:
            pulumi.set(__self__, "text_value5", text_value5)
        if text_value6 is not None:
            pulumi.set(__self__, "text_value6", text_value6)
        if text_value7 is not None:
            pulumi.set(__self__, "text_value7", text_value7)
        if text_value8 is not None:
            pulumi.set(__self__, "text_value8", text_value8)
        if text_value9 is not None:
            pulumi.set(__self__, "text_value9", text_value9)

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
        * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.

        The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        If you need a second entry, use `key_2`/`text_value_2`, and so on.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def key1(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key1")

    @key1.setter
    def key1(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key1", value)

    @property
    @pulumi.getter
    def key10(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key10")

    @key10.setter
    def key10(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key10", value)

    @property
    @pulumi.getter
    def key2(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key2")

    @key2.setter
    def key2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key2", value)

    @property
    @pulumi.getter
    def key3(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key3")

    @key3.setter
    def key3(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key3", value)

    @property
    @pulumi.getter
    def key4(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key4")

    @key4.setter
    def key4(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key4", value)

    @property
    @pulumi.getter
    def key5(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key5")

    @key5.setter
    def key5(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key5", value)

    @property
    @pulumi.getter
    def key6(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key6")

    @key6.setter
    def key6(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key6", value)

    @property
    @pulumi.getter
    def key7(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key7")

    @key7.setter
    def key7(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key7", value)

    @property
    @pulumi.getter
    def key8(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key8")

    @key8.setter
    def key8(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key8", value)

    @property
    @pulumi.getter
    def key9(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key9")

    @key9.setter
    def key9(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key9", value)

    @property
    @pulumi.getter(name="textValue1")
    def text_value1(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value1")

    @text_value1.setter
    def text_value1(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value1", value)

    @property
    @pulumi.getter(name="textValue10")
    def text_value10(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value10")

    @text_value10.setter
    def text_value10(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value10", value)

    @property
    @pulumi.getter(name="textValue2")
    def text_value2(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value2")

    @text_value2.setter
    def text_value2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value2", value)

    @property
    @pulumi.getter(name="textValue3")
    def text_value3(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value3")

    @text_value3.setter
    def text_value3(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value3", value)

    @property
    @pulumi.getter(name="textValue4")
    def text_value4(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value4")

    @text_value4.setter
    def text_value4(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value4", value)

    @property
    @pulumi.getter(name="textValue5")
    def text_value5(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value5")

    @text_value5.setter
    def text_value5(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value5", value)

    @property
    @pulumi.getter(name="textValue6")
    def text_value6(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value6")

    @text_value6.setter
    def text_value6(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value6", value)

    @property
    @pulumi.getter(name="textValue7")
    def text_value7(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value7")

    @text_value7.setter
    def text_value7(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value7", value)

    @property
    @pulumi.getter(name="textValue8")
    def text_value8(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value8")

    @text_value8.setter
    def text_value8(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value8", value)

    @property
    @pulumi.getter(name="textValue9")
    def text_value9(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value9")

    @text_value9.setter
    def text_value9(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value9", value)


@pulumi.input_type
class _LockboxSecretVersionHashedState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 key1: Optional[pulumi.Input[str]] = None,
                 key10: Optional[pulumi.Input[str]] = None,
                 key2: Optional[pulumi.Input[str]] = None,
                 key3: Optional[pulumi.Input[str]] = None,
                 key4: Optional[pulumi.Input[str]] = None,
                 key5: Optional[pulumi.Input[str]] = None,
                 key6: Optional[pulumi.Input[str]] = None,
                 key7: Optional[pulumi.Input[str]] = None,
                 key8: Optional[pulumi.Input[str]] = None,
                 key9: Optional[pulumi.Input[str]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None,
                 text_value1: Optional[pulumi.Input[str]] = None,
                 text_value10: Optional[pulumi.Input[str]] = None,
                 text_value2: Optional[pulumi.Input[str]] = None,
                 text_value3: Optional[pulumi.Input[str]] = None,
                 text_value4: Optional[pulumi.Input[str]] = None,
                 text_value5: Optional[pulumi.Input[str]] = None,
                 text_value6: Optional[pulumi.Input[str]] = None,
                 text_value7: Optional[pulumi.Input[str]] = None,
                 text_value8: Optional[pulumi.Input[str]] = None,
                 text_value9: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering LockboxSecretVersionHashed resources.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
               * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
               
               The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
               If you need a second entry, use `key_2`/`text_value_2`, and so on.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if key1 is not None:
            pulumi.set(__self__, "key1", key1)
        if key10 is not None:
            pulumi.set(__self__, "key10", key10)
        if key2 is not None:
            pulumi.set(__self__, "key2", key2)
        if key3 is not None:
            pulumi.set(__self__, "key3", key3)
        if key4 is not None:
            pulumi.set(__self__, "key4", key4)
        if key5 is not None:
            pulumi.set(__self__, "key5", key5)
        if key6 is not None:
            pulumi.set(__self__, "key6", key6)
        if key7 is not None:
            pulumi.set(__self__, "key7", key7)
        if key8 is not None:
            pulumi.set(__self__, "key8", key8)
        if key9 is not None:
            pulumi.set(__self__, "key9", key9)
        if secret_id is not None:
            pulumi.set(__self__, "secret_id", secret_id)
        if text_value1 is not None:
            pulumi.set(__self__, "text_value1", text_value1)
        if text_value10 is not None:
            pulumi.set(__self__, "text_value10", text_value10)
        if text_value2 is not None:
            pulumi.set(__self__, "text_value2", text_value2)
        if text_value3 is not None:
            pulumi.set(__self__, "text_value3", text_value3)
        if text_value4 is not None:
            pulumi.set(__self__, "text_value4", text_value4)
        if text_value5 is not None:
            pulumi.set(__self__, "text_value5", text_value5)
        if text_value6 is not None:
            pulumi.set(__self__, "text_value6", text_value6)
        if text_value7 is not None:
            pulumi.set(__self__, "text_value7", text_value7)
        if text_value8 is not None:
            pulumi.set(__self__, "text_value8", text_value8)
        if text_value9 is not None:
            pulumi.set(__self__, "text_value9", text_value9)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The Yandex Cloud Lockbox secret version description.
        * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.

        The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        If you need a second entry, use `key_2`/`text_value_2`, and so on.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def key1(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key1")

    @key1.setter
    def key1(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key1", value)

    @property
    @pulumi.getter
    def key10(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key10")

    @key10.setter
    def key10(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key10", value)

    @property
    @pulumi.getter
    def key2(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key2")

    @key2.setter
    def key2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key2", value)

    @property
    @pulumi.getter
    def key3(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key3")

    @key3.setter
    def key3(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key3", value)

    @property
    @pulumi.getter
    def key4(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key4")

    @key4.setter
    def key4(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key4", value)

    @property
    @pulumi.getter
    def key5(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key5")

    @key5.setter
    def key5(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key5", value)

    @property
    @pulumi.getter
    def key6(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key6")

    @key6.setter
    def key6(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key6", value)

    @property
    @pulumi.getter
    def key7(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key7")

    @key7.setter
    def key7(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key7", value)

    @property
    @pulumi.getter
    def key8(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key8")

    @key8.setter
    def key8(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key8", value)

    @property
    @pulumi.getter
    def key9(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "key9")

    @key9.setter
    def key9(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key9", value)

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

    @property
    @pulumi.getter(name="textValue1")
    def text_value1(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value1")

    @text_value1.setter
    def text_value1(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value1", value)

    @property
    @pulumi.getter(name="textValue10")
    def text_value10(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value10")

    @text_value10.setter
    def text_value10(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value10", value)

    @property
    @pulumi.getter(name="textValue2")
    def text_value2(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value2")

    @text_value2.setter
    def text_value2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value2", value)

    @property
    @pulumi.getter(name="textValue3")
    def text_value3(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value3")

    @text_value3.setter
    def text_value3(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value3", value)

    @property
    @pulumi.getter(name="textValue4")
    def text_value4(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value4")

    @text_value4.setter
    def text_value4(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value4", value)

    @property
    @pulumi.getter(name="textValue5")
    def text_value5(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value5")

    @text_value5.setter
    def text_value5(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value5", value)

    @property
    @pulumi.getter(name="textValue6")
    def text_value6(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value6")

    @text_value6.setter
    def text_value6(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value6", value)

    @property
    @pulumi.getter(name="textValue7")
    def text_value7(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value7")

    @text_value7.setter
    def text_value7(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value7", value)

    @property
    @pulumi.getter(name="textValue8")
    def text_value8(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value8")

    @text_value8.setter
    def text_value8(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value8", value)

    @property
    @pulumi.getter(name="textValue9")
    def text_value9(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "text_value9")

    @text_value9.setter
    def text_value9(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "text_value9", value)


class LockboxSecretVersionHashed(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 key1: Optional[pulumi.Input[str]] = None,
                 key10: Optional[pulumi.Input[str]] = None,
                 key2: Optional[pulumi.Input[str]] = None,
                 key3: Optional[pulumi.Input[str]] = None,
                 key4: Optional[pulumi.Input[str]] = None,
                 key5: Optional[pulumi.Input[str]] = None,
                 key6: Optional[pulumi.Input[str]] = None,
                 key7: Optional[pulumi.Input[str]] = None,
                 key8: Optional[pulumi.Input[str]] = None,
                 key9: Optional[pulumi.Input[str]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None,
                 text_value1: Optional[pulumi.Input[str]] = None,
                 text_value10: Optional[pulumi.Input[str]] = None,
                 text_value2: Optional[pulumi.Input[str]] = None,
                 text_value3: Optional[pulumi.Input[str]] = None,
                 text_value4: Optional[pulumi.Input[str]] = None,
                 text_value5: Optional[pulumi.Input[str]] = None,
                 text_value6: Optional[pulumi.Input[str]] = None,
                 text_value7: Optional[pulumi.Input[str]] = None,
                 text_value8: Optional[pulumi.Input[str]] = None,
                 text_value9: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Yandex Cloud Lockbox secret version resource (with values hashed in state). For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_secret = yandex.LockboxSecret("mySecret")
        my_version = yandex.LockboxSecretVersionHashed("myVersion",
            secret_id=my_secret.id,
            key1="key1",
            text_value1="sensitive value 1",
            key2="k2",
            text_value2="sensitive value 2")
        # etc. (up to 10 entries)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
               * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
               
               The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
               If you need a second entry, use `key_2`/`text_value_2`, and so on.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LockboxSecretVersionHashedArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Yandex Cloud Lockbox secret version resource (with values hashed in state). For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        my_secret = yandex.LockboxSecret("mySecret")
        my_version = yandex.LockboxSecretVersionHashed("myVersion",
            secret_id=my_secret.id,
            key1="key1",
            text_value1="sensitive value 1",
            key2="k2",
            text_value2="sensitive value 2")
        # etc. (up to 10 entries)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param LockboxSecretVersionHashedArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LockboxSecretVersionHashedArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 key1: Optional[pulumi.Input[str]] = None,
                 key10: Optional[pulumi.Input[str]] = None,
                 key2: Optional[pulumi.Input[str]] = None,
                 key3: Optional[pulumi.Input[str]] = None,
                 key4: Optional[pulumi.Input[str]] = None,
                 key5: Optional[pulumi.Input[str]] = None,
                 key6: Optional[pulumi.Input[str]] = None,
                 key7: Optional[pulumi.Input[str]] = None,
                 key8: Optional[pulumi.Input[str]] = None,
                 key9: Optional[pulumi.Input[str]] = None,
                 secret_id: Optional[pulumi.Input[str]] = None,
                 text_value1: Optional[pulumi.Input[str]] = None,
                 text_value10: Optional[pulumi.Input[str]] = None,
                 text_value2: Optional[pulumi.Input[str]] = None,
                 text_value3: Optional[pulumi.Input[str]] = None,
                 text_value4: Optional[pulumi.Input[str]] = None,
                 text_value5: Optional[pulumi.Input[str]] = None,
                 text_value6: Optional[pulumi.Input[str]] = None,
                 text_value7: Optional[pulumi.Input[str]] = None,
                 text_value8: Optional[pulumi.Input[str]] = None,
                 text_value9: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LockboxSecretVersionHashedArgs.__new__(LockboxSecretVersionHashedArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["key1"] = key1
            __props__.__dict__["key10"] = key10
            __props__.__dict__["key2"] = key2
            __props__.__dict__["key3"] = key3
            __props__.__dict__["key4"] = key4
            __props__.__dict__["key5"] = key5
            __props__.__dict__["key6"] = key6
            __props__.__dict__["key7"] = key7
            __props__.__dict__["key8"] = key8
            __props__.__dict__["key9"] = key9
            if secret_id is None and not opts.urn:
                raise TypeError("Missing required property 'secret_id'")
            __props__.__dict__["secret_id"] = secret_id
            __props__.__dict__["text_value1"] = None if text_value1 is None else pulumi.Output.secret(text_value1)
            __props__.__dict__["text_value10"] = None if text_value10 is None else pulumi.Output.secret(text_value10)
            __props__.__dict__["text_value2"] = None if text_value2 is None else pulumi.Output.secret(text_value2)
            __props__.__dict__["text_value3"] = None if text_value3 is None else pulumi.Output.secret(text_value3)
            __props__.__dict__["text_value4"] = None if text_value4 is None else pulumi.Output.secret(text_value4)
            __props__.__dict__["text_value5"] = None if text_value5 is None else pulumi.Output.secret(text_value5)
            __props__.__dict__["text_value6"] = None if text_value6 is None else pulumi.Output.secret(text_value6)
            __props__.__dict__["text_value7"] = None if text_value7 is None else pulumi.Output.secret(text_value7)
            __props__.__dict__["text_value8"] = None if text_value8 is None else pulumi.Output.secret(text_value8)
            __props__.__dict__["text_value9"] = None if text_value9 is None else pulumi.Output.secret(text_value9)
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["textValue1", "textValue10", "textValue2", "textValue3", "textValue4", "textValue5", "textValue6", "textValue7", "textValue8", "textValue9"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(LockboxSecretVersionHashed, __self__).__init__(
            'yandex:index/lockboxSecretVersionHashed:LockboxSecretVersionHashed',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            key1: Optional[pulumi.Input[str]] = None,
            key10: Optional[pulumi.Input[str]] = None,
            key2: Optional[pulumi.Input[str]] = None,
            key3: Optional[pulumi.Input[str]] = None,
            key4: Optional[pulumi.Input[str]] = None,
            key5: Optional[pulumi.Input[str]] = None,
            key6: Optional[pulumi.Input[str]] = None,
            key7: Optional[pulumi.Input[str]] = None,
            key8: Optional[pulumi.Input[str]] = None,
            key9: Optional[pulumi.Input[str]] = None,
            secret_id: Optional[pulumi.Input[str]] = None,
            text_value1: Optional[pulumi.Input[str]] = None,
            text_value10: Optional[pulumi.Input[str]] = None,
            text_value2: Optional[pulumi.Input[str]] = None,
            text_value3: Optional[pulumi.Input[str]] = None,
            text_value4: Optional[pulumi.Input[str]] = None,
            text_value5: Optional[pulumi.Input[str]] = None,
            text_value6: Optional[pulumi.Input[str]] = None,
            text_value7: Optional[pulumi.Input[str]] = None,
            text_value8: Optional[pulumi.Input[str]] = None,
            text_value9: Optional[pulumi.Input[str]] = None) -> 'LockboxSecretVersionHashed':
        """
        Get an existing LockboxSecretVersionHashed resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The Yandex Cloud Lockbox secret version description.
               * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
               * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
               
               The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
               If you need a second entry, use `key_2`/`text_value_2`, and so on.
        :param pulumi.Input[str] secret_id: The Yandex Cloud Lockbox secret ID where to add the version.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LockboxSecretVersionHashedState.__new__(_LockboxSecretVersionHashedState)

        __props__.__dict__["description"] = description
        __props__.__dict__["key1"] = key1
        __props__.__dict__["key10"] = key10
        __props__.__dict__["key2"] = key2
        __props__.__dict__["key3"] = key3
        __props__.__dict__["key4"] = key4
        __props__.__dict__["key5"] = key5
        __props__.__dict__["key6"] = key6
        __props__.__dict__["key7"] = key7
        __props__.__dict__["key8"] = key8
        __props__.__dict__["key9"] = key9
        __props__.__dict__["secret_id"] = secret_id
        __props__.__dict__["text_value1"] = text_value1
        __props__.__dict__["text_value10"] = text_value10
        __props__.__dict__["text_value2"] = text_value2
        __props__.__dict__["text_value3"] = text_value3
        __props__.__dict__["text_value4"] = text_value4
        __props__.__dict__["text_value5"] = text_value5
        __props__.__dict__["text_value6"] = text_value6
        __props__.__dict__["text_value7"] = text_value7
        __props__.__dict__["text_value8"] = text_value8
        __props__.__dict__["text_value9"] = text_value9
        return LockboxSecretVersionHashed(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The Yandex Cloud Lockbox secret version description.
        * `key_<NUMBER>` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        * `text_value_<NUMBER>` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.

        The `<NUMBER>` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        If you need a second entry, use `key_2`/`text_value_2`, and so on.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def key1(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key1")

    @property
    @pulumi.getter
    def key10(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key10")

    @property
    @pulumi.getter
    def key2(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key2")

    @property
    @pulumi.getter
    def key3(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key3")

    @property
    @pulumi.getter
    def key4(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key4")

    @property
    @pulumi.getter
    def key5(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key5")

    @property
    @pulumi.getter
    def key6(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key6")

    @property
    @pulumi.getter
    def key7(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key7")

    @property
    @pulumi.getter
    def key8(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key8")

    @property
    @pulumi.getter
    def key9(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "key9")

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> pulumi.Output[str]:
        """
        The Yandex Cloud Lockbox secret ID where to add the version.
        """
        return pulumi.get(self, "secret_id")

    @property
    @pulumi.getter(name="textValue1")
    def text_value1(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value1")

    @property
    @pulumi.getter(name="textValue10")
    def text_value10(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value10")

    @property
    @pulumi.getter(name="textValue2")
    def text_value2(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value2")

    @property
    @pulumi.getter(name="textValue3")
    def text_value3(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value3")

    @property
    @pulumi.getter(name="textValue4")
    def text_value4(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value4")

    @property
    @pulumi.getter(name="textValue5")
    def text_value5(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value5")

    @property
    @pulumi.getter(name="textValue6")
    def text_value6(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value6")

    @property
    @pulumi.getter(name="textValue7")
    def text_value7(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value7")

    @property
    @pulumi.getter(name="textValue8")
    def text_value8(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value8")

    @property
    @pulumi.getter(name="textValue9")
    def text_value9(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "text_value9")
