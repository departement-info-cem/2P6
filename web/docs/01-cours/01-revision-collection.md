---
description: Révision - Objet et collection
---

# Révision - Objet et collection

## 🎯 Objectifs
1. Utiliser des listes simples
2. Créer des objets avec **new** (Instancier des classes)
3. Comprendre le fonctionnement d’un objet en utilisant :
   - les propriétés exposées,
   - les méthodes disponibles,
4. Utiliser des listes d'objets
5. Utiliser des fichiers csv


## ✅ Les objets et les classes
### 1. Définition
* Une classe est un modèle ou un plan
* Un objet, c’est un exemplaire concret créé à partir de ce modèle

| Élément      | Rôle                   |
| ------------ | ---------------------- |
| Classe       | Modèle                 |
| Objet        | Exemplaire concret     |
| Propriété    | Ce que l’objet possède |
| Méthode      | Ce que l’objet fait    |
| Constructeur | Initialise l’objet     |

### 2. Instanciation

L’**instanciation** consiste à créer un objet à partir d’une classe grâce au mot-clé `new` et le **constructeur** de la classse. Le constructeur est une méthode qui porte le même nom de la classe et qui peut avoir des paramètres.

```csharp
MaClasse objet = new MaClasse();
```
  * MaClasse : le modèle existant

  * objet : le nom de l’objet

  * new : mot-clé qui signifie créer

  * MaClasse() : appel au constructeur pour fabriquer l’objet

  👉 Phrase clé à retenir : Cette instruction crée un nouvel objet à partir de la classe MaClasse.
#### Exemples d’instanciation

```csharp
// Créer un générateur de nombre à partir de la classe Random
Random generateur = new Random();
// Créer un compte bancaire à partir de la classe Compte
Compte unCompte = new Compte();
// Créer un compte bancaire avec un solde initial de 500$ à partir de la classe Compte
Compte unCompte = new Compte(500);
```

### 3. Accéder aux membres d’un objet

```csharp
Random generateur new Random();
// Utiliser la méthode Next pour générer un nombre entre 1 et 10
int nombre = generateur.Next(1, 11); 

Compte unCompte = new Compte(500);
// Accéder à la propriété Solde de l'objet pour obtenir le solde du compte
decimal solde = unCompte.Solde;
// Utiliser la méthode Deposer de l'objet pour déposer 100$
unCompte.Deposer(100);

// Utiliser la constante de la classse pout obtenir le solde maximal
decimal soldeMaximal = Compte.SOLDE_MAX;

```

💡 **À retenir :**

* Une constante est rattachée à la classe et non aux instances (objets) de cette classe.
* Une méthode/propriété statique est aussi rattachée à la classe.
* Dans els deux cas, on les utilise directement via la classe, sans avoir besoin de créer un objet.

---

## ✅ Les listes simples `List<T>`

### 1. Définition

* Une **liste** est une **collection d’éléments ordonnés**.
* `List<T>` est une **liste générique** qui peut contenir des éléments d’un **type unique** `T` (int, string, double…).
* Chaque élément a un **indice** (position) commençant à 0.

#### ⚖️ Différence entre `List<T>` et un tableau (`T[]`)

| Critère             | Tableau (`T[]`)                               | Liste (`List<T>`)                                                        |
| ------------------- | --------------------------------------------- | ------------------------------------------------------------------------ |
| Taille              | Fixe après sa création                        | Dynamique : on peut ajouter ou retirer des éléments                      |
| Redimensionnement   | Impossible (il faut créer un nouveau tableau) | Automatique                                                              |
| Méthodes intégrées  | Peu de méthodes (Length, Get/Set)             | Beaucoup de méthodes utiles : `Add`, `Remove`, `Contains`, `Clear`, etc. |
| Syntaxe de création | `int[] nombres = new int[5];`                 | `List<int> nombres = new List<int>();`                                   |
| Accès aux éléments  | Par indice : `nombres[0]`                     | Par indice : `nombres[0]` et méthodes comme `Add`, `Remove`              |

### 2. Manipuler une liste

```csharp

// Déclarer une liste
List<int> notes ; // La variable notes est initialement à null. On ne peut rien insérer dans la liste pour le moment!
// Instancier une liste 
notes = List<int>(); //  Un espace mémoire est alloué pour la variable notes. On peut commencer à insérer des éléemnts dans la liste!
// Déclarer et instancier une liste 
List<int> notes  = List<int>(); // La variable est déclarée et un espace mémoire est allouée.
// Initialiser une liste 
List<int> notes  = new List<int>() {10, 15, 58}; // crée la liste en mémoire et ajoute directement ces éléments à la liste au moment de la création

// Obtenir la taille d'une liste
int taille = liste.Count;
// Accéder à un élément dans la liste
int uneNote = liste[2];
//ou
int nombre = liste.ElementAt(2);
// Modifier le contenu d'un élément
liste[1] = -5;

// Vérifier si une valeur est dans la liste
bool estPresent = liste.Contains(15)); // estPresent contient true puisque 15 est dans la liste.

// Ajouter un élément à la fin de la liste
liste.Add(20); // le contenu de la liste est {10, -5, 58, 20}
// Supprimer un élément à ujhe position spécifiée
liste.RemoveAt(20); // le contenu de la liste est {10, -5, 58}
// Supprimer le premier élément contenant la valeur spécifiée
liste.Remove(-5); // le contenu de la liste est {10, 58}. Tous les éléments après la valeur supprimée sont décalés à gauche.
// Vider une liste
liste.Clear(); // le contenu de la liste est {}.


```

