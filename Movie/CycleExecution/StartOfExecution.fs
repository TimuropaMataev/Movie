module StartOfExecution

[<AbstractClass>]
type Shape(startX, startY) = class
    let mutable x = startX
    let mutable y = startY
    member _.printStartPoint()= printfn $"x: {x}  y: {y}"
 
    abstract Area: float with get
end
 
type Rectangle(width, height, startX, startY) = 
    inherit Shape(startX, startY)
    member this.Width = width
    member this.Height = height
    override this.Area = this.Width * this.Height
 
type Circle(radius, startX, startY) = 
    inherit Shape(startX, startY)
    member this.Radius = radius
    override this.Area = this.Radius * System.Math.PI