// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupGrpcBackendArgs : global::Pulumi.InvokeArgs
    {
        [Input("healthcheck", required: true)]
        public Inputs.GetAlbBackendGroupGrpcBackendHealthcheckArgs Healthcheck { get; set; } = null!;

        [Input("loadBalancingConfig", required: true)]
        public Inputs.GetAlbBackendGroupGrpcBackendLoadBalancingConfigArgs LoadBalancingConfig { get; set; } = null!;

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("port", required: true)]
        public int Port { get; set; }

        [Input("targetGroupIds", required: true)]
        private List<string>? _targetGroupIds;
        public List<string> TargetGroupIds
        {
            get => _targetGroupIds ?? (_targetGroupIds = new List<string>());
            set => _targetGroupIds = value;
        }

        [Input("tls", required: true)]
        public Inputs.GetAlbBackendGroupGrpcBackendTlsArgs Tls { get; set; } = null!;

        [Input("weight", required: true)]
        public int Weight { get; set; }

        public GetAlbBackendGroupGrpcBackendArgs()
        {
        }
        public static new GetAlbBackendGroupGrpcBackendArgs Empty => new GetAlbBackendGroupGrpcBackendArgs();
    }
}
