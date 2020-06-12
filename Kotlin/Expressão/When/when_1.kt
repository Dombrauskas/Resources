/**
 * 
 * Maurício Freire
 * Em substituição ao switch do Java existe o when em Kotlin. Ao invés de default
 * a opção padrão do when é o else, que deve ficar dentro do bloco de escopo.
 * Substituting the switch of Java there is when in Kotlin. Instead of default as
 * a standard option of when is else, which must be within the scope block.
 */

fun main(args : Array<String>) {
    val op : Int = 7
    
    when (op) {
        1 -> println("Luffy")
        2 -> println("Nami")
        3 -> println("Zoro")
        4 -> println("Usopp")
        5 -> println("Sanji")
        6 -> println("Chopper")
        7 -> println("Robin")
        8 -> println("Franky")
        9 -> println("Brook")
        10 -> println("Jinbei")
    	else -> println("None")
    }
}

