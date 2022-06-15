object fibonacci {
  
  def fibo(n: Int):Int = {
  var a = -1
  var b = 1
  var c = 0
  var d = 0
  var i = 0
  
  while( i < n ) {
  
  a = b
  b = c
  c = d
  i = i + 1
  d = a + b + c
  }
  return d
  }
  
  
  def fibonacci_estruc(tamano: Int):Unit = {
	for (i <-0 to (tamano-1)){
	System.out.print(fibo(i)+" ")
	}
	}
  
  def main(args:Array[String]):Unit = {
  println("Dame un valor a: ")
  val a = scala.io.StdIn.readInt()
  print(fibonacci_estruc(a))
  }
  
}