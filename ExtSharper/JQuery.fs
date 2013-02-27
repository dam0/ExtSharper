namespace ExtSharper.Client

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.JQuery

module JQuery =

    [<JavaScript>]
    let GetAttribute (selector : string, attributeName) = JQuery.Of(selector).Attr(attributeName)

    [<JavaScript>]
    let GetText (selector : string) = JQuery.Of(selector).Text()

    [<JavaScript>]
    let AddClass (selector : string, className : string) = JQuery.Of(selector).AddClass(className).Ignore

    [<JavaScript>]
    let RemoveClass (selector : string, className) = JQuery.Of(selector).RemoveClass(className).Ignore

    [<JavaScript>]
    let SetAttribute (selector: string, attributeName, attributeValue) = JQuery.Of(selector).Attr(attributeName, attributeValue).Ignore

    [<JavaScript>]
    let SetText (selector : string, newText) = JQuery.Of(selector).Text(newText).Ignore

    


