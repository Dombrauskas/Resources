/**
 * 
 * Maurício Freire
 * Tipos Numéricos: Tipo	De		Até
 * Numeric Types:	Type	From	To
 * 					Byte	-128	127
 * 					Short	-32768	32767
 * 					Int		-2³¹	2³¹-1
 * 					Long	-2⁶³	2⁶³-1
 * 					Float	Double precision of 32-bit
 * 					Double	Double precision of 64-bit
 */

fun main(args : Array<String>) {
    val byte: Byte = 112
    val short: Short = -32768
    val int: Int = 2147483647
    val long: Long = -2147483650
    val float: Float = 19.18F
    val double: Double = 3.14159265359
    
    println("Byte: \t$byte\nShort: \t$short")
    println("Integer:$int\nLong: \t$long")
    println("Float: \t$float\nDouble: $double")
}


