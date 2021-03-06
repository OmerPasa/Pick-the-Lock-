USBC�y:�     
* 5   �       �---------------------------------------------- |
| `LogType type`  | A type of log to expect. It can take one of the [LogType enum](https://docs.unity3d.com/ScriptReference/LogType.html) values. |
| `Regex message` | A regular expression pattern to match the expected message.  |                                                                                                                                                                                                       # Vector3EqualityComparer

Use this class to compare two [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) objects for equality with `NUnit` constraints. Call `Vector3EqualityComparer.Instance` comparer to perform a comparison with the default calculation error value 0.0001f. To specify a different error value, use the [one argument constructor](#constructors) to instantiate a new comparer.

## Static properties

| Syntax     | Description                                                  |
| ---------- | ------------------------------------------------------------ |
| `Instance` | A comparer instance with the default calculation error value equal to 0.0001f. |

## Constructors

| Syntax                                        | Description                                    |
| --------------------------------------------- | ---------------------------------------------- |
| `Vector3EqualityComparer(float allowedError)` | Creates an instance with a custom error value. |

## Public methods

| Syntax                                          | Description                                                  |
| ----------------------------------------------- | ------------------------------------------------------------ |
| `bool Equals(Vector3 expected, Vector3 actual)` | Compares the `actual` and `expected` `Vector3` objects for equality using [Utils.AreFloatsEqual](http://todo) to compare the `x`, `y`, and `z` attributes of `Vector3`. |

## Example

```c#
[TestFixture]
public class Vector3Test
{
    [Test]
    public void VerifyThat_TwoVector3ObjectsAreEqual()
    {
     