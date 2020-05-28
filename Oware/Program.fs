﻿module Oware

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

    a':int;
    b':int;
    c':int;
    d':int;
    e':int;
    f':int;

    north_points:int;
    south_points:int;

    turn: StartingPosition;

    }





let getSeeds n board = 
    match n with
       |1 ->board.a
       |2 ->board.b
       |3 ->board.c
       |4 ->board.d
       |5 ->board.e
       |6 ->board.f

       |7 ->board.a'
       |8 ->board.b'
       |9 ->board.c'
       |10->board.d'
       |11->board.e'
       |12->board.f'

       //if value is not within the numbers of 1 to 12
       |_-> failwith" not within the bounds of the game"

let useHouse n board = failwith "Not implemented"

//initial position of all players
let start position ={

    a = 4;
    b = 4;
    c = 4;
    d = 4;
    e = 4;
    f = 4;

    a' = 4;
    b' = 4;
    c' = 4;
    d' = 4;
    e' = 4;
    f' = 4;

    north_points = 0;
    south_points = 0;

    turn = position;

}

let score board = (board.north_points, board.south_points)

let gameState board = 
    match (board.south_points >=25,board.north_points>=25,(board.south_points = 24 && board.north_points =24)) with
        |true,true,_-> "Game ended in a draw"
        |_,_,true-> "Game ended in a draw"
        |true,false,_->"South won"
        |false,true,_->"North won"
        |false,false,_-> match board.turn with
                            |South -> "South's turn"
                            |North -> "North's turn"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code
