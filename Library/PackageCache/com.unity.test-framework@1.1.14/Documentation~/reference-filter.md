                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Filter
The filter class provides the [TestRunnerApi](./reference-test-runner-api.md) with a specification of what tests to run when [running tests programmatically](./extension-run-tests.md).

## Fields

| Syntax                        | Description                                                  |
| ----------------------------- | ------------------------------------------------------------ |
| `TestMode testMode`           | An enum flag that specifies if **Edit Mode** or **Play Mode** tests should run. Applying both Edit Mode and Play Mode is currently not supported when running tests from the API. |
| `string[] testNames`          | The full name of the tests to match the filter. This is usually in the format `FixtureName.TestName`. If the test has test arguments, then include them in parenthesis. E.g. `MyTestClass2.MyTestWithMultipleValues(1)`. |
| `string[] groupNames`         | The same as `testNames`, except that it allows for Regex. This is useful for running specific fixtures or namespaces. E.g. `"^MyNamespace\\."` Runs any tests where the top namespace is `MyNamespace`. |
| `string[] categoryNames`      | The name of a [Category](htt