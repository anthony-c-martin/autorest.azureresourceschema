
###############################################
# LEGACY 
# Instead: have bunch of configuration files sitting in a well-known spot, discover them, feed them to AutoRest, done.

regenExpected = (opts,done) ->
  keys = Object.getOwnPropertyNames(opts.mappings)
  instances = 0

  for kkey in keys
    value = opts.mappings[kkey]
    instances += value.tags.length

  for kkey in keys
    value = opts.mappings[kkey]
    key = kkey.trim();

    args = [
      # uncomment for local debugging "--#{opts.language}.debugger=true",
      "--#{opts.language}",
      "--output-folder=#{__dirname}/../#{opts.outputDir}/#{key}",
      "--title=none"
    ]

    args.push("#{opts.inputBaseDir}/#{value.basePath}/readme.md")

    for tag in value.tags
      args2 = args.slice()
      if tag == 'multiapi'
        args2.push("--multiapi")
      else
        args2.push("--tag=#{tag}")
      autorest args2,() =>
        instances--
        return done() if instances is 0

task 'regenerate', '', (done) ->
  regenExpected {
    'outputDir': 'generated',
    'inputBaseDir': "#{__dirname}/../../azure-rest-api-specs/specification",
    'mappings': {
      'Microsoft.AlertsManagement': { basePath: 'alertsmanagement/resource-manager', tags: ['multiapi'] },
      'Microsoft.Attestation': { basePath: 'attestation/resource-manager', tags: ['multiapi'] },
      'Microsoft.Automation': { basePath: 'automation/resource-manager', tags: ['multiapi'] },
      'Microsoft.AzureData': { basePath: 'azuredata/resource-manager', tags: ['multiapi'] },
      'Microsoft.Blockchain': { basePath: 'blockchain/resource-manager', tags: ['multiapi'] },
      'Microsoft.BotService': { basePath: 'botservice/resource-manager', tags: ['multiapi'] },
      'Microsoft.CognitiveServices': { basePath: 'cognitiveservices/resource-manager', tags: ['multiapi'] },
      'Microsoft.Consumption': { basePath: 'consumption/resource-manager', tags: ['multiapi'] },
      'Microsoft.ContainerInstance': { basePath: 'containerinstance/resource-manager', tags: ['multiapi'] },
      'Microsoft.DocumentDB': { basePath: 'cosmos-db/resource-manager', tags: ['multiapi'] },
      'Microsoft.ContainerRegistry': { basePath: 'containerregistry/resource-manager', tags: ['multiapi'] },
      'Microsoft.CustomProviders': { basePath: 'customproviders/resource-manager', tags: ['multiapi'] },
      'Microsoft.DataBox': { basePath: 'databox/resource-manager', tags: ['multiapi'] },
      'Microsoft.ContainerService': { basePath: 'containerservice/resource-manager', tags: ['multiapi'] },
      'Microsoft.DataBoxEdge': { basePath: 'databoxedge/resource-manager', tags: ['multiapi'] },
      'Microsoft.Databricks': { basePath: 'databricks/resource-manager', tags: ['multiapi'] },
      'Microsoft.DataFactory': { basePath: 'datafactory/resource-manager', tags: ['multiapi'] },
      'Microsoft.DataShare': { basePath: 'datashare/resource-manager', tags: ['multiapi'] },
      'Microsoft.DeploymentManager': { basePath: 'deploymentmanager/resource-manager', tags: ['multiapi'] },
      'Microsoft.DevOps': { basePath: 'devops/resource-manager', tags: ['multiapi'] },
      'Microsoft.DevSpaces': { basePath: 'devspaces/resource-manager', tags: ['multiapi'] },
      'Microsoft.DevTestLab': { basePath: 'devtestlabs/resource-manager', tags: ['multiapi'] },
      'Microsoft.HDInsight': { basePath: 'hdinsight/resource-manager', tags: ['multiapi'] },
      'Microsoft.EnterpriseKnowledgeGraph': { basePath: 'EnterpriseKnowledgeGraph/resource-manager', tags: ['multiapi'] },
      'Microsoft.AAD': { basePath: 'domainservices/resource-manager', tags: ['multiapi'] },
      'Microsoft.EventHub': { basePath: 'eventhub/resource-manager', tags: ['multiapi'] },
      'Microsoft.HanaOnAzure': { basePath: 'hanaonazure/resource-manager', tags: ['multiapi'] },
      'Microsoft.HybridData': { basePath: 'hybriddatamanager/resource-manager', tags: ['multiapi'] },
      'Microsoft.IoTSpaces': { basePath: 'iotspaces/resource-manager', tags: ['multiapi'] },
      'Microsoft.LabServices': { basePath: 'labservices/resource-manager', tags: ['multiapi'] },
      'Microsoft.Logic': { basePath: 'logic/resource-manager', tags: ['multiapi'] },
      'Microsoft.MachineLearningCompute': { basePath: 'machinelearningcompute/resource-manager', tags: ['multiapi'] },
      'Microsoft.Maintenance': { basePath: 'maintenance/resource-manager', tags: ['multiapi'] },
      'Microsoft.ManagedNetwork': { basePath: 'managednetwork/resource-manager', tags: ['multiapi'] },
      'Microsoft.DBforMariaDB': { basePath: 'mariadb/resource-manager', tags: ['multiapi'] },
      'Microsoft.DBforMySQL': { basePath: 'mysql/resource-manager', tags: ['multiapi'] },
      'Microsoft.PolicyInsights': { basePath: 'policyinsights/resource-manager', tags: ['multiapi'] },
      'Microsoft.Peering': { basePath: 'peering/resource-manager', tags: ['multiapi'] },
      'Microsoft.Portal': { basePath: 'portal/resource-manager', tags: ['multiapi'] },
      'Microsoft.DBforPostgreSQL': { basePath: 'postgresql/resource-manager', tags: ['multiapi'] },
      'Microsoft.Relay': { basePath: 'relay/resource-manager', tags: ['multiapi'] },
      'Microsoft.ServiceBus': { basePath: 'servicebus/resource-manager', tags: ['multiapi'] },
      # 'Microsoft.ServiceFabric': { basePath: 'servicefabric/resource-manager', tags: ['multiapi'] },
      'Microsoft.ServiceFabricMesh': { basePath: 'servicefabricmesh/resource-manager', tags: ['multiapi'] },
      'Microsoft.Sql': { basePath: 'sql/resource-manager', tags: ['multiapi'] },
      'Microsoft.SqlVirtualMachine': { basePath: 'sqlvirtualmachine/resource-manager', tags: ['multiapi'] },
      'Microsoft.StorageCache': { basePath: 'storagecache/resource-manager', tags: ['multiapi'] },
      'Microsoft.StorageSync': { basePath: 'storagesync/resource-manager', tags: ['multiapi'] },
      'Microsoft.VMwareCloudSimple': { basePath: 'vmwarecloudsimple/resource-manager', tags: ['multiapi'] },
      'Microsoft.TimeSeriesInsights': { basePath: 'timeseriesinsights/resource-manager', tags: ['multiapi'] },
      'Microsoft.VirtualMachineImages': { basePath: 'imagebuilder/resource-manager', tags: ['multiapi'] },
      'Microsoft.WindowsIoT': { basePath: 'windowsiot/resource-manager', tags: ['multiapi'] },
      'Microsoft.Web': { basePath: 'web/resource-manager', tags: ['multiapi'] },
      'Microsoft.Compute': { basePath: 'compute/resource-manager', tags: ['multiapi'] },
      'Microsoft.Storage': { basePath: 'storage/resource-manager', tags: ['multiapi'] },
      'Microsoft.Network': { basePath: 'network/resource-manager', tags: ['multiapi'] },
    },
    'language': 'azureresourceschema'
  },done
  return null
