# F# Mutable Variable Unexpected Behavior

This example demonstrates a common misunderstanding in F# related to mutable variables and function calls.  When a mutable variable is passed to a function, the function operates on a *copy* of the value at the time of the call, rather than a reference to the variable itself.  Subsequent changes to the variable outside of the function do not affect the result of the function.

The file `bug.fs` demonstrates the incorrect behavior.  The file `bugSolution.fs` shows a corrected implementation.