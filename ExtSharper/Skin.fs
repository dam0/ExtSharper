namespace ExtSharper

open System.Web
open IntelliFactory.WebSharper.Sitelets
open IntelliFactory.WebSharper.Sitelets.Content

module Skin =

    type DefaultPage =
        {
            Title           : string
            MetaDescription : string
            Body            : HtmlElement list
        }

        static member Make title metaDescription makeBody context =
            {
                Title           = title
                MetaDescription = metaDescription
                Body            = makeBody context
            }

    type LoadFrequency = Template.LoadFrequency

    let MakeTemplate<'T> path (loadFrequency : LoadFrequency) =
        let path' = HttpContext.Current.Server.MapPath path
        Template<'T>(path', loadFrequency)
    
    let MakeDefaultTemplate path loadFrequency =
        MakeTemplate<DefaultPage> path loadFrequency
        |> fun x ->
            x.With("title"          , fun x -> x.Title)
             .With("metaDescription", fun x -> x.MetaDescription)
             .With("body"           , fun x -> x.Body)

    let WithTemplate<'T> template title metaDescription makeBody : Content<'T> =
        WithTemplate template
        <| fun context -> DefaultPage.Make title metaDescription makeBody context