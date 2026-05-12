---
title: Tests unitaires (Suite)
---

:::info Travail à faire

Complétez les exercices du laboratoire 13.2 (Tests unitaires)!

Compléter le TP3 !

Polymorphisme : Comprendre l'usage de l'opérateur `is`

:::


## Polymorphisme et l'opérateur `is`

Grâce au polymorphisme, il est fréquent de manipuler plusieurs types d’objets à travers une même référence commune. 

Par exemple, une liste de `Personne` peut contenir des objets `Etudiant`, `Employe` ou d’autres types dérivés. Cela permet d’écrire un code plus flexible et générique.

Cependant, dans certaines situations, il devient nécessaire de connaître le type réel d’un objet afin d’exécuter un traitement spécifique. On peut aussi vouloir vérifier si un objet possède certaines capacités définies par une interface.

C’est dans ce contexte que l’opérateur `is` devient utile et va nous permettre de répondre à des questions comme :

* « Cette personne est-elle un étudiant ? »
* « Cet objet est-il un employé ? »

## Operateur `is` : syntaxe
```csharp
Personne p;
Question question;

// Vérifie si l'objet p est de type Etudiant
// et crée automatiquement une variable e de type Etudiant
// afin de pouvoir accéder directement aux membres spécifiques de cette classe
if (p is Etudiant e)
{
    Console.WriteLine(e.CodePermanent);
}

// Vérifie si la question implémente l'interface IReponseAvecIndice
// et crée automatiquement une variable indicee de type IReponseAvecIndice
// pour accéder directement aux méthodes et propriétés de l’interface
if (question is IReponseAvecIndice indicee)
{
    Console.WriteLine(indicee.Indice);
}
```

Si nous reprenons l’exemple d’héritage avec les classes `Personne`, `Etudiant` et `Employe`. 
```csharp
public class Personne
{
    public string Nom { get; protected set; }
    public DateTime DateDeNaissance { get; protected set; }

    public Personne(string nom, DateTime dateDeNaissance)
    {
        Nom = nom;
        DateDeNaissance = dateDeNaissance;
    }
}

public class Etudiant : Personne
{
    public string CodePermanent { get; private set; }

    public Etudiant(string nom, DateTime dateDeNaissance, string codePermanent)
        : base(nom, dateDeNaissance)
    {
        CodePermanent = codePermanent;
    }
}

public class Employe : Personne
{
    public double Salaire { get; private set; }

    public Employe(string nom, DateTime dateDeNaissance, double salaire)
        : base(nom, dateDeNaissance)
    {
        Salaire = salaire;
    }

}

```
et nous remplissons une liste de `Personne` avec des objets de type `Etudiant` ainsi que des objets de type `Employe`.


```csharp
// Création des objets

Etudiant e1 = new Etudiant("Mimi", new DateTime(2002, 5, 12), "ALIC02051201");
Etudiant e2 = new Etudiant("Adam", new DateTime(2001, 9, 3), "MARC01090302");

Employe emp1 = new Employe("Sophie", new DateTime(1988, 11, 20), 55000);
Employe emp2 = new Employe("Marc", new DateTime(1990, 2, 14), 62000);

// Liste polymorphique
List<Personne> personnes = new List<Personne>
{
    e1,
    e2,
    emp1,
    emp2
};
```
Nous pouvons parcourir la liste des personnes et afficher le **code permanent** des objets de type `Etudiant`, ainsi que le **salaire** des objets de type `Employe`.

## Solution avec `if`
```csharp
foreach (Personne p in personnes)
{
    if (p is Etudiant e)
    {
        Console.WriteLine(e.CodePermanent);
    }
    else if (p is Employe emp)
    {
        Console.WriteLine(emp.Salaire);
    }
}
```
## Solution avec `switch`
```csharp
foreach (Personne p in personnes)
{
    switch (p)
    {
        case Etudiant e:
            Console.WriteLine(e.CodePermanent);
            break;

        case Employe emp:
            Console.WriteLine(emp.Salaire);
            break;
    }
}
```






