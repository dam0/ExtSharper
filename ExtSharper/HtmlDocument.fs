namespace ExtSharper.Client

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.JQuery

type HtmlDocument =

    [<JavaScript>]
    static member GetAttribute (selector : string, attributeName) = JQuery.Of(selector).Attr(attributeName)

    [<JavaScript>]
    static member GetAttribute (jquery : JQuery, attributeName) = jquery.Attr(attributeName)

    [<JavaScript>]
    static member GetText (selector : string) = JQuery.Of(selector).Text()

    [<JavaScript>]
    static member GetText (jquery : JQuery) = jquery.Text()

    [<JavaScript>]
    static member Select (selector : string) = JQuery.Of selector

    [<JavaScript>]
    static member SetAttribute (selector: string, attributeName, attributeValue) = JQuery.Of(selector).Attr(attributeName, attributeValue).Ignore

    [<JavaScript>]
    static member SetAttribute (jquery : JQuery, attributeName, attributeValue) = jquery.Attr(attributeName, attributeValue).Ignore

    [<JavaScript>]
    static member SetText (selector : string, newText) = JQuery.Of(selector).Text(newText).Ignore

    [<JavaScript>]
    static member SetText (jquery : JQuery, newText) = jquery.Text(newText).Ignore