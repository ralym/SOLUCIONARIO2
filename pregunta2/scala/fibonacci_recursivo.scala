object fibonacci {
  
  def fibo(n: Int):Int = {
  if (n == 0){
  return 0
  }else if (n == 1){
  return 1
  }else if (n == 2){
  return 1
  }else{
  return (tem (n))
  }
  }
  
  def fi(tamano: Int):Unit = {
  for (i <-0 to (tamano-1)){
  System.out.print(fibo(i)+" ")
  }
  }
  
  val tem = (n: Int)=> fibo(n-1)+fibo(n-2)+fibo(n-3)
  
  def main(args:Array[String]):Unit = {
  println("valor de imprimir serie fibonacci ")
  val a = scala.io.StdIn.readInt()
  fi(a)
  }
  
}