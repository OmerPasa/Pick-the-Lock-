USBC�y:�     
* 5�  �       j                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # TestMustExpectAllLogs attribute

The presence of this attribute causes the **Test Runner** to expect every single log. By default, the Test Runner only fails on error logs, but `TestMustExpectAllLogs` fails on warnings and info level messages as well. It is the same as calling the method [LogAssert.NoUnexpectedReceived](./reference-custom-assertion.md#static-methods) at the bottom of every affected test.

## Assembly-wide usage

You can apply this attribute to test assemblies (that affects every test in the assembly), fixtures (affects every test in the fixture), or on individual test metho