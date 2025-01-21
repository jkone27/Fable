# Fable Library Components

Fable includes several library components (`library-x`) that provide implementations of F# namespaces for different target languages. This document explains how these components work and how the implementation can vary from `.fs` to native language implementations.

## Components Example

### Python Library

The Python library provides implementations of F# namespaces for Python.

- **Location**: [src/fable-library-python](src/fable-library-python)

### Example: List Module

#### Non-Native Implementation

In some cases, the F# code can be directly compiled to the target language without any modifications. For example, the `List` module in F# can be implemented in `List.fs` and compiled to Python.

- **F# Code** (`List.fs`):

  ```fsharp
  module List

  let rec map f lst =
      match lst with
      | [] -> []
      | x::xs -> f x :: map f xs
    ```

- **Compiled Compiled code**

```py
def map(f, lst):
    if not lst:
        return []
    else:
        x, *xs = lst
        return [f(x)] + map(f, xs)
```

## Native Implementation

In some cases, it may be necessary to write native language implementations for certain features. For example, the `List` module in Python may require direct Python implementations for performance reasons.

- **Native Python Code (`list.py`)**:

```py
def map(f, lst):
    return [f(x) for x in lst]
```
