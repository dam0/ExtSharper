namespace ExtSharper

module Array =

    /// Splits an array into arrays of the specified length.
    let split count array =        
        let rec loop array =
            [
                yield Seq.truncate count array |> Seq.toArray
                match Array.length array < count with
                    | false ->
                        let array' = Seq.skip count array |> Seq.toArray
                        yield! loop array'
                    | true -> ()
            ]
        loop array



