# Discrete Logarithm Solver

## Overview

This repository contains a **C# implementation** of a **Discrete Logarithm Solver** using a **baby-step giant-step** approach. The program reads input values (modulus, base, order, and number of queries) and efficiently computes the discrete logarithm for given values.

## Time Complexity

The implemented **baby-step giant-step** algorithm has a time complexity of **O(√n)**, where **n** is the order of the group. This makes it significantly more efficient than brute-force methods (**O(n)**).

## Usage

1. Compile and run the program in a **C# environment**.
2. Provide input values in the following format:

```modulus base order k (number of queries) x1 x2 ... xk```

3. The program outputs the discrete logarithm results for each query.

## Dependencies

- **.NET Framework or .NET Core**
- **System.Numerics** for handling large integers

## Notes

- The program handles **large integers** using **BigInteger**.
- If no solution exists for a query, it outputs `"geen macht"` (Dutch for "no power").
- Optimized for values where `k ≤ 100`, adjusting step sizes accordingly.
