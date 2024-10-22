// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type SmartcaptchaCaptcha struct {
	pulumi.CustomResourceState

	AllowedSites         pulumi.StringArrayOutput                      `pulumi:"allowedSites"`
	ChallengeType        pulumi.StringPtrOutput                        `pulumi:"challengeType"`
	ClientKey            pulumi.StringOutput                           `pulumi:"clientKey"`
	CloudId              pulumi.StringOutput                           `pulumi:"cloudId"`
	Complexity           pulumi.StringPtrOutput                        `pulumi:"complexity"`
	CreatedAt            pulumi.StringOutput                           `pulumi:"createdAt"`
	DeletionProtection   pulumi.BoolPtrOutput                          `pulumi:"deletionProtection"`
	FolderId             pulumi.StringOutput                           `pulumi:"folderId"`
	Name                 pulumi.StringOutput                           `pulumi:"name"`
	OverrideVariants     SmartcaptchaCaptchaOverrideVariantArrayOutput `pulumi:"overrideVariants"`
	PreCheckType         pulumi.StringPtrOutput                        `pulumi:"preCheckType"`
	SecurityRules        SmartcaptchaCaptchaSecurityRuleArrayOutput    `pulumi:"securityRules"`
	StyleJson            pulumi.StringPtrOutput                        `pulumi:"styleJson"`
	Suspend              pulumi.BoolOutput                             `pulumi:"suspend"`
	TurnOffHostnameCheck pulumi.BoolPtrOutput                          `pulumi:"turnOffHostnameCheck"`
}

