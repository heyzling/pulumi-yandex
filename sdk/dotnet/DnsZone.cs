// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Manages a DNS Zone.
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var foo = new Yandex.VpcNetwork("foo");
    /// 
    ///     var zone1 = new Yandex.DnsZone("zone1", new()
    ///     {
    ///         Description = "desc",
    ///         Labels = 
    ///         {
    ///             { "label1", "label-1-value" },
    ///         },
    ///         Zone = "example.com.",
    ///         Public = false,
    ///         PrivateNetworks = new[]
    ///         {
    ///             foo.Id,
    ///         },
    ///         DeletionProtection = true,
    ///     });
    /// 
    ///     var rs1 = new Yandex.DnsRecordset("rs1", new()
    ///     {
    ///         ZoneId = zone1.Id,
    ///         Type = "A",
    ///         Ttl = 200,
    ///         Datas = new[]
    ///         {
    ///             "10.1.0.1",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// DNS zone can be imported using this format:
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/dnsZone:DnsZone zone1 {{zone_id}}
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/dnsZone:DnsZone")]
    public partial class DnsZone : global::Pulumi.CustomResource
    {
        /// <summary>
        /// (Computed) The DNS zone creation timestamp.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Flag that protects the dns zone from accidental deletion.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Description of the DNS zone.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// ID of the folder to create a zone in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the DNS zone.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// User assigned name of a specific resource. Must be unique within the folder.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from.
        /// </summary>
        [Output("privateNetworks")]
        public Output<ImmutableArray<string>> PrivateNetworks { get; private set; } = null!;

        /// <summary>
        /// The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources.
        /// </summary>
        [Output("public")]
        public Output<bool> Public { get; private set; } = null!;

        /// <summary>
        /// The DNS name of this zone, e.g. "example.com.". Must ends with dot.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a DnsZone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DnsZone(string name, DnsZoneArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/dnsZone:DnsZone", name, args ?? new DnsZoneArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DnsZone(string name, Input<string> id, DnsZoneState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/dnsZone:DnsZone", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DnsZone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DnsZone Get(string name, Input<string> id, DnsZoneState? state = null, CustomResourceOptions? options = null)
        {
            return new DnsZone(name, id, state, options);
        }
    }

    public sealed class DnsZoneArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag that protects the dns zone from accidental deletion.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the DNS zone.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder to create a zone in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the DNS zone.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// User assigned name of a specific resource. Must be unique within the folder.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("privateNetworks")]
        private InputList<string>? _privateNetworks;

        /// <summary>
        /// For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from.
        /// </summary>
        public InputList<string> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<string>());
            set => _privateNetworks = value;
        }

        /// <summary>
        /// The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources.
        /// </summary>
        [Input("public")]
        public Input<bool>? Public { get; set; }

        /// <summary>
        /// The DNS name of this zone, e.g. "example.com.". Must ends with dot.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public DnsZoneArgs()
        {
        }
        public static new DnsZoneArgs Empty => new DnsZoneArgs();
    }

    public sealed class DnsZoneState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Computed) The DNS zone creation timestamp.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Flag that protects the dns zone from accidental deletion.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the DNS zone.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder to create a zone in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the DNS zone.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// User assigned name of a specific resource. Must be unique within the folder.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("privateNetworks")]
        private InputList<string>? _privateNetworks;

        /// <summary>
        /// For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from.
        /// </summary>
        public InputList<string> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<string>());
            set => _privateNetworks = value;
        }

        /// <summary>
        /// The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources.
        /// </summary>
        [Input("public")]
        public Input<bool>? Public { get; set; }

        /// <summary>
        /// The DNS name of this zone, e.g. "example.com.". Must ends with dot.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public DnsZoneState()
        {
        }
        public static new DnsZoneState Empty => new DnsZoneState();
    }
}