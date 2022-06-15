object fibonacci {
  
  def fibo(n: Int):Int = {
  if (n == 0){
  return 0
  }else if (n == 1){
  return 1
  }else if (n == 2){
  return 1
  }else{
  return (fibo(n-1)+fibo(n-2)+fibo(n-3))
  }
  }
  
  def fsuperior(funcion:(Int)=>Int,m: Int):Unit = {
  for (i <-0 to (m-1)){
  println("valor de la serie fibonacci: ")
  System.out.print(funcion(i)+" ")
  }
  }
  
  def main(args:Array[String]):Unit = {
  println("valor de la serie fibonacci: ")
  val a = scala.io.StdIn.readInt()
  fsuperior(fibo, a)
  }
  
}