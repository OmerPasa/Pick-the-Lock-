                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Vector4EqualityComparer

Use this class to compare two [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) objects for equality with [NUnit](http://www.nunit.org/) constraints. Call `Vector4EqualityComparer.Instance` to perform comparisons using default calculation error value 0.0001f. To set a custom test value, instantiate a new comparer using the [one argument constructor](#constructor).

## Static Properties

| Syntax                             | Description                                                  |
| ---------------------------------- | ------------------------------------------------------------ |
| `Vector4EqualityComparer Instance` | A comparer instance with the default calculation error value set to 0.0001f. |

## Constructors

| Syntax                                        | Description                                    |
| --------------------------------------------- | ---------------------------------------------- |
| `Vector4EqualityComparer(float allowedError)` | Creates an instance with a custom error value. |

## Public methods

| Syntax                                           | Description                                                  |
| ------------------------------------------------ | ------------------------------------------------------------ |
| `bool Equals(Vector4 expected, Vector4 actual);` | Compares the `actual` and `expected` `Vector4` objects for equality using [Utils.AreFloatsEqual](http://todo) to compare the `x`, `y`, `z`, and `w` attributes of `Vector4`. |

## Example

```c#
[TestFixture]
public class Vector4Test
{
    [Test]
    public void VerifyThat_TwoVector4ObjectsAreEqual()
    {
        // Custom