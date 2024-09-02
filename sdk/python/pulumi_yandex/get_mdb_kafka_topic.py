# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetMdbKafkaTopicResult',
    'AwaitableGetMdbKafkaTopicResult',
    'get_mdb_kafka_topic',
    'get_mdb_kafka_topic_output',
]

@pulumi.output_type
class GetMdbKafkaTopicResult:
    """
    A collection of values returned by getMdbKafkaTopic.
    """
    def __init__(__self__, cluster_id=None, id=None, name=None, partitions=None, replication_factor=None, topic_configs=None):
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if partitions and not isinstance(partitions, int):
            raise TypeError("Expected argument 'partitions' to be a int")
        pulumi.set(__self__, "partitions", partitions)
        if replication_factor and not isinstance(replication_factor, int):
            raise TypeError("Expected argument 'replication_factor' to be a int")
        pulumi.set(__self__, "replication_factor", replication_factor)
        if topic_configs and not isinstance(topic_configs, list):
            raise TypeError("Expected argument 'topic_configs' to be a list")
        pulumi.set(__self__, "topic_configs", topic_configs)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> str:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def partitions(self) -> int:
        return pulumi.get(self, "partitions")

    @property
    @pulumi.getter(name="replicationFactor")
    def replication_factor(self) -> int:
        return pulumi.get(self, "replication_factor")

    @property
    @pulumi.getter(name="topicConfigs")
    def topic_configs(self) -> Sequence['outputs.GetMdbKafkaTopicTopicConfigResult']:
        return pulumi.get(self, "topic_configs")


class AwaitableGetMdbKafkaTopicResult(GetMdbKafkaTopicResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMdbKafkaTopicResult(
            cluster_id=self.cluster_id,
            id=self.id,
            name=self.name,
            partitions=self.partitions,
            replication_factor=self.replication_factor,
            topic_configs=self.topic_configs)


def get_mdb_kafka_topic(cluster_id: Optional[str] = None,
                        name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetMdbKafkaTopicResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['clusterId'] = cluster_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getMdbKafkaTopic:getMdbKafkaTopic', __args__, opts=opts, typ=GetMdbKafkaTopicResult).value

    return AwaitableGetMdbKafkaTopicResult(
        cluster_id=pulumi.get(__ret__, 'cluster_id'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        partitions=pulumi.get(__ret__, 'partitions'),
        replication_factor=pulumi.get(__ret__, 'replication_factor'),
        topic_configs=pulumi.get(__ret__, 'topic_configs'))


@_utilities.lift_output_func(get_mdb_kafka_topic)
def get_mdb_kafka_topic_output(cluster_id: Optional[pulumi.Input[str]] = None,
                               name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetMdbKafkaTopicResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
