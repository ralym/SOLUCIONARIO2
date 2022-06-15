fiboest :: [Integer]
fiboest = d 0 1 1
 where d a b c = a: d b c (a+b+c)

main = do
 putStrLn "Ingrese el numero para la serie de fibonacci :"
 num <- getLine
 let m = read num::Int
 print(take m fiboest)