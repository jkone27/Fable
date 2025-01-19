[<RequireQualifiedAccess>]
module Fable.Transforms.Java.Replacements

#nowarn "1182"

open System
open System.Text.RegularExpressions
open Fable
open Fable.AST
open Fable.AST.Fable
open Fable.Transforms
open Replacements.Util

// implement using eclipse JDT and follow examples from other languages in @workspace but for Java here
