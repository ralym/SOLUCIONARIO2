# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""

from math import sqrt


def fibonacci_recursivo(n):
    if (n == 0 ) :
        return 0
    if (n == 1) :
        return 1
    if (n == 2) :
        return 1
    
    return (fibonacci_recursivo(n - 1) +fibonacci_recursivo(n - 2) +fibonacci_recursivo(n - 3))




def fibonacci_estructurado(n):
    a = -1
    b = 1
    c = 0
    d = 0
    for k in range(n):
        print(d)
        a = b
        b = c
        c = d
        d = a+b+c
        
        
    

print("introducta n")
dato=input()
print("metodo estructurado")    

fibonacci_estructurado(int(dato))
print("metodo recuresivo")  
for i in range(int(dato)):
    print(fibonacci_recursivo(i))





