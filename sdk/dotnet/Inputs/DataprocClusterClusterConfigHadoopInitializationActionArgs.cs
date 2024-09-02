// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DataprocClusterClusterConfigHadoopInitializationActionArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// List of arguments of the initialization script.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        /// <summary>
        /// Script execution timeout, in seconds.
        /// </summary>
        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        /// <summary>
        /// Script URI.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public DataprocClusterClusterConfigHadoopInitializationActionArgs()
        {
        }
        public static new DataprocClusterClusterConfigHadoopInitializationActionArgs Empty => new DataprocClusterClusterConfigHadoopInitializationActionArgs();
    }
}
