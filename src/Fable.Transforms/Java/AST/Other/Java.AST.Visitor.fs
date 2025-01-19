// Info: https://help.eclipse.org/latest/index.jsp?topic=%2Forg.eclipse.jdt.doc.isv%2Freference%2Fapi%2Forg%2Feclipse%2Fjdt%2Fcore%2Fdom%2FASTVisitor.html

// To find an AST Node you could check of levels in the AST. A better solution is to use the visitor pattern via the ASTVisitor class.
module rec Fable.Transforms.Java.AST.Visitor

open Fable.Transforms.Java.AST.Adapters
open Fable.Transforms.Java.AST.Types
