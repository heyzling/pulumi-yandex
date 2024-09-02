// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsMongoSourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("collections")]
        private InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionArgs>? _collections;

        /// <summary>
        /// The list of the MongoDB collections that should be transferred. If omitted, all available collections will be transferred. The structure of the list item is documented below.
        /// </summary>
        public InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionArgs> Collections
        {
            get => _collections ?? (_collections = new InputList<Inputs.DatatransferEndpointSettingsMongoSourceCollectionArgs>());
            set => _collections = value;
        }

        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsMongoSourceConnectionArgs>? Connection { get; set; }

        [Input("excludedCollections")]
        private InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs>? _excludedCollections;

        /// <summary>
        /// The list of the MongoDB collections that should not be transferred.
        /// </summary>
        public InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs> ExcludedCollections
        {
            get => _excludedCollections ?? (_excludedCollections = new InputList<Inputs.DatatransferEndpointSettingsMongoSourceExcludedCollectionArgs>());
            set => _excludedCollections = value;
        }

        /// <summary>
        /// whether the secondary server should be preferred to the primary when copying data.
        /// </summary>
        [Input("secondaryPreferredMode")]
        public Input<bool>? SecondaryPreferredMode { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public DatatransferEndpointSettingsMongoSourceArgs()
        {
        }
        public static new DatatransferEndpointSettingsMongoSourceArgs Empty => new DatatransferEndpointSettingsMongoSourceArgs();
    }
}