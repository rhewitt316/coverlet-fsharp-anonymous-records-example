module Tests

open System
open Xunit
open Module1

[<Fact>]
let ``My test`` () =
    let foo = Type1.Option1
    Assert.True(true)