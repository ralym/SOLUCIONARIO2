namespace ClassLibrary1fibonacci

module Say =

    let fibobonormal (n:int) =
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
    

    let rec fib (n:int) =
  //printfn "fib"
        match n with
        | 0 -> 0
        | 1 ->0
        | 2 ->1
        | n ->fib(n-1) + fib(n-2)+fib(n-3)
// impresiones 

    let fiboRecursivosa (n:int)=
         let mutable r=""
         for i in 1..n do
             r<- r+string (fibobonormal i)+","
         r
    let fiboestructurado (x:int)=
         let mutable r=""
         for i in 1..x do
             r<- r + string(fiboRecursivosa i)+","
         r



    let hello name =
        printfn "Hello %s" name

    let suma a b = a+b

 type Class1() = 
    member this.X = "F#"





        
