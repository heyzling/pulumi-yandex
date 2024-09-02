// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterClusterConfigMongodStorageJournalGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum amount of time in milliseconds that the mongod process allows between journal operations.
        /// For more information, see the [storage.journal.commitIntervalMs](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-storage.journal.commitIntervalMs)
        /// description in the official documentation.
        /// </summary>
        [Input("commitInterval")]
        public Input<int>? CommitInterval { get; set; }

        public MdbMongodbClusterClusterConfigMongodStorageJournalGetArgs()
        {
        }
        public static new MdbMongodbClusterClusterConfigMongodStorageJournalGetArgs Empty => new MdbMongodbClusterClusterConfigMongodStorageJournalGetArgs();
    }
}
