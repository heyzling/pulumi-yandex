// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DataprocClusterClusterConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data Proc specific options. The structure is documented below.
        /// </summary>
        [Input("hadoop")]
        public Input<Inputs.DataprocClusterClusterConfigHadoopGetArgs>? Hadoop { get; set; }

        [Input("subclusterSpecs", required: true)]
        private InputList<Inputs.DataprocClusterClusterConfigSubclusterSpecGetArgs>? _subclusterSpecs;

        /// <summary>
        /// Configuration of the Data Proc subcluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.DataprocClusterClusterConfigSubclusterSpecGetArgs> SubclusterSpecs
        {
            get => _subclusterSpecs ?? (_subclusterSpecs = new InputList<Inputs.DataprocClusterClusterConfigSubclusterSpecGetArgs>());
            set => _subclusterSpecs = value;
        }

        /// <summary>
        /// Version of Data Proc image.
        /// </summary>
        [Input("versionId")]
        public Input<string>? VersionId { get; set; }

        public DataprocClusterClusterConfigGetArgs()
        {
        }
        public static new DataprocClusterClusterConfigGetArgs Empty => new DataprocClusterClusterConfigGetArgs();
    }
}