// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMysqlUserPermissionArgs : global::Pulumi.InvokeArgs
    {
        [Input("databaseName", required: true)]
        public string DatabaseName { get; set; } = null!;

        [Input("roles")]
        private List<string>? _roles;
        public List<string> Roles
        {
            get => _roles ?? (_roles = new List<string>());
            set => _roles = value;
        }

        public GetMdbMysqlUserPermissionArgs()
        {
        }
        public static new GetMdbMysqlUserPermissionArgs Empty => new GetMdbMysqlUserPermissionArgs();
    }
}
