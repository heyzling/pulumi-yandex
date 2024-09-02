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

__all__ = ['CmCertificateArgs', 'CmCertificate']

@pulumi.input_type
class CmCertificateArgs:
    def __init__(__self__, *,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 domains: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 managed: Optional[pulumi.Input['CmCertificateManagedArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 self_managed: Optional[pulumi.Input['CmCertificateSelfManagedArgs']] = None):
        """
        The set of arguments for constructing a CmCertificate resource.
        :param pulumi.Input[str] description: Certificate description.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domains: Domains for this certificate. Should be specified for managed certificates.
        :param pulumi.Input[str] folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this certificate.
        :param pulumi.Input['CmCertificateManagedArgs'] managed: Managed specification. Structure is documented below.
        :param pulumi.Input[str] name: Certificate name.
        :param pulumi.Input['CmCertificateSelfManagedArgs'] self_managed: Self-managed specification. Structure is documented below.
               
               > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        """
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if domains is not None:
            pulumi.set(__self__, "domains", domains)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if managed is not None:
            pulumi.set(__self__, "managed", managed)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if self_managed is not None:
            pulumi.set(__self__, "self_managed", self_managed)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def domains(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Domains for this certificate. Should be specified for managed certificates.
        """
        return pulumi.get(self, "domains")

    @domains.setter
    def domains(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "domains", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this certificate.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def managed(self) -> Optional[pulumi.Input['CmCertificateManagedArgs']]:
        """
        Managed specification. Structure is documented below.
        """
        return pulumi.get(self, "managed")

    @managed.setter
    def managed(self, value: Optional[pulumi.Input['CmCertificateManagedArgs']]):
        pulumi.set(self, "managed", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="selfManaged")
    def self_managed(self) -> Optional[pulumi.Input['CmCertificateSelfManagedArgs']]:
        """
        Self-managed specification. Structure is documented below.

        > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        """
        return pulumi.get(self, "self_managed")

    @self_managed.setter
    def self_managed(self, value: Optional[pulumi.Input['CmCertificateSelfManagedArgs']]):
        pulumi.set(self, "self_managed", value)


@pulumi.input_type
class _CmCertificateState:
    def __init__(__self__, *,
                 challenges: Optional[pulumi.Input[Sequence[pulumi.Input['CmCertificateChallengeArgs']]]] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 domains: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 issued_at: Optional[pulumi.Input[str]] = None,
                 issuer: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 managed: Optional[pulumi.Input['CmCertificateManagedArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 not_after: Optional[pulumi.Input[str]] = None,
                 not_before: Optional[pulumi.Input[str]] = None,
                 self_managed: Optional[pulumi.Input['CmCertificateSelfManagedArgs']] = None,
                 serial: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 subject: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 updated_at: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CmCertificate resources.
        :param pulumi.Input[Sequence[pulumi.Input['CmCertificateChallengeArgs']]] challenges: Array of challenges. Structure is documented below.
        :param pulumi.Input[str] created_at: Time the challenge was created.
        :param pulumi.Input[str] description: Certificate description.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domains: Domains for this certificate. Should be specified for managed certificates.
        :param pulumi.Input[str] folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        :param pulumi.Input[str] issued_at: Certificate issue timestamp.
        :param pulumi.Input[str] issuer: Certificate issuer.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this certificate.
        :param pulumi.Input['CmCertificateManagedArgs'] managed: Managed specification. Structure is documented below.
        :param pulumi.Input[str] name: Certificate name.
        :param pulumi.Input[str] not_after: Certificate end valid period.
        :param pulumi.Input[str] not_before: Certificate start valid period.
        :param pulumi.Input['CmCertificateSelfManagedArgs'] self_managed: Self-managed specification. Structure is documented below.
               
               > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        :param pulumi.Input[str] serial: Certificate serial number.
        :param pulumi.Input[str] status: Certificate status: `"VALIDATING"`, `"INVALID"`,  `"ISSUED"`, `"REVOKED"`, `"RENEWING"` or `"RENEWAL_FAILED"`.
        :param pulumi.Input[str] subject: Certificate subject.
        :param pulumi.Input[str] type: Challenge type `"DNS"` or `"HTTP"`.
        :param pulumi.Input[str] updated_at: Last time the challenge was updated.
        """
        if challenges is not None:
            pulumi.set(__self__, "challenges", challenges)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if domains is not None:
            pulumi.set(__self__, "domains", domains)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if issued_at is not None:
            pulumi.set(__self__, "issued_at", issued_at)
        if issuer is not None:
            pulumi.set(__self__, "issuer", issuer)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if managed is not None:
            pulumi.set(__self__, "managed", managed)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if not_after is not None:
            pulumi.set(__self__, "not_after", not_after)
        if not_before is not None:
            pulumi.set(__self__, "not_before", not_before)
        if self_managed is not None:
            pulumi.set(__self__, "self_managed", self_managed)
        if serial is not None:
            pulumi.set(__self__, "serial", serial)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if subject is not None:
            pulumi.set(__self__, "subject", subject)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if updated_at is not None:
            pulumi.set(__self__, "updated_at", updated_at)

    @property
    @pulumi.getter
    def challenges(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CmCertificateChallengeArgs']]]]:
        """
        Array of challenges. Structure is documented below.
        """
        return pulumi.get(self, "challenges")

    @challenges.setter
    def challenges(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CmCertificateChallengeArgs']]]]):
        pulumi.set(self, "challenges", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        Time the challenge was created.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def domains(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Domains for this certificate. Should be specified for managed certificates.
        """
        return pulumi.get(self, "domains")

    @domains.setter
    def domains(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "domains", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter(name="issuedAt")
    def issued_at(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate issue timestamp.
        """
        return pulumi.get(self, "issued_at")

    @issued_at.setter
    def issued_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "issued_at", value)

    @property
    @pulumi.getter
    def issuer(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate issuer.
        """
        return pulumi.get(self, "issuer")

    @issuer.setter
    def issuer(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "issuer", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this certificate.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def managed(self) -> Optional[pulumi.Input['CmCertificateManagedArgs']]:
        """
        Managed specification. Structure is documented below.
        """
        return pulumi.get(self, "managed")

    @managed.setter
    def managed(self, value: Optional[pulumi.Input['CmCertificateManagedArgs']]):
        pulumi.set(self, "managed", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="notAfter")
    def not_after(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate end valid period.
        """
        return pulumi.get(self, "not_after")

    @not_after.setter
    def not_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "not_after", value)

    @property
    @pulumi.getter(name="notBefore")
    def not_before(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate start valid period.
        """
        return pulumi.get(self, "not_before")

    @not_before.setter
    def not_before(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "not_before", value)

    @property
    @pulumi.getter(name="selfManaged")
    def self_managed(self) -> Optional[pulumi.Input['CmCertificateSelfManagedArgs']]:
        """
        Self-managed specification. Structure is documented below.

        > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        """
        return pulumi.get(self, "self_managed")

    @self_managed.setter
    def self_managed(self, value: Optional[pulumi.Input['CmCertificateSelfManagedArgs']]):
        pulumi.set(self, "self_managed", value)

    @property
    @pulumi.getter
    def serial(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate serial number.
        """
        return pulumi.get(self, "serial")

    @serial.setter
    def serial(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "serial", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate status: `"VALIDATING"`, `"INVALID"`,  `"ISSUED"`, `"REVOKED"`, `"RENEWING"` or `"RENEWAL_FAILED"`.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def subject(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate subject.
        """
        return pulumi.get(self, "subject")

    @subject.setter
    def subject(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subject", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Challenge type `"DNS"` or `"HTTP"`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> Optional[pulumi.Input[str]]:
        """
        Last time the challenge was updated.
        """
        return pulumi.get(self, "updated_at")

    @updated_at.setter
    def updated_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "updated_at", value)


class CmCertificate(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 domains: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateManagedArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 self_managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateSelfManagedArgs']]] = None,
                 __props__=None):
        """
        Creates or requests a TLS certificate in the specified folder.
        For more information, see [the official documentation](https://cloud.yandex.com/en/docs/certificate-manager/concepts/).

        ## Example Usage

        ### Managed Certificate

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        example = yandex.CmCertificate("example",
            domains=["example.com"],
            managed=yandex.CmCertificateManagedArgs(
                challenge_type="DNS_CNAME",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ### Self-Managed Certificate

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        example = yandex.CmCertificate("example", self_managed=yandex.CmCertificateSelfManagedArgs(
            certificate=\"\"\"-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE----- 
         -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----
        \"\"\",
            private_key="-----BEGIN RSA PRIVATE KEY----- ... -----END RSA PRIVATE KEY-----",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ## Limitations

        At the moment, a resource may not work correctly if it declares the use of a DNS challenge, but the certificate is confirmed using an HTTP challenge. And vice versa.

        In this case, the service does not provide the parameters of the required type of challenges.

        ## Import

        A certificate can be imported using the `id` of the resource, e.g.:

        ```sh
        $ pulumi import yandex:index/cmCertificate:CmCertificate default certificate_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Certificate description.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domains: Domains for this certificate. Should be specified for managed certificates.
        :param pulumi.Input[str] folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this certificate.
        :param pulumi.Input[pulumi.InputType['CmCertificateManagedArgs']] managed: Managed specification. Structure is documented below.
        :param pulumi.Input[str] name: Certificate name.
        :param pulumi.Input[pulumi.InputType['CmCertificateSelfManagedArgs']] self_managed: Self-managed specification. Structure is documented below.
               
               > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[CmCertificateArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates or requests a TLS certificate in the specified folder.
        For more information, see [the official documentation](https://cloud.yandex.com/en/docs/certificate-manager/concepts/).

        ## Example Usage

        ### Managed Certificate

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        example = yandex.CmCertificate("example",
            domains=["example.com"],
            managed=yandex.CmCertificateManagedArgs(
                challenge_type="DNS_CNAME",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ### Self-Managed Certificate

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_yandex as yandex

        example = yandex.CmCertificate("example", self_managed=yandex.CmCertificateSelfManagedArgs(
            certificate=\"\"\"-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE----- 
         -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----
        \"\"\",
            private_key="-----BEGIN RSA PRIVATE KEY----- ... -----END RSA PRIVATE KEY-----",
        ))
        ```
        <!--End PulumiCodeChooser -->

        ## Limitations

        At the moment, a resource may not work correctly if it declares the use of a DNS challenge, but the certificate is confirmed using an HTTP challenge. And vice versa.

        In this case, the service does not provide the parameters of the required type of challenges.

        ## Import

        A certificate can be imported using the `id` of the resource, e.g.:

        ```sh
        $ pulumi import yandex:index/cmCertificate:CmCertificate default certificate_id
        ```

        :param str resource_name: The name of the resource.
        :param CmCertificateArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CmCertificateArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 domains: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateManagedArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 self_managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateSelfManagedArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CmCertificateArgs.__new__(CmCertificateArgs)

            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["description"] = description
            __props__.__dict__["domains"] = domains
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["managed"] = managed
            __props__.__dict__["name"] = name
            __props__.__dict__["self_managed"] = self_managed
            __props__.__dict__["challenges"] = None
            __props__.__dict__["created_at"] = None
            __props__.__dict__["issued_at"] = None
            __props__.__dict__["issuer"] = None
            __props__.__dict__["not_after"] = None
            __props__.__dict__["not_before"] = None
            __props__.__dict__["serial"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["subject"] = None
            __props__.__dict__["type"] = None
            __props__.__dict__["updated_at"] = None
        super(CmCertificate, __self__).__init__(
            'yandex:index/cmCertificate:CmCertificate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            challenges: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CmCertificateChallengeArgs']]]]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            domains: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            issued_at: Optional[pulumi.Input[str]] = None,
            issuer: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateManagedArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            not_after: Optional[pulumi.Input[str]] = None,
            not_before: Optional[pulumi.Input[str]] = None,
            self_managed: Optional[pulumi.Input[pulumi.InputType['CmCertificateSelfManagedArgs']]] = None,
            serial: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            subject: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None,
            updated_at: Optional[pulumi.Input[str]] = None) -> 'CmCertificate':
        """
        Get an existing CmCertificate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CmCertificateChallengeArgs']]]] challenges: Array of challenges. Structure is documented below.
        :param pulumi.Input[str] created_at: Time the challenge was created.
        :param pulumi.Input[str] description: Certificate description.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domains: Domains for this certificate. Should be specified for managed certificates.
        :param pulumi.Input[str] folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        :param pulumi.Input[str] issued_at: Certificate issue timestamp.
        :param pulumi.Input[str] issuer: Certificate issuer.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this certificate.
        :param pulumi.Input[pulumi.InputType['CmCertificateManagedArgs']] managed: Managed specification. Structure is documented below.
        :param pulumi.Input[str] name: Certificate name.
        :param pulumi.Input[str] not_after: Certificate end valid period.
        :param pulumi.Input[str] not_before: Certificate start valid period.
        :param pulumi.Input[pulumi.InputType['CmCertificateSelfManagedArgs']] self_managed: Self-managed specification. Structure is documented below.
               
               > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        :param pulumi.Input[str] serial: Certificate serial number.
        :param pulumi.Input[str] status: Certificate status: `"VALIDATING"`, `"INVALID"`,  `"ISSUED"`, `"REVOKED"`, `"RENEWING"` or `"RENEWAL_FAILED"`.
        :param pulumi.Input[str] subject: Certificate subject.
        :param pulumi.Input[str] type: Challenge type `"DNS"` or `"HTTP"`.
        :param pulumi.Input[str] updated_at: Last time the challenge was updated.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CmCertificateState.__new__(_CmCertificateState)

        __props__.__dict__["challenges"] = challenges
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["description"] = description
        __props__.__dict__["domains"] = domains
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["issued_at"] = issued_at
        __props__.__dict__["issuer"] = issuer
        __props__.__dict__["labels"] = labels
        __props__.__dict__["managed"] = managed
        __props__.__dict__["name"] = name
        __props__.__dict__["not_after"] = not_after
        __props__.__dict__["not_before"] = not_before
        __props__.__dict__["self_managed"] = self_managed
        __props__.__dict__["serial"] = serial
        __props__.__dict__["status"] = status
        __props__.__dict__["subject"] = subject
        __props__.__dict__["type"] = type
        __props__.__dict__["updated_at"] = updated_at
        return CmCertificate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def challenges(self) -> pulumi.Output[Sequence['outputs.CmCertificateChallenge']]:
        """
        Array of challenges. Structure is documented below.
        """
        return pulumi.get(self, "challenges")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Time the challenge was created.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def domains(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Domains for this certificate. Should be specified for managed certificates.
        """
        return pulumi.get(self, "domains")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="issuedAt")
    def issued_at(self) -> pulumi.Output[str]:
        """
        Certificate issue timestamp.
        """
        return pulumi.get(self, "issued_at")

    @property
    @pulumi.getter
    def issuer(self) -> pulumi.Output[str]:
        """
        Certificate issuer.
        """
        return pulumi.get(self, "issuer")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Labels to assign to this certificate.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def managed(self) -> pulumi.Output[Optional['outputs.CmCertificateManaged']]:
        """
        Managed specification. Structure is documented below.
        """
        return pulumi.get(self, "managed")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Certificate name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="notAfter")
    def not_after(self) -> pulumi.Output[str]:
        """
        Certificate end valid period.
        """
        return pulumi.get(self, "not_after")

    @property
    @pulumi.getter(name="notBefore")
    def not_before(self) -> pulumi.Output[str]:
        """
        Certificate start valid period.
        """
        return pulumi.get(self, "not_before")

    @property
    @pulumi.getter(name="selfManaged")
    def self_managed(self) -> pulumi.Output[Optional['outputs.CmCertificateSelfManaged']]:
        """
        Self-managed specification. Structure is documented below.

        > **NOTE:** Only one type `managed` or `self_managed` should be specified.
        """
        return pulumi.get(self, "self_managed")

    @property
    @pulumi.getter
    def serial(self) -> pulumi.Output[str]:
        """
        Certificate serial number.
        """
        return pulumi.get(self, "serial")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Certificate status: `"VALIDATING"`, `"INVALID"`,  `"ISSUED"`, `"REVOKED"`, `"RENEWING"` or `"RENEWAL_FAILED"`.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def subject(self) -> pulumi.Output[str]:
        """
        Certificate subject.
        """
        return pulumi.get(self, "subject")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Challenge type `"DNS"` or `"HTTP"`.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> pulumi.Output[str]:
        """
        Last time the challenge was updated.
        """
        return pulumi.get(self, "updated_at")

