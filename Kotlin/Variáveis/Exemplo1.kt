/**
 * 
 * Maurício Freire
 * Declaração de variáveis: as variáveis em Kotlin podem ser declaradas como var
 * ou val; a diferença é que val é imutável como uma variável final em java e as
 * variáveis var podem ser alteradas.
 * Variables declaration: the variables in Kotlin can be declared either as var
 * or as val; the difference is that val is immutable just like a final variable
 * in java, and var is changeble. 
 */

fun main(args : Array<String>) {
    var x = 10
    val y = 5
    
    x += y

    // Isto causaria erro fora dos comentários.
    // This would cause an error out of the comments.
    //y = x
    println(x)
    println(y)
}


