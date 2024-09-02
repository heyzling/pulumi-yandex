// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Allows management of [Yandex.Cloud Storage Bucket](https://cloud.yandex.com/docs/storage/concepts/bucket).
 *
 * > **Note:** Your need to provide [static access key](https://cloud.yandex.com/docs/iam/concepts/authorization/access-key) (Access and Secret) to create storage client to work with Storage Service. To create them you need Service Account and proper permissions.
 *
 * > **Note:** For extended API usage, such as setting `maxSize`, `folderId`, `anonymousAccessFlags`,
 * `defaultStorageClass` and `https` parameters for bucket, will be used default authorization method, i.e.
 * `IAM` / `OAuth` token from `provider` block will be used.
 * This might be a little bit confusing in cases when separate service account is used for managing buckets because
 * in this case buckets will be accessed by two different accounts that might have different permissions for buckets.
 *
 * ## Example Usage
 *
 * ### Simple Private Bucket
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const folderId = "<folder-id>";
 * // Create SA
 * const sa = new yandex.IamServiceAccount("sa", {folderId: folderId});
 * // Grant permissions
 * const sa_editor = new yandex.ResourcemanagerFolderIamMember("sa-editor", {
 *     folderId: folderId,
 *     role: "storage.editor",
 *     member: pulumi.interpolate`serviceAccount:${sa.id}`,
 * });
 * // Create Static Access Keys
 * const sa_static_key = new yandex.IamServiceAccountStaticAccessKey("sa-static-key", {
 *     serviceAccountId: sa.id,
 *     description: "static access key for object storage",
 * });
 * // Use keys to create bucket
 * const test = new yandex.StorageBucket("test", {
 *     accessKey: sa_static_key.accessKey,
 *     secretKey: sa_static_key.secretKey,
 *     bucket: "tf-test-bucket",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Static Website Hosting
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const test = new yandex.StorageBucket("test", {
 *     acl: "public-read",
 *     bucket: "storage-website-test.hashicorp.com",
 *     website: {
 *         errorDocument: "error.html",
 *         indexDocument: "index.html",
 *         routingRules: `[{
 *     "Condition": {
 *         "KeyPrefixEquals": "docs/"
 *     },
 *     "Redirect": {
 *         "ReplaceKeyPrefixWith": "documents/"
 *     }
 * }]
 *
 * `,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using ACL policy grants
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const test = new yandex.StorageBucket("test", {
 *     bucket: "mybucket",
 *     grants: [
 *         {
 *             id: "myuser",
 *             permissions: ["FULL_CONTROL"],
 *             type: "CanonicalUser",
 *         },
 *         {
 *             permissions: [
 *                 "READ",
 *                 "WRITE",
 *             ],
 *             type: "Group",
 *             uri: "http://acs.amazonaws.com/groups/global/AllUsers",
 *         },
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using CORS
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     acl: "public-read",
 *     bucket: "s3-website-test.hashicorp.com",
 *     corsRules: [{
 *         allowedHeaders: ["*"],
 *         allowedMethods: [
 *             "PUT",
 *             "POST",
 *         ],
 *         allowedOrigins: ["https://s3-website-test.hashicorp.com"],
 *         exposeHeaders: ["ETag"],
 *         maxAgeSeconds: 3000,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using versioning
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     acl: "private",
 *     bucket: "my-tf-test-bucket",
 *     versioning: {
 *         enabled: true,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using Object Lock Configuration
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     acl: "private",
 *     bucket: "my-tf-test-bucket",
 *     objectLockConfiguration: {
 *         objectLockEnabled: "Enabled",
 *         rule: {
 *             defaultRetention: {
 *                 mode: "GOVERNANCE",
 *                 years: 1,
 *             },
 *         },
 *     },
 *     versioning: {
 *         enabled: true,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Enable Logging
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const logBucket = new yandex.StorageBucket("logBucket", {bucket: "my-tf-log-bucket"});
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-tf-test-bucket",
 *     acl: "private",
 *     loggings: [{
 *         targetBucket: logBucket.id,
 *         targetPrefix: "log/",
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using object lifecycle
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const bucket = new yandex.StorageBucket("bucket", {
 *     acl: "private",
 *     bucket: "my-bucket",
 *     lifecycleRules: [
 *         {
 *             enabled: true,
 *             expiration: {
 *                 days: 90,
 *             },
 *             id: "log",
 *             prefix: "log/",
 *             transitions: [{
 *                 days: 30,
 *                 storageClass: "COLD",
 *             }],
 *         },
 *         {
 *             enabled: true,
 *             expiration: {
 *                 date: "2020-12-21",
 *             },
 *             id: "tmp",
 *             prefix: "tmp/",
 *         },
 *         {
 *             enabled: true,
 *             expiration: {
 *                 date: "2020-12-21",
 *             },
 *             filter: {
 *                 tag: {
 *                     key: "key1",
 *                     value: "value1",
 *                 },
 *             },
 *             id: "test_tag",
 *         },
 *         {
 *             enabled: true,
 *             expiration: {
 *                 date: "2020-12-21",
 *             },
 *             filter: {
 *                 objectSizeGreaterThan: 1000,
 *             },
 *             id: "test_object_size_greater_than",
 *         },
 *         {
 *             enabled: true,
 *             expiration: {
 *                 date: "2020-12-21",
 *             },
 *             filter: {
 *                 objectSizeLessThan: 30000,
 *             },
 *             id: "object_size_less_than",
 *         },
 *         {
 *             enabled: true,
 *             expiration: {
 *                 date: "2020-12-21",
 *             },
 *             filter: {
 *                 and: {
 *                     objectSizeGreaterThan: 1000,
 *                     objectSizeLessThan: 30000,
 *                     prefix: "path2/",
 *                     tags: {
 *                         key1: "value1",
 *                         key2: "value2",
 *                     },
 *                 },
 *             },
 *             id: "test_filter",
 *         },
 *     ],
 * });
 * const versioningBucket = new yandex.StorageBucket("versioningBucket", {
 *     acl: "private",
 *     bucket: "my-versioning-bucket",
 *     lifecycleRules: [{
 *         enabled: true,
 *         noncurrentVersionExpiration: {
 *             days: 90,
 *         },
 *         noncurrentVersionTransitions: [{
 *             days: 30,
 *             storageClass: "COLD",
 *         }],
 *         prefix: "config/",
 *     }],
 *     versioning: {
 *         enabled: true,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Using SSE
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const key_a = new yandex.KmsSymmetricKey("key-a", {
 *     description: "description for key",
 *     defaultAlgorithm: "AES_128",
 *     rotationPeriod: "8760h",
 * });
 * // equal to 1 year
 * const test = new yandex.StorageBucket("test", {
 *     bucket: "mybucket",
 *     serverSideEncryptionConfiguration: {
 *         rule: {
 *             applyServerSideEncryptionByDefault: {
 *                 kmsMasterKeyId: key_a.id,
 *                 sseAlgorithm: "aws:kms",
 *             },
 *         },
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Policy
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     policy: `{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Effect": "Allow",
 *       "Principal": "*",
 *       "Action": "s3:*",
 *       "Resource": [
 *         "arn:aws:s3:::my-policy-bucket/*",
 *         "arn:aws:s3:::my-policy-bucket"
 *       ]
 *     },
 *     {
 *       "Effect": "Deny",
 *       "Principal": "*",
 *       "Action": "s3:PutObject",
 *       "Resource": [
 *         "arn:aws:s3:::my-policy-bucket/*",
 *         "arn:aws:s3:::my-policy-bucket"
 *       ]
 *     }
 *   ]
 * }
 *
 * `,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Tagging
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     tags: {
 *         other_key: "other_value",
 *         test_key: "test_value",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Max Size
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     maxSize: 1048576,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Folder Id
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     folderId: "<folder_id>",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Anonymous Access Flags
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     anonymousAccessFlags: {
 *         configRead: true,
 *         list: false,
 *         read: true,
 *     },
 *     bucket: "my-policy-bucket",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket HTTPS Certificate
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     https: {
 *         certificateId: "<certificate_id_from_certificate_manager>",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Bucket Default Storage Class
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const storageBucket = new yandex.StorageBucket("storageBucket", {
 *     bucket: "my-policy-bucket",
 *     defaultStorageClass: "COLD",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### All settings example
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const logBucket = new yandex.StorageBucket("logBucket", {
 *     bucket: "my-tf-log-bucket",
 *     lifecycleRules: [{
 *         id: "cleanupoldlogs",
 *         enabled: true,
 *         expiration: {
 *             days: 365,
 *         },
 *     }],
 * });
 * const key_a = new yandex.KmsSymmetricKey("key-a", {
 *     description: "description for key",
 *     defaultAlgorithm: "AES_128",
 *     rotationPeriod: "8760h",
 * });
 * // equal to 1 year
 * const allSettings = new yandex.StorageBucket("allSettings", {
 *     bucket: "example-tf-settings-bucket",
 *     website: {
 *         indexDocument: "index.html",
 *         errorDocument: "error.html",
 *     },
 *     lifecycleRules: [
 *         {
 *             id: "test",
 *             enabled: true,
 *             prefix: "prefix/",
 *             expiration: {
 *                 days: 30,
 *             },
 *         },
 *         {
 *             id: "log",
 *             enabled: true,
 *             prefix: "log/",
 *             transitions: [{
 *                 days: 30,
 *                 storageClass: "COLD",
 *             }],
 *             expiration: {
 *                 days: 90,
 *             },
 *         },
 *         {
 *             id: "everything180",
 *             prefix: "",
 *             enabled: true,
 *             expiration: {
 *                 days: 180,
 *             },
 *         },
 *         {
 *             id: "cleanupoldversions",
 *             prefix: "config/",
 *             enabled: true,
 *             noncurrentVersionTransitions: [{
 *                 days: 30,
 *                 storageClass: "COLD",
 *             }],
 *             noncurrentVersionExpiration: {
 *                 days: 90,
 *             },
 *         },
 *         {
 *             id: "abortmultiparts",
 *             prefix: "",
 *             enabled: true,
 *             abortIncompleteMultipartUploadDays: 7,
 *         },
 *     ],
 *     corsRules: [{
 *         allowedHeaders: ["*"],
 *         allowedMethods: [
 *             "GET",
 *             "PUT",
 *         ],
 *         allowedOrigins: ["https://storage-cloud.example.com"],
 *         exposeHeaders: ["ETag"],
 *         maxAgeSeconds: 3000,
 *     }],
 *     versioning: {
 *         enabled: true,
 *     },
 *     serverSideEncryptionConfiguration: {
 *         rule: {
 *             applyServerSideEncryptionByDefault: {
 *                 kmsMasterKeyId: key_a.id,
 *                 sseAlgorithm: "aws:kms",
 *             },
 *         },
 *     },
 *     loggings: [{
 *         targetBucket: logBucket.id,
 *         targetPrefix: "tf-logs/",
 *     }],
 *     maxSize: 1024,
 *     folderId: "<folder_id>",
 *     defaultStorageClass: "COLD",
 *     anonymousAccessFlags: {
 *         read: true,
 *         list: true,
 *     },
 *     https: {
 *         certificateId: "<certificate_id>",
 *     },
 *     tags: {
 *         some_key: "some_value",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * Storage bucket can be imported using the `bucket`, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/storageBucket:StorageBucket bucket bucket-name
 * ```
 * ~> __Note:__ Terraform will import this resource with `force_destroy` set to
 * `false` in state. If you've set it to `true` in config, run `pulumi up` to
 * update the value set in state. If you delete this resource before updating the
 * value, objects in the bucket will not be destroyed.
 */
export class StorageBucket extends pulumi.CustomResource {
    /**
     * Get an existing StorageBucket resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: StorageBucketState, opts?: pulumi.CustomResourceOptions): StorageBucket {
        return new StorageBucket(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/storageBucket:StorageBucket';

    /**
     * Returns true if the given object is an instance of StorageBucket.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StorageBucket {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StorageBucket.__pulumiType;
    }

    /**
     * The access key to use when applying changes. If omitted, `storageAccessKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    public readonly accessKey!: pulumi.Output<string | undefined>;
    /**
     * The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply.
     * Defaults to `private`. Conflicts with `grant`.
     *
     * > **Note:** To change ACL after creation, service account with `storage.admin` role should be used, though this role is not necessary to create a bucket with any ACL.
     */
    public readonly acl!: pulumi.Output<string | undefined>;
    /**
     * Provides various access to objects.
     * See [bucket availability](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/bucket-availability)
     * for more infomation.
     */
    public readonly anonymousAccessFlags!: pulumi.Output<outputs.StorageBucketAnonymousAccessFlags>;
    public readonly bucket!: pulumi.Output<string>;
    /**
     * The bucket domain name.
     */
    public /*out*/ readonly bucketDomainName!: pulumi.Output<string>;
    /**
     * Creates a unique bucket name beginning with the specified prefix.
     * Conflicts with `bucket`.
     */
    public readonly bucketPrefix!: pulumi.Output<string | undefined>;
    /**
     * A rule of [Cross-Origin Resource Sharing](https://cloud.yandex.com/docs/storage/concepts/cors) (documented below).
     */
    public readonly corsRules!: pulumi.Output<outputs.StorageBucketCorsRule[] | undefined>;
    /**
     * Storage class which is used for storing objects by default.
     * Available values are: "STANDARD", "COLD", "ICE". Default is `"STANDARD"`.
     * See [storage class](https://cloud.yandex.com/en-ru/docs/storage/concepts/storage-class) for more inforamtion.
     */
    public readonly defaultStorageClass!: pulumi.Output<string>;
    /**
     * Allow to create bucket in different folder.
     *
     * > **NOTE:** it will try to create bucket using `IAM-token`, not using `access keys`.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * A boolean that indicates all objects should be deleted from the bucket so that the bucket can be destroyed without error. These objects are *not* recoverable.
     */
    public readonly forceDestroy!: pulumi.Output<boolean | undefined>;
    /**
     * An [ACL policy grant](https://cloud.yandex.com/docs/storage/concepts/acl#permissions-types). Conflicts with `acl`.
     */
    public readonly grants!: pulumi.Output<outputs.StorageBucketGrant[] | undefined>;
    /**
     * Manages https certificates for bucket. See [https](https://cloud.yandex.com/en-ru/docs/storage/operations/hosting/certificate) for more infomation.
     */
    public readonly https!: pulumi.Output<outputs.StorageBucketHttps | undefined>;
    /**
     * A configuration of [object lifecycle management](https://cloud.yandex.com/docs/storage/concepts/lifecycles) (documented below).
     */
    public readonly lifecycleRules!: pulumi.Output<outputs.StorageBucketLifecycleRule[] | undefined>;
    /**
     * A settings of [bucket logging](https://cloud.yandex.com/docs/storage/concepts/server-logs) (documented below).
     */
    public readonly loggings!: pulumi.Output<outputs.StorageBucketLogging[] | undefined>;
    /**
     * The size of bucket, in bytes. See [size limiting](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/limit-max-volume) for more information.
     */
    public readonly maxSize!: pulumi.Output<number | undefined>;
    /**
     * A configuration of [object lock management](https://cloud.yandex.com/en/docs/storage/concepts/object-lock) (documented below).
     */
    public readonly objectLockConfiguration!: pulumi.Output<outputs.StorageBucketObjectLockConfiguration | undefined>;
    public readonly policy!: pulumi.Output<string | undefined>;
    /**
     * The secret key to use when applying changes. If omitted, `storageSecretKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    public readonly secretKey!: pulumi.Output<string | undefined>;
    /**
     * A configuration of server-side encryption for the bucket (documented below)
     */
    public readonly serverSideEncryptionConfiguration!: pulumi.Output<outputs.StorageBucketServerSideEncryptionConfiguration | undefined>;
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A state of [versioning](https://cloud.yandex.com/docs/storage/concepts/versioning) (documented below)
     *
     * > **Note:** To manage `versioning` argument, service account with `storage.admin` role should be used.
     */
    public readonly versioning!: pulumi.Output<outputs.StorageBucketVersioning>;
    /**
     * A [website object](https://cloud.yandex.com/docs/storage/concepts/hosting) (documented below).
     */
    public readonly website!: pulumi.Output<outputs.StorageBucketWebsite | undefined>;
    /**
     * The domain of the website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    public readonly websiteDomain!: pulumi.Output<string>;
    /**
     * The website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    public readonly websiteEndpoint!: pulumi.Output<string>;

    /**
     * Create a StorageBucket resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: StorageBucketArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: StorageBucketArgs | StorageBucketState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as StorageBucketState | undefined;
            resourceInputs["accessKey"] = state ? state.accessKey : undefined;
            resourceInputs["acl"] = state ? state.acl : undefined;
            resourceInputs["anonymousAccessFlags"] = state ? state.anonymousAccessFlags : undefined;
            resourceInputs["bucket"] = state ? state.bucket : undefined;
            resourceInputs["bucketDomainName"] = state ? state.bucketDomainName : undefined;
            resourceInputs["bucketPrefix"] = state ? state.bucketPrefix : undefined;
            resourceInputs["corsRules"] = state ? state.corsRules : undefined;
            resourceInputs["defaultStorageClass"] = state ? state.defaultStorageClass : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["forceDestroy"] = state ? state.forceDestroy : undefined;
            resourceInputs["grants"] = state ? state.grants : undefined;
            resourceInputs["https"] = state ? state.https : undefined;
            resourceInputs["lifecycleRules"] = state ? state.lifecycleRules : undefined;
            resourceInputs["loggings"] = state ? state.loggings : undefined;
            resourceInputs["maxSize"] = state ? state.maxSize : undefined;
            resourceInputs["objectLockConfiguration"] = state ? state.objectLockConfiguration : undefined;
            resourceInputs["policy"] = state ? state.policy : undefined;
            resourceInputs["secretKey"] = state ? state.secretKey : undefined;
            resourceInputs["serverSideEncryptionConfiguration"] = state ? state.serverSideEncryptionConfiguration : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["versioning"] = state ? state.versioning : undefined;
            resourceInputs["website"] = state ? state.website : undefined;
            resourceInputs["websiteDomain"] = state ? state.websiteDomain : undefined;
            resourceInputs["websiteEndpoint"] = state ? state.websiteEndpoint : undefined;
        } else {
            const args = argsOrState as StorageBucketArgs | undefined;
            resourceInputs["accessKey"] = args ? args.accessKey : undefined;
            resourceInputs["acl"] = args ? args.acl : undefined;
            resourceInputs["anonymousAccessFlags"] = args ? args.anonymousAccessFlags : undefined;
            resourceInputs["bucket"] = args ? args.bucket : undefined;
            resourceInputs["bucketPrefix"] = args ? args.bucketPrefix : undefined;
            resourceInputs["corsRules"] = args ? args.corsRules : undefined;
            resourceInputs["defaultStorageClass"] = args ? args.defaultStorageClass : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["forceDestroy"] = args ? args.forceDestroy : undefined;
            resourceInputs["grants"] = args ? args.grants : undefined;
            resourceInputs["https"] = args ? args.https : undefined;
            resourceInputs["lifecycleRules"] = args ? args.lifecycleRules : undefined;
            resourceInputs["loggings"] = args ? args.loggings : undefined;
            resourceInputs["maxSize"] = args ? args.maxSize : undefined;
            resourceInputs["objectLockConfiguration"] = args ? args.objectLockConfiguration : undefined;
            resourceInputs["policy"] = args ? args.policy : undefined;
            resourceInputs["secretKey"] = args?.secretKey ? pulumi.secret(args.secretKey) : undefined;
            resourceInputs["serverSideEncryptionConfiguration"] = args ? args.serverSideEncryptionConfiguration : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["versioning"] = args ? args.versioning : undefined;
            resourceInputs["website"] = args ? args.website : undefined;
            resourceInputs["websiteDomain"] = args ? args.websiteDomain : undefined;
            resourceInputs["websiteEndpoint"] = args ? args.websiteEndpoint : undefined;
            resourceInputs["bucketDomainName"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["secretKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(StorageBucket.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering StorageBucket resources.
 */
export interface StorageBucketState {
    /**
     * The access key to use when applying changes. If omitted, `storageAccessKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    accessKey?: pulumi.Input<string>;
    /**
     * The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply.
     * Defaults to `private`. Conflicts with `grant`.
     *
     * > **Note:** To change ACL after creation, service account with `storage.admin` role should be used, though this role is not necessary to create a bucket with any ACL.
     */
    acl?: pulumi.Input<string>;
    /**
     * Provides various access to objects.
     * See [bucket availability](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/bucket-availability)
     * for more infomation.
     */
    anonymousAccessFlags?: pulumi.Input<inputs.StorageBucketAnonymousAccessFlags>;
    bucket?: pulumi.Input<string>;
    /**
     * The bucket domain name.
     */
    bucketDomainName?: pulumi.Input<string>;
    /**
     * Creates a unique bucket name beginning with the specified prefix.
     * Conflicts with `bucket`.
     */
    bucketPrefix?: pulumi.Input<string>;
    /**
     * A rule of [Cross-Origin Resource Sharing](https://cloud.yandex.com/docs/storage/concepts/cors) (documented below).
     */
    corsRules?: pulumi.Input<pulumi.Input<inputs.StorageBucketCorsRule>[]>;
    /**
     * Storage class which is used for storing objects by default.
     * Available values are: "STANDARD", "COLD", "ICE". Default is `"STANDARD"`.
     * See [storage class](https://cloud.yandex.com/en-ru/docs/storage/concepts/storage-class) for more inforamtion.
     */
    defaultStorageClass?: pulumi.Input<string>;
    /**
     * Allow to create bucket in different folder.
     *
     * > **NOTE:** it will try to create bucket using `IAM-token`, not using `access keys`.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A boolean that indicates all objects should be deleted from the bucket so that the bucket can be destroyed without error. These objects are *not* recoverable.
     */
    forceDestroy?: pulumi.Input<boolean>;
    /**
     * An [ACL policy grant](https://cloud.yandex.com/docs/storage/concepts/acl#permissions-types). Conflicts with `acl`.
     */
    grants?: pulumi.Input<pulumi.Input<inputs.StorageBucketGrant>[]>;
    /**
     * Manages https certificates for bucket. See [https](https://cloud.yandex.com/en-ru/docs/storage/operations/hosting/certificate) for more infomation.
     */
    https?: pulumi.Input<inputs.StorageBucketHttps>;
    /**
     * A configuration of [object lifecycle management](https://cloud.yandex.com/docs/storage/concepts/lifecycles) (documented below).
     */
    lifecycleRules?: pulumi.Input<pulumi.Input<inputs.StorageBucketLifecycleRule>[]>;
    /**
     * A settings of [bucket logging](https://cloud.yandex.com/docs/storage/concepts/server-logs) (documented below).
     */
    loggings?: pulumi.Input<pulumi.Input<inputs.StorageBucketLogging>[]>;
    /**
     * The size of bucket, in bytes. See [size limiting](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/limit-max-volume) for more information.
     */
    maxSize?: pulumi.Input<number>;
    /**
     * A configuration of [object lock management](https://cloud.yandex.com/en/docs/storage/concepts/object-lock) (documented below).
     */
    objectLockConfiguration?: pulumi.Input<inputs.StorageBucketObjectLockConfiguration>;
    policy?: pulumi.Input<string>;
    /**
     * The secret key to use when applying changes. If omitted, `storageSecretKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    secretKey?: pulumi.Input<string>;
    /**
     * A configuration of server-side encryption for the bucket (documented below)
     */
    serverSideEncryptionConfiguration?: pulumi.Input<inputs.StorageBucketServerSideEncryptionConfiguration>;
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A state of [versioning](https://cloud.yandex.com/docs/storage/concepts/versioning) (documented below)
     *
     * > **Note:** To manage `versioning` argument, service account with `storage.admin` role should be used.
     */
    versioning?: pulumi.Input<inputs.StorageBucketVersioning>;
    /**
     * A [website object](https://cloud.yandex.com/docs/storage/concepts/hosting) (documented below).
     */
    website?: pulumi.Input<inputs.StorageBucketWebsite>;
    /**
     * The domain of the website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    websiteDomain?: pulumi.Input<string>;
    /**
     * The website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    websiteEndpoint?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a StorageBucket resource.
 */
export interface StorageBucketArgs {
    /**
     * The access key to use when applying changes. If omitted, `storageAccessKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    accessKey?: pulumi.Input<string>;
    /**
     * The [predefined ACL](https://cloud.yandex.com/docs/storage/concepts/acl#predefined_acls) to apply.
     * Defaults to `private`. Conflicts with `grant`.
     *
     * > **Note:** To change ACL after creation, service account with `storage.admin` role should be used, though this role is not necessary to create a bucket with any ACL.
     */
    acl?: pulumi.Input<string>;
    /**
     * Provides various access to objects.
     * See [bucket availability](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/bucket-availability)
     * for more infomation.
     */
    anonymousAccessFlags?: pulumi.Input<inputs.StorageBucketAnonymousAccessFlags>;
    bucket?: pulumi.Input<string>;
    /**
     * Creates a unique bucket name beginning with the specified prefix.
     * Conflicts with `bucket`.
     */
    bucketPrefix?: pulumi.Input<string>;
    /**
     * A rule of [Cross-Origin Resource Sharing](https://cloud.yandex.com/docs/storage/concepts/cors) (documented below).
     */
    corsRules?: pulumi.Input<pulumi.Input<inputs.StorageBucketCorsRule>[]>;
    /**
     * Storage class which is used for storing objects by default.
     * Available values are: "STANDARD", "COLD", "ICE". Default is `"STANDARD"`.
     * See [storage class](https://cloud.yandex.com/en-ru/docs/storage/concepts/storage-class) for more inforamtion.
     */
    defaultStorageClass?: pulumi.Input<string>;
    /**
     * Allow to create bucket in different folder.
     *
     * > **NOTE:** it will try to create bucket using `IAM-token`, not using `access keys`.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A boolean that indicates all objects should be deleted from the bucket so that the bucket can be destroyed without error. These objects are *not* recoverable.
     */
    forceDestroy?: pulumi.Input<boolean>;
    /**
     * An [ACL policy grant](https://cloud.yandex.com/docs/storage/concepts/acl#permissions-types). Conflicts with `acl`.
     */
    grants?: pulumi.Input<pulumi.Input<inputs.StorageBucketGrant>[]>;
    /**
     * Manages https certificates for bucket. See [https](https://cloud.yandex.com/en-ru/docs/storage/operations/hosting/certificate) for more infomation.
     */
    https?: pulumi.Input<inputs.StorageBucketHttps>;
    /**
     * A configuration of [object lifecycle management](https://cloud.yandex.com/docs/storage/concepts/lifecycles) (documented below).
     */
    lifecycleRules?: pulumi.Input<pulumi.Input<inputs.StorageBucketLifecycleRule>[]>;
    /**
     * A settings of [bucket logging](https://cloud.yandex.com/docs/storage/concepts/server-logs) (documented below).
     */
    loggings?: pulumi.Input<pulumi.Input<inputs.StorageBucketLogging>[]>;
    /**
     * The size of bucket, in bytes. See [size limiting](https://cloud.yandex.com/en-ru/docs/storage/operations/buckets/limit-max-volume) for more information.
     */
    maxSize?: pulumi.Input<number>;
    /**
     * A configuration of [object lock management](https://cloud.yandex.com/en/docs/storage/concepts/object-lock) (documented below).
     */
    objectLockConfiguration?: pulumi.Input<inputs.StorageBucketObjectLockConfiguration>;
    policy?: pulumi.Input<string>;
    /**
     * The secret key to use when applying changes. If omitted, `storageSecretKey` specified in
     * provider config (explicitly or within `sharedCredentialsFile`) is used.
     */
    secretKey?: pulumi.Input<string>;
    /**
     * A configuration of server-side encryption for the bucket (documented below)
     */
    serverSideEncryptionConfiguration?: pulumi.Input<inputs.StorageBucketServerSideEncryptionConfiguration>;
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A state of [versioning](https://cloud.yandex.com/docs/storage/concepts/versioning) (documented below)
     *
     * > **Note:** To manage `versioning` argument, service account with `storage.admin` role should be used.
     */
    versioning?: pulumi.Input<inputs.StorageBucketVersioning>;
    /**
     * A [website object](https://cloud.yandex.com/docs/storage/concepts/hosting) (documented below).
     */
    website?: pulumi.Input<inputs.StorageBucketWebsite>;
    /**
     * The domain of the website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    websiteDomain?: pulumi.Input<string>;
    /**
     * The website endpoint, if the bucket is configured with a website. If not, this will be an empty string.
     */
    websiteEndpoint?: pulumi.Input<string>;
}
