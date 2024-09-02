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
    'GetCmCertificateContentResult',
    'AwaitableGetCmCertificateContentResult',
    'get_cm_certificate_content',
    'get_cm_certificate_content_output',
]

@pulumi.output_type
class GetCmCertificateContentResult:
    """
    A collection of values returned by getCmCertificateContent.
    """
    def __init__(__self__, certificate_id=None, certificates=None, folder_id=None, id=None, name=None, private_key=None, private_key_format=None, wait_validation=None):
        if certificate_id and not isinstance(certificate_id, str):
            raise TypeError("Expected argument 'certificate_id' to be a str")
        pulumi.set(__self__, "certificate_id", certificate_id)
        if certificates and not isinstance(certificates, list):
            raise TypeError("Expected argument 'certificates' to be a list")
        pulumi.set(__self__, "certificates", certificates)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if private_key and not isinstance(private_key, str):
            raise TypeError("Expected argument 'private_key' to be a str")
        pulumi.set(__self__, "private_key", private_key)
        if private_key_format and not isinstance(private_key_format, str):
            raise TypeError("Expected argument 'private_key_format' to be a str")
        pulumi.set(__self__, "private_key_format", private_key_format)
        if wait_validation and not isinstance(wait_validation, bool):
            raise TypeError("Expected argument 'wait_validation' to be a bool")
        pulumi.set(__self__, "wait_validation", wait_validation)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> Optional[str]:
        return pulumi.get(self, "certificate_id")

    @property
    @pulumi.getter
    def certificates(self) -> Sequence[str]:
        return pulumi.get(self, "certificates")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[str]:
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
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> str:
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="privateKeyFormat")
    def private_key_format(self) -> Optional[str]:
        return pulumi.get(self, "private_key_format")

    @property
    @pulumi.getter(name="waitValidation")
    def wait_validation(self) -> Optional[bool]:
        return pulumi.get(self, "wait_validation")


class AwaitableGetCmCertificateContentResult(GetCmCertificateContentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCmCertificateContentResult(
            certificate_id=self.certificate_id,
            certificates=self.certificates,
            folder_id=self.folder_id,
            id=self.id,
            name=self.name,
            private_key=self.private_key,
            private_key_format=self.private_key_format,
            wait_validation=self.wait_validation)


def get_cm_certificate_content(certificate_id: Optional[str] = None,
                               folder_id: Optional[str] = None,
                               name: Optional[str] = None,
                               private_key_format: Optional[str] = None,
                               wait_validation: Optional[bool] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCmCertificateContentResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['certificateId'] = certificate_id
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['privateKeyFormat'] = private_key_format
    __args__['waitValidation'] = wait_validation
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getCmCertificateContent:getCmCertificateContent', __args__, opts=opts, typ=GetCmCertificateContentResult).value

    return AwaitableGetCmCertificateContentResult(
        certificate_id=pulumi.get(__ret__, 'certificate_id'),
        certificates=pulumi.get(__ret__, 'certificates'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        private_key=pulumi.get(__ret__, 'private_key'),
        private_key_format=pulumi.get(__ret__, 'private_key_format'),
        wait_validation=pulumi.get(__ret__, 'wait_validation'))


@_utilities.lift_output_func(get_cm_certificate_content)
def get_cm_certificate_content_output(certificate_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      name: Optional[pulumi.Input[Optional[str]]] = None,
                                      private_key_format: Optional[pulumi.Input[Optional[str]]] = None,
                                      wait_validation: Optional[pulumi.Input[Optional[bool]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCmCertificateContentResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
