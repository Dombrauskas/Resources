/**
 * 
 * Maurício Freire
 * Em Kotlin o if é uma expressão e não uma declaração, portanto o if pode ser
 * diretamente atribuído a uma variável.
 * In Kotlin the if is an expression instead of a statement, thus the if can be
 * directly assigned to a variable. 
 */

fun main(args : Array<String>) {
    val c : Int = 29
    val v : Int = 19
    
    val p = if (c > v) c else v
    
    println("Valor de p = $p")
}