💡 **À retenir :**

* Lorsque'on supprime un élément dans une liste, tous les éléments se trouvant après la valeur supprimée seront décalés à gauche.


### 2. Parcourir une liste

#### avec une boucle `for`
```csharp
// Afficher le contenu de la liste
 for (int index = 0; index < notes.Count; index++)
 {
     Console.WriteLine(notes[index]);
 }
```
#### avec une boucle `foreach`
```csharp
// Afficher le contenu de la liste
foreach (int note in notes)
{
    Console.WriteLine(note);
}
```

💡 **À retenir :**

* avec `foreach`, impossible de modifier les éléments directement
* `for` est utile si on a besoin **de l’indice** ou pour **modifier des éléments**.
* `foreach` est pratique pour **lire tous les éléments** facilement et éviter les erreurs d’indice.



---

## ✅ Les listes simples `List<T>`

### 1. Définition

* Une **liste** est une **collection d’éléments ordonnés**.
* `List<T>` est une **liste générique** qui peut contenir des éléments d’un **type unique** `T` (int, string, double…).
* Chaque élément a un **indice** (position) commençant à 0.

#### ⚖️ Différence entre `List<T>` et un tableau (`T[]`)

| Critère             | Tableau (`T[]`)                               | Liste (`List<T>`)                                                        |
| ------------------- | --------------------------------------------- | ------------------------------------------------------------------------ |
| Taille              | Fixe après sa création                        | Dynamique : on peut ajouter ou retirer des éléments                      |
| Redimensionnement   | Impossible (il faut créer un nouveau tableau) | Automatique                                                              |
| Méthodes intégrées  | Peu de méthodes (Length, Get/Set)             | Beaucoup de méthodes utiles : `Add`, `Remove`, `Contains`, `Clear`, etc. |
| Syntaxe de création | `int[] nombres = new int[5];`                 | `List<int> nombres = new List<int>();`                                   |
| Accès aux éléments  | Par indice : `nombres[0]`                     | Par indice : `nombres[0]` et méthodes comme `Add`, `Remove`              |

### 2. Manipuler une liste

```csharp

// Déclarer une liste
List<int> notes ; // La variable notes est initialement à null. On ne peut rien insérer dans la liste pour le moment!
// Instancier une liste 
notes = List<int>(); //  Un espace mémoire est alloué pour la variable notes. On peut commencer à insérer des éléemnts dans la liste!
// Déclarer et instancier une liste 
List<int> notes  = List<int>(); // La variable est déclarée et un espace mémoire est allouée.
// Initialiser une liste 
List<int> notes  = new List<int>() {10, 15, 58}; // crée la liste en mémoire et ajoute directement ces éléments à la liste au moment de la création

// Obtenir la taille d'une liste
int taille = liste.Count;
// Accéder à un élément dans la liste
int uneNote = liste[2];
//ou
int nombre = liste.ElementAt(2);
// Modifier le contenu d'un élément
liste[1] = -5;

// Vérifier si une valeur est dans la liste
bool estPresent = liste.Contains(15)); // estPresent contient true puisque 15 est dans la liste.

// Ajouter un élément à la fin de la liste
liste.Add(20); // le contenu de la liste est {10, -5, 58, 20}
// Supprimer un élément à ujhe position spécifiée
liste.RemoveAt(20); // le contenu de la liste est {10, -5, 58}
// Supprimer le premier élément contenant la valeur spécifiée
liste.Remove(-5); // le contenu de la liste est {10, 58}. Tous les éléments après la valeur supprimée sont décalés à gauche.
// Vider une liste
liste.Clear(); // le contenu de la liste est {}.


```

💡 **À retenir :**

* Lorsque'on supprime un élément dans une liste, tous les éléments se trouvant après la valeur supprimée seront décalés à gauche.


### 2. Parcourir une liste

#### avec une boucle `for`
```csharp
// Afficher le contenu de la liste
 for (int index = 0; index < notes.Count; index++)
 {
     Console.WriteLine(notes[index]);
 }
```
#### avec une boucle `foreach`
```csharp
// Afficher le contenu de la liste
foreach (int note in notes)
{
    Console.WriteLine(note);
}
```

💡 **À retenir :**

* avec `foreach`, impossible de modifier les éléments directement
* `for` est utile si on a besoin **de l’indice** ou pour **modifier des éléments**.
* `foreach` est pratique pour **lire tous les éléments** facilement et éviter les erreurs d’indice.



## 📚 Ressources supplémentaires

👉 Notions C# : [Instanciation objet](https://info.cegepmontpetit.ca/notions-csharp/documentation/instanciation-objet)


Vous devez réaliser le labo suivant :
 [🧪 Labo 13.1](/laboratoire/laboratoire13.1)

---
