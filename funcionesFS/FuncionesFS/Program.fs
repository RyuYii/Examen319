// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

module calculadora = 
  let sumar x y = x+y
  let restar x y = x-y
  let multiplicar x y = x*y
  let dividir x y = x/y


[<EntryPoint>]
let main argv = 
    Console.WriteLine("Calcu en F#")
    Console.WriteLine("Numero 1:")
    let num1 = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Numero 2:")
    let num2 = Convert.ToInt32(Console.ReadLine())
    let suma = calculadora.sumar num1 num2
    Console.WriteLine("La suma es: " + suma.ToString())
    let resta = calculadora.restar num1 num2
    Console.WriteLine("La resta es: " + resta.ToString())
    let multi = calculadora.multiplicar num1 num2
    Console.WriteLine("La multiplicacion es: " + multi.ToString())
    let divi = calculadora.dividir num1 num2 
    Console.WriteLine("La division es: " + divi.ToString())
    let tecla = Console.ReadKey()
    0
