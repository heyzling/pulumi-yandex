// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetAlbVirtualHostRouteHttpRouteRedirectActionResult
    {
        public readonly bool RemoveQuery;
        public readonly string ReplaceHost;
        public readonly string ReplacePath;
        public readonly int ReplacePort;
        public readonly string ReplacePrefix;
        public readonly string ReplaceScheme;
        public readonly string ResponseCode;

        [OutputConstructor]
        private GetAlbVirtualHostRouteHttpRouteRedirectActionResult(
            bool removeQuery,

            string replaceHost,

            string replacePath,

            int replacePort,

            string replacePrefix,

            string replaceScheme,

            string responseCode)
        {
            RemoveQuery = removeQuery;
            ReplaceHost = replaceHost;
            ReplacePath = replacePath;
            ReplacePort = replacePort;
            ReplacePrefix = replacePrefix;
            ReplaceScheme = replaceScheme;
            ResponseCode = responseCode;
        }
    }
}
