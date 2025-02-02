# Mutable Variable Swap Bug in F#

This repository demonstrates a common error when working with mutable variables in F#.  The `swap` function attempts to swap two mutable variables, but due to pass-by-reference semantics, it fails to produce the expected result.

## Bug Description
The `bug.fs` file contains a function that attempts to swap two mutable integers. However, because mutable variables are passed by reference, the function modifies the original variables directly, leading to unexpected output. The expected output is "2 1", but the actual output is "1 2".

## Solution
The `bugSolution.fs` file provides a corrected version that uses a different approach to solve the problem. This corrected version creates a tuple to manage the variables so that the swap function works correctly. 