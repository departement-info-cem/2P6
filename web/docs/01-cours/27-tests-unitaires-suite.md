---
title: Tests unitaires (Suite)
---


Grâce au polymorphisme, il est fréquent de manipuler plusieurs types d’objets à travers une même référence commune. 

Par exemple, une liste de `Personne` peut contenir des objets `Etudiant`, `Employe` ou d’autres types dérivés. Cela permet d’écrire un code plus flexible et générique.


```csharp

interface IPayable
{
    double CalculerSalaire();
}

class Personne
{
    public string Nom { get; set; }
    public DateTime DateDeNaissance { get; set; }

    public Personne(string nom, DateTime dateDeNaissance)
    {
        Nom = nom;
        DateDeNaissance = dateDeNaissance;
    }
}

class Etudiant : Personne
{
    public string CodePermanent { get; set; }

    public Etudiant(string nom, DateTime dateDeNaissance, string codePermanent)
        : base(nom, dateDeNaissance)
    {
        CodePermanent = codePermanent;
    }
}

class Employe : Personne, IPayable
{
    public double Salaire { get; set; }

    public Employe(string nom, DateTime dateDeNaissance, double salaire)
        : base(nom, dateDeNaissance)
    {
        Salaire = salaire;
    }

    public double CalculerSalaire()
    {
        return Salaire;
    }
}

```

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


foreach (Personne p in personnes)
{
    if (p is Etudiant e)
    {
        Console.WriteLine(e.CodePermanent);
    }
}

double totalPaie = 0;

foreach (IPayable p in employesAPayer)
{
    totalPaie += p.CalculerSalaire();
}

Console.WriteLine("Total de la paie : " + totalPaie);



```



