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
    /// Encrypts given plaintext with the specified Yandex KMS key and provides access to the ciphertext.
    /// 
    /// &gt; **Note:** Using this resource will allow you to conceal secret data within your
    /// resource definitions, but it does not take care of protecting that data in the
    /// logging output, plan output, or state output.  Please take care to secure your secret
    /// data outside of resource definitions.
    /// 
    /// For more information, see [the official documentation](https://cloud.yandex.com/docs/kms/concepts/).
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
    ///     var example = new Yandex.KmsSymmetricKey("example", new()
    ///     {
    ///         Description = "description for key",
    ///     });
    /// 
    ///     var password = new Yandex.KmsSecretCiphertext("password", new()
    ///     {
    ///         AadContext = "additional authenticated data",
    ///         KeyId = example.Id,
    ///         Plaintext = "strong password",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext")]
    public partial class KmsSecretCiphertext : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Additional authenticated data (AAD context), optional. If specified, this data will be required for decryption with the `SymmetricDecryptRequest`
        /// </summary>
        [Output("aadContext")]
        public Output<string?> AadContext { get; private set; } = null!;

        /// <summary>
        /// Resulting ciphertext, encoded with "standard" base64 alphabet as defined in RFC 4648 section 4
        /// </summary>
        [Output("ciphertext")]
        public Output<string> Ciphertext { get; private set; } = null!;

        /// <summary>
        /// ID of the symmetric KMS key to use for encryption.
        /// </summary>
        [Output("keyId")]
        public Output<string> KeyId { get; private set; } = null!;

        /// <summary>
        /// Plaintext to be encrypted.
        /// </summary>
        [Output("plaintext")]
        public Output<string> Plaintext { get; private set; } = null!;


        /// <summary>
        /// Create a KmsSecretCiphertext resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KmsSecretCiphertext(string name, KmsSecretCiphertextArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext", name, args ?? new KmsSecretCiphertextArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KmsSecretCiphertext(string name, Input<string> id, KmsSecretCiphertextState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
                AdditionalSecretOutputs =
                {
                    "plaintext",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing KmsSecretCiphertext resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KmsSecretCiphertext Get(string name, Input<string> id, KmsSecretCiphertextState? state = null, CustomResourceOptions? options = null)
        {
            return new KmsSecretCiphertext(name, id, state, options);
        }
    }

    public sealed class KmsSecretCiphertextArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Additional authenticated data (AAD context), optional. If specified, this data will be required for decryption with the `SymmetricDecryptRequest`
        /// </summary>
        [Input("aadContext")]
        public Input<string>? AadContext { get; set; }

        /// <summary>
        /// ID of the symmetric KMS key to use for encryption.
        /// </summary>
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("plaintext", required: true)]
        private Input<string>? _plaintext;

        /// <summary>
        /// Plaintext to be encrypted.
        /// </summary>
        public Input<string>? Plaintext
        {
            get => _plaintext;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _plaintext = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public KmsSecretCiphertextArgs()
        {
        }
        public static new KmsSecretCiphertextArgs Empty => new KmsSecretCiphertextArgs();
    }

    public sealed class KmsSecretCiphertextState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Additional authenticated data (AAD context), optional. If specified, this data will be required for decryption with the `SymmetricDecryptRequest`
        /// </summary>
        [Input("aadContext")]
        public Input<string>? AadContext { get; set; }

        /// <summary>
        /// Resulting ciphertext, encoded with "standard" base64 alphabet as defined in RFC 4648 section 4
        /// </summary>
        [Input("ciphertext")]
        public Input<string>? Ciphertext { get; set; }

        /// <summary>
        /// ID of the symmetric KMS key to use for encryption.
        /// </summary>
        [Input("keyId")]
        public Input<string>? KeyId { get; set; }

        [Input("plaintext")]
        private Input<string>? _plaintext;

        /// <summary>
        /// Plaintext to be encrypted.
        /// </summary>
        public Input<string>? Plaintext
        {
            get => _plaintext;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _plaintext = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public KmsSecretCiphertextState()
        {
        }
        public static new KmsSecretCiphertextState Empty => new KmsSecretCiphertextState();
    }
}
