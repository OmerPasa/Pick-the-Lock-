                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # ColorEqualityComparer

Use this class to compare two `Color` objects. `ColorEqualityComparer.Instance` has default calculation error value set to 0.01f. To set a test specific error value instantiate a comparer instance using the [one argument constructor](#constructors).

## Static properties

| Syntax     | Description                                                  |
| ---------- | ------------------------------------------------------------ |
| `Instance` | A singleton instance of the comparer with a default error value set to 0.01f. |

## Constructors

| Syntax                               | Description                                                  |
| ------------------------------------ | ------------------------------------------------------------ |
| `ColorEqualityComparer(float error)` | Creates an instance of the comparer with a custom error value. |

## Public methods

| Syntax                                       | Description                                                  |
| -------------------------------------------- | ------------------------------------------------------------ |
| `bool Equals(Color expected, Color actual);` | Compares the actual and expected `Color` objects for equality using  `Utils.AreFloatsEqualAbsoluteError` to compare the `RGB` and `Alpha` attributes of `Color`. Returns `true` if expected and actual objects are equal otherwise, it returns `false`. |

## Example

```c#
[TestFixture]
public class ColorEqualityTest
{
    [Test]
    public void GivenColorsAreEqual_WithAllowedCalculationError()
    {
        // Using de