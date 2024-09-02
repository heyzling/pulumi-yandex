// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ServerlessContainerLogOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Is logging from container disabled
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Folder ID for the Yandex Cloud Serverless Container
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Log entries are written to specified log group
        /// </summary>
        [Input("logGroupId")]
        public Input<string>? LogGroupId { get; set; }

        /// <summary>
        /// Minimum log entry level
        /// </summary>
        [Input("minLevel")]
        public Input<string>? MinLevel { get; set; }

        public ServerlessContainerLogOptionsGetArgs()
        {
        }
        public static new ServerlessContainerLogOptionsGetArgs Empty => new ServerlessContainerLogOptionsGetArgs();
    }
}
