/**
 * 
 * Maurício Freire
 * Em Java é possível fazer conversões automáticas de tipo se o destino for maior
 * maior. Entretanto, em Kotlin a conversão deve ser feita explicitamente por
 * questão de segurança.
 * In Java is possible automatically convert types as long the destiny type is 
 * larger. However, in Kotlin the type conversion must be done explicitly as a
 * safety matter.
 * Java:
 * int num1 = 32;
 * int num2 = num1; // OK
 * Kotlin:
 * val num1 : Int = 32
 * val num2 : Long = num1 // Erro
 */

fun main(args : Array<String>) {
    val x : Int = 101
    val y : Long = x.toLong()
    val z : Double = y.toDouble()
    val c : Char = x.toChar()
    
    println("Int = $x")
    println("Long = $y")
    println("Double = $z")
    println("Char = $c")
}

