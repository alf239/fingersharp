namespace FingerTree

open Xunit
open Core

module Test =
    [<Fact>]
    let ``Hello says my name`` () =
        Assert.Equal(hello "world", "Hello world")
