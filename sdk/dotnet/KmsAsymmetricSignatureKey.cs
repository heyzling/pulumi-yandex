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
    /// Creates a Yandex KMS asymmetric signature key that can be used for cryptographic operation.
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
    ///     var key_a = new Yandex.KmsAsymmetricSignatureKey("key-a", new()
    ///     {
    ///         Description = "description for key",
    ///         SignatureAlgorithm = "RSA_2048_SIGN_PSS_SHA_256",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// A KMS asymmetric signature key can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/kmsAsymmetricSignatureKey:KmsAsymmetricSignatureKey top-secret kms_asymmetric_signature_key_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/kmsAsymmetricSignatureKey:KmsAsymmetricSignatureKey")]
    public partial class KmsAsymmetricSignatureKey : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Signature algorithm to be used with a new key. The default value is `RSA_2048_SIGN_PSS_SHA_256`.
        /// </summary>
        [Output("signatureAlgorithm")]
        public Output<string?> SignatureAlgorithm { get; private set; } = null!;

        /// <summary>
        /// The status of the key.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a KmsAsymmetricSignatureKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KmsAsymmetricSignatureKey(string name, KmsAsymmetricSignatureKeyArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsAsymmetricSignatureKey:KmsAsymmetricSignatureKey", name, args ?? new KmsAsymmetricSignatureKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KmsAsymmetricSignatureKey(string name, Input<string> id, KmsAsymmetricSignatureKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsAsymmetricSignatureKey:KmsAsymmetricSignatureKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KmsAsymmetricSignatureKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KmsAsymmetricSignatureKey Get(string name, Input<string> id, KmsAsymmetricSignatureKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new KmsAsymmetricSignatureKey(name, id, state, options);
        }
    }

    public sealed class KmsAsymmetricSignatureKeyArgs : global::Pulumi.ResourceArgs
    {
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Signature algorithm to be used with a new key. The default value is `RSA_2048_SIGN_PSS_SHA_256`.
        /// </summary>
        [Input("signatureAlgorithm")]
        public Input<string>? SignatureAlgorithm { get; set; }

        public KmsAsymmetricSignatureKeyArgs()
        {
        }
        public static new KmsAsymmetricSignatureKeyArgs Empty => new KmsAsymmetricSignatureKeyArgs();
    }

    public sealed class KmsAsymmetricSignatureKeyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// An optional description of the key.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the key.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Signature algorithm to be used with a new key. The default value is `RSA_2048_SIGN_PSS_SHA_256`.
        /// </summary>
        [Input("signatureAlgorithm")]
        public Input<string>? SignatureAlgorithm { get; set; }

        /// <summary>
        /// The status of the key.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public KmsAsymmetricSignatureKeyState()
        {
        }
        public static new KmsAsymmetricSignatureKeyState Empty => new KmsAsymmetricSignatureKeyState();
    }
}