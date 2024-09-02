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
    public sealed class AlbHttpRouterRouteOptionsRbacPrincipalAndPrincipalHeader
    {
        /// <summary>
        /// Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        /// </summary>
        public readonly string Name;
        public readonly Outputs.AlbHttpRouterRouteOptionsRbacPrincipalAndPrincipalHeaderValue? Value;

        [OutputConstructor]
        private AlbHttpRouterRouteOptionsRbacPrincipalAndPrincipalHeader(
            string name,

            Outputs.AlbHttpRouterRouteOptionsRbacPrincipalAndPrincipalHeaderValue? value)
        {
            Name = name;
            Value = value;
        }
    }
}