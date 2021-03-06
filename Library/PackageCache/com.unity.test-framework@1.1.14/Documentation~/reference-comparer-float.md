                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # FloatEqualityComparer

Use this class to compare two float values for equality with [NUnit](http://www.nunit.org/) constraints. Use `FloatEqualityComparer.Instance` comparer to have the default error value set to 0.0001f. For any other error, use the [one argument constructor](#constructors) to create a comparer.

## Static Properties

| Syntax     | Description                                                  |
| ---------- | ------------------------------------------------------------ |
| `Instance` | A singleton instance of the comparer with a default error value set to 0.0001f. |

## Constructors

| Syntax                                      | Description                                                  |
| ------------------------------------------- | ------------------------------------------------------------ |
| `FloatEqualityComparer(float allowedError)` | Creates an instance of the comparer with a custom error value. |

## Public methods

| Syntax                                       | Description                                                  |
| -------------------------------------------- | ------------------------------------------------------------ |
| `bool Equals(float expected, float actual);` | Compares the `actual` and `expected` float values for equality using `Utils.AreFloatsEqual`. |

## Example

```c#