// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigRabbitmqArgs : global::Pulumi.InvokeArgs
    {
        [Input("password", required: true)]
        private string? _password;
        public string? Password
        {
            get => _password;
            set => _password = value;
        }

        [Input("username", required: true)]
        public string Username { get; set; } = null!;

        [Input("vhost", required: true)]
        public string Vhost { get; set; } = null!;

        public GetMdbClickhouseClusterClickhouseConfigRabbitmqArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigRabbitmqArgs Empty => new GetMdbClickhouseClusterClickhouseConfigRabbitmqArgs();
    }
}