// NewSmartcaptchaCaptcha registers a new resource with the given unique name, arguments, and options.
func NewSmartcaptchaCaptcha(ctx *pulumi.Context,
	name string, args *SmartcaptchaCaptchaArgs, opts ...pulumi.ResourceOption) (*SmartcaptchaCaptcha, error) {
	if args == nil {
		args = &SmartcaptchaCaptchaArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SmartcaptchaCaptcha
	err := ctx.RegisterResource("yandex:index/smartcaptchaCaptcha:SmartcaptchaCaptcha", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSmartcaptchaCaptcha gets an existing SmartcaptchaCaptcha resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSmartcaptchaCaptcha(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SmartcaptchaCaptchaState, opts ...pulumi.ResourceOption) (*SmartcaptchaCaptcha, error) {
	var resource SmartcaptchaCaptcha
	err := ctx.ReadResource("yandex:index/smartcaptchaCaptcha:SmartcaptchaCaptcha", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SmartcaptchaCaptcha resources.
type smartcaptchaCaptchaState struct {
	AllowedSites         []string                             `pulumi:"allowedSites"`
	ChallengeType        *string                              `pulumi:"challengeType"`
	ClientKey            *string                              `pulumi:"clientKey"`
	CloudId              *string                              `pulumi:"cloudId"`
	Complexity           *string                              `pulumi:"complexity"`
	CreatedAt            *string                              `pulumi:"createdAt"`
	DeletionProtection   *bool                                `pulumi:"deletionProtection"`
	FolderId             *string                              `pulumi:"folderId"`
	Name                 *string                              `pulumi:"name"`
	OverrideVariants     []SmartcaptchaCaptchaOverrideVariant `pulumi:"overrideVariants"`
	PreCheckType         *string                              `pulumi:"preCheckType"`
	SecurityRules        []SmartcaptchaCaptchaSecurityRule    `pulumi:"securityRules"`
	StyleJson            *string                              `pulumi:"styleJson"`
	Suspend              *bool                                `pulumi:"suspend"`
	TurnOffHostnameCheck *bool                                `pulumi:"turnOffHostnameCheck"`
}

type SmartcaptchaCaptchaState struct {
	AllowedSites         pulumi.StringArrayInput
	ChallengeType        pulumi.StringPtrInput
	ClientKey            pulumi.StringPtrInput
	CloudId              pulumi.StringPtrInput
	Complexity           pulumi.StringPtrInput
	CreatedAt            pulumi.StringPtrInput
	DeletionProtection   pulumi.BoolPtrInput
	FolderId             pulumi.StringPtrInput
	Name                 pulumi.StringPtrInput
	OverrideVariants     SmartcaptchaCaptchaOverrideVariantArrayInput
	PreCheckType         pulumi.StringPtrInput
	SecurityRules        SmartcaptchaCaptchaSecurityRuleArrayInput
	StyleJson            pulumi.StringPtrInput
	Suspend              pulumi.BoolPtrInput
	TurnOffHostnameCheck pulumi.BoolPtrInput
}

func (SmartcaptchaCaptchaState) ElementType() reflect.Type {
	return reflect.TypeOf((*smartcaptchaCaptchaState)(nil)).Elem()
}

type smartcaptchaCaptchaArgs struct {
	AllowedSites         []string                             `pulumi:"allowedSites"`
	ChallengeType        *string                              `pulumi:"challengeType"`
	CloudId              *string                              `pulumi:"cloudId"`
	Complexity           *string                              `pulumi:"complexity"`
	DeletionProtection   *bool                                `pulumi:"deletionProtection"`
	FolderId             *string                              `pulumi:"folderId"`
	Name                 *string                              `pulumi:"name"`
	OverrideVariants     []SmartcaptchaCaptchaOverrideVariant `pulumi:"overrideVariants"`
	PreCheckType         *string                              `pulumi:"preCheckType"`
	SecurityRules        []SmartcaptchaCaptchaSecurityRule    `pulumi:"securityRules"`
	StyleJson            *string                              `pulumi:"styleJson"`
	TurnOffHostnameCheck *bool                                `pulumi:"turnOffHostnameCheck"`
}

// The set of arguments for constructing a SmartcaptchaCaptcha resource.
type SmartcaptchaCaptchaArgs struct {
	AllowedSites         pulumi.StringArrayInput
	ChallengeType        pulumi.StringPtrInput
	CloudId              pulumi.StringPtrInput
	Complexity           pulumi.StringPtrInput
	DeletionProtection   pulumi.BoolPtrInput
	FolderId             pulumi.StringPtrInput
	Name                 pulumi.StringPtrInput
	OverrideVariants     SmartcaptchaCaptchaOverrideVariantArrayInput
	PreCheckType         pulumi.StringPtrInput
	SecurityRules        SmartcaptchaCaptchaSecurityRuleArrayInput
	StyleJson            pulumi.StringPtrInput
	TurnOffHostnameCheck pulumi.BoolPtrInput
}

func (SmartcaptchaCaptchaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*smartcaptchaCaptchaArgs)(nil)).Elem()
}

type SmartcaptchaCaptchaInput interface {
	pulumi.Input

	ToSmartcaptchaCaptchaOutput() SmartcaptchaCaptchaOutput
	ToSmartcaptchaCaptchaOutputWithContext(ctx context.Context) SmartcaptchaCaptchaOutput
}

func (*SmartcaptchaCaptcha) ElementType() reflect.Type {
	return reflect.TypeOf((**SmartcaptchaCaptcha)(nil)).Elem()
}

func (i *SmartcaptchaCaptcha) ToSmartcaptchaCaptchaOutput() SmartcaptchaCaptchaOutput {
	return i.ToSmartcaptchaCaptchaOutputWithContext(context.Background())
}

func (i *SmartcaptchaCaptcha) ToSmartcaptchaCaptchaOutputWithContext(ctx context.Context) SmartcaptchaCaptchaOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SmartcaptchaCaptchaOutput)
}

// SmartcaptchaCaptchaArrayInput is an input type that accepts SmartcaptchaCaptchaArray and SmartcaptchaCaptchaArrayOutput values.
// You can construct a concrete instance of `SmartcaptchaCaptchaArrayInput` via:
//
//	SmartcaptchaCaptchaArray{ SmartcaptchaCaptchaArgs{...} }
type SmartcaptchaCaptchaArrayInput interface {
	pulumi.Input

	ToSmartcaptchaCaptchaArrayOutput() SmartcaptchaCaptchaArrayOutput
	ToSmartcaptchaCaptchaArrayOutputWithContext(context.Context) SmartcaptchaCaptchaArrayOutput
}

type SmartcaptchaCaptchaArray []SmartcaptchaCaptchaInput

func (SmartcaptchaCaptchaArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SmartcaptchaCaptcha)(nil)).Elem()
}

