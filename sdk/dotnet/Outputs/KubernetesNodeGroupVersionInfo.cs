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
    public sealed class KubernetesNodeGroupVersionInfo
    {
        /// <summary>
        /// Current Kubernetes version, major.minor (e.g. 1.15).
        /// </summary>
        public readonly string? CurrentVersion;
        /// <summary>
        /// True/false flag.
        /// Newer revisions may include Kubernetes patches (e.g 1.15.1 &gt; 1.15.2) as well
        /// as some internal component updates - new features or bug fixes in yandex-specific
        /// components either on the master or nodes.
        /// </summary>
        public readonly bool? NewRevisionAvailable;
        /// <summary>
        /// Human readable description of the changes to be applied
        /// when updating to the latest revision. Empty if new_revision_available is false.
        /// </summary>
        public readonly string? NewRevisionSummary;
        /// <summary>
        /// True/false flag. The current version is on the deprecation schedule,
        /// component (master or node group) should be upgraded.
        /// </summary>
        public readonly bool? VersionDeprecated;

        [OutputConstructor]
        private KubernetesNodeGroupVersionInfo(
            string? currentVersion,

            bool? newRevisionAvailable,

            string? newRevisionSummary,

            bool? versionDeprecated)
        {
            CurrentVersion = currentVersion;
            NewRevisionAvailable = newRevisionAvailable;
            NewRevisionSummary = newRevisionSummary;
            VersionDeprecated = versionDeprecated;
        }
    }
}
