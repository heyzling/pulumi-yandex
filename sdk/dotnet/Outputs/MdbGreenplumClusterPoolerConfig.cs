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
    public sealed class MdbGreenplumClusterPoolerConfig
    {
        /// <summary>
        /// Value for `pool_client_idle_timeout` [parameter in Odyssey](https://github.com/yandex/odyssey/blob/master/documentation/configuration.md#pool_ttl-integer).
        /// </summary>
        public readonly int? PoolClientIdleTimeout;
        /// <summary>
        /// Value for `pool_size` [parameter in Odyssey](https://github.com/yandex/odyssey/blob/master/documentation/configuration.md#pool_size-integer).
        /// </summary>
        public readonly int? PoolSize;
        /// <summary>
        /// Mode that the connection pooler is working in. See descriptions of all modes in the [documentation for Odyssey](https://github.com/yandex/odyssey/blob/master/documentation/configuration.md#pool-string.
        /// </summary>
        public readonly string? PoolingMode;

        [OutputConstructor]
        private MdbGreenplumClusterPoolerConfig(
            int? poolClientIdleTimeout,

            int? poolSize,

            string? poolingMode)
        {
            PoolClientIdleTimeout = poolClientIdleTimeout;
            PoolSize = poolSize;
            PoolingMode = poolingMode;
        }
    }
}
