namespace ExtSharper

open System

module Uri =

    let TryCreate uriString =
        Uri.TryCreate(uriString, UriKind.Absolute)
        |> function
            | false, _ ->
                Uri.TryCreate("http://" + uriString, UriKind.Absolute)
                |> function
                    | false, _   -> None
                    | true , uri -> Some uri
            | true , uri -> Some uri