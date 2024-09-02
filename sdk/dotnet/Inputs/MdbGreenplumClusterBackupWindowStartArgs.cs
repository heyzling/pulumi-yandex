// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbGreenplumClusterBackupWindowStartArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hour at which backup will be started (UTC).
        /// </summary>
        [Input("hours")]
        public Input<int>? Hours { get; set; }

        /// <summary>
        /// The minute at which backup will be started (UTC).
        /// </summary>
        [Input("minutes")]
        public Input<int>? Minutes { get; set; }

        public MdbGreenplumClusterBackupWindowStartArgs()
        {
        }
        public static new MdbGreenplumClusterBackupWindowStartArgs Empty => new MdbGreenplumClusterBackupWindowStartArgs();
    }
}
