# -*- coding: utf-8 -*-
"""
Created on Mon Jun 13 18:26:06 2022

@author: RAUL
"""

def fibonacci(n):
    fib_list = [0, 1,1]
  
    any(map(lambda _: fib_list.append(sum(fib_list[-3:])),
                                         range(3, n)))
  
    return fib_list[:n]

#fibonaci estructurado

def fibonacci_e(n):
    a=-1
    b=1
    c=0
    d=0

    for k in range(n):
            print(d)
            a=b
            b=c
            c=d
            d=temp(a, b, c)

temp = lambda a, b, c : a + b + c
#fibonaci recursivo 
def fibonacci_rec(n):
    for i in range(n):
        print(fib_rec(i))

def fib_rec(n):
    if(n==0):
        return 0
    if(n==1):
        return 1
    if(n==2):
        return 1
    return temp1(n)


temp1 = lambda n : fib_rec(n-1)+fib_rec(n-2)+fib_rec(n-3)

numerorecu = int(input("ingrese el numero de fibonaccis a imprimir : "))
print("los primeros "+str(numerorecu) +" numeros fibonacci recursivo es: ")
fibonacci_rec(numerorecu)

numero = int(input("ingrese el numero de fibonaccis a imprimir : "))
print("los primeros "+str(numero) +" numeros fibonacci estructurado es: ")
fibonacci_e(numero)
  
n = int(input("Ingrese el valor de n: "))
print(fibonacci(n))