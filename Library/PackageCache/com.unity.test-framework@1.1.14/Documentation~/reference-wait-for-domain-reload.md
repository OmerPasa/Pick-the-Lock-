                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               # WaitForDomainReload
`WaitForDomainReload` is an [IEditModeTestYieldInstruction](./reference-custom-yield-instructions.md) that you can yield in Edit Mode tests. It delays the execution of scripts until after an incoming domain reload. If the domain reload results in a script compilation failure, then it throws an exception.

## Constructors

| Syntax                 