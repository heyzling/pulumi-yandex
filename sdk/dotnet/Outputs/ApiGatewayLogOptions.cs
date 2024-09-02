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
    public sealed class ApiGatewayLogOptions
    {
        /// <summary>
        /// Is logging from API Gateway disabled
        /// </summary>
        public readonly bool? Disabled;
        /// <summary>
        /// Folder ID for the Yandex Cloud API Gateway. If it is not provided, the default provider folder is used.
        /// </summary>
        public readonly string? FolderId;
        /// <summary>
        /// Log entries are written to specified log group
        /// </summary>
        public readonly string? LogGroupId;
        /// <summary>
        /// Minimum log entry level
        /// </summary>
        public readonly string? MinLevel;

        [OutputConstructor]
        private ApiGatewayLogOptions(
            bool? disabled,

            string? folderId,

            string? logGroupId,

            string? minLevel)
        {
            Disabled = disabled;
            FolderId = folderId;
            LogGroupId = logGroupId;
            MinLevel = minLevel;
        }
    }
}