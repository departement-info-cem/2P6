---
description: Pondération 10%
---

# Git et TP1 (Partie 1)
## Qu'est-ce qu'un gestionnaire de code source

Un **gestionnaire de code source** (souvent appelé système de gestion de versions — VCS/SCM en anglais) est un outil qui permet de suivre **l’historique des modifications** d’un projet (code, documents, configuration), de **travailler à plusieurs** sans écraser le travail des autres, et de **revenir à une version antérieure** en cas d’erreur. C’est un peu comme un « **Ctrl+Z illimité** » et **collaboratif**, avec un **journal détaillé** de qui a changé quoi, quand, et pourquoi.

**Pourquoi?**

- **Suivre l'évolution de son code source.** Un système de contrôle de version est une catégorie de logiciel qui permet à une équipe de développement de gérer les changements du code source en tout temps. Il enregistre l’évolution du projet en gardant une trace de toutes les versions d’un fichier. Chaque fois qu’on valide des modifications, le gestionnaire de code source enregistre une image (snapshot) avec une référence afin d’y accéder par la suite. L’historique du projet consiste alors en une séquence d’images (snapshots). Git est l’exemple de logiciel de contrôle de versions décentralisé le plus populaire.

![](@site/static/img/R02/SCV.png)


- **Collaborer dans le cadre d'un projet d'équipe.** Lorsqu’on collabore dans le cadre d’un projet, les membres de l’équipe partagent le code source dans un référentiel ou encore dépôt distant (remote repository). Chaque membre peut avoir sa copie (clone) dans son dépôt local (local repository) pour ajouter de nouvelles fonctionnalités ou corriger des bugs et tester avant de le pousser (push) vers le dépôt distant. Le dépôt est une copie (clone) de l’ensemble des fichiers d’un projet dans un gestionnaire de versions.

![](@site/static/img/R02/DepotLocalEtDistant.png)

## Git

### Qu'est-ce que c'est?

### Installation

### Créer un dépôt
1.	Si ce n’est pas fait, vous devez créer un compte GitHub avec votre compte du cégep (matricule@cegepmontpetit.ca ). Regardez la capsule vidéo sur Moodle et accéder à cette page pour le créer et avoir le Student Service Pack : https://education.github.com/pack
2.	Connectez-vous à GitHub avec votre compte du cégep (matricule@cegepmontpetit.ca) 
3.	Créez un nouveau dépôt GitHub privé et le nommez selon ce format en mettant votre propre matricule. Exemple: H26-2P6-R02Ex-MATRICULE  

:::info
Exceptionnellement, dans notre cours 2N6 on va utiliser ce format. Sinon, pour les autres cours, vous devez faire référence à la page Git du département et les consignes de votre professeur ! https://info.cegepmontpetit.ca/git
::: 

![](@site/static/img/R02/newRepo.png)

4.	Ajoutez votre professeur comme collaborateur à votre projet. (Sur votre repository, Onglet settings, Manage Access, Add a collaborator). Utilisez l’une des deux adresses courriel suivantes selon votre groupe :
    - Groupes 1010, 1020 	: jamil.gammoudi@cegepmontpetit.ca
    - Groupes 1030, 1040 	: david.gagne-leroux@cegepmontpetit.ca
    - Groupe 1050       	: philippe.martel@cegepmontpetit.ca
    - Groupe 1060           : jimmy.beaubien@cegepmontpetit.ca

![](@site/static/img/R02/collaborators.png)

### Cloner un dépôt

### Enregistrer des changements

### Voir l'historique

### Comment corriger

### Les commandes de base

| Comamnde  | Description |
| --------- | ------------------ |
| **clone** | Crée une **copie locale** d'un dépôt Git existant. |
| **commit** | Crée un **noeud** dans le dépôt contenant les modificatons apportées aux fichiers qui ont été placés à l'état "staged". Il faut spécifier un message aux changements apportés. |
| **branch** | Crée une **nouvelle branche** dans le dépôt. Ceci permet d'avoir une copie avec des changements isolés des autres branches. |
| **merge** | **Fusionne** une branche dans une autre. Cette opération peut être à l'origine de conflits que nous devons résoudre manuellement. |
| **push** | **Pousse** tous les noeuds locales de la branche vers la branche du **dépôt distant**. Il est possible que cette opération produise des conflits. |
| **pull** | **Récupère** les modifications du **dépôt distant**. Si il y a une différence entre la branche locale et distante, les deux branches seront fusionnnées et une opération merge + commit se exécutée. |

## Liens utils

## Labo
<!-- 
## 🧠 Théorie Rencontre 2

[Variable](https://info.cegepmontpetit.ca/notions-csharp/documentation/variable/variable) : une variable est une zone mémoire identifiée permettant de stocker et modifier une valeur durant l'exécution d'un programme.

## 1. Déclaration et affectation

La déclaration d'une variable signifie que l'on réserve un espace mémoire pour stocker une valeur d'un type précis. L'affectation consiste à attribuer une valeur à cette variable.

### 🧱 Syntaxe générale
```csharp
type nomDeVariable = valeur;
```

### 📝 Règles de nommage
[Identificateur](https://info.cegepmontpetit.ca/notions-csharp/documentation/identificateur) : un identificateur est un nom choisi pour désigner variables, méthodes, etc., selon des conventions précises de style.
- Une variable commence par une lettre (pas de chiffre au début)
- Elle ne peut pas contenir d'espaces ou de symboles spéciaux
- Convention : camelCase (`monNom`, `nombreTotal`)

### 🔹 Exemples
```csharp
int age = 25;
char lettre = 'C';
bool estValide = true;
string nom = "Louis";
```

### 🔄 Assignation après déclaration

[Assignation](https://info.cegepmontpetit.ca/notions-csharp/documentation/assignation) : l'assignation utilise `=` pour placer une valeur calculée ou littérale dans une variable.

Vous pouvez aussi déclarer une variable sans lui donner de valeur immédiatement, puis l'affecter plus tard :
```csharp
int score;
score = 100;
```
## 2. Types de base en C#

[Types de données](https://info.cegepmontpetit.ca/notions-csharp/documentation/types-de-donnees) : Types de données

Les types de base sont les types fondamentaux utilisés pour déclarer des variables. Voici les plus courants en C# :

### 🔢 int
- Représente un **entier** (positif ou négatif).
- Exemples :
```csharp
int age = 18;
int score = -10;
```

### 🔣 char
- Représente un **caractère unique**.
- Utilise des apostrophes : `'A'`, `'b'`
- Exemples :
```csharp
char lettre = 'A';
```

### 🧮 double
- Représente un **nombre décimal** avec plus de précision que `float`.
- Exemples :
```csharp
double pi = 3.14159;
double note = 87.5;
```

### 🔁 bool
- Représente un **booléen** : `true` ou `false`
- Utilisé pour les conditions
```csharp
bool estConnecte = true;
bool aFini = false;
```

### 🧵 string
- Représente une **chaîne de caractères**.
- Utilise des guillemets : "Bonjour"
```csharp
string nom = "Alice";
string message = "Bienvenue!";
```

## 3. Concaténation de chaînes

La concaténation consiste à assembler plusieurs chaînes de caractères en une seule.

### ➕ Opérateur `+`
L’opérateur `+` permet de combiner des chaînes et des variables de type `string`.
```csharp
string nom = "Alice";
string message = "Bonjour, " + nom + "!";
Console.WriteLine(message);
```

### 📦 Concaténation avec autres types
On peut concaténer des types différents (comme `int`) avec des chaînes : ils sont automatiquement convertis en texte.
```csharp
int age = 30;
Console.WriteLine("Âge : " + age);
```

### 📏 Mise en forme avancée : interpolation (facultatif)
On peut aussi utiliser l’interpolation (niveau plus avancé, à présenter plus tard) :
```csharp
string nom = "Bob";
Console.WriteLine($"Salut, {nom}!");
```
## 4. Opérations arithmétiques

Les opérations arithmétiques permettent de manipuler des valeurs numériques (`int`, `double`).

### ➕ Opérations de base
```csharp
int a = 10;
int b = 3;

int somme = a + b;       // Addition
int difference = a - b;  // Soustraction
int produit = a * b;     // Multiplication
int quotient = a / b;    // Division entière
int reste = a % b;       // Modulo (reste de la division)
```

### 🧠 Exemple
```csharp
int x = 7;
int y = 2;
Console.WriteLine("x + y = " + (x + y)); //Donne 9
Console.WriteLine("x % y = " + (x % y)); //Donne 1
```

### 🔢 Avec `double`
```csharp
double prix = 12.99;
double taxe = 0.15 * prix;
Console.WriteLine("Taxe : " + taxe); //Donne 1,9485
```

### ⚠️ Division entière
Lorsque vous divisez deux `int`, le résultat est un entier (le reste est perdu). Pour un résultat avec décimales, utilisez `float`, `double` ou `decimal`.
```csharp
int a = 7;
int b = 2;
Console.WriteLine(a / b); // Résultat : 3 (pas 3.5)
```

### 📐 Priorité des opérateurs
En C#, certaines opérations sont effectuées avant d'autres, selon la priorité :
1. Parenthèses `()`
2. Multiplication `*`, division `/`, modulo `%`
3. Addition `+` et soustraction `-`

Exemple :
```csharp
int resultat = 2 + 3 * 4;      // Donne 14 (car 3*4 est calculé avant)
int correct = (2 + 3) * 4;     // Donne 20
```

### 🔁 Permutation de valeurs
Il arrive souvent qu’on veuille échanger la valeur de deux variables. Cette opération s’appelle une **permutation**.

```csharp
int a = 5;
int b = 10;

// Permuter les valeurs de a et b
int temporaire = a;
a = b;
b = temporaire;

Console.WriteLine("a = " + a); // a = 10
Console.WriteLine("b = " + b); // b = 5
```
## 5. Conversion de types

Lorsqu’on lit une entrée utilisateur via `Console.ReadLine()`, on obtient toujours une **chaîne de caractères (`string`)**. Pour utiliser cette entrée comme un nombre, il faut la convertir.

### 🔁 Convertir une `string` en `int`
```csharp
Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();
int age = int.Parse(saisie);
```

### 🔁 Convertir en `double`
```csharp
Console.Write("Entrez un prix : ");
string entree = Console.ReadLine();
double prix = double.Parse(entree);
```


### 🛑 Attention aux erreurs !
Si l’utilisateur entre un texte non numérique (ex: "abc"), `int.Parse()` ou `double.Parse()` déclencheront une **erreur d’exécution**.

### ✅ Astuce (plus tard) : `TryParse()`
Pour éviter les erreurs, on peut utiliser `TryParse()`, mais cette méthode sera vue plus tard dans le cours.

Voici les documents de référence :




- [Opérateur](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur) : un opérateur réalise des opérations arithmétiques, logiques ou d’assignation entre variables et littéraux.
- [Priorité des opérateurs](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur/priorite) : la priorité des opérateurs détermine l’ordre dans lequel les opérations sont évaluées, comme dans les expressions mathématiques.
- [Littéral](https://info.cegepmontpetit.ca/notions-csharp/documentation/litteral) : un littéral représente une valeur fixe directement inscrite dans le code, comme un nombre ou une chaîne de caractères.

Vous devez réaliser les labos suivants :
 [🧪 Labo 1.2A](/laboratoire/laboratoire1.2A)
 [🧪 Labo 1.2B](/laboratoire/laboratoire1.2B) -->
