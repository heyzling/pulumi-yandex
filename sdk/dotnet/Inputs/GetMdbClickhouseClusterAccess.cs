// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterAccessArgs : global::Pulumi.InvokeArgs
    {
        [Input("dataLens")]
        public bool? DataLens { get; set; }

        [Input("dataTransfer")]
        public bool? DataTransfer { get; set; }

        [Input("metrika")]
        public bool? Metrika { get; set; }

        [Input("serverless")]
        public bool? Serverless { get; set; }

        [Input("webSql")]
        public bool? WebSql { get; set; }

        [Input("yandexQuery")]
        public bool? YandexQuery { get; set; }

        public GetMdbClickhouseClusterAccessArgs()
        {
        }
        public static new GetMdbClickhouseClusterAccessArgs Empty => new GetMdbClickhouseClusterAccessArgs();
    }
}
