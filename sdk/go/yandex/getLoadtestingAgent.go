// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupLoadtestingAgent(ctx *pulumi.Context, args *LookupLoadtestingAgentArgs, opts ...pulumi.InvokeOption) (*LookupLoadtestingAgentResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupLoadtestingAgentResult
	err := ctx.Invoke("yandex:index/getLoadtestingAgent:getLoadtestingAgent", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLoadtestingAgent.
type LookupLoadtestingAgentArgs struct {
	AgentId string `pulumi:"agentId"`
}

// A collection of values returned by getLoadtestingAgent.
type LookupLoadtestingAgentResult struct {
	AgentId           string                               `pulumi:"agentId"`
	ComputeInstanceId string                               `pulumi:"computeInstanceId"`
	ComputeInstances  []GetLoadtestingAgentComputeInstance `pulumi:"computeInstances"`
	Description       string                               `pulumi:"description"`
	FolderId          string                               `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id     string            `pulumi:"id"`
	Labels map[string]string `pulumi:"labels"`
	Name   string            `pulumi:"name"`
}

func LookupLoadtestingAgentOutput(ctx *pulumi.Context, args LookupLoadtestingAgentOutputArgs, opts ...pulumi.InvokeOption) LookupLoadtestingAgentResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupLoadtestingAgentResult, error) {
			args := v.(LookupLoadtestingAgentArgs)
			r, err := LookupLoadtestingAgent(ctx, &args, opts...)
			var s LookupLoadtestingAgentResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupLoadtestingAgentResultOutput)
}

// A collection of arguments for invoking getLoadtestingAgent.
type LookupLoadtestingAgentOutputArgs struct {
	AgentId pulumi.StringInput `pulumi:"agentId"`
}

func (LookupLoadtestingAgentOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLoadtestingAgentArgs)(nil)).Elem()
}

// A collection of values returned by getLoadtestingAgent.
type LookupLoadtestingAgentResultOutput struct{ *pulumi.OutputState }

func (LookupLoadtestingAgentResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLoadtestingAgentResult)(nil)).Elem()
}

func (o LookupLoadtestingAgentResultOutput) ToLookupLoadtestingAgentResultOutput() LookupLoadtestingAgentResultOutput {
	return o
}

func (o LookupLoadtestingAgentResultOutput) ToLookupLoadtestingAgentResultOutputWithContext(ctx context.Context) LookupLoadtestingAgentResultOutput {
	return o
}

func (o LookupLoadtestingAgentResultOutput) AgentId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.AgentId }).(pulumi.StringOutput)
}

func (o LookupLoadtestingAgentResultOutput) ComputeInstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.ComputeInstanceId }).(pulumi.StringOutput)
}

func (o LookupLoadtestingAgentResultOutput) ComputeInstances() GetLoadtestingAgentComputeInstanceArrayOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) []GetLoadtestingAgentComputeInstance { return v.ComputeInstances }).(GetLoadtestingAgentComputeInstanceArrayOutput)
}

func (o LookupLoadtestingAgentResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupLoadtestingAgentResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupLoadtestingAgentResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupLoadtestingAgentResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupLoadtestingAgentResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadtestingAgentResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupLoadtestingAgentResultOutput{})
}