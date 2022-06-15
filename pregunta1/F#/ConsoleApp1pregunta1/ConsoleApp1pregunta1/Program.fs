// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// Recursive function:

open System
let fibobonormal n =
  let mutable a=(-1)
  let mutable b=1
  let mutable c=0
  let mutable d=0
  for i in 1..(n-1) do
    a<-b
    b<-c
    c<-d
    d<-a+b+c        
  d           
    

let rec fib n =
  //printfn "fib"
  match n with
    | 0 -> 0
    | 1 ->0
    | 2 ->1
    | n ->fib(n-1) + fib(n-2)+fib(n-3)

let fiboRecursivosa n=
     for i in 1..n do
        printf "%d, " (fib i)

let fiboestructurado n=
     for i in 1..n do
        printf "%d, " (fibobonormal i)


[<EntryPoint>]
let main argv = 
  

    // fibo estructurada 
  Console.WriteLine("Introduzca un numero n:")
  let digito=Console.ReadLine()
  let n=Convert.ToInt32(digito)
    
  Console.WriteLine(fiboestructurado n)


    // fibo RECURSIVO
  Console.WriteLine("Introduzca un numero n: ")
  let digito=Console.ReadLine()
  let n=Convert.ToInt32(digito)
  Console.WriteLine(fiboRecursivosa n)

  let tecla= Console.ReadKey()
  0 //caso 0
