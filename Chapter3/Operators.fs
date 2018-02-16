#if INTERACTIVE
#else
module Operators
#endif

open System

// Use the + operator to concatenate strings:
let rhyme = "Jack " + "and " + "Jill"
let rhyme2 = String.concat " " [|"Jack"; "and"; "Jill"|]

// ...or Dates and TimeSpans:
let oneYearLater = DateTime.Now + TimeSpan(365, 0, 0, 0, 0)
let anotherYearLater = oneYearLater.AddYears(1)

// Use brackets to allow an operator to be treated as a function:
let result = (+) 1 1
let add = (+)

// You can redefine operators - use with care!
let (+) a b = a - b
printfn "%i" (1 + 1)

// You can define your own operators:
let (+*) a b = (a + b) * a * b
printfn "(1 +* 2) = %i" (1 +* 2)
