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
    public sealed class DatatransferEndpointSettingsMysqlSourceObjectTransferSettings
    {
        public readonly string? Routine;
        public readonly string? Tables;
        /// <summary>
        /// All of the attrubutes are optional and should be either "BEFORE_DATA", "AFTER_DATA" or "NEVER".
        /// </summary>
        public readonly string? Trigger;
        public readonly string? View;

        [OutputConstructor]
        private DatatransferEndpointSettingsMysqlSourceObjectTransferSettings(
            string? routine,

            string? tables,

            string? trigger,

            string? view)
        {
            Routine = routine;
            Tables = tables;
            Trigger = trigger;
            View = view;
        }
    }
}
