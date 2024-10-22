// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The provider type for the yandex package. By default, resources use package-wide configuration
// settings, however an explicit `Provider` instance may be created and passed during resource
// construction to achieve fine-grained programmatic control over provider settings. See the
// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
type Provider struct {
	pulumi.ProviderResourceState

	// ID of Yandex.Cloud tenant.
	CloudId pulumi.StringPtrOutput `pulumi:"cloudId"`
	// The API endpoint for Yandex.Cloud SDK client.
	Endpoint pulumi.StringPtrOutput `pulumi:"endpoint"`
	// The default folder ID where resources will be placed.
	FolderId       pulumi.StringPtrOutput `pulumi:"folderId"`
	OrganizationId pulumi.StringPtrOutput `pulumi:"organizationId"`
	// Profile to use in the shared credentials file. Default value is `default`.
	Profile pulumi.StringPtrOutput `pulumi:"profile"`
	// The region where operations will take place. Examples are ru-central1
	RegionId pulumi.StringPtrOutput `pulumi:"regionId"`
	// Either the path to or the contents of a Service Account key file in JSON format.
	ServiceAccountKeyFile pulumi.StringPtrOutput `pulumi:"serviceAccountKeyFile"`
	// Path to shared credentials file.
	SharedCredentialsFile pulumi.StringPtrOutput `pulumi:"sharedCredentialsFile"`
	// Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
	// specified.
	StorageAccessKey pulumi.StringPtrOutput `pulumi:"storageAccessKey"`
	// Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
	StorageEndpoint pulumi.StringPtrOutput `pulumi:"storageEndpoint"`
	// Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
	// specified.
	StorageSecretKey pulumi.StringPtrOutput `pulumi:"storageSecretKey"`
	// The access token for API operations.
	Token pulumi.StringPtrOutput `pulumi:"token"`
	// Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
	// specified.
	YmqAccessKey pulumi.StringPtrOutput `pulumi:"ymqAccessKey"`
	// Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
	YmqEndpoint pulumi.StringPtrOutput `pulumi:"ymqEndpoint"`
	// Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
	// specified.
	YmqSecretKey pulumi.StringPtrOutput `pulumi:"ymqSecretKey"`
	// The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
	Zone pulumi.StringPtrOutput `pulumi:"zone"`
}

// NewProvider registers a new resource with the given unique name, arguments, and options.
func NewProvider(ctx *pulumi.Context,
	name string, args *ProviderArgs, opts ...pulumi.ResourceOption) (*Provider, error) {
	if args == nil {
		args = &ProviderArgs{}
	}

	if args.StorageSecretKey != nil {
		args.StorageSecretKey = pulumi.ToSecret(args.StorageSecretKey).(pulumi.StringPtrInput)
	}
	if args.Token != nil {
		args.Token = pulumi.ToSecret(args.Token).(pulumi.StringPtrInput)
	}
	if args.YmqSecretKey != nil {
		args.YmqSecretKey = pulumi.ToSecret(args.YmqSecretKey).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"storageSecretKey",
		"token",
		"ymqSecretKey",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Provider
	err := ctx.RegisterResource("pulumi:providers:yandex", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

type providerArgs struct {
	// ID of Yandex.Cloud tenant.
	CloudId *string `pulumi:"cloudId"`
	// The API endpoint for Yandex.Cloud SDK client.
	Endpoint *string `pulumi:"endpoint"`
	// The default folder ID where resources will be placed.
	FolderId *string `pulumi:"folderId"`
	// Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
	Insecure *bool `pulumi:"insecure"`
	// The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
	MaxRetries     *int    `pulumi:"maxRetries"`
	OrganizationId *string `pulumi:"organizationId"`
	// Disable use of TLS. Default value is `false`.
	Plaintext *bool `pulumi:"plaintext"`
	// Profile to use in the shared credentials file. Default value is `default`.
	Profile *string `pulumi:"profile"`
	// The region where operations will take place. Examples are ru-central1
	RegionId *string `pulumi:"regionId"`
	// Either the path to or the contents of a Service Account key file in JSON format.
	ServiceAccountKeyFile *string `pulumi:"serviceAccountKeyFile"`
	// Path to shared credentials file.
	SharedCredentialsFile *string `pulumi:"sharedCredentialsFile"`
	// Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
	// specified.
	StorageAccessKey *string `pulumi:"storageAccessKey"`
	// Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
	StorageEndpoint *string `pulumi:"storageEndpoint"`
	// Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
	// specified.
	StorageSecretKey *string `pulumi:"storageSecretKey"`
	// The access token for API operations.
	Token *string `pulumi:"token"`
	// Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
	// specified.
	YmqAccessKey *string `pulumi:"ymqAccessKey"`
	// Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
	YmqEndpoint *string `pulumi:"ymqEndpoint"`
	// Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
	// specified.
	YmqSecretKey *string `pulumi:"ymqSecretKey"`
	// The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
	Zone *string `pulumi:"zone"`
}

// The set of arguments for constructing a Provider resource.
type ProviderArgs struct {
	// ID of Yandex.Cloud tenant.
	CloudId pulumi.StringPtrInput
	// The API endpoint for Yandex.Cloud SDK client.
	Endpoint pulumi.StringPtrInput
	// The default folder ID where resources will be placed.
	FolderId pulumi.StringPtrInput
	// Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
	Insecure pulumi.BoolPtrInput
	// The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
	MaxRetries     pulumi.IntPtrInput
	OrganizationId pulumi.StringPtrInput
	// Disable use of TLS. Default value is `false`.
	Plaintext pulumi.BoolPtrInput
	// Profile to use in the shared credentials file. Default value is `default`.
	Profile pulumi.StringPtrInput
	// The region where operations will take place. Examples are ru-central1
	RegionId pulumi.StringPtrInput
	// Either the path to or the contents of a Service Account key file in JSON format.
	ServiceAccountKeyFile pulumi.StringPtrInput
	// Path to shared credentials file.
	SharedCredentialsFile pulumi.StringPtrInput
	// Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
	// specified.
	StorageAccessKey pulumi.StringPtrInput
	// Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
	StorageEndpoint pulumi.StringPtrInput
	// Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
	// specified.
	StorageSecretKey pulumi.StringPtrInput
	// The access token for API operations.
	Token pulumi.StringPtrInput
	// Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
	// specified.
	YmqAccessKey pulumi.StringPtrInput
	// Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
	YmqEndpoint pulumi.StringPtrInput
	// Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
	// specified.
	YmqSecretKey pulumi.StringPtrInput
	// The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
	Zone pulumi.StringPtrInput
}

func (ProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*providerArgs)(nil)).Elem()
}

type ProviderInput interface {
	pulumi.Input

	ToProviderOutput() ProviderOutput
	ToProviderOutputWithContext(ctx context.Context) ProviderOutput
}

func (*Provider) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (i *Provider) ToProviderOutput() ProviderOutput {
	return i.ToProviderOutputWithContext(context.Background())
}

func (i *Provider) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderOutput)
}

