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
    public sealed class AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeader
    {
        /// <summary>
        /// name of the header to modify.
        /// </summary>
        public readonly string Name;
        public readonly Outputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValue? Value;

        [OutputConstructor]
        private AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeader(
            string name,

            Outputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValue? value)
        {
            Name = name;
            Value = value;
        }
    }
}