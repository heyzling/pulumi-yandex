// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Collection name.
        /// </summary>
        [Input("collectionName")]
        public Input<string>? CollectionName { get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [Input("databaseName")]
        public Input<string>? DatabaseName { get; set; }

        public DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs Empty => new DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs();
    }
}
