// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbPostgresqlDatabase(ctx *pulumi.Context, args *LookupMdbPostgresqlDatabaseArgs, opts ...pulumi.InvokeOption) (*LookupMdbPostgresqlDatabaseResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupMdbPostgresqlDatabaseResult
	err := ctx.Invoke("yandex:index/getMdbPostgresqlDatabase:getMdbPostgresqlDatabase", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseArgs struct {
	ClusterId          string                              `pulumi:"clusterId"`
	DeletionProtection *string                             `pulumi:"deletionProtection"`
	Extensions         []GetMdbPostgresqlDatabaseExtension `pulumi:"extensions"`
	LcCollate          *string                             `pulumi:"lcCollate"`
	LcType             *string                             `pulumi:"lcType"`
	Name               string                              `pulumi:"name"`
	Owner              *string                             `pulumi:"owner"`
	TemplateDb         *string                             `pulumi:"templateDb"`
}

// A collection of values returned by getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseResult struct {
	ClusterId          string                              `pulumi:"clusterId"`
	DeletionProtection *string                             `pulumi:"deletionProtection"`
	Extensions         []GetMdbPostgresqlDatabaseExtension `pulumi:"extensions"`
	// The provider-assigned unique ID for this managed resource.
	Id         string `pulumi:"id"`
	LcCollate  string `pulumi:"lcCollate"`
	LcType     string `pulumi:"lcType"`
	Name       string `pulumi:"name"`
	Owner      string `pulumi:"owner"`
	TemplateDb string `pulumi:"templateDb"`
}

func LookupMdbPostgresqlDatabaseOutput(ctx *pulumi.Context, args LookupMdbPostgresqlDatabaseOutputArgs, opts ...pulumi.InvokeOption) LookupMdbPostgresqlDatabaseResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbPostgresqlDatabaseResult, error) {
			args := v.(LookupMdbPostgresqlDatabaseArgs)
			r, err := LookupMdbPostgresqlDatabase(ctx, &args, opts...)
			var s LookupMdbPostgresqlDatabaseResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbPostgresqlDatabaseResultOutput)
}

// A collection of arguments for invoking getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseOutputArgs struct {
	ClusterId          pulumi.StringInput                          `pulumi:"clusterId"`
	DeletionProtection pulumi.StringPtrInput                       `pulumi:"deletionProtection"`
	Extensions         GetMdbPostgresqlDatabaseExtensionArrayInput `pulumi:"extensions"`
	LcCollate          pulumi.StringPtrInput                       `pulumi:"lcCollate"`
	LcType             pulumi.StringPtrInput                       `pulumi:"lcType"`
	Name               pulumi.StringInput                          `pulumi:"name"`
	Owner              pulumi.StringPtrInput                       `pulumi:"owner"`
	TemplateDb         pulumi.StringPtrInput                       `pulumi:"templateDb"`
}

func (LookupMdbPostgresqlDatabaseOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlDatabaseArgs)(nil)).Elem()
}

// A collection of values returned by getMdbPostgresqlDatabase.
type LookupMdbPostgresqlDatabaseResultOutput struct{ *pulumi.OutputState }

func (LookupMdbPostgresqlDatabaseResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlDatabaseResult)(nil)).Elem()
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ToLookupMdbPostgresqlDatabaseResultOutput() LookupMdbPostgresqlDatabaseResultOutput {
	return o
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ToLookupMdbPostgresqlDatabaseResultOutputWithContext(ctx context.Context) LookupMdbPostgresqlDatabaseResultOutput {
	return o
}

func (o LookupMdbPostgresqlDatabaseResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) DeletionProtection() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) *string { return v.DeletionProtection }).(pulumi.StringPtrOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) Extensions() GetMdbPostgresqlDatabaseExtensionArrayOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) []GetMdbPostgresqlDatabaseExtension { return v.Extensions }).(GetMdbPostgresqlDatabaseExtensionArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbPostgresqlDatabaseResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) LcCollate() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.LcCollate }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) LcType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.LcType }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) Owner() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.Owner }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlDatabaseResultOutput) TemplateDb() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlDatabaseResult) string { return v.TemplateDb }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbPostgresqlDatabaseResultOutput{})
}