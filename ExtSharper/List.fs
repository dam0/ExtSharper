namespace ExtSharper

module List =

    /// Splits a list into lists of the specified length.
    let split count list =        
        let rec loop list =
            [
                yield Seq.truncate count list |> Seq.toList
                match List.length list < count with
                    | false ->
                        let list' = Seq.skip count list |> Seq.toList
                        yield! loop list'
                    | true -> ()
            ]
        loop list


