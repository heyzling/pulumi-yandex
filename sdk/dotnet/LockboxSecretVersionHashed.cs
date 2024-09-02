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
    /// Yandex Cloud Lockbox secret version resource (with values hashed in state). For more information, see
    /// [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
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
    ///     var mySecret = new Yandex.LockboxSecret("mySecret");
    /// 
    ///     var myVersion = new Yandex.LockboxSecretVersionHashed("myVersion", new()
    ///     {
    ///         SecretId = mySecret.Id,
    ///         Key1 = "key1",
    ///         TextValue1 = "sensitive value 1",
    ///         Key2 = "k2",
    ///         TextValue2 = "sensitive value 2",
    ///     });
    /// 
    ///     // etc. (up to 10 entries)
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/lockboxSecretVersionHashed:LockboxSecretVersionHashed")]
    public partial class LockboxSecretVersionHashed : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The Yandex Cloud Lockbox secret version description.
        /// * `key_&lt;NUMBER&gt;` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        /// * `text_value_&lt;NUMBER&gt;` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
        /// 
        /// The `&lt;NUMBER&gt;` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        /// If you need a second entry, use `key_2`/`text_value_2`, and so on.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("key1")]
        public Output<string?> Key1 { get; private set; } = null!;

        [Output("key10")]
        public Output<string?> Key10 { get; private set; } = null!;

        [Output("key2")]
        public Output<string?> Key2 { get; private set; } = null!;

        [Output("key3")]
        public Output<string?> Key3 { get; private set; } = null!;

        [Output("key4")]
        public Output<string?> Key4 { get; private set; } = null!;

        [Output("key5")]
        public Output<string?> Key5 { get; private set; } = null!;

        [Output("key6")]
        public Output<string?> Key6 { get; private set; } = null!;

        [Output("key7")]
        public Output<string?> Key7 { get; private set; } = null!;

        [Output("key8")]
        public Output<string?> Key8 { get; private set; } = null!;

        [Output("key9")]
        public Output<string?> Key9 { get; private set; } = null!;

        /// <summary>
        /// The Yandex Cloud Lockbox secret ID where to add the version.
        /// </summary>
        [Output("secretId")]
        public Output<string> SecretId { get; private set; } = null!;

        [Output("textValue1")]
        public Output<string?> TextValue1 { get; private set; } = null!;

        [Output("textValue10")]
        public Output<string?> TextValue10 { get; private set; } = null!;

        [Output("textValue2")]
        public Output<string?> TextValue2 { get; private set; } = null!;

        [Output("textValue3")]
        public Output<string?> TextValue3 { get; private set; } = null!;

        [Output("textValue4")]
        public Output<string?> TextValue4 { get; private set; } = null!;

        [Output("textValue5")]
        public Output<string?> TextValue5 { get; private set; } = null!;

        [Output("textValue6")]
        public Output<string?> TextValue6 { get; private set; } = null!;

        [Output("textValue7")]
        public Output<string?> TextValue7 { get; private set; } = null!;

        [Output("textValue8")]
        public Output<string?> TextValue8 { get; private set; } = null!;

        [Output("textValue9")]
        public Output<string?> TextValue9 { get; private set; } = null!;


        /// <summary>
        /// Create a LockboxSecretVersionHashed resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LockboxSecretVersionHashed(string name, LockboxSecretVersionHashedArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/lockboxSecretVersionHashed:LockboxSecretVersionHashed", name, args ?? new LockboxSecretVersionHashedArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LockboxSecretVersionHashed(string name, Input<string> id, LockboxSecretVersionHashedState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/lockboxSecretVersionHashed:LockboxSecretVersionHashed", name, state, MakeResourceOptions(options, id))
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
                    "textValue1",
                    "textValue10",
                    "textValue2",
                    "textValue3",
                    "textValue4",
                    "textValue5",
                    "textValue6",
                    "textValue7",
                    "textValue8",
                    "textValue9",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LockboxSecretVersionHashed resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LockboxSecretVersionHashed Get(string name, Input<string> id, LockboxSecretVersionHashedState? state = null, CustomResourceOptions? options = null)
        {
            return new LockboxSecretVersionHashed(name, id, state, options);
        }
    }

    public sealed class LockboxSecretVersionHashedArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Yandex Cloud Lockbox secret version description.
        /// * `key_&lt;NUMBER&gt;` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        /// * `text_value_&lt;NUMBER&gt;` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
        /// 
        /// The `&lt;NUMBER&gt;` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        /// If you need a second entry, use `key_2`/`text_value_2`, and so on.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("key1")]
        public Input<string>? Key1 { get; set; }

        [Input("key10")]
        public Input<string>? Key10 { get; set; }

        [Input("key2")]
        public Input<string>? Key2 { get; set; }

        [Input("key3")]
        public Input<string>? Key3 { get; set; }

        [Input("key4")]
        public Input<string>? Key4 { get; set; }

        [Input("key5")]
        public Input<string>? Key5 { get; set; }

        [Input("key6")]
        public Input<string>? Key6 { get; set; }

        [Input("key7")]
        public Input<string>? Key7 { get; set; }

        [Input("key8")]
        public Input<string>? Key8 { get; set; }

        [Input("key9")]
        public Input<string>? Key9 { get; set; }

        /// <summary>
        /// The Yandex Cloud Lockbox secret ID where to add the version.
        /// </summary>
        [Input("secretId", required: true)]
        public Input<string> SecretId { get; set; } = null!;

        [Input("textValue1")]
        private Input<string>? _textValue1;
        public Input<string>? TextValue1
        {
            get => _textValue1;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue1 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue10")]
        private Input<string>? _textValue10;
        public Input<string>? TextValue10
        {
            get => _textValue10;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue10 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue2")]
        private Input<string>? _textValue2;
        public Input<string>? TextValue2
        {
            get => _textValue2;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue2 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue3")]
        private Input<string>? _textValue3;
        public Input<string>? TextValue3
        {
            get => _textValue3;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue3 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue4")]
        private Input<string>? _textValue4;
        public Input<string>? TextValue4
        {
            get => _textValue4;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue4 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue5")]
        private Input<string>? _textValue5;
        public Input<string>? TextValue5
        {
            get => _textValue5;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue5 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue6")]
        private Input<string>? _textValue6;
        public Input<string>? TextValue6
        {
            get => _textValue6;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue6 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue7")]
        private Input<string>? _textValue7;
        public Input<string>? TextValue7
        {
            get => _textValue7;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue7 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue8")]
        private Input<string>? _textValue8;
        public Input<string>? TextValue8
        {
            get => _textValue8;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue8 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue9")]
        private Input<string>? _textValue9;
        public Input<string>? TextValue9
        {
            get => _textValue9;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue9 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public LockboxSecretVersionHashedArgs()
        {
        }
        public static new LockboxSecretVersionHashedArgs Empty => new LockboxSecretVersionHashedArgs();
    }

    public sealed class LockboxSecretVersionHashedState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Yandex Cloud Lockbox secret version description.
        /// * `key_&lt;NUMBER&gt;` - (Optional) Each of the entry keys in the Yandex Cloud Lockbox secret version.
        /// * `text_value_&lt;NUMBER&gt;` - (Optional) Each of the entry values in the Yandex Cloud Lockbox secret version.
        /// 
        /// The `&lt;NUMBER&gt;` can range from `1` to `10`. If you only need one entry, use `key_1`/`text_value_1`.
        /// If you need a second entry, use `key_2`/`text_value_2`, and so on.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("key1")]
        public Input<string>? Key1 { get; set; }

        [Input("key10")]
        public Input<string>? Key10 { get; set; }

        [Input("key2")]
        public Input<string>? Key2 { get; set; }

        [Input("key3")]
        public Input<string>? Key3 { get; set; }

        [Input("key4")]
        public Input<string>? Key4 { get; set; }

        [Input("key5")]
        public Input<string>? Key5 { get; set; }

        [Input("key6")]
        public Input<string>? Key6 { get; set; }

        [Input("key7")]
        public Input<string>? Key7 { get; set; }

        [Input("key8")]
        public Input<string>? Key8 { get; set; }

        [Input("key9")]
        public Input<string>? Key9 { get; set; }

        /// <summary>
        /// The Yandex Cloud Lockbox secret ID where to add the version.
        /// </summary>
        [Input("secretId")]
        public Input<string>? SecretId { get; set; }

        [Input("textValue1")]
        private Input<string>? _textValue1;
        public Input<string>? TextValue1
        {
            get => _textValue1;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue1 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue10")]
        private Input<string>? _textValue10;
        public Input<string>? TextValue10
        {
            get => _textValue10;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue10 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue2")]
        private Input<string>? _textValue2;
        public Input<string>? TextValue2
        {
            get => _textValue2;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue2 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue3")]
        private Input<string>? _textValue3;
        public Input<string>? TextValue3
        {
            get => _textValue3;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue3 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue4")]
        private Input<string>? _textValue4;
        public Input<string>? TextValue4
        {
            get => _textValue4;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue4 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue5")]
        private Input<string>? _textValue5;
        public Input<string>? TextValue5
        {
            get => _textValue5;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue5 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue6")]
        private Input<string>? _textValue6;
        public Input<string>? TextValue6
        {
            get => _textValue6;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue6 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue7")]
        private Input<string>? _textValue7;
        public Input<string>? TextValue7
        {
            get => _textValue7;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue7 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue8")]
        private Input<string>? _textValue8;
        public Input<string>? TextValue8
        {
            get => _textValue8;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue8 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("textValue9")]
        private Input<string>? _textValue9;
        public Input<string>? TextValue9
        {
            get => _textValue9;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue9 = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public LockboxSecretVersionHashedState()
        {
        }
        public static new LockboxSecretVersionHashedState Empty => new LockboxSecretVersionHashedState();
    }
}