type ProviderOutput struct{ *pulumi.OutputState }

func (ProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (o ProviderOutput) ToProviderOutput() ProviderOutput {
	return o
}

func (o ProviderOutput) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return o
}

// ID of Yandex.Cloud tenant.
func (o ProviderOutput) CloudId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.CloudId }).(pulumi.StringPtrOutput)
}

// The API endpoint for Yandex.Cloud SDK client.
func (o ProviderOutput) Endpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Endpoint }).(pulumi.StringPtrOutput)
}

// The default folder ID where resources will be placed.
func (o ProviderOutput) FolderId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.FolderId }).(pulumi.StringPtrOutput)
}

func (o ProviderOutput) OrganizationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.OrganizationId }).(pulumi.StringPtrOutput)
}

// Profile to use in the shared credentials file. Default value is `default`.
func (o ProviderOutput) Profile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Profile }).(pulumi.StringPtrOutput)
}

// The region where operations will take place. Examples are ru-central1
func (o ProviderOutput) RegionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.RegionId }).(pulumi.StringPtrOutput)
}

// Either the path to or the contents of a Service Account key file in JSON format.
func (o ProviderOutput) ServiceAccountKeyFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ServiceAccountKeyFile }).(pulumi.StringPtrOutput)
}

// Path to shared credentials file.
func (o ProviderOutput) SharedCredentialsFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.SharedCredentialsFile }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
// specified.
func (o ProviderOutput) StorageAccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.StorageAccessKey }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
func (o ProviderOutput) StorageEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.StorageEndpoint }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
// specified.
func (o ProviderOutput) StorageSecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.StorageSecretKey }).(pulumi.StringPtrOutput)
}

// The access token for API operations.
func (o ProviderOutput) Token() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Token }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
// specified.
func (o ProviderOutput) YmqAccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.YmqAccessKey }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
func (o ProviderOutput) YmqEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.YmqEndpoint }).(pulumi.StringPtrOutput)
}

// Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
// specified.
func (o ProviderOutput) YmqSecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.YmqSecretKey }).(pulumi.StringPtrOutput)
}

// The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
func (o ProviderOutput) Zone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.Zone }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProviderInput)(nil)).Elem(), &Provider{})
	pulumi.RegisterOutputType(ProviderOutput{})
}
