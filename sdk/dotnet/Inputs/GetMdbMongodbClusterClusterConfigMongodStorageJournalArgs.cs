// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodStorageJournalInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("commitInterval")]
        public Input<int>? CommitInterval { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodStorageJournalInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodStorageJournalInputArgs Empty => new GetMdbMongodbClusterClusterConfigMongodStorageJournalInputArgs();
    }
}