// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbPostgresqlDatabaseExtensionArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("version")]
        public string? Version { get; set; }

        public GetMdbPostgresqlDatabaseExtensionArgs()
        {
        }
        public static new GetMdbPostgresqlDatabaseExtensionArgs Empty => new GetMdbPostgresqlDatabaseExtensionArgs();
    }
}
