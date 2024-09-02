// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupComputeSnapshotSchedule(ctx *pulumi.Context, args *LookupComputeSnapshotScheduleArgs, opts ...pulumi.InvokeOption) (*LookupComputeSnapshotScheduleResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupComputeSnapshotScheduleResult
	err := ctx.Invoke("yandex:index/getComputeSnapshotSchedule:getComputeSnapshotSchedule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeSnapshotSchedule.
type LookupComputeSnapshotScheduleArgs struct {
	Description        *string                                    `pulumi:"description"`
	DiskIds            []string                                   `pulumi:"diskIds"`
	FolderId           *string                                    `pulumi:"folderId"`
	Labels             map[string]string                          `pulumi:"labels"`
	Name               *string                                    `pulumi:"name"`
	RetentionPeriod    *string                                    `pulumi:"retentionPeriod"`
	SchedulePolicies   []GetComputeSnapshotScheduleSchedulePolicy `pulumi:"schedulePolicies"`
	SnapshotCount      *int                                       `pulumi:"snapshotCount"`
	SnapshotScheduleId *string                                    `pulumi:"snapshotScheduleId"`
	SnapshotSpecs      []GetComputeSnapshotScheduleSnapshotSpec   `pulumi:"snapshotSpecs"`
}

// A collection of values returned by getComputeSnapshotSchedule.
type LookupComputeSnapshotScheduleResult struct {
	CreatedAt   string   `pulumi:"createdAt"`
	Description string   `pulumi:"description"`
	DiskIds     []string `pulumi:"diskIds"`
	FolderId    string   `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id                 string                                     `pulumi:"id"`
	Labels             map[string]string                          `pulumi:"labels"`
	Name               string                                     `pulumi:"name"`
	RetentionPeriod    string                                     `pulumi:"retentionPeriod"`
	SchedulePolicies   []GetComputeSnapshotScheduleSchedulePolicy `pulumi:"schedulePolicies"`
	SnapshotCount      int                                        `pulumi:"snapshotCount"`
	SnapshotScheduleId string                                     `pulumi:"snapshotScheduleId"`
	SnapshotSpecs      []GetComputeSnapshotScheduleSnapshotSpec   `pulumi:"snapshotSpecs"`
	Status             string                                     `pulumi:"status"`
}

func LookupComputeSnapshotScheduleOutput(ctx *pulumi.Context, args LookupComputeSnapshotScheduleOutputArgs, opts ...pulumi.InvokeOption) LookupComputeSnapshotScheduleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupComputeSnapshotScheduleResult, error) {
			args := v.(LookupComputeSnapshotScheduleArgs)
			r, err := LookupComputeSnapshotSchedule(ctx, &args, opts...)
			var s LookupComputeSnapshotScheduleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupComputeSnapshotScheduleResultOutput)
}

// A collection of arguments for invoking getComputeSnapshotSchedule.
type LookupComputeSnapshotScheduleOutputArgs struct {
	Description        pulumi.StringPtrInput                              `pulumi:"description"`
	DiskIds            pulumi.StringArrayInput                            `pulumi:"diskIds"`
	FolderId           pulumi.StringPtrInput                              `pulumi:"folderId"`
	Labels             pulumi.StringMapInput                              `pulumi:"labels"`
	Name               pulumi.StringPtrInput                              `pulumi:"name"`
	RetentionPeriod    pulumi.StringPtrInput                              `pulumi:"retentionPeriod"`
	SchedulePolicies   GetComputeSnapshotScheduleSchedulePolicyArrayInput `pulumi:"schedulePolicies"`
	SnapshotCount      pulumi.IntPtrInput                                 `pulumi:"snapshotCount"`
	SnapshotScheduleId pulumi.StringPtrInput                              `pulumi:"snapshotScheduleId"`
	SnapshotSpecs      GetComputeSnapshotScheduleSnapshotSpecArrayInput   `pulumi:"snapshotSpecs"`
}

func (LookupComputeSnapshotScheduleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeSnapshotScheduleArgs)(nil)).Elem()
}

// A collection of values returned by getComputeSnapshotSchedule.
type LookupComputeSnapshotScheduleResultOutput struct{ *pulumi.OutputState }

func (LookupComputeSnapshotScheduleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupComputeSnapshotScheduleResult)(nil)).Elem()
}

func (o LookupComputeSnapshotScheduleResultOutput) ToLookupComputeSnapshotScheduleResultOutput() LookupComputeSnapshotScheduleResultOutput {
	return o
}

func (o LookupComputeSnapshotScheduleResultOutput) ToLookupComputeSnapshotScheduleResultOutputWithContext(ctx context.Context) LookupComputeSnapshotScheduleResultOutput {
	return o
}

func (o LookupComputeSnapshotScheduleResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) DiskIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) []string { return v.DiskIds }).(pulumi.StringArrayOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupComputeSnapshotScheduleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) RetentionPeriod() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.RetentionPeriod }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) SchedulePolicies() GetComputeSnapshotScheduleSchedulePolicyArrayOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) []GetComputeSnapshotScheduleSchedulePolicy {
		return v.SchedulePolicies
	}).(GetComputeSnapshotScheduleSchedulePolicyArrayOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) SnapshotCount() pulumi.IntOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) int { return v.SnapshotCount }).(pulumi.IntOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) SnapshotScheduleId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.SnapshotScheduleId }).(pulumi.StringOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) SnapshotSpecs() GetComputeSnapshotScheduleSnapshotSpecArrayOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) []GetComputeSnapshotScheduleSnapshotSpec {
		return v.SnapshotSpecs
	}).(GetComputeSnapshotScheduleSnapshotSpecArrayOutput)
}

func (o LookupComputeSnapshotScheduleResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupComputeSnapshotScheduleResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupComputeSnapshotScheduleResultOutput{})
}