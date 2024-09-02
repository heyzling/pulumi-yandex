# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetKmsAsymmetricSignatureKeyResult',
    'AwaitableGetKmsAsymmetricSignatureKeyResult',
    'get_kms_asymmetric_signature_key',
    'get_kms_asymmetric_signature_key_output',
]

@pulumi.output_type
class GetKmsAsymmetricSignatureKeyResult:
    """
    A collection of values returned by getKmsAsymmetricSignatureKey.
    """
    def __init__(__self__, asymmetric_signature_key_id=None, created_at=None, deletion_protection=None, description=None, folder_id=None, id=None, labels=None, name=None, signature_algorithm=None, status=None):
        if asymmetric_signature_key_id and not isinstance(asymmetric_signature_key_id, str):
            raise TypeError("Expected argument 'asymmetric_signature_key_id' to be a str")
        pulumi.set(__self__, "asymmetric_signature_key_id", asymmetric_signature_key_id)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if deletion_protection and not isinstance(deletion_protection, bool):
            raise TypeError("Expected argument 'deletion_protection' to be a bool")
        pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if signature_algorithm and not isinstance(signature_algorithm, str):
            raise TypeError("Expected argument 'signature_algorithm' to be a str")
        pulumi.set(__self__, "signature_algorithm", signature_algorithm)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="asymmetricSignatureKeyId")
    def asymmetric_signature_key_id(self) -> str:
        return pulumi.get(self, "asymmetric_signature_key_id")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[bool]:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="signatureAlgorithm")
    def signature_algorithm(self) -> Optional[str]:
        return pulumi.get(self, "signature_algorithm")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")


class AwaitableGetKmsAsymmetricSignatureKeyResult(GetKmsAsymmetricSignatureKeyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetKmsAsymmetricSignatureKeyResult(
            asymmetric_signature_key_id=self.asymmetric_signature_key_id,
            created_at=self.created_at,
            deletion_protection=self.deletion_protection,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            signature_algorithm=self.signature_algorithm,
            status=self.status)


def get_kms_asymmetric_signature_key(asymmetric_signature_key_id: Optional[str] = None,
                                     deletion_protection: Optional[bool] = None,
                                     description: Optional[str] = None,
                                     folder_id: Optional[str] = None,
                                     labels: Optional[Mapping[str, str]] = None,
                                     name: Optional[str] = None,
                                     signature_algorithm: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetKmsAsymmetricSignatureKeyResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['asymmetricSignatureKeyId'] = asymmetric_signature_key_id
    __args__['deletionProtection'] = deletion_protection
    __args__['description'] = description
    __args__['folderId'] = folder_id
    __args__['labels'] = labels
    __args__['name'] = name
    __args__['signatureAlgorithm'] = signature_algorithm
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getKmsAsymmetricSignatureKey:getKmsAsymmetricSignatureKey', __args__, opts=opts, typ=GetKmsAsymmetricSignatureKeyResult).value

    return AwaitableGetKmsAsymmetricSignatureKeyResult(
        asymmetric_signature_key_id=pulumi.get(__ret__, 'asymmetric_signature_key_id'),
        created_at=pulumi.get(__ret__, 'created_at'),
        deletion_protection=pulumi.get(__ret__, 'deletion_protection'),
        description=pulumi.get(__ret__, 'description'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        id=pulumi.get(__ret__, 'id'),
        labels=pulumi.get(__ret__, 'labels'),
        name=pulumi.get(__ret__, 'name'),
        signature_algorithm=pulumi.get(__ret__, 'signature_algorithm'),
        status=pulumi.get(__ret__, 'status'))


@_utilities.lift_output_func(get_kms_asymmetric_signature_key)
def get_kms_asymmetric_signature_key_output(asymmetric_signature_key_id: Optional[pulumi.Input[str]] = None,
                                            deletion_protection: Optional[pulumi.Input[Optional[bool]]] = None,
                                            description: Optional[pulumi.Input[Optional[str]]] = None,
                                            folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                            labels: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                                            name: Optional[pulumi.Input[Optional[str]]] = None,
                                            signature_algorithm: Optional[pulumi.Input[Optional[str]]] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetKmsAsymmetricSignatureKeyResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
