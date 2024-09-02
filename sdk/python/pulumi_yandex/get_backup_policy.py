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

__all__ = [
    'GetBackupPolicyResult',
    'AwaitableGetBackupPolicyResult',
    'get_backup_policy',
    'get_backup_policy_output',
]

@pulumi.output_type
class GetBackupPolicyResult:
    """
    A collection of values returned by getBackupPolicy.
    """
    def __init__(__self__, archive_name=None, cbt=None, compression=None, created_at=None, enabled=None, fast_backup_enabled=None, folder_id=None, format=None, id=None, multi_volume_snapshotting_enabled=None, name=None, performance_window_enabled=None, policy_id=None, preserve_file_security_settings=None, quiesce_snapshotting_enabled=None, reattempts=None, retentions=None, schedulings=None, silent_mode_enabled=None, splitting_bytes=None, updated_at=None, vm_snapshot_reattempts=None, vss_provider=None):
        if archive_name and not isinstance(archive_name, str):
            raise TypeError("Expected argument 'archive_name' to be a str")
        pulumi.set(__self__, "archive_name", archive_name)
        if cbt and not isinstance(cbt, str):
            raise TypeError("Expected argument 'cbt' to be a str")
        pulumi.set(__self__, "cbt", cbt)
        if compression and not isinstance(compression, str):
            raise TypeError("Expected argument 'compression' to be a str")
        pulumi.set(__self__, "compression", compression)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if fast_backup_enabled and not isinstance(fast_backup_enabled, bool):
            raise TypeError("Expected argument 'fast_backup_enabled' to be a bool")
        pulumi.set(__self__, "fast_backup_enabled", fast_backup_enabled)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if format and not isinstance(format, str):
            raise TypeError("Expected argument 'format' to be a str")
        pulumi.set(__self__, "format", format)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if multi_volume_snapshotting_enabled and not isinstance(multi_volume_snapshotting_enabled, bool):
            raise TypeError("Expected argument 'multi_volume_snapshotting_enabled' to be a bool")
        pulumi.set(__self__, "multi_volume_snapshotting_enabled", multi_volume_snapshotting_enabled)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if performance_window_enabled and not isinstance(performance_window_enabled, bool):
            raise TypeError("Expected argument 'performance_window_enabled' to be a bool")
        pulumi.set(__self__, "performance_window_enabled", performance_window_enabled)
        if policy_id and not isinstance(policy_id, str):
            raise TypeError("Expected argument 'policy_id' to be a str")
        pulumi.set(__self__, "policy_id", policy_id)
        if preserve_file_security_settings and not isinstance(preserve_file_security_settings, bool):
            raise TypeError("Expected argument 'preserve_file_security_settings' to be a bool")
        pulumi.set(__self__, "preserve_file_security_settings", preserve_file_security_settings)
        if quiesce_snapshotting_enabled and not isinstance(quiesce_snapshotting_enabled, bool):
            raise TypeError("Expected argument 'quiesce_snapshotting_enabled' to be a bool")
        pulumi.set(__self__, "quiesce_snapshotting_enabled", quiesce_snapshotting_enabled)
        if reattempts and not isinstance(reattempts, list):
            raise TypeError("Expected argument 'reattempts' to be a list")
        pulumi.set(__self__, "reattempts", reattempts)
        if retentions and not isinstance(retentions, list):
            raise TypeError("Expected argument 'retentions' to be a list")
        pulumi.set(__self__, "retentions", retentions)
        if schedulings and not isinstance(schedulings, list):
            raise TypeError("Expected argument 'schedulings' to be a list")
        pulumi.set(__self__, "schedulings", schedulings)
        if silent_mode_enabled and not isinstance(silent_mode_enabled, bool):
            raise TypeError("Expected argument 'silent_mode_enabled' to be a bool")
        pulumi.set(__self__, "silent_mode_enabled", silent_mode_enabled)
        if splitting_bytes and not isinstance(splitting_bytes, str):
            raise TypeError("Expected argument 'splitting_bytes' to be a str")
        pulumi.set(__self__, "splitting_bytes", splitting_bytes)
        if updated_at and not isinstance(updated_at, str):
            raise TypeError("Expected argument 'updated_at' to be a str")
        pulumi.set(__self__, "updated_at", updated_at)
        if vm_snapshot_reattempts and not isinstance(vm_snapshot_reattempts, list):
            raise TypeError("Expected argument 'vm_snapshot_reattempts' to be a list")
        pulumi.set(__self__, "vm_snapshot_reattempts", vm_snapshot_reattempts)
        if vss_provider and not isinstance(vss_provider, str):
            raise TypeError("Expected argument 'vss_provider' to be a str")
        pulumi.set(__self__, "vss_provider", vss_provider)

    @property
    @pulumi.getter(name="archiveName")
    def archive_name(self) -> str:
        return pulumi.get(self, "archive_name")

    @property
    @pulumi.getter
    def cbt(self) -> str:
        return pulumi.get(self, "cbt")

    @property
    @pulumi.getter
    def compression(self) -> str:
        return pulumi.get(self, "compression")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="fastBackupEnabled")
    def fast_backup_enabled(self) -> bool:
        return pulumi.get(self, "fast_backup_enabled")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def format(self) -> str:
        return pulumi.get(self, "format")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="multiVolumeSnapshottingEnabled")
    def multi_volume_snapshotting_enabled(self) -> bool:
        return pulumi.get(self, "multi_volume_snapshotting_enabled")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="performanceWindowEnabled")
    def performance_window_enabled(self) -> bool:
        return pulumi.get(self, "performance_window_enabled")

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> str:
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter(name="preserveFileSecuritySettings")
    def preserve_file_security_settings(self) -> bool:
        return pulumi.get(self, "preserve_file_security_settings")

    @property
    @pulumi.getter(name="quiesceSnapshottingEnabled")
    def quiesce_snapshotting_enabled(self) -> bool:
        return pulumi.get(self, "quiesce_snapshotting_enabled")

    @property
    @pulumi.getter
    def reattempts(self) -> Sequence['outputs.GetBackupPolicyReattemptResult']:
        return pulumi.get(self, "reattempts")

    @property
    @pulumi.getter
    def retentions(self) -> Sequence['outputs.GetBackupPolicyRetentionResult']:
        return pulumi.get(self, "retentions")

    @property
    @pulumi.getter
    def schedulings(self) -> Sequence['outputs.GetBackupPolicySchedulingResult']:
        return pulumi.get(self, "schedulings")

    @property
    @pulumi.getter(name="silentModeEnabled")
    def silent_mode_enabled(self) -> bool:
        return pulumi.get(self, "silent_mode_enabled")

    @property
    @pulumi.getter(name="splittingBytes")
    def splitting_bytes(self) -> str:
        return pulumi.get(self, "splitting_bytes")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> str:
        return pulumi.get(self, "updated_at")

    @property
    @pulumi.getter(name="vmSnapshotReattempts")
    def vm_snapshot_reattempts(self) -> Sequence['outputs.GetBackupPolicyVmSnapshotReattemptResult']:
        return pulumi.get(self, "vm_snapshot_reattempts")

    @property
    @pulumi.getter(name="vssProvider")
    def vss_provider(self) -> str:
        return pulumi.get(self, "vss_provider")


