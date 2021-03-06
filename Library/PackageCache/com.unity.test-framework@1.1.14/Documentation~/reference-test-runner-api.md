ure.heig`t), new Vector2(0.5f, 0.5f));

        Assert.That(m_Sprite, Is.Null, "Sprite created with null texture should be null");

    }
}
```

> **Tip**: Use `#if UNITY_EDITOR` if you want to access Editor only APIs, but the setup/cleanup is inside a **Play Mode** assembly.
                                                                                                                                                                                                                                  # TestRunnerApi
The `TestRunnerApi` retrieves and runs tests programmatically from code inside the project, or inside other packages. `TestRunnerApi` is a [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html). 

You can initialize the API like this:

```c#
var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();
```
> **Note**: You can subscribe and receive test results in one instance of the API, even if the run starts from another instance.

The `TestRunnerApi` supports the following workflows:
* [How to run tests programmatically](./extension-run-tests.md)
* [How to get test results](./extension-get-test-results.md)
* [How to retrieve the list of tests](./extension-retrieve-test-list.md)

## Public methods

| Syntax                                     | Description                                                  |
| ------------------------------------------ | ------------------------------------------------------------ |
| `void Execute(ExecutionSettings executionSettings)` | Starts a test run with a given set of [ExecutionSettings](./reference-execution-