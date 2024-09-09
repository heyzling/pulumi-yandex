# Yandex Cloud Provider

The Yandex Cloud Resource Provider lets you manage Yandex Cloud resources.

## Installing

This package is available in many languages in the standard packaging formats.

### Node.js (Java/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

    $ npm install @pulumi/yandex

or `yarn`:

    $ yarn add @pulumi/yandex

### Python

To use from Python, install using `pip`:

    $ pip install pulumi_yandex

### Go

To use from Go, use `go get` to grab the latest version of the library

    $ go get github.com/pulumi/pulumi-yandex/sdk

### .NET

To use from .NET, install using `dotnet add package`:

    $ dotnet add package Pulumi.Yandex

## Configuration

The following configuration points are available:

- `yandex:token` - (Optional) Security token or IAM token used for authentication in Yandex.Cloud. This can also be 
  specified using environment variable `YC_TOKEN`. [Learn how to create an IAM token](https://cloud.yandex.ru/docs/iam/operations/iam-token/create).
- `yandex:serviceAccountKeyFile` - (Optional) Contains either a path to or the contents of the Service Account file in
  JSON format. This can also be specified using environment variable `YC_SERVICE_ACCOUNT_KEY_FILE`.
  [learn how to create a service account key file](https://cloud.yandex.com/docs/iam/operations/iam-token/create-for-sa#keys-create)
- `yandex:cloudId` - (Required) The ID of the cloud to apply any resources to. This can also be specified using
  environment variable `YC_CLOUD_ID`.
- `yandex:folderId` - (Required) The ID of the folder to operate under, if not specified by a given resource. This can
  also be specified using environment variable `YC_FOLDER_ID`.
- `yandex:zone` - (Optional) The default availability zone to operate under, if not specified by a given resource. This
can also be specified using environment variable `YC_ZONE`.
- `yandex:maxRetries` - (Optional) This is the maximum number of times an API call is retried, in the case where requests
  are being throttled or experiencing transient failures. The delay between the subsequent API calls increases exponentially.
- `yandex:storageAccessKey` - (Optional) Yandex.Cloud storage service access key, which is used when a storage data/resource
  doesn't have an access key explicitly specified. This can also be specified using environment variable `YC_STORAGE_ACCESS_KEY`.
- `yandex:storageSecretKey` - (Optional)  Yandex.Cloud storage service secret key, which is used when a storage data/resource
  doesn't have a secret key explicitly specified. This can also be specified using environment variable `YC_STORAGE_SECRET_KEY`.
- `yandex:storageAccessKey` - (Optional) Yandex.Cloud storage service access key, which is used when a storage data/resource
  doesn't have an access key explicitly specified. This can also be specified using environment variable `YC_STORAGE_ACCESS_KEY`.
- `yandex:ymqAccessKey` - (Optional)  Yandex.Cloud Message Queue service access key, which is used when a YMQ queue resource
  doesn't have an access key explicitly specified. This can also be specified using environment variable `YC_MESSAGE_QUEUE_ACCESS_KEY`.
- `yandex:ymqSecretKey` - (Optional) Yandex.Cloud Message Queue service secret key, which is used when a YMQ queue resource
  doesn't have a secret key explicitly specified. This can also be specified using environment variable `YC_MESSAGE_QUEUE_SECRET_KEY`.

## Reference

For further information, please visit [the yandex provider docs](https://www.pulumi.com/docs/intro/cloud-providers/yandex)
or for detailed reference documentation, please visit [the API docs](https://www.pulumi.com/docs/reference/pkg/yandex).

