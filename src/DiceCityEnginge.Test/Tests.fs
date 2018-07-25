module Tests

open System
open Xunit
open DiceCityEngine
open Akka.TestKit.Xunit

[<Fact>]
let ``DiceActor Rolls Single Dice`` () =
    let diceActor = DiceCityEngine.GameActors.DiceActor()

    // let actor = Akka.TestKit.TestActorRef<DiceActor>
    Assert.NotNull(diceActor)

    let a = diceActor.Roll

    Assert.Equal(3, a)