class AwaitableGetBackupPolicyResult(GetBackupPolicyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBackupPolicyResult(
            archive_name=self.archive_name,
            cbt=self.cbt,
            compression=self.compression,
            created_at=self.created_at,
            enabled=self.enabled,
            fast_backup_enabled=self.fast_backup_enabled,
            folder_id=self.folder_id,
            format=self.format,
            id=self.id,
            multi_volume_snapshotting_enabled=self.multi_volume_snapshotting_enabled,
            name=self.name,
            performance_window_enabled=self.performance_window_enabled,
            policy_id=self.policy_id,
            preserve_file_security_settings=self.preserve_file_security_settings,
            quiesce_snapshotting_enabled=self.quiesce_snapshotting_enabled,
            reattempts=self.reattempts,
            retentions=self.retentions,
            schedulings=self.schedulings,
            silent_mode_enabled=self.silent_mode_enabled,
            splitting_bytes=self.splitting_bytes,
            updated_at=self.updated_at,
            vm_snapshot_reattempts=self.vm_snapshot_reattempts,
            vss_provider=self.vss_provider)


def get_backup_policy(name: Optional[str] = None,
                      policy_id: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetBackupPolicyResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['policyId'] = policy_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getBackupPolicy:getBackupPolicy', __args__, opts=opts, typ=GetBackupPolicyResult).value

    return AwaitableGetBackupPolicyResult(
        archive_name=pulumi.get(__ret__, 'archive_name'),
        cbt=pulumi.get(__ret__, 'cbt'),
        compression=pulumi.get(__ret__, 'compression'),
        created_at=pulumi.get(__ret__, 'created_at'),
        enabled=pulumi.get(__ret__, 'enabled'),
        fast_backup_enabled=pulumi.get(__ret__, 'fast_backup_enabled'),
        folder_id=pulumi.get(__ret__, 'folder_id'),
        format=pulumi.get(__ret__, 'format'),
        id=pulumi.get(__ret__, 'id'),
        multi_volume_snapshotting_enabled=pulumi.get(__ret__, 'multi_volume_snapshotting_enabled'),
        name=pulumi.get(__ret__, 'name'),
        performance_window_enabled=pulumi.get(__ret__, 'performance_window_enabled'),
        policy_id=pulumi.get(__ret__, 'policy_id'),
        preserve_file_security_settings=pulumi.get(__ret__, 'preserve_file_security_settings'),
        quiesce_snapshotting_enabled=pulumi.get(__ret__, 'quiesce_snapshotting_enabled'),
        reattempts=pulumi.get(__ret__, 'reattempts'),
        retentions=pulumi.get(__ret__, 'retentions'),
        schedulings=pulumi.get(__ret__, 'schedulings'),
        silent_mode_enabled=pulumi.get(__ret__, 'silent_mode_enabled'),
        splitting_bytes=pulumi.get(__ret__, 'splitting_bytes'),
        updated_at=pulumi.get(__ret__, 'updated_at'),
        vm_snapshot_reattempts=pulumi.get(__ret__, 'vm_snapshot_reattempts'),
        vss_provider=pulumi.get(__ret__, 'vss_provider'))


@_utilities.lift_output_func(get_backup_policy)
def get_backup_policy_output(name: Optional[pulumi.Input[Optional[str]]] = None,
                             policy_id: Optional[pulumi.Input[Optional[str]]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetBackupPolicyResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...