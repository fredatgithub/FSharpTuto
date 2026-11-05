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

// boucle for
for i in 1..5 do
    printfn "%d" i

// boucle while
let mutable i = 1

while i <= 5 do
    printfn "%d" i
    i <- i + 1

// Tu peux aussi utiliser downto
for i in 10 .. -1 .. 1 do
    printfn "%d" i

// Les fonctions
let addition a b =
    a + b

//Pour appeler la fonction
let resultat2 = addition 10 20

printfn "%d" resultat2

// Tu peux aussi préciser les types
let addition2 (a: int) (b: int) : int =
    a + b

// les fonctions peuvent être utilisées comme des valeurs
let multiplierParDeux x = x * 2
let resultat3 = multiplierParDeux 10
printfn "%d" resultat3

// Les listes
// Attention : les éléments sont séparés par des points-virgules
let nombres = [1; 2; 3; 4; 5]
// Tu peux parcourir une liste
for nombre in nombres do
    printfn "%d" nombre

// Les tableaux
let nombres2 = [1; 2; 3; 4; 5]
let doubles = List.map (fun x -> x * 2) nombres2
let pairs = List.filter (fun x -> x % 2 = 0) nombres2
let somme = List.sum nombres

// Le pattern matching
// En C#, tu connais probablement switch
let afficherJour jour =
    match jour with
    | 1 -> "Lundi"
    | 2 -> "Mardi"
    | 3 -> "Mercredi"
    | 4 -> "Jeudi"
    | 5 -> "Vendredi"
    | 6 -> "Samedi"
    | 7 -> "Dimanche"
    | _ -> "Jour invalide"
// Le caractère _ signifie « tous les autres cas »
printfn "%s" (afficherJour 3) // Mercredi

let resultat4 valeur =
    match valeur with
    | 0 -> "Zéro"
    | n when n > 0 -> "Positif"
    | _ -> "Négatif"

// Les records permettent de créer des structures de données
type Personne =
    {
        Nom: string
        Age: int
    }

let personne =
    {
        Nom = "Jean"
        Age = 35
    }

printfn "%s a %d ans" personne.Nom personne.Age
// Les records F# sont immuables par défaut
let nouvellePersonne =  { personne with Age = 36 }

printfn "%s a %d ans" nouvellePersonne.Nom nouvellePersonne.Age

type Resultat =
    | Succes of int
    | Erreur of string

let resultat1 = Succes 100
let resultat5 = Erreur "Une erreur est survenue"

let afficherResultat resultat =
    match resultat with
    | Succes valeur ->
        printfn "Résultat : %d" valeur

    | Erreur message ->
        printfn "Erreur : %s" message

let rechercherAge nom =
    if nom = "Jean" then
        Some 35
    else
        None

let age2 = rechercherAge "Jean"

match age2 with
| Some valeur ->
    printfn "Age : %d" valeur

| None ->
    printfn "Personne introuvable"

// Le pipeline |> permet d'envoyer le résultat d'une expression vers une fonction
let nombres3 = [1; 2; 3; 4; 5]

let resultat6 =
    nombres3
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * 10)
    |> List.sum

printfn "%d" resultat6

type Calculatrice() =

    member this.Addition(a: int, b: int) =
        a + b

    member this.Multiplication(a: int, b: int) =
        a * b

let calculatrice = Calculatrice()

let resultat7 = calculatrice.Addition(10, 20)

printfn "%d" resultat7

let estPremier n =
    if n < 2 then
        false
    else
        let mutable premier = true
        let mutable diviseur = 2

        while diviseur * diviseur <= n && premier do
            if n % diviseur = 0 then
                premier <- false

            diviseur <- diviseur + 1

        premier

let nombreMax = 100

let nombresPremiers =
    [2..nombreMax]
    |> List.filter estPremier

printfn "Nombres premiers jusqu'à %d :" nombreMax

nombresPremiers
|> List.iter (fun n -> printf "%d " n)

printfn ""

