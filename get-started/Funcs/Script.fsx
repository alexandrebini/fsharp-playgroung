#load "Funcs.fs"
open Funcs

// Define your library scripting code here
let square x = x * x
let distance x y = x - y |> abs
let distanceFrom5 = distance 5
distanceFrom5 -5
(distance 5) 2

(+) 1 3
let add1 = (+) 1
add1 5

//
(+) 1 2
(+) ((+) 1 2) 3

// infix distance
let (|><|) x y = x - y |> abs
5 |><| 2
5 |><| 2 |><| 10

// lambdas
List.map (fun x -> x * x) [1;2;3]
(fun x y -> x - y |> abs)  20 35
(fun (x:float) (y:float) -> x - y |> abs)  20.10 35.20

// recursion
let rec length = function
  | [] -> 0
  | x::xs -> 1 + length xs
length [1;2;3;4;5;6]

let rec factorial (n) =
  if n < 2 then
    1
   else
    n * factorial (n-1)

factorial 10

// Pipe operators - pipe forward
sin 7.
7. |> sin
sin 7.
  |> sin
  |> ((*) 2.)

min 12 7
12 |> min <| 7
(12, 7) ||> min
min <|| (12,7)

sin (2. + 1.)
sin <| 2. + 1.

[1;2;3;4]
  |> List.filter (fun i -> i % 2 = 0)
  |> List.map ((*) 2)
  |> List.sum

let (|<><><>|) a f = f a


// function composition
let minus1 x = x - 1
let times2 = (*) 2

minus1 9
times2 8

times2 (minus1 9)

let minus1ThenTimes2 = times2 << minus1
minus1ThenTimes2 9
(times2 << minus1) 9
times2 << minus1 <| 9

minus1 (times2 9)
let times2ThenMinus1 = times2 >> minus1
times2ThenMinus1 9




