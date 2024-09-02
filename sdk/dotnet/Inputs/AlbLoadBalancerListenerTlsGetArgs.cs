// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerListenerTlsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// TLS handler resource. The structure is documented below.
        /// </summary>
        [Input("defaultHandler", required: true)]
        public Input<Inputs.AlbLoadBalancerListenerTlsDefaultHandlerGetArgs> DefaultHandler { get; set; } = null!;

        [Input("sniHandlers")]
        private InputList<Inputs.AlbLoadBalancerListenerTlsSniHandlerGetArgs>? _sniHandlers;

        /// <summary>
        /// SNI match resource. The structure is documented below.
        /// </summary>
        public InputList<Inputs.AlbLoadBalancerListenerTlsSniHandlerGetArgs> SniHandlers
        {
            get => _sniHandlers ?? (_sniHandlers = new InputList<Inputs.AlbLoadBalancerListenerTlsSniHandlerGetArgs>());
            set => _sniHandlers = value;
        }

        public AlbLoadBalancerListenerTlsGetArgs()
        {
        }
        public static new AlbLoadBalancerListenerTlsGetArgs Empty => new AlbLoadBalancerListenerTlsGetArgs();
    }
}