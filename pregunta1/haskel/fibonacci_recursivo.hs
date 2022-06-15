fiborecu x y z = x : fiborecu y z (x+y+z)


main = do
  putStrLn "Ingrese el numero para la serie de fibonacci :"
  num <- getLine
  let m = read num :: Int
  print(take m (fiborecu 0 1 1))
