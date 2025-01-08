module Fable.Tests.Java

open NUnit.Framework
open Fable.Compiler.App

[<Test>]
let ``Test Java component initialization`` () =
    let fableManager = initFable()
    Assert.IsNotNull(fableManager)

[<Test>]
let ``Test Java component metadata directory`` () =
    let metadataDir = getMetadataDir()
    Assert.IsTrue(metadataDir.EndsWith("/fable-metadata/lib/"))

[<Test>]
let ``Test Java component Fable library directory`` () =
    let fableLibDir = getFableLibDir()
    Assert.IsTrue(fableLibDir.EndsWith("/temp/fable-library-java/"))

[<Test>]
let ``Test Java component version`` () =
    let version = getVersion()
    Assert.AreEqual(".next", version)
