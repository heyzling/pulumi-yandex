// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbKafkaConnector(ctx *pulumi.Context, args *LookupMdbKafkaConnectorArgs, opts ...pulumi.InvokeOption) (*LookupMdbKafkaConnectorResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupMdbKafkaConnectorResult
	err := ctx.Invoke("yandex:index/getMdbKafkaConnector:getMdbKafkaConnector", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbKafkaConnector.
type LookupMdbKafkaConnectorArgs struct {
	ClusterId string `pulumi:"clusterId"`
	Name      string `pulumi:"name"`
}

// A collection of values returned by getMdbKafkaConnector.
type LookupMdbKafkaConnectorResult struct {
	ClusterId                   string                                           `pulumi:"clusterId"`
	ConnectorConfigMirrormakers []GetMdbKafkaConnectorConnectorConfigMirrormaker `pulumi:"connectorConfigMirrormakers"`
	ConnectorConfigS3Sinks      []GetMdbKafkaConnectorConnectorConfigS3Sink      `pulumi:"connectorConfigS3Sinks"`
	// The provider-assigned unique ID for this managed resource.
	Id         string            `pulumi:"id"`
	Name       string            `pulumi:"name"`
	Properties map[string]string `pulumi:"properties"`
	TasksMax   int               `pulumi:"tasksMax"`
}

func LookupMdbKafkaConnectorOutput(ctx *pulumi.Context, args LookupMdbKafkaConnectorOutputArgs, opts ...pulumi.InvokeOption) LookupMdbKafkaConnectorResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbKafkaConnectorResult, error) {
			args := v.(LookupMdbKafkaConnectorArgs)
			r, err := LookupMdbKafkaConnector(ctx, &args, opts...)
			var s LookupMdbKafkaConnectorResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbKafkaConnectorResultOutput)
}

// A collection of arguments for invoking getMdbKafkaConnector.
type LookupMdbKafkaConnectorOutputArgs struct {
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	Name      pulumi.StringInput `pulumi:"name"`
}

func (LookupMdbKafkaConnectorOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbKafkaConnectorArgs)(nil)).Elem()
}

// A collection of values returned by getMdbKafkaConnector.
type LookupMdbKafkaConnectorResultOutput struct{ *pulumi.OutputState }

func (LookupMdbKafkaConnectorResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbKafkaConnectorResult)(nil)).Elem()
}

func (o LookupMdbKafkaConnectorResultOutput) ToLookupMdbKafkaConnectorResultOutput() LookupMdbKafkaConnectorResultOutput {
	return o
}

func (o LookupMdbKafkaConnectorResultOutput) ToLookupMdbKafkaConnectorResultOutputWithContext(ctx context.Context) LookupMdbKafkaConnectorResultOutput {
	return o
}

func (o LookupMdbKafkaConnectorResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaConnectorResultOutput) ConnectorConfigMirrormakers() GetMdbKafkaConnectorConnectorConfigMirrormakerArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) []GetMdbKafkaConnectorConnectorConfigMirrormaker {
		return v.ConnectorConfigMirrormakers
	}).(GetMdbKafkaConnectorConnectorConfigMirrormakerArrayOutput)
}

func (o LookupMdbKafkaConnectorResultOutput) ConnectorConfigS3Sinks() GetMdbKafkaConnectorConnectorConfigS3SinkArrayOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) []GetMdbKafkaConnectorConnectorConfigS3Sink {
		return v.ConnectorConfigS3Sinks
	}).(GetMdbKafkaConnectorConnectorConfigS3SinkArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbKafkaConnectorResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaConnectorResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMdbKafkaConnectorResultOutput) Properties() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) map[string]string { return v.Properties }).(pulumi.StringMapOutput)
}

func (o LookupMdbKafkaConnectorResultOutput) TasksMax() pulumi.IntOutput {
	return o.ApplyT(func(v LookupMdbKafkaConnectorResult) int { return v.TasksMax }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbKafkaConnectorResultOutput{})
}