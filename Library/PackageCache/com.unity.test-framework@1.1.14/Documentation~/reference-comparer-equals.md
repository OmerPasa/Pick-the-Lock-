                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Custom equality comparers with equals operator

If you need to compare Vectors using the overloaded operator == (see [Vector2.operator ==](https://docs.unity3d.com/ScriptReference/Vector2-operator_eq.html),  [Vector3.operator ==](https://docs.unity3d.com/ScriptReference/Vector3-operator_eq.html), and [Vector4.operator ==](https://docs.unity3d.com/ScriptReference/Vector4-operator_eq.html))  you should use the respective comparer implementations:

- Vector2ComparerWithEqualsOperator
- Vector3ComparerWithEqualsOperator
- Vector4ComparerWithEqualsOperator

The interface is the same as for other [equality comparers](./reference-custom-equality-comparers.