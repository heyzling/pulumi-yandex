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
    public sealed class GetOrganizationmanagerGroupMemberResult
    {
        public readonly string Id;
        public readonly string Type;

        [OutputConstructor]
        private GetOrganizationmanagerGroupMemberResult(
            string id,

            string type)
        {
            Id = id;
            Type = type;
        }
    }
}
