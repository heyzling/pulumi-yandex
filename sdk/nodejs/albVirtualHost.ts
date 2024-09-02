// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Creates a virtual host that belongs to specified HTTP router and adds the specified routes to it. For more information,
 * see [the official documentation](https://cloud.yandex.com/en/docs/application-load-balancer/concepts/http-router).
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const my_virtual_host = new yandex.AlbVirtualHost("my-virtual-host", {
 *     httpRouterId: yandex_alb_http_router["my-router"].id,
 *     routes: [{
 *         name: "my-route",
 *         httpRoute: {
 *             httpRouteAction: {
 *                 backendGroupId: yandex_alb_backend_group["my-bg"].id,
 *                 timeout: "3s",
 *             },
 *         },
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A virtual host can be imported using the `id` of the resource, which for a virtual host is defined as its
 * http router id separated by `/` from the virtual host's name, e.g.:
 *
 * ```sh
 * $ pulumi import yandex:index/albVirtualHost:AlbVirtualHost default http_router_id/vhost_name
 * ```
 */
export class AlbVirtualHost extends pulumi.CustomResource {
    /**
     * Get an existing AlbVirtualHost resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AlbVirtualHostState, opts?: pulumi.CustomResourceOptions): AlbVirtualHost {
        return new AlbVirtualHost(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/albVirtualHost:AlbVirtualHost';

    /**
     * Returns true if the given object is an instance of AlbVirtualHost.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AlbVirtualHost {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AlbVirtualHost.__pulumiType;
    }

    /**
     * A list of domains (host/authority header) that will be matched to this virtual host. Wildcard
     * hosts are supported in the form of '*.foo.com' or '*-bar.foo.com'. If not specified, all domains will be matched.
     */
    public readonly authorities!: pulumi.Output<string[] | undefined>;
    /**
     * The ID of the HTTP router to which the virtual host belongs.
     */
    public readonly httpRouterId!: pulumi.Output<string>;
    /**
     * Apply the following modifications to the request
     * headers. The structure is documented below.
     */
    public readonly modifyRequestHeaders!: pulumi.Output<outputs.AlbVirtualHostModifyRequestHeader[] | undefined>;
    /**
     * Apply the following modifications to the response
     * headers. The structure is documented below.
     */
    public readonly modifyResponseHeaders!: pulumi.Output<outputs.AlbVirtualHostModifyResponseHeader[] | undefined>;
    /**
     * name of the header to modify.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Route options for the virtual host. The structure is documented below.
     */
    public readonly routeOptions!: pulumi.Output<outputs.AlbVirtualHostRouteOptions | undefined>;
    /**
     * A Route resource. Routes are matched *in-order*. Be careful when adding them to the end. For instance, having
     * http '/' match first makes all other routes unused. The structure is documented below.
     */
    public readonly routes!: pulumi.Output<outputs.AlbVirtualHostRoute[] | undefined>;

    /**
     * Create a AlbVirtualHost resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AlbVirtualHostArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AlbVirtualHostArgs | AlbVirtualHostState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AlbVirtualHostState | undefined;
            resourceInputs["authorities"] = state ? state.authorities : undefined;
            resourceInputs["httpRouterId"] = state ? state.httpRouterId : undefined;
            resourceInputs["modifyRequestHeaders"] = state ? state.modifyRequestHeaders : undefined;
            resourceInputs["modifyResponseHeaders"] = state ? state.modifyResponseHeaders : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["routeOptions"] = state ? state.routeOptions : undefined;
            resourceInputs["routes"] = state ? state.routes : undefined;
        } else {
            const args = argsOrState as AlbVirtualHostArgs | undefined;
            if ((!args || args.httpRouterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'httpRouterId'");
            }
            resourceInputs["authorities"] = args ? args.authorities : undefined;
            resourceInputs["httpRouterId"] = args ? args.httpRouterId : undefined;
            resourceInputs["modifyRequestHeaders"] = args ? args.modifyRequestHeaders : undefined;
            resourceInputs["modifyResponseHeaders"] = args ? args.modifyResponseHeaders : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["routeOptions"] = args ? args.routeOptions : undefined;
            resourceInputs["routes"] = args ? args.routes : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AlbVirtualHost.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AlbVirtualHost resources.
 */
export interface AlbVirtualHostState {
    /**
     * A list of domains (host/authority header) that will be matched to this virtual host. Wildcard
     * hosts are supported in the form of '*.foo.com' or '*-bar.foo.com'. If not specified, all domains will be matched.
     */
    authorities?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the HTTP router to which the virtual host belongs.
     */
    httpRouterId?: pulumi.Input<string>;
    /**
     * Apply the following modifications to the request
     * headers. The structure is documented below.
     */
    modifyRequestHeaders?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostModifyRequestHeader>[]>;
    /**
     * Apply the following modifications to the response
     * headers. The structure is documented below.
     */
    modifyResponseHeaders?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostModifyResponseHeader>[]>;
    /**
     * name of the header to modify.
     */
    name?: pulumi.Input<string>;
    /**
     * Route options for the virtual host. The structure is documented below.
     */
    routeOptions?: pulumi.Input<inputs.AlbVirtualHostRouteOptions>;
    /**
     * A Route resource. Routes are matched *in-order*. Be careful when adding them to the end. For instance, having
     * http '/' match first makes all other routes unused. The structure is documented below.
     */
    routes?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostRoute>[]>;
}

/**
 * The set of arguments for constructing a AlbVirtualHost resource.
 */
export interface AlbVirtualHostArgs {
    /**
     * A list of domains (host/authority header) that will be matched to this virtual host. Wildcard
     * hosts are supported in the form of '*.foo.com' or '*-bar.foo.com'. If not specified, all domains will be matched.
     */
    authorities?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the HTTP router to which the virtual host belongs.
     */
    httpRouterId: pulumi.Input<string>;
    /**
     * Apply the following modifications to the request
     * headers. The structure is documented below.
     */
    modifyRequestHeaders?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostModifyRequestHeader>[]>;
    /**
     * Apply the following modifications to the response
     * headers. The structure is documented below.
     */
    modifyResponseHeaders?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostModifyResponseHeader>[]>;
    /**
     * name of the header to modify.
     */
    name?: pulumi.Input<string>;
    /**
     * Route options for the virtual host. The structure is documented below.
     */
    routeOptions?: pulumi.Input<inputs.AlbVirtualHostRouteOptions>;
    /**
     * A Route resource. Routes are matched *in-order*. Be careful when adding them to the end. For instance, having
     * http '/' match first makes all other routes unused. The structure is documented below.
     */
    routes?: pulumi.Input<pulumi.Input<inputs.AlbVirtualHostRoute>[]>;
}