open StartOfExecution

[<EntryPoint>]
let main argv =
    printfn "func main"

    let print(shape: Shape) = printfn $"Area - {shape.Area}"

    let rectangle = Rectangle(10.0, 20.0, 3, 4)
    let circle = Circle(10.0, 2, 3)
    print(rectangle)
    print(circle)
    0