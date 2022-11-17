// For more information see https://aka.ms/fsharp-console-apps
module PipelinesAndComposition =

  let square x = x*x
  let addOne x = x+1
  let isOdd x = x%2 <> 0
  let numbers = [1;2;3;4;5]
  let squareOddValuesAndAddOne values =
    let odds = List.filter isOdd values
    let squares = List.map square odds
    let result = List.map addOne squares
    result

  printfn $"processing {numbers} through 'squareOddValuesAndAddOne' produces: {squareOddValuesAndAddOne numbers}!"

  let squareOddValuesAndAddOneShorterPipeline values =
    values
    |> List.filter isOdd
    |> List.map(fun x -> x |> square |> addOne)

  printfn $"processing {numbers} through 'squareOddValuesAndAddOneShorterPipeline' produces: {squareOddValuesAndAddOneShorterPipeline numbers}!"
