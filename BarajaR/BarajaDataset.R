valores <- c(rep(c("A",2:10,"J","Q","K"), 4),rep("Joker",2))
simbolos <- c(rep(c("corazon","diamante","trebol","espada"),rep(13,4)), rep("comodin",2))
colores_base <- c("rojo","negro")
colores <- c(rep(colores_base, rep(26,2)), colores_base)
baraja=data.frame(valores,simbolos,colores)
baraja
