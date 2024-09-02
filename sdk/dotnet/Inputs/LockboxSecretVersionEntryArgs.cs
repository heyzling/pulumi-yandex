// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LockboxSecretVersionEntryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The command that generates the text value of the entry.
        /// 
        /// Note that either `text_value` or `command` is required.
        /// 
        /// The `command` block contains:
        /// </summary>
        [Input("command")]
        public Input<Inputs.LockboxSecretVersionEntryCommandArgs>? Command { get; set; }

        /// <summary>
        /// The key of the entry.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("textValue")]
        private Input<string>? _textValue;

        /// <summary>
        /// The text value of the entry.
        /// </summary>
        public Input<string>? TextValue
        {
            get => _textValue;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _textValue = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public LockboxSecretVersionEntryArgs()
        {
        }
        public static new LockboxSecretVersionEntryArgs Empty => new LockboxSecretVersionEntryArgs();
    }
}
