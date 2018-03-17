//open System
//namespace Echo

module Echo
    [<EntryPoint>]
    let main argv =
        Printer.printArray "Hello World from F#!"
        0 // return an integer exit code
