namespace ExtSharper

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.EcmaScript

type Random =
        
    /// Returns a random positive number.
    [<JavaScript>]
    static member Next () =
        Math.Random () * 2147483648.
        |> Math.Floor

    /// Returns a random positive number that is less than the specified max value.
    [<JavaScript>]
    static member Next maxValue =
        Math.Random () * (maxValue + 1 |> float)
        |> Math.Floor

    /// Returns a random positive number in the specified range.
    [<JavaScript>]
    static member Next (minValue, maxValue) =
        Math.Random () * (maxValue - minValue + 1 |> float) + float minValue
        |> Math.Floor

    /// Returns a random number between 0.0 and 1.0.
    [<JavaScript>]
    static member NextDouble () = Math.Random ()