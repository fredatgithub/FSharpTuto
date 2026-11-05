printfn "Tutorial: F#"
printfn " "

// en F#, les variables sont immuables par défaut
let age2 = 25
let nom2 = "Jean"
let prix2 = 12.5

// les variables mutables sont déclarées avec le mot-clé `mutable`
let mutable nombre = 10
nombre <- 20
printfn "%d" nombre

let age: int = 42
let prix: decimal = 19.99m
let actif: bool = true
let nom: string = "Pierre"

// Comme en C#, le compilateur peut généralement déduire automatiquement les types
let age3 = 25
let nom3 = "Jean"
let prix3 = 12.5

//Tu remarqueras l'absence de parenthèses et d'accolades.

let age4 = 20
if age4 >= 18 then
    printfn "Majeur"
else
    printfn "Mineur"

//Une autre particularité : en F#, if est une expression qui retourne une valeur
let age5 = 20
let resultat =
    if age5 >= 18 then
        "Majeur"
    else
        "Mineur"
printfn "%s" resultat

