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
    public sealed class YdbDatabaseDedicatedStorageConfig
    {
        /// <summary>
        /// Amount of storage groups of selected type for the Yandex Database cluster.
        /// </summary>
        public readonly int GroupCount;
        /// <summary>
        /// Storage type ID for the Yandex Database cluster.
        /// Available presets can be obtained via `yc ydb storage-type list` command.
        /// </summary>
        public readonly string StorageTypeId;

        [OutputConstructor]
        private YdbDatabaseDedicatedStorageConfig(
            int groupCount,

            string storageTypeId)
        {
            GroupCount = groupCount;
            StorageTypeId = storageTypeId;
        }
    }
}
