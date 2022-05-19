
import System.Directory

suma :: Int -> Int -> Int
suma x y = x + y
resta :: Int -> Int -> Int
resta x y = x - y
multiplicacion :: Int -> Int -> Int
multiplicacion x y = x * y
division :: Int -> Int -> Int
division x y = x `div` y

main = do
    putStrLn "Calculadora Haskell"
    putStrLn "Numero 1:"
    num1 <- getLine
    putStrLn "Numero 2:"
    num2 <- getLine
    putStrLn "Resultados Obtenidos:"
    putStrLn "La suma es: "
    print(suma (read num1) (read num2))
    putStrLn "La resta es: "
    print(resta (read num1) (read num2))
    putStrLn "La multiplicacion es: "
    print(multiplicacion (read num1) (read num2))
    putStrLn "La division es: "
    print(division (read num1) (read num2))