// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerListenerArgs : global::Pulumi.ResourceArgs
    {
        [Input("endpoints")]
        private InputList<Inputs.AlbLoadBalancerListenerEndpointArgs>? _endpoints;

        /// <summary>
        /// Network endpoints (addresses and ports) of the listener. The structure is documented below.
        /// </summary>
        public InputList<Inputs.AlbLoadBalancerListenerEndpointArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.AlbLoadBalancerListenerEndpointArgs>());
            set => _endpoints = value;
        }

        /// <summary>
        /// HTTP listener resource. The structure is documented below.
        /// </summary>
        [Input("http")]
        public Input<Inputs.AlbLoadBalancerListenerHttpArgs>? Http { get; set; }

        /// <summary>
        /// name of the listener.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Stream listener resource. The structure is documented below.
        /// </summary>
        [Input("stream")]
        public Input<Inputs.AlbLoadBalancerListenerStreamArgs>? Stream { get; set; }

        /// <summary>
        /// TLS listener resource. The structure is documented below.
        /// 
        /// &gt; **NOTE:** Exactly one listener type: `http` or `tls` or `stream` should be specified.
        /// </summary>
        [Input("tls")]
        public Input<Inputs.AlbLoadBalancerListenerTlsArgs>? Tls { get; set; }

        public AlbLoadBalancerListenerArgs()
        {
        }
        public static new AlbLoadBalancerListenerArgs Empty => new AlbLoadBalancerListenerArgs();
    }
}
