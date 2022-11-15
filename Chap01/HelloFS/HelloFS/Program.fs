// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let square x = x * x          // Note that no parens are used.
let result = square 3                      // Now run the function. Again, no parens.
printfn "3^2 = %i" result
// define the sumOfSquares function
let sumOfSquares n =
   [1..n] |> List.map square |> List.sum

// try it
let sum2 = sumOfSquares 100
printfn "sum of squares upto 100 = %i" sum2
