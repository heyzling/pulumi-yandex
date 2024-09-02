// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterUserArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("password")]
        private string? _password;
        public string? Password
        {
            get => _password;
            set => _password = value;
        }

        [Input("permissions", required: true)]
        private List<Inputs.GetMdbMongodbClusterUserPermissionArgs>? _permissions;
        public List<Inputs.GetMdbMongodbClusterUserPermissionArgs> Permissions
        {
            get => _permissions ?? (_permissions = new List<Inputs.GetMdbMongodbClusterUserPermissionArgs>());
            set => _permissions = value;
        }

        public GetMdbMongodbClusterUserArgs()
        {
        }
        public static new GetMdbMongodbClusterUserArgs Empty => new GetMdbMongodbClusterUserArgs();
    }
}
