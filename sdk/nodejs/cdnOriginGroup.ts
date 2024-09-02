// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Allows management of [Yandex.Cloud CDN Origin Groups](https://cloud.yandex.ru/docs/cdn/concepts/origins).
 *
 * > **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id <folder-id> --type gcore```
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myGroup = new yandex.CdnOriginGroup("myGroup", {
 *     origins: [
 *         {
 *             source: "ya.ru",
 *         },
 *         {
 *             source: "yandex.ru",
 *         },
 *         {
 *             source: "goo.gl",
 *         },
 *         {
 *             backup: false,
 *             source: "amazon.com",
 *         },
 *     ],
 *     useNext: true,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A origin group can be imported using any of these accepted formats:
 *
 * ```sh
 * $ pulumi import yandex:index/cdnOriginGroup:CdnOriginGroup default origin_group_id
 * ```
 */
export class CdnOriginGroup extends pulumi.CustomResource {
    /**
     * Get an existing CdnOriginGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CdnOriginGroupState, opts?: pulumi.CustomResourceOptions): CdnOriginGroup {
        return new CdnOriginGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/cdnOriginGroup:CdnOriginGroup';

    /**
     * Returns true if the given object is an instance of CdnOriginGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CdnOriginGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CdnOriginGroup.__pulumiType;
    }

    public readonly folderId!: pulumi.Output<string>;
    /**
     * CDN Origin Group name used to define device.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly origins!: pulumi.Output<outputs.CdnOriginGroupOrigin[]>;
    /**
     * If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
     */
    public readonly useNext!: pulumi.Output<boolean | undefined>;

    /**
     * Create a CdnOriginGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CdnOriginGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CdnOriginGroupArgs | CdnOriginGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CdnOriginGroupState | undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["origins"] = state ? state.origins : undefined;
            resourceInputs["useNext"] = state ? state.useNext : undefined;
        } else {
            const args = argsOrState as CdnOriginGroupArgs | undefined;
            if ((!args || args.origins === undefined) && !opts.urn) {
                throw new Error("Missing required property 'origins'");
            }
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["origins"] = args ? args.origins : undefined;
            resourceInputs["useNext"] = args ? args.useNext : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CdnOriginGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CdnOriginGroup resources.
 */
export interface CdnOriginGroupState {
    folderId?: pulumi.Input<string>;
    /**
     * CDN Origin Group name used to define device.
     */
    name?: pulumi.Input<string>;
    origins?: pulumi.Input<pulumi.Input<inputs.CdnOriginGroupOrigin>[]>;
    /**
     * If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
     */
    useNext?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a CdnOriginGroup resource.
 */
export interface CdnOriginGroupArgs {
    folderId?: pulumi.Input<string>;
    /**
     * CDN Origin Group name used to define device.
     */
    name?: pulumi.Input<string>;
    origins: pulumi.Input<pulumi.Input<inputs.CdnOriginGroupOrigin>[]>;
    /**
     * If the option is active (has true value), in case the origin responds with 4XX or 5XX codes, use the next origin from the list.
     */
    useNext?: pulumi.Input<boolean>;
}
