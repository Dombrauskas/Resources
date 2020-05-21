/**
 * 
 * Maurício Freire
 * Os operadores aritméticos +, -, *, / e % chamam as funções a.plus(b), 
 * a.minus(b), a.times(b), a.div(b) e a.mod(b) respectivamente.
 * The arithmetic operands +, -, *, / and % call the functions a,plus(b),
 * a.minus(b), a.times(b), a.div(b) e a.mod(b) respectively.
 */

fun main(args : Array<String>) {
    val a = 16
    val b = 44
    var result: Number
    
    result = a + b
    println("a + b = $result\ta.plus(b): " + a.plus(b))
    result = b - a
    println("b - a = $result\tb.minus(a): " + b.minus(a))
    result = a * b
    println("a * b = $result\ta.times(b): " + a.times(b))
    result = b / a
    println("b / a = $result\tb.div(a): " + b.div(a))
    result = b % a
    println("b + a = $result\tb.mod(a): " + b.mod(a))
}

