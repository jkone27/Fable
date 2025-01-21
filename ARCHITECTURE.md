# Fable Architecture

Fable is a compiler that allows F# code to be compiled to multiple target languages, including JavaScript, Rust, Python, and more. This document provides an overview of the main components of Fable's architecture.

## Components

### Transformer
The Transformer is responsible for converting the F# Abstract Syntax Tree (AST) into an intermediate representation suitable for the target language.

- **JavaScript**: [Fable2Babel.fs](src/Fable.Transforms/Fable2Babel.fs)
- **Rust**: [Fable2Rust.fs](src/Fable.Transforms/Rust/Fable2Rust.fs)
- **Python**: [Fable2Python.fs](src/Fable.Transforms/Python/Fable2Python.fs)
- **Java**: [Fable2Java.fs](src/Fable.Transforms/Java/Fable2Java.fs) (to be implemented)

### Printer
The Printer takes the intermediate representation and generates the target language code.

- **JavaScript**: [BabelPrinter.fs](src/Fable.Transforms/BabelPrinter.fs)
- **Rust**: [RustPrinter.fs](src/Fable.Transforms/Rust/RustPrinter.fs)
- **Python**: [PythonPrinter.fs](src/Fable.Transforms/Python/PythonPrinter.fs)
- **Java**: [JavaPrinter.fs](src/Fable.Transforms/Java/JavaPrinter.fs) (to be implemented)

### Pipeline
The Pipeline orchestrates the transformation and printing processes, ensuring that the F# code is correctly compiled to the target language: [Main.fs](src/fable-standalone/src/Main.fs)

### Project Cracker
The Project Cracker is responsible for parsing the F# project files and extracting the necessary information for the compilation process: [ProjectCracker.fs](src/Fable.Compiler/ProjectCracker.fs)

## Mermaid Diagram

```mermaid
graph TD
    subgraph Fable Pipeline
        A[F# Code]
        B[Fable Compiler]
        C[Intermediate Representation]
        D[Target Language Code]
    end

    A --> B
    B --> C
    C --> D

    subgraph "Transformers"
        B1[Fable2Babel - JavaScript]
        B2[Fable2Rust - Rust]
        B3[Fable2Python - Python]
        B4[Fable2Java - Java]
    end

    subgraph "Printers"
        C1[BabelPrinter - JavaScript]
        C2[RustPrinter - Rust]
        C3[PythonPrinter - Python]
        C4[JavaPrinter - Java]
    end

    B --> B1
    B --> B2
    B --> B3
    B --> B4

    C --> C1
    C --> C2
    C --> C3
    C --> C4
