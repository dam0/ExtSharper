namespace ExtSharper

module Seq =

    /// Splits a sequence into sequences of the specified length.
    let split count source =           
        let rec loop source =
            seq {
                yield Seq.truncate count source
                let len = Seq.length source
                match Seq.length source < count with
                    | false ->
                        let source' = Seq.skip count source
                        yield! loop source'
                    | true -> ()
            }
        loop source
