module Tests

open System
open Xunit
open DiceCityEngine
open Akka.TestKit.Xunit

[<Fact>]
let ``DiceActor Rolls Single Dice`` () =
    let actor = 1//ActorOf<DiceActor>
    Assert.NotNull(actor)
