// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"errors"
	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Allows management of [Yandex Cloud Function](https://cloud.yandex.com/docs/functions/)
type Function struct {
	pulumi.CustomResourceState

	// Config for asynchronous invocations of Yandex Cloud Function.
	AsyncInvocation FunctionAsyncInvocationPtrOutput `pulumi:"asyncInvocation"`
	// The maximum number of requests processed by a function instance at the same time.
	Concurrency pulumi.IntOutput `pulumi:"concurrency"`
	// Function version connectivity. If specified the version will be attached to specified network.
	// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
	Connectivity FunctionConnectivityPtrOutput `pulumi:"connectivity"`
	// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `content.0.zip_filename` - Filename to zip archive for the version.
	Content FunctionContentPtrOutput `pulumi:"content"`
	// Creation timestamp of the Yandex Cloud Function.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Description of the Yandex Cloud Function
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Entrypoint for Yandex Cloud Function
	Entrypoint pulumi.StringOutput `pulumi:"entrypoint"`
	// A set of key/value environment variables for Yandex Cloud Function
	Environment pulumi.StringMapOutput `pulumi:"environment"`
	// Execution timeout in seconds for Yandex Cloud Function
	ExecutionTimeout pulumi.StringPtrOutput `pulumi:"executionTimeout"`
	// Folder ID for the Yandex Cloud Function
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// Image size for Yandex Cloud Function.
	ImageSize pulumi.IntOutput `pulumi:"imageSize"`
	// A set of key/value label pairs to assign to the Yandex Cloud Function
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Options for logging from Yandex Cloud Function.
	LogOptions FunctionLogOptionsOutput `pulumi:"logOptions"`
	// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
	Memory pulumi.IntOutput `pulumi:"memory"`
	// Yandex Cloud Function name used to define trigger
	Name pulumi.StringOutput `pulumi:"name"`
	// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `package.0.sha_256` - SHA256 hash of the version deployment package.
	// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
	// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
	Package FunctionPackagePtrOutput `pulumi:"package"`
	// Runtime for Yandex Cloud Function
	Runtime pulumi.StringOutput `pulumi:"runtime"`
	// Secrets for Yandex Cloud Function.
	Secrets FunctionSecretArrayOutput `pulumi:"secrets"`
	// Service account ID for Yandex Cloud Function
	ServiceAccountId pulumi.StringPtrOutput `pulumi:"serviceAccountId"`
	// Storage mounts for Yandex Cloud Function.
	StorageMounts FunctionStorageMountArrayOutput `pulumi:"storageMounts"`
	// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// Tmpfs size for Yandex Cloud Function.
	TmpfsSize pulumi.IntOutput `pulumi:"tmpfsSize"`
	// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
	UserHash pulumi.StringOutput `pulumi:"userHash"`
	// Version for Yandex Cloud Function.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewFunction registers a new resource with the given unique name, arguments, and options.
func NewFunction(ctx *pulumi.Context,
	name string, args *FunctionArgs, opts ...pulumi.ResourceOption) (*Function, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Entrypoint == nil {
		return nil, errors.New("invalid value for required argument 'Entrypoint'")
	}
	if args.Memory == nil {
		return nil, errors.New("invalid value for required argument 'Memory'")
	}
	if args.Runtime == nil {
		return nil, errors.New("invalid value for required argument 'Runtime'")
	}
	if args.UserHash == nil {
		return nil, errors.New("invalid value for required argument 'UserHash'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Function
	err := ctx.RegisterResource("yandex:index/function:Function", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFunction gets an existing Function resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFunction(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FunctionState, opts ...pulumi.ResourceOption) (*Function, error) {
	var resource Function
	err := ctx.ReadResource("yandex:index/function:Function", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Function resources.
type functionState struct {
	// Config for asynchronous invocations of Yandex Cloud Function.
	AsyncInvocation *FunctionAsyncInvocation `pulumi:"asyncInvocation"`
	// The maximum number of requests processed by a function instance at the same time.
	Concurrency *int `pulumi:"concurrency"`
	// Function version connectivity. If specified the version will be attached to specified network.
	// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
	Connectivity *FunctionConnectivity `pulumi:"connectivity"`
	// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `content.0.zip_filename` - Filename to zip archive for the version.
	Content *FunctionContent `pulumi:"content"`
	// Creation timestamp of the Yandex Cloud Function.
	CreatedAt *string `pulumi:"createdAt"`
	// Description of the Yandex Cloud Function
	Description *string `pulumi:"description"`
	// Entrypoint for Yandex Cloud Function
	Entrypoint *string `pulumi:"entrypoint"`
	// A set of key/value environment variables for Yandex Cloud Function
	Environment map[string]string `pulumi:"environment"`
	// Execution timeout in seconds for Yandex Cloud Function
	ExecutionTimeout *string `pulumi:"executionTimeout"`
	// Folder ID for the Yandex Cloud Function
	FolderId *string `pulumi:"folderId"`
	// Image size for Yandex Cloud Function.
	ImageSize *int `pulumi:"imageSize"`
	// A set of key/value label pairs to assign to the Yandex Cloud Function
	Labels map[string]string `pulumi:"labels"`
	// Options for logging from Yandex Cloud Function.
	LogOptions *FunctionLogOptions `pulumi:"logOptions"`
	// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
	Memory *int `pulumi:"memory"`
	// Yandex Cloud Function name used to define trigger
	Name *string `pulumi:"name"`
	// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `package.0.sha_256` - SHA256 hash of the version deployment package.
	// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
	// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
	Package *FunctionPackage `pulumi:"package"`
	// Runtime for Yandex Cloud Function
	Runtime *string `pulumi:"runtime"`
	// Secrets for Yandex Cloud Function.
	Secrets []FunctionSecret `pulumi:"secrets"`
	// Service account ID for Yandex Cloud Function
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	// Storage mounts for Yandex Cloud Function.
	StorageMounts []FunctionStorageMount `pulumi:"storageMounts"`
	// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
	Tags []string `pulumi:"tags"`
	// Tmpfs size for Yandex Cloud Function.
	TmpfsSize *int `pulumi:"tmpfsSize"`
	// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
	UserHash *string `pulumi:"userHash"`
	// Version for Yandex Cloud Function.
	Version *string `pulumi:"version"`
}

type FunctionState struct {
	// Config for asynchronous invocations of Yandex Cloud Function.
	AsyncInvocation FunctionAsyncInvocationPtrInput
	// The maximum number of requests processed by a function instance at the same time.
	Concurrency pulumi.IntPtrInput
	// Function version connectivity. If specified the version will be attached to specified network.
	// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
	Connectivity FunctionConnectivityPtrInput
	// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `content.0.zip_filename` - Filename to zip archive for the version.
	Content FunctionContentPtrInput
	// Creation timestamp of the Yandex Cloud Function.
	CreatedAt pulumi.StringPtrInput
	// Description of the Yandex Cloud Function
	Description pulumi.StringPtrInput
	// Entrypoint for Yandex Cloud Function
	Entrypoint pulumi.StringPtrInput
	// A set of key/value environment variables for Yandex Cloud Function
	Environment pulumi.StringMapInput
	// Execution timeout in seconds for Yandex Cloud Function
	ExecutionTimeout pulumi.StringPtrInput
	// Folder ID for the Yandex Cloud Function
	FolderId pulumi.StringPtrInput
	// Image size for Yandex Cloud Function.
	ImageSize pulumi.IntPtrInput
	// A set of key/value label pairs to assign to the Yandex Cloud Function
	Labels pulumi.StringMapInput
	// Options for logging from Yandex Cloud Function.
	LogOptions FunctionLogOptionsPtrInput
	// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
	Memory pulumi.IntPtrInput
	// Yandex Cloud Function name used to define trigger
	Name pulumi.StringPtrInput
	// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `package.0.sha_256` - SHA256 hash of the version deployment package.
	// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
	// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
	Package FunctionPackagePtrInput
	// Runtime for Yandex Cloud Function
	Runtime pulumi.StringPtrInput
	// Secrets for Yandex Cloud Function.
	Secrets FunctionSecretArrayInput
	// Service account ID for Yandex Cloud Function
	ServiceAccountId pulumi.StringPtrInput
	// Storage mounts for Yandex Cloud Function.
	StorageMounts FunctionStorageMountArrayInput
	// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
	Tags pulumi.StringArrayInput
	// Tmpfs size for Yandex Cloud Function.
	TmpfsSize pulumi.IntPtrInput
	// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
	UserHash pulumi.StringPtrInput
	// Version for Yandex Cloud Function.
	Version pulumi.StringPtrInput
}

func (FunctionState) ElementType() reflect.Type {
	return reflect.TypeOf((*functionState)(nil)).Elem()
}

type functionArgs struct {
	// Config for asynchronous invocations of Yandex Cloud Function.
	AsyncInvocation *FunctionAsyncInvocation `pulumi:"asyncInvocation"`
	// The maximum number of requests processed by a function instance at the same time.
	Concurrency *int `pulumi:"concurrency"`
	// Function version connectivity. If specified the version will be attached to specified network.
	// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
	Connectivity *FunctionConnectivity `pulumi:"connectivity"`
	// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `content.0.zip_filename` - Filename to zip archive for the version.
	Content *FunctionContent `pulumi:"content"`
	// Description of the Yandex Cloud Function
	Description *string `pulumi:"description"`
	// Entrypoint for Yandex Cloud Function
	Entrypoint string `pulumi:"entrypoint"`
	// A set of key/value environment variables for Yandex Cloud Function
	Environment map[string]string `pulumi:"environment"`
	// Execution timeout in seconds for Yandex Cloud Function
	ExecutionTimeout *string `pulumi:"executionTimeout"`
	// Folder ID for the Yandex Cloud Function
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the Yandex Cloud Function
	Labels map[string]string `pulumi:"labels"`
	// Options for logging from Yandex Cloud Function.
	LogOptions *FunctionLogOptions `pulumi:"logOptions"`
	// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
	Memory int `pulumi:"memory"`
	// Yandex Cloud Function name used to define trigger
	Name *string `pulumi:"name"`
	// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `package.0.sha_256` - SHA256 hash of the version deployment package.
	// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
	// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
	Package *FunctionPackage `pulumi:"package"`
	// Runtime for Yandex Cloud Function
	Runtime string `pulumi:"runtime"`
	// Secrets for Yandex Cloud Function.
	Secrets []FunctionSecret `pulumi:"secrets"`
	// Service account ID for Yandex Cloud Function
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	// Storage mounts for Yandex Cloud Function.
	StorageMounts []FunctionStorageMount `pulumi:"storageMounts"`
	// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
	Tags []string `pulumi:"tags"`
	// Tmpfs size for Yandex Cloud Function.
	TmpfsSize *int `pulumi:"tmpfsSize"`
	// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
	UserHash string `pulumi:"userHash"`
}

// The set of arguments for constructing a Function resource.
type FunctionArgs struct {
	// Config for asynchronous invocations of Yandex Cloud Function.
	AsyncInvocation FunctionAsyncInvocationPtrInput
	// The maximum number of requests processed by a function instance at the same time.
	Concurrency pulumi.IntPtrInput
	// Function version connectivity. If specified the version will be attached to specified network.
	// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
	Connectivity FunctionConnectivityPtrInput
	// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `content.0.zip_filename` - Filename to zip archive for the version.
	Content FunctionContentPtrInput
	// Description of the Yandex Cloud Function
	Description pulumi.StringPtrInput
	// Entrypoint for Yandex Cloud Function
	Entrypoint pulumi.StringInput
	// A set of key/value environment variables for Yandex Cloud Function
	Environment pulumi.StringMapInput
	// Execution timeout in seconds for Yandex Cloud Function
	ExecutionTimeout pulumi.StringPtrInput
	// Folder ID for the Yandex Cloud Function
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the Yandex Cloud Function
	Labels pulumi.StringMapInput
	// Options for logging from Yandex Cloud Function.
	LogOptions FunctionLogOptionsPtrInput
	// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
	Memory pulumi.IntInput
	// Yandex Cloud Function name used to define trigger
	Name pulumi.StringPtrInput
	// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
	// * `package.0.sha_256` - SHA256 hash of the version deployment package.
	// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
	// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
	Package FunctionPackagePtrInput
	// Runtime for Yandex Cloud Function
	Runtime pulumi.StringInput
	// Secrets for Yandex Cloud Function.
	Secrets FunctionSecretArrayInput
	// Service account ID for Yandex Cloud Function
	ServiceAccountId pulumi.StringPtrInput
	// Storage mounts for Yandex Cloud Function.
	StorageMounts FunctionStorageMountArrayInput
	// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
	Tags pulumi.StringArrayInput
	// Tmpfs size for Yandex Cloud Function.
	TmpfsSize pulumi.IntPtrInput
	// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
	UserHash pulumi.StringInput
}

func (FunctionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*functionArgs)(nil)).Elem()
}

type FunctionInput interface {
	pulumi.Input

	ToFunctionOutput() FunctionOutput
	ToFunctionOutputWithContext(ctx context.Context) FunctionOutput
}

func (*Function) ElementType() reflect.Type {
	return reflect.TypeOf((**Function)(nil)).Elem()
}

func (i *Function) ToFunctionOutput() FunctionOutput {
	return i.ToFunctionOutputWithContext(context.Background())
}

func (i *Function) ToFunctionOutputWithContext(ctx context.Context) FunctionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionOutput)
}

// FunctionArrayInput is an input type that accepts FunctionArray and FunctionArrayOutput values.
// You can construct a concrete instance of `FunctionArrayInput` via:
//
//	FunctionArray{ FunctionArgs{...} }
type FunctionArrayInput interface {
	pulumi.Input

	ToFunctionArrayOutput() FunctionArrayOutput
	ToFunctionArrayOutputWithContext(context.Context) FunctionArrayOutput
}

type FunctionArray []FunctionInput

func (FunctionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Function)(nil)).Elem()
}

func (i FunctionArray) ToFunctionArrayOutput() FunctionArrayOutput {
	return i.ToFunctionArrayOutputWithContext(context.Background())
}

func (i FunctionArray) ToFunctionArrayOutputWithContext(ctx context.Context) FunctionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionArrayOutput)
}

// FunctionMapInput is an input type that accepts FunctionMap and FunctionMapOutput values.
// You can construct a concrete instance of `FunctionMapInput` via:
//
//	FunctionMap{ "key": FunctionArgs{...} }
type FunctionMapInput interface {
	pulumi.Input

	ToFunctionMapOutput() FunctionMapOutput
	ToFunctionMapOutputWithContext(context.Context) FunctionMapOutput
}

type FunctionMap map[string]FunctionInput

func (FunctionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Function)(nil)).Elem()
}

func (i FunctionMap) ToFunctionMapOutput() FunctionMapOutput {
	return i.ToFunctionMapOutputWithContext(context.Background())
}

func (i FunctionMap) ToFunctionMapOutputWithContext(ctx context.Context) FunctionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionMapOutput)
}

type FunctionOutput struct{ *pulumi.OutputState }

func (FunctionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Function)(nil)).Elem()
}

func (o FunctionOutput) ToFunctionOutput() FunctionOutput {
	return o
}

func (o FunctionOutput) ToFunctionOutputWithContext(ctx context.Context) FunctionOutput {
	return o
}

// Config for asynchronous invocations of Yandex Cloud Function.
func (o FunctionOutput) AsyncInvocation() FunctionAsyncInvocationPtrOutput {
	return o.ApplyT(func(v *Function) FunctionAsyncInvocationPtrOutput { return v.AsyncInvocation }).(FunctionAsyncInvocationPtrOutput)
}

