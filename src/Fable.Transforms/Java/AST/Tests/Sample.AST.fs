module Sample.AST

open Fable.Transforms.Java.AST.Adapters
open Fable.Transforms.Java.AST.Spans
open Fable.Transforms.Java.AST.Types
open Fable.Transforms.Java.AST.Helpers

// The AST for this Java program:
//
// public class Main {
//     public static void main(String[] args) {
//         int[] a = {1, 2, 3, 4, 5};
//         System.out.println(Arrays.toString(a));
//     }
// }
