/**
 * 
 * Maurício Freire
 * O when pode ser usado como uma expressão ou como um bloco de código.
 * Aqui o when é uma expressão.
 * The when can be used either as an expression or as a code scope.
 * Here when is used as an expression. 
 */

fun main(args : Array<String>) {
    val op : Int = 5
    
    val nm = when (op) {
        1 -> "Luffy"
        2 -> "Nami"
        3 -> "Zoro"
        4 -> "Usopp"
        5 -> "Sanji"
        6 -> "Chopper"
        7 -> "Robin"
        8 -> "Franky"
        9 -> "Brook"
        10 -> "Jinbei"
    	else -> "None"
    }
    println(nm)
}


