// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupSessionAffinityCookieInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the HTTP cookie
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// TTL for the cookie (if not set, session cookie will be used)
        /// </summary>
        [Input("ttl", required: true)]
        public Input<string> Ttl { get; set; } = null!;

        public GetAlbBackendGroupSessionAffinityCookieInputArgs()
        {
        }
        public static new GetAlbBackendGroupSessionAffinityCookieInputArgs Empty => new GetAlbBackendGroupSessionAffinityCookieInputArgs();
    }
}