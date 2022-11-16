// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let myOne = 1
let myTwo = 2
let hello = "Hello"
let letterA = 'a'
let mutable isEnabled = true
isEnabled <- false
printfn $"isEnabled {isEnabled}"

let add x y = x+y
printfn $"add one two = {add myOne myTwo}"

