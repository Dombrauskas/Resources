/**
 * 
 * Maurício Freire
 * Em Kotlin não é possível tratar um tipo char como um tipo inteiro:
 * Em Java isto é aceitável -> char ch = 97; mas não em Kotlin.
 * In Kotlin it is not possible to treat a char type as an int type:
 * In Java it is acceptable -> char ch = 97; but not in Kotlin.
 */

fun main(args : Array<String>) {
    var txt = "Kotlin"
    val chr = ' '
    var msg = "Language"
    val concatenate = txt + chr + msg
    
    //var ch: Char = 97 
    println("Mensagem concatenada: $concatenate")
}