// The maximum number of requests processed by a function instance at the same time.
func (o FunctionOutput) Concurrency() pulumi.IntOutput {
	return o.ApplyT(func(v *Function) pulumi.IntOutput { return v.Concurrency }).(pulumi.IntOutput)
}

// Function version connectivity. If specified the version will be attached to specified network.
// * `connectivity.0.network_id` - Network the version will have access to. It's essential to specify network with subnets in all availability zones.
func (o FunctionOutput) Connectivity() FunctionConnectivityPtrOutput {
	return o.ApplyT(func(v *Function) FunctionConnectivityPtrOutput { return v.Connectivity }).(FunctionConnectivityPtrOutput)
}

// Version deployment content for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
// * `content.0.zip_filename` - Filename to zip archive for the version.
func (o FunctionOutput) Content() FunctionContentPtrOutput {
	return o.ApplyT(func(v *Function) FunctionContentPtrOutput { return v.Content }).(FunctionContentPtrOutput)
}

// Creation timestamp of the Yandex Cloud Function.
func (o FunctionOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Description of the Yandex Cloud Function
func (o FunctionOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Function) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Entrypoint for Yandex Cloud Function
func (o FunctionOutput) Entrypoint() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.Entrypoint }).(pulumi.StringOutput)
}

// A set of key/value environment variables for Yandex Cloud Function
func (o FunctionOutput) Environment() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Function) pulumi.StringMapOutput { return v.Environment }).(pulumi.StringMapOutput)
}

