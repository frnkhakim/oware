module Oware

type StartingPosition =
    | South
    | North

type board = {

    a:int;
    b:int;
    c:int;
    d:int;
    e:int;
    f:int;

    g:int;
    h:int;
    i:int;
    j:int;
    k:int;
    l:int;

    north_points:int;
    south_points:int;

    turn: StartingPosition;

    }

//initial position of all players
let start position ={

    a = 4;
    b = 4;
    c = 4;
    d = 4;
    e = 4;
    f = 4;

    g = 4;
    h = 4;
    i = 4;
    j = 4;
    k = 4;
    l = 4;

    north_points = 4;
    south_points = 4;

    turn = position;

}




let getSeeds n board = failwith "Not implemented"
//i am worked only with frank
let useHouse n board = failwith "Not implemented"

//initial position of all players
let start position ={

    a = 4;
    b = 4;
    c = 4;
    d = 4;
    e = 4;
    f = 4;

    g = 4;
    h = 4;
    i = 4;
    j = 4;
    k = 4;
    l = 4;

    north_points = 4;
    south_points = 4;

    turn = position;

}

let score board = failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code