func (i SmartcaptchaCaptchaArray) ToSmartcaptchaCaptchaArrayOutput() SmartcaptchaCaptchaArrayOutput {
	return i.ToSmartcaptchaCaptchaArrayOutputWithContext(context.Background())
}

func (i SmartcaptchaCaptchaArray) ToSmartcaptchaCaptchaArrayOutputWithContext(ctx context.Context) SmartcaptchaCaptchaArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SmartcaptchaCaptchaArrayOutput)
}

// SmartcaptchaCaptchaMapInput is an input type that accepts SmartcaptchaCaptchaMap and SmartcaptchaCaptchaMapOutput values.
// You can construct a concrete instance of `SmartcaptchaCaptchaMapInput` via:
//
//	SmartcaptchaCaptchaMap{ "key": SmartcaptchaCaptchaArgs{...} }
type SmartcaptchaCaptchaMapInput interface {
	pulumi.Input

	ToSmartcaptchaCaptchaMapOutput() SmartcaptchaCaptchaMapOutput
	ToSmartcaptchaCaptchaMapOutputWithContext(context.Context) SmartcaptchaCaptchaMapOutput
}

type SmartcaptchaCaptchaMap map[string]SmartcaptchaCaptchaInput

func (SmartcaptchaCaptchaMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SmartcaptchaCaptcha)(nil)).Elem()
}

func (i SmartcaptchaCaptchaMap) ToSmartcaptchaCaptchaMapOutput() SmartcaptchaCaptchaMapOutput {
	return i.ToSmartcaptchaCaptchaMapOutputWithContext(context.Background())
}

func (i SmartcaptchaCaptchaMap) ToSmartcaptchaCaptchaMapOutputWithContext(ctx context.Context) SmartcaptchaCaptchaMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SmartcaptchaCaptchaMapOutput)
}

type SmartcaptchaCaptchaOutput struct{ *pulumi.OutputState }

func (SmartcaptchaCaptchaOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SmartcaptchaCaptcha)(nil)).Elem()
}

func (o SmartcaptchaCaptchaOutput) ToSmartcaptchaCaptchaOutput() SmartcaptchaCaptchaOutput {
	return o
}

func (o SmartcaptchaCaptchaOutput) ToSmartcaptchaCaptchaOutputWithContext(ctx context.Context) SmartcaptchaCaptchaOutput {
	return o
}

func (o SmartcaptchaCaptchaOutput) AllowedSites() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringArrayOutput { return v.AllowedSites }).(pulumi.StringArrayOutput)
}

func (o SmartcaptchaCaptchaOutput) ChallengeType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringPtrOutput { return v.ChallengeType }).(pulumi.StringPtrOutput)
}

func (o SmartcaptchaCaptchaOutput) ClientKey() pulumi.StringOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringOutput { return v.ClientKey }).(pulumi.StringOutput)
}

func (o SmartcaptchaCaptchaOutput) CloudId() pulumi.StringOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringOutput { return v.CloudId }).(pulumi.StringOutput)
}

func (o SmartcaptchaCaptchaOutput) Complexity() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringPtrOutput { return v.Complexity }).(pulumi.StringPtrOutput)
}

func (o SmartcaptchaCaptchaOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o SmartcaptchaCaptchaOutput) DeletionProtection() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.BoolPtrOutput { return v.DeletionProtection }).(pulumi.BoolPtrOutput)
}

func (o SmartcaptchaCaptchaOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

func (o SmartcaptchaCaptchaOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o SmartcaptchaCaptchaOutput) OverrideVariants() SmartcaptchaCaptchaOverrideVariantArrayOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) SmartcaptchaCaptchaOverrideVariantArrayOutput { return v.OverrideVariants }).(SmartcaptchaCaptchaOverrideVariantArrayOutput)
}

func (o SmartcaptchaCaptchaOutput) PreCheckType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringPtrOutput { return v.PreCheckType }).(pulumi.StringPtrOutput)
}

func (o SmartcaptchaCaptchaOutput) SecurityRules() SmartcaptchaCaptchaSecurityRuleArrayOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) SmartcaptchaCaptchaSecurityRuleArrayOutput { return v.SecurityRules }).(SmartcaptchaCaptchaSecurityRuleArrayOutput)
}

func (o SmartcaptchaCaptchaOutput) StyleJson() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.StringPtrOutput { return v.StyleJson }).(pulumi.StringPtrOutput)
}

func (o SmartcaptchaCaptchaOutput) Suspend() pulumi.BoolOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.BoolOutput { return v.Suspend }).(pulumi.BoolOutput)
}

func (o SmartcaptchaCaptchaOutput) TurnOffHostnameCheck() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SmartcaptchaCaptcha) pulumi.BoolPtrOutput { return v.TurnOffHostnameCheck }).(pulumi.BoolPtrOutput)
}

type SmartcaptchaCaptchaArrayOutput struct{ *pulumi.OutputState }

func (SmartcaptchaCaptchaArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SmartcaptchaCaptcha)(nil)).Elem()
}

func (o SmartcaptchaCaptchaArrayOutput) ToSmartcaptchaCaptchaArrayOutput() SmartcaptchaCaptchaArrayOutput {
	return o
}

func (o SmartcaptchaCaptchaArrayOutput) ToSmartcaptchaCaptchaArrayOutputWithContext(ctx context.Context) SmartcaptchaCaptchaArrayOutput {
	return o
}

func (o SmartcaptchaCaptchaArrayOutput) Index(i pulumi.IntInput) SmartcaptchaCaptchaOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SmartcaptchaCaptcha {
		return vs[0].([]*SmartcaptchaCaptcha)[vs[1].(int)]
	}).(SmartcaptchaCaptchaOutput)
}

type SmartcaptchaCaptchaMapOutput struct{ *pulumi.OutputState }

func (SmartcaptchaCaptchaMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SmartcaptchaCaptcha)(nil)).Elem()
}

func (o SmartcaptchaCaptchaMapOutput) ToSmartcaptchaCaptchaMapOutput() SmartcaptchaCaptchaMapOutput {
	return o
}

func (o SmartcaptchaCaptchaMapOutput) ToSmartcaptchaCaptchaMapOutputWithContext(ctx context.Context) SmartcaptchaCaptchaMapOutput {
	return o
}

func (o SmartcaptchaCaptchaMapOutput) MapIndex(k pulumi.StringInput) SmartcaptchaCaptchaOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SmartcaptchaCaptcha {
		return vs[0].(map[string]*SmartcaptchaCaptcha)[vs[1].(string)]
	}).(SmartcaptchaCaptchaOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SmartcaptchaCaptchaInput)(nil)).Elem(), &SmartcaptchaCaptcha{})
	pulumi.RegisterInputType(reflect.TypeOf((*SmartcaptchaCaptchaArrayInput)(nil)).Elem(), SmartcaptchaCaptchaArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SmartcaptchaCaptchaMapInput)(nil)).Elem(), SmartcaptchaCaptchaMap{})
	pulumi.RegisterOutputType(SmartcaptchaCaptchaOutput{})
	pulumi.RegisterOutputType(SmartcaptchaCaptchaArrayOutput{})
	pulumi.RegisterOutputType(SmartcaptchaCaptchaMapOutput{})
}