// Execution timeout in seconds for Yandex Cloud Function
func (o FunctionOutput) ExecutionTimeout() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Function) pulumi.StringPtrOutput { return v.ExecutionTimeout }).(pulumi.StringPtrOutput)
}

// Folder ID for the Yandex Cloud Function
func (o FunctionOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// Image size for Yandex Cloud Function.
func (o FunctionOutput) ImageSize() pulumi.IntOutput {
	return o.ApplyT(func(v *Function) pulumi.IntOutput { return v.ImageSize }).(pulumi.IntOutput)
}

// A set of key/value label pairs to assign to the Yandex Cloud Function
func (o FunctionOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Function) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Options for logging from Yandex Cloud Function.
func (o FunctionOutput) LogOptions() FunctionLogOptionsOutput {
	return o.ApplyT(func(v *Function) FunctionLogOptionsOutput { return v.LogOptions }).(FunctionLogOptionsOutput)
}

// Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Function
func (o FunctionOutput) Memory() pulumi.IntOutput {
	return o.ApplyT(func(v *Function) pulumi.IntOutput { return v.Memory }).(pulumi.IntOutput)
}

// Yandex Cloud Function name used to define trigger
func (o FunctionOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Version deployment package for Yandex Cloud Function code. Can be only one `package` or `content` section. Either `package` or `content` section must be specified.
// * `package.0.sha_256` - SHA256 hash of the version deployment package.
// * `package.0.bucket_name` - Name of the bucket that stores the code for the version.
// * `package.0.object_name` - Name of the object in the bucket that stores the code for the version.
func (o FunctionOutput) Package() FunctionPackagePtrOutput {
	return o.ApplyT(func(v *Function) FunctionPackagePtrOutput { return v.Package }).(FunctionPackagePtrOutput)
}

// Runtime for Yandex Cloud Function
func (o FunctionOutput) Runtime() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.Runtime }).(pulumi.StringOutput)
}

// Secrets for Yandex Cloud Function.
func (o FunctionOutput) Secrets() FunctionSecretArrayOutput {
	return o.ApplyT(func(v *Function) FunctionSecretArrayOutput { return v.Secrets }).(FunctionSecretArrayOutput)
}

// Service account ID for Yandex Cloud Function
func (o FunctionOutput) ServiceAccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Function) pulumi.StringPtrOutput { return v.ServiceAccountId }).(pulumi.StringPtrOutput)
}

// Storage mounts for Yandex Cloud Function.
func (o FunctionOutput) StorageMounts() FunctionStorageMountArrayOutput {
	return o.ApplyT(func(v *Function) FunctionStorageMountArrayOutput { return v.StorageMounts }).(FunctionStorageMountArrayOutput)
}

// Tags for Yandex Cloud Function. Tag "$latest" isn't returned.
func (o FunctionOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Function) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

// Tmpfs size for Yandex Cloud Function.
func (o FunctionOutput) TmpfsSize() pulumi.IntOutput {
	return o.ApplyT(func(v *Function) pulumi.IntOutput { return v.TmpfsSize }).(pulumi.IntOutput)
}

// User-defined string for current function version. User must change this string any times when function changed. Function will be updated when hash is changed.
func (o FunctionOutput) UserHash() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.UserHash }).(pulumi.StringOutput)
}

// Version for Yandex Cloud Function.
func (o FunctionOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v *Function) pulumi.StringOutput { return v.Version }).(pulumi.StringOutput)
}

type FunctionArrayOutput struct{ *pulumi.OutputState }

func (FunctionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Function)(nil)).Elem()
}

func (o FunctionArrayOutput) ToFunctionArrayOutput() FunctionArrayOutput {
	return o
}

func (o FunctionArrayOutput) ToFunctionArrayOutputWithContext(ctx context.Context) FunctionArrayOutput {
	return o
}

func (o FunctionArrayOutput) Index(i pulumi.IntInput) FunctionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Function {
		return vs[0].([]*Function)[vs[1].(int)]
	}).(FunctionOutput)
}

type FunctionMapOutput struct{ *pulumi.OutputState }

func (FunctionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Function)(nil)).Elem()
}

func (o FunctionMapOutput) ToFunctionMapOutput() FunctionMapOutput {
	return o
}

func (o FunctionMapOutput) ToFunctionMapOutputWithContext(ctx context.Context) FunctionMapOutput {
	return o
}

func (o FunctionMapOutput) MapIndex(k pulumi.StringInput) FunctionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Function {
		return vs[0].(map[string]*Function)[vs[1].(string)]
	}).(FunctionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionInput)(nil)).Elem(), &Function{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionArrayInput)(nil)).Elem(), FunctionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionMapInput)(nil)).Elem(), FunctionMap{})
	pulumi.RegisterOutputType(FunctionOutput{})
	pulumi.RegisterOutputType(FunctionArrayOutput{})
	pulumi.RegisterOutputType(FunctionMapOutput{})
}
