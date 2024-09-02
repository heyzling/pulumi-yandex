// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LockboxSecretVersionEntryCommandArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// List of arguments to be passed to the script/command.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("env")]
        private InputMap<string>? _env;

        /// <summary>
        /// Map of environment variables to set before calling the script/command.
        /// </summary>
        public InputMap<string> Env
        {
            get => _env ?? (_env = new InputMap<string>());
            set => _env = value;
        }

        /// <summary>
        /// The path to the script or command to execute.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        public LockboxSecretVersionEntryCommandArgs()
        {
        }
        public static new LockboxSecretVersionEntryCommandArgs Empty => new LockboxSecretVersionEntryCommandArgs();
    }
}
