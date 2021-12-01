module Day1

open System
open System.IO
open Xunit

[<Fact>]
let ``Step 1`` () =
    let input = File.ReadAllLines("Day1/Day1.input.txt")

    let result =
        input
        |> Seq.map Convert.ToInt32
        |> Seq.pairwise
        |> Seq.map (fun (a, b) -> b > a)
        |> Seq.filter id
        |> Seq.length

    Assert.Equal(1462, result)


[<Fact>]
let ``Step 2`` () =
    let input = File.ReadAllLines("Day1/Day1.input.txt")

    let result =
        input
        |> Seq.map Convert.ToInt32
        |> Seq.windowed 3
        |> Seq.map (fun win -> (win.[0], win.[1], win.[2]))
        |> Seq.map (fun (a, b, c) -> a + b + c)
        |> Seq.pairwise
        |> Seq.map (fun (a, b) -> b > a)
        |> Seq.filter id
        |> Seq.length

    Assert.Equal(1497, result)
