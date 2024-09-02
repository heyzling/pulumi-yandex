// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class KubernetesClusterMaster
    {
        /// <summary>
        /// (Computed) PEM-encoded public certificate that is the root of trust for the Kubernetes cluster.
        /// </summary>
        public readonly string? ClusterCaCertificate;
        public readonly int? EtcdClusterSize;
        /// <summary>
        /// (Computed) An IPv4 external network address that is assigned to the master.
        /// </summary>
        public readonly string? ExternalV4Address;
        /// <summary>
        /// (Computed) External endpoint that can be used to access Kubernetes cluster API from the internet (outside of the cloud).
        /// </summary>
        public readonly string? ExternalV4Endpoint;
        public readonly string? ExternalV6Address;
        public readonly string? ExternalV6Endpoint;
        /// <summary>
        /// (Computed) An IPv4 internal network address that is assigned to the master.
        /// </summary>
        public readonly string? InternalV4Address;
        /// <summary>
        /// (Computed) Internal endpoint that can be used to connect to the master from cloud networks.
        /// </summary>
        public readonly string? InternalV4Endpoint;
        /// <summary>
        /// (Optional) (Computed) Maintenance policy for Kubernetes master.
        /// If policy is omitted, automatic revision upgrades of the kubernetes master are enabled and could happen at any time.
        /// Revision upgrades are performed only within the same minor version, e.g. 1.13.
        /// Minor version upgrades (e.g. 1.13-&gt;1.14) should be performed manually. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesClusterMasterMaintenancePolicy? MaintenancePolicy;
        /// <summary>
        /// (Optional) Cluster master's instances locations array (zone and subnet).
        /// Cannot be used together with `zonal` or `regional`. Currently, supports either one, for zonal master, or three instances of `master_location`.
        /// Can be updated inplace. When creating regional cluster (three master instances), its `region` will be evaluated automatically by backend.
        /// The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.KubernetesClusterMasterMasterLocation> MasterLocations;
        /// <summary>
        /// (Optional) Master Logging options. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesClusterMasterMasterLogging? MasterLogging;
        /// <summary>
        /// (Optional) (Computed) Boolean flag. When `true`, Kubernetes master will have visible ipv4 address.
        /// </summary>
        public readonly bool? PublicIp;
        /// <summary>
        /// (Optional) Initialize parameters for Regional Master (highly available master). The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesClusterMasterRegional? Regional;
        /// <summary>
        /// (Optional) List of security group IDs to which the Kubernetes cluster belongs.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// (Optional) (Computed) Version of Kubernetes that will be used for master.
        /// </summary>
        public readonly string? Version;
        /// <summary>
        /// (Computed) Information about cluster version. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.KubernetesClusterMasterVersionInfo> VersionInfos;
        /// <summary>
        /// (Optional) Initialize parameters for Zonal Master (single node master). The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesClusterMasterZonal? Zonal;

        [OutputConstructor]
        private KubernetesClusterMaster(
            string? clusterCaCertificate,

            int? etcdClusterSize,

            string? externalV4Address,

            string? externalV4Endpoint,

            string? externalV6Address,

            string? externalV6Endpoint,

            string? internalV4Address,

            string? internalV4Endpoint,

            Outputs.KubernetesClusterMasterMaintenancePolicy? maintenancePolicy,

            ImmutableArray<Outputs.KubernetesClusterMasterMasterLocation> masterLocations,

            Outputs.KubernetesClusterMasterMasterLogging? masterLogging,

            bool? publicIp,

            Outputs.KubernetesClusterMasterRegional? regional,

            ImmutableArray<string> securityGroupIds,

            string? version,

            ImmutableArray<Outputs.KubernetesClusterMasterVersionInfo> versionInfos,

            Outputs.KubernetesClusterMasterZonal? zonal)
        {
            ClusterCaCertificate = clusterCaCertificate;
            EtcdClusterSize = etcdClusterSize;
            ExternalV4Address = externalV4Address;
            ExternalV4Endpoint = externalV4Endpoint;
            ExternalV6Address = externalV6Address;
            ExternalV6Endpoint = externalV6Endpoint;
            InternalV4Address = internalV4Address;
            InternalV4Endpoint = internalV4Endpoint;
            MaintenancePolicy = maintenancePolicy;
            MasterLocations = masterLocations;
            MasterLogging = masterLogging;
            PublicIp = publicIp;
            Regional = regional;
            SecurityGroupIds = securityGroupIds;
            Version = version;
            VersionInfos = versionInfos;
            Zonal = zonal;
        }
    }
}