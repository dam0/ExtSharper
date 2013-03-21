namespace ExtSharper

module Option =

    let tryWith f = try f |> Some with _ -> None

