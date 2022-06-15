# -*- coding: utf-8 -*-
"""
Created on Wed Jun 15 07:04:06 2022

@author: RAUL
"""

# -*- coding: utf-8 -*-

def fibonacci_estructurado(n):
    a=-1
    b=1
    c=0
    d=0

    for k in range(n):
            print(d)
            a=b
            b=c
            c=d
            d=a+b+c

def inprimimeestru(funcion, n):
    funcion(n)



def impresionrecur(funcion, n):
    for i in range(n):
        print(funcion(i))


def fibonacci_recursivo(n):
    if(n==0):
        return 0
    if(n==1):
        return 1
    if(n==2):
        return 1
    return (fibonacci_recursivo(n-1)+fibonacci_recursivo(n-2)+fibonacci_recursivo(n-3))

numero1 = int(input("ingrese el numero de fibonaccis a imprimir : "))
print("los primeros "+str(numero1) +" la serie fibonacci es: ")
impresionrecur(fibonacci_recursivo, numero1)



numero = int(input("ingrese el numero de fibonaccis a imprimir : "))
print("los primeros "+str(numero) +" la serie fibonacci es: ")
inprimimeestru(fibonacci_estructurado, numero)
