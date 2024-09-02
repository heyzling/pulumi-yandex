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
    public sealed class GetMdbClickhouseClusterUserQuotaResult
    {
        public readonly int Errors;
        public readonly int ExecutionTime;
        public readonly int? IntervalDuration;
        public readonly int Queries;
        public readonly int ReadRows;
        public readonly int ResultRows;

        [OutputConstructor]
        private GetMdbClickhouseClusterUserQuotaResult(
            int errors,

            int executionTime,

            int? intervalDuration,

            int queries,

            int readRows,

            int resultRows)
        {
            Errors = errors;
            ExecutionTime = executionTime;
            IntervalDuration = intervalDuration;
            Queries = queries;
            ReadRows = readRows;
            ResultRows = resultRows;
        }
    }
}
