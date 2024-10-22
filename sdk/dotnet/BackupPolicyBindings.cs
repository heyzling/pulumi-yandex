// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Allows management
    /// of [Yandex.Cloud Attach and Detach VM](https://yandex.cloud/docs/backup/operations/policy-vm/attach-and-detach-vm).
    /// 
    /// &gt; **NOTE:\_** Cloud Backup Provider must be activated in order to manipulate with policies.
    /// Active it either by UI Console or by `yc` command.
    /// 
    /// ## Example Usage
    /// 
    /// The configuration of Backup Policy Bindings consists of the following attributes:
    /// 
    /// - `policy_id`
    /// - `instance_id`
    /// 
    /// Please, note the basic example below:
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var testSa = new Yandex.IamServiceAccount("testSa");
    /// 
    ///     var testBinding = new Yandex.ResourcemanagerFolderIamMember("testBinding", new()
    ///     {
    ///         FolderId = testSa.FolderId,
    ///         Role = "backup.editor",
    ///         Member = testSa.Id.Apply(id =&gt; $"serviceAccount:{id}"),
    ///     });
    /// 
    ///     var testBackupNetwork = new Yandex.VpcNetwork("testBackupNetwork");
    /// 
    ///     var testBackupSubnet = new Yandex.VpcSubnet("testBackupSubnet", new()
    ///     {
    ///         Zone = "ru-central1-a",
    ///         NetworkId = testBackupNetwork.Id,
    ///         V4CidrBlocks = new[]
    ///         {
    ///             "192.168.0.0/24",
    ///         },
    ///     });
    /// 
    ///     // https://yandex.cloud/ru/docs/backup/concepts/vm-connection#vm-network-access
    ///     var testBackupSecurityGroup = new Yandex.VpcSecurityGroup("testBackupSecurityGroup", new()
    ///     {
    ///         NetworkId = testBackupNetwork.Id,
    ///         Egresses = new[]
    ///         {
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "TCP",
    ///                 FromPort = 7770,
    ///                 ToPort = 7800,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "84.47.172.0/24",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "TCP",
    ///                 Port = 443,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "213.180.204.0/24",
    ///                     "213.180.193.0/24",
    ///                     "178.176.128.0/24",
    ///                     "84.201.181.0/24",
    ///                     "84.47.172.0/24",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "TCP",
    ///                 Port = 80,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "213.180.204.0/24",
    ///                     "213.180.193.0/24",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "TCP",
    ///                 Port = 8443,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "84.47.172.0/24",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "TCP",
    ///                 Port = 44445,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "51.250.1.0/24",
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var ubuntu = Yandex.GetComputeImage.Invoke(new()
    ///     {
    ///         Family = "ubuntu-2004-lts",
    ///     });
    /// 
    ///     var testBackupCompute = new Yandex.ComputeInstance("testBackupCompute", new()
    ///     {
    ///         PlatformId = "standard-v1",
    ///         Zone = "ru-central1-a",
    ///         ServiceAccountId = testSa.Id,
    ///         NetworkInterfaces = new[]
    ///         {
    ///             new Yandex.Inputs.ComputeInstanceNetworkInterfaceArgs
    ///             {
    ///                 SubnetId = testBackupSubnet.Id,
    ///                 SecurityGroupIds = new[]
    ///                 {
    ///                     testBackupSecurityGroup.Id,
    ///                 },
    ///                 Nat = true,
    ///             },
    ///         },
    ///         BootDisk = new Yandex.Inputs.ComputeInstanceBootDiskArgs
    ///         {
    ///             InitializeParams = new Yandex.Inputs.ComputeInstanceBootDiskInitializeParamsArgs
    ///             {
    ///                 ImageId = ubuntu.Apply(getComputeImageResult =&gt; getComputeImageResult.Id),
    ///             },
    ///         },
    ///         Resources = new Yandex.Inputs.ComputeInstanceResourcesArgs
    ///         {
    ///             Cores = 2,
    ///             Memory = 4,
    ///         },
    ///         Metadata = 
    ///         {
    ///             { "user-data", @"#cloud-config
    /// packages:
    ///   - curl
    ///   - perl
    ///   - jq
    /// runcmd:
    ///   - curl https://storage.yandexcloud.net/backup-distributions/agent_installer.sh | sudo bash
    /// " },
    ///         },
    ///     });
    /// 
    ///     var testBackupPolicy = Yandex.GetBackupPolicy.Invoke(new()
    ///     {
    ///         Name = "Default daily",
    ///     });
    /// 
    ///     var testBackupBinding = new Yandex.BackupPolicyBindings("testBackupBinding", new()
    ///     {
    ///         InstanceId = testBackupCompute.Id,
    ///         PolicyId = testBackupPolicy.Apply(getBackupPolicyResult =&gt; getBackupPolicyResult.Id),
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/backupPolicyBindings:BackupPolicyBindings")]
    public partial class BackupPolicyBindings : global::Pulumi.CustomResource
    {
        /// <summary>
        /// (Computed) - Creation timestamp of the Yandex Cloud Policy Bindings.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// (Computed) - Boolean flag that specifies whether the policy application is enabled. May be `false`
        /// if `processing` flag is `true`.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// — Compute Cloud instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// — Backup Policy ID.
        /// </summary>
        [Output("policyId")]
        public Output<string> PolicyId { get; private set; } = null!;

        /// <summary>
        /// (Computed) - Boolean flag that specifies whether the policy is in the process of binding to an instance.
        /// </summary>
        [Output("processing")]
        public Output<bool> Processing { get; private set; } = null!;


        /// <summary>
        /// Create a BackupPolicyBindings resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BackupPolicyBindings(string name, BackupPolicyBindingsArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/backupPolicyBindings:BackupPolicyBindings", name, args ?? new BackupPolicyBindingsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BackupPolicyBindings(string name, Input<string> id, BackupPolicyBindingsState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/backupPolicyBindings:BackupPolicyBindings", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing BackupPolicyBindings resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BackupPolicyBindings Get(string name, Input<string> id, BackupPolicyBindingsState? state = null, CustomResourceOptions? options = null)
        {
            return new BackupPolicyBindings(name, id, state, options);
        }
    }

    public sealed class BackupPolicyBindingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// — Compute Cloud instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// — Backup Policy ID.
        /// </summary>
        [Input("policyId", required: true)]
        public Input<string> PolicyId { get; set; } = null!;

        public BackupPolicyBindingsArgs()
        {
        }
        public static new BackupPolicyBindingsArgs Empty => new BackupPolicyBindingsArgs();
    }

    public sealed class BackupPolicyBindingsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Computed) - Creation timestamp of the Yandex Cloud Policy Bindings.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// (Computed) - Boolean flag that specifies whether the policy application is enabled. May be `false`
        /// if `processing` flag is `true`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// — Compute Cloud instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// — Backup Policy ID.
        /// </summary>
        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        /// <summary>
        /// (Computed) - Boolean flag that specifies whether the policy is in the process of binding to an instance.
        /// </summary>
        [Input("processing")]
        public Input<bool>? Processing { get; set; }

        public BackupPolicyBindingsState()
        {
        }
        public static new BackupPolicyBindingsState Empty => new BackupPolicyBindingsState();
    }
}
