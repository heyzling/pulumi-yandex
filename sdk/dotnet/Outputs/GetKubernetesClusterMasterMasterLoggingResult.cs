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
    public sealed class GetKubernetesClusterMasterMasterLoggingResult
    {
        public readonly bool AuditEnabled;
        public readonly bool ClusterAutoscalerEnabled;
        public readonly bool Enabled;
        public readonly bool EventsEnabled;
        public readonly string FolderId;
        public readonly bool KubeApiserverEnabled;
        public readonly string LogGroupId;

        [OutputConstructor]
        private GetKubernetesClusterMasterMasterLoggingResult(
            bool auditEnabled,

            bool clusterAutoscalerEnabled,

            bool enabled,

            bool eventsEnabled,

            string folderId,

            bool kubeApiserverEnabled,

            string logGroupId)
        {
            AuditEnabled = auditEnabled;
            ClusterAutoscalerEnabled = clusterAutoscalerEnabled;
            Enabled = enabled;
            EventsEnabled = eventsEnabled;
            FolderId = folderId;
            KubeApiserverEnabled = kubeApiserverEnabled;
            LogGroupId = logGroupId;
        }
    }
}