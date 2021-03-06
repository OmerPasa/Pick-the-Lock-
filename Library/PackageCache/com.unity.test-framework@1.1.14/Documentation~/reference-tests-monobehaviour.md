                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # MonoBehaviour tests

`MonoBehaviourTest` is a [coroutine](https://docs.unity3d.com/ScriptReference/Coroutine.html) and a helper for writing [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) tests. 

Yield a `MonoBehaviourTest` when using the `UnityTest` attribute to instantiate the `MonoBehaviour` you wish to test and wait for it to finish running. Implement the `IMonoBehaviourTest` interface on the `MonoBehaviour` to state when the test completes.

## Example

```c#
[UnityTest]
public IEnumerator MonoBehaviourTest_Works()
{
    yield return new MonoBehaviourTest<MyMonoBehaviourTest>();
}

public class MyMonoBehaviourTest : MonoBehaviour, IMonoBehaviourTest
{
    private int frameCount;
    public bool IsTestFinished
    {
        get { return frameCount > 10; }
    }

     void Update()
     {
        frameCount++;
     }
}
```

## MonoBehaviourTest&lt;T&gt;

This is a wrapper that allows running tests on `MonoBehaviour` scripts. Inherits from [CustomYieldInstruction](https://docs.unity3d.com/ScriptReference/CustomYieldInstruction.html).

### Properties

| Syntax                  | Description                                                  |
| ----------------------- | ------------------------------------------------------------ |
| `T component`           | A `MonoBehaviour` component created for the test and attached to the test’s [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html). |
| `GameObject gameObject` | A `GameObj