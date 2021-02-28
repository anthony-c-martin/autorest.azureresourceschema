
# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

# IMPORTANT NOTE

This project uses a git submodule for dependent code. When cloning this repository use `git clone --recursive ...` or perform a `git submodule init ` after the project is cloned.



# AutoRest extension configuration

```yaml
version: 3.0.6320
use-extension:
  "@autorest/modelerfour": "4.16.2"

modelerfour:
  # this runs a pre-namer step to clean up names
  prenamer: true
  # this will flatten modelers marked with 'x-ms-client-flatten'
  flatten-models: true
  # this will flatten parameters marked with 'x-ms-client-flatten'
  flatten-payloads: true
  # this will make the content-type parameter always specified
  always-create-content-type-parameter: true
  # enables parameter grouping via x-ms-parameter-grouping
  group-parameters: true
  # don't return errors for deduplication failures
  additional-checks: false
  lenient-model-deduplication: true

pipeline:
  azureresourceschema: # <- name of plugin
    input: modelerfour/identity
    output-artifact: azureresourceschema-files

  azureresourceschema/emitter:
    input: azureresourceschema
    scope: azureresourceschema-scope/emitter

azureresourceschema-scope/emitter:
  input-artifact: azureresourceschema-files

output-artifact: azureresourceschema-files
```