                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Custom constraints 

`NUnit` allows you to write test assertions in a more descriptive and human readable way using the [Assert.That](https://github.com/nunit/docs/wiki/Assertions) mechanism, where the first parameter is an object under test and the second parameter describes conditions that the object has to meet. 

## Is

We’ve extended `NUnit` API with a custom constraint type and declared an overlay `Is` class. To resolve ambiguity between the original implementation and the custom one you must explicitly declare it with a using statement or via addressing through the full type name `UnityEngine.TestTools.Constraints.Is`.

### Static Methods

| Syntax               | Description                                                  |
| -------------------- | ---------------------------------------------