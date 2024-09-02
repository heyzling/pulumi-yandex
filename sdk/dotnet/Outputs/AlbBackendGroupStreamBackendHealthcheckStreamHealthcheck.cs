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
    public sealed class AlbBackendGroupStreamBackendHealthcheckStreamHealthcheck
    {
        /// <summary>
        /// Data that must be contained in the messages received from targets for a successful health check. If not specified, no messages are expected from targets, and those that are received are not checked.
        /// </summary>
        public readonly string? Receive;
        /// <summary>
        /// Message sent to targets during TCP data transfer.  If not specified, no data is sent to the target.
        /// </summary>
        public readonly string? Send;

        [OutputConstructor]
        private AlbBackendGroupStreamBackendHealthcheckStreamHealthcheck(
            string? receive,

            string? send)
        {
            Receive = receive;
            Send = send;
        }
    }
}
