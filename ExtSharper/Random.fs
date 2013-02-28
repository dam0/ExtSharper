namespace ExtSharper.Client

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

    /// Returns a radom string of the specified length.
    [<JavaScript>]
    static member NextString(length, ?charSet : char list) =
        let defaultCharSet =
          ['A'; 'B'; 'C'; 'D'; 'E'; 'F'; 'G'; 'H'; 'I'; 'J'; 'K'; 'L'; 'M'; 'N'; 'O';
           'P'; 'Q'; 'R'; 'S'; 'T'; 'U'; 'V'; 'W'; 'X'; 'Y'; 'Z'; 'a'; 'b'; 'c'; 'd';
           'e'; 'f'; 'g'; 'h'; 'i'; 'j'; 'k'; 'l'; 'm'; 'n'; 'o'; 'p'; 'q'; 'r'; 's';
           't'; 'u'; 'v'; 'w'; 'x'; 'y'; 'z'; '0'; '1'; '2'; '3'; '4'; '5'; '6'; '7';
           '8'; '9']            
        let charSet' = defaultArg charSet defaultCharSet
        let charSetLength = float charSet'.Length
        [
            for x in 1 .. length do
                let item = Math.Floor <| Math.Random() * charSetLength
                yield charSet'.[item]
        ] |> List.fold (fun state x -> state + string x) ""