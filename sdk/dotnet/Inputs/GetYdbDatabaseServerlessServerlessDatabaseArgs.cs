// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetYdbDatabaseServerlessServerlessDatabaseInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableThrottlingRcuLimit", required: true)]
        public Input<bool> EnableThrottlingRcuLimit { get; set; } = null!;

        [Input("provisionedRcuLimit", required: true)]
        public Input<int> ProvisionedRcuLimit { get; set; } = null!;

        [Input("storageSizeLimit", required: true)]
        public Input<int> StorageSizeLimit { get; set; } = null!;

        [Input("throttlingRcuLimit", required: true)]
        public Input<int> ThrottlingRcuLimit { get; set; } = null!;

        public GetYdbDatabaseServerlessServerlessDatabaseInputArgs()
        {
        }
        public static new GetYdbDatabaseServerlessServerlessDatabaseInputArgs Empty => new GetYdbDatabaseServerlessServerlessDatabaseInputArgs();
    }
}