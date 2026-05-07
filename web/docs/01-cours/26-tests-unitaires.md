---
description: Tests unitaires
---

# Tests unitaires
---

### Télécharger la démonstration à compléter

Disponible ici 👉 [Demonstration13_2](../../static/files/demonstrations/Demo_13.2_A_COMPLETER.zip)

---
## 🎯 Objectifs

À la fin de cette séance, vous serez en mesure de :

- comprendre l’utilité des tests unitaires ;
- générer un projet de tests unitaires ;
- définir des classes et des méthodes de tests ;
- utiliser les principales méthodes d’assertion ;
- exécuter des tests unitaires ;
- interpréter les résultats des tests ;
- détecter des erreurs dans un programme ;
- corriger un programme à l’aide des tests unitaires.

---

## Mise en situation

Dans ce cours, nous allons utiliser la classe `Thermostat` afin d’apprendre à écrire des tests unitaires.

La classe fournie n’est volontairement pas complète. Certaines parties du code devront être complétées ou corrigées.

L’objectif est donc de :

- écrire des tests unitaires ;
- exécuter les tests ;
- identifier les erreurs ;
- corriger la classe `Thermostat` ;
- vérifier que les tests réussissent correctement.

Cette approche s’inspire du développement dirigé par les tests (*Test-Driven Development* ou **TDD**), dans lequel les tests servent à détecter les problèmes et à guider le développement du programme.

:::info
Nous allons voir ensemble :

- comment générer un projet de tests ;
- comment définir des classes et des méthodes de tests ;
- comment exécuter les tests ;
- comment détecter et corriger des erreurs dans le programme.
:::

## Test unitaire 
### Définition

* Un test unitaire est un procédé permettant de s'assurer du **bon fonctionnement** d'une **unité de programme**.
* Un test est donc un **bout de code** qui permet de tester un autre **code**.

### Utilité

* **Vérifier** que le programme **fonctionne comme prévu**
 > *(Exemple : la température augmente correctement lorsqu’on appelle la méthode `AugmenterTemperature`.)*

* **Détecter** rapidement les **erreurs** dans le programme
 > *(Exemple : découvrir qu’une méthode retourne une mauvaise valeur ou provoque une erreur inattendue.)*

---

## Qu’est-ce qu’on teste exactement dans un programme ?

Quand on fait un test unitaire, on essaie simplement de vérifier que notre programme fonctionne correctement dans plusieurs situations.
- L’objectif est de répondre à des questions comme :
    - Est-ce que la méthode retourne le bon résultat ?
    - Est-ce que les données sont bien modifiées ?
    - Est-ce que les validations fonctionnent ?
    - Est-ce que les erreurs sont bien détectées ?
    - Est-ce que les exceptions sont bien levées ?

---

## Exemples simples de choses à tester

### Tester une valeur retournée

On veut vérifier que le résultat produit par une méthode est correct.

**Exemple**

```csharp
int resultat = Additionner(2, 3);
```

On veut vérifier que le résultat vaut bien `5`.

---

### Tester une modification d’état

Certaines méthodes modifient les données d’un objet.

**Exemple**

```csharp
thermostat.AugmenterTemperature();
```

Après l’appel de la méthode, on veut vérifier que la température a augmenté de 1.

---

### Tester les limites

On doit vérifier ce qui arrive avec des valeurs minimales ou maximales.

**Exemple**

```csharp
Thermostat thermostat = new Thermostat(35);
thermostat.AugmenterTemperature();
```

Si `35` est la température maximale permise, on peut tester ce qui arrive si on essaie encore d’augmenter la température.

---

### Tester des valeurs invalides

On vérifie que le programme refuse les mauvaises données.

**Exemple**

```csharp
CompteBancaire compte = new CompteBancaire(-100);
```

Un solde négatif pourrait être interdit.

On teste donc si le programme déclenche une erreur correctement.

---

### Tester des objets null

On vérifie ce qui arrive lorsqu’un objet n’existe pas.

**Exemple**

```csharp id="ym7a0s"
Client client = null;
```

Certaines méthodes doivent gérer cette situation sans faire planter le programme.

---

### Tester des listes vides

On veut vérifier le comportement du programme lorsqu’il n’y a aucune donnée.

**Exemple**

```csharp id="f7p8y3"
List<string> noms = new List<string>();
```

Par exemple :

* afficher un message ;
* retourner `0` ;
* ou empêcher une opération.

---

### Tester des chaînes de caractères vides

**Exemple**

```csharp id="0vd0m6"
string nom = "";
```

ou

```csharp id="x4v8m2"
string nom = null;
```

On vérifie si le programme refuse un nom vide.

---

### Tester des fichiers inexistants

**Exemple**

```csharp id="2q2o91"
string chemin =
    "C:\\Documents\\test.txt";
```

On vérifie ce qui arrive si le fichier n’existe pas.

---

## En résumé

:::warning
Quand on prépare des tests, on doit penser à plusieurs types de situations :

* **Cas normaux**  
  Tester une utilisation normale du programme.  

  *(Exemple : augmenter la température lorsque celle-ci est à 20.)*

* **Cas limites**  
  Tester les valeurs minimales et maximales permises.  

  *(Exemple : augmenter la température lorsqu’elle est déjà à la valeur maximale de 35.)*

* **Erreurs possibles**  
  Tester des situations pouvant provoquer une erreur ou une exception.  

  *(Exemple : essayer d’ouvrir un fichier qui n’existe pas.)*

* **Données vides**  
  Tester le comportement du programme avec des données vides.  

  *(Exemple : une chaîne vide `""` ou une liste sans éléments.)*

* **Valeurs invalides**  
  Tester des valeurs qui ne respectent pas les règles du programme.  

  *(Exemple : créer un compte bancaire avec un solde négatif.)*

Un **bon test** permet de **vérifier** que le programme **fonctionne correctement** dans **toutes les situations importantes**.
:::


# Étapes d'un test unitaire

En général, un test unitaire se décompose en trois parties suivant le modèle **AAA** :

* **Arrange (Arranger)**
  Préparer les objets et les données nécessaires au test.

* **Act (Agir)**
  Exécuter la méthode ou l’action à tester.

* **Assert (Auditer)**
  Vérifier que le résultat obtenu correspond au résultat attendu.

---

## Exemple : Test de la méthode `AugmenterTemperature`


```csharp id="u8j3vp"
public void TestsAugmenterTemperature()
{
    // Arranger (Arrange)
    Thermostat unThermostat = new Thermostat(15);

    // Agir (Act)
    unThermostat.AugmenterTemperature();
    int valeurRetournee = unThermostat.Temperature;

    // Auditer (Assert)
    int valeurAttendue = 16;

    Assert.AreEqual(valeurAttendue, valeurRetournee);
}
```

---

## Arrange (Arranger)

```csharp id="7z9xla"
Thermostat unThermostat = new Thermostat(15);
```

Dans cette étape, on prépare les objets et les données nécessaires au test.

Ici, on crée un thermostat dont la température initiale est `15`.

---

## Act (Agir)

```csharp id="4m1rke"
unThermostat.AugmenterTemperature();

int valeurRetournee = unThermostat.Temperature;
```

Dans cette étape, on exécute la méthode que l’on veut tester.

Ici, on augmente la température du thermostat puis on récupère la nouvelle valeur de la température.

---

## Assert (Auditer)

```csharp id="5h0btr"
int valeurAttendue = 16;

Assert.AreEqual(valeurAttendue, valeurRetournee);
```

Dans cette étape, on vérifie que le résultat obtenu correspond au résultat attendu.

Ici, on s’attend à ce que la température soit passée de `15` à `16`. Le test vérifie donc que la valeur retournée est bien `16`.

---

# Principales méthodes d’assertion

## AreEqual

Le test échoue si les deux valeurs sont différentes.

```csharp
Assert.AreEqual(valeurAttendue, valeurRetournee);
```

---

## AreNotEqual

Le test échoue si les deux valeurs sont identiques.

```csharp
Assert.AreNotEqual(valeurAttendue, valeurRetournee);
```

---

## IsTrue

Le test échoue si l’expression est fausse.

```csharp
Assert.IsTrue(expression);
```

---

## IsFalse

Le test échoue si l’expression est vraie.

```csharp
Assert.IsFalse(expression);
```

---

## IsNull

Le test échoue si l’objet n’est pas `null`.

```csharp
Assert.IsNull(objet);
```

---

## IsNotNull

Le test échoue si l’objet est `null`.

```csharp
Assert.IsNotNull(objet);
```

---

## Fail

Le test échoue systématiquement.

```csharp
Assert.Fail();
```

---

# Tester une méthode qui lève une exception

```csharp
[TestMethod()]
public void AugmenterTemperatureTest()
{
    // Arranger (Arrange)
    // On crée un thermostat avec la température maximale permise
    Thermostat unThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);

    // Agir/Auditer (Act/Assert)
    // On essaie d’augmenter la température.
    // Le test vérifie qu’une exception de type
    // InvalidOperationException est bien déclenchée.
    Assert.ThrowsException<InvalidOperationException>(
        () => unThermostat.AugmenterTemperature()
    );


}
```

```csharp
Assert.ThrowsException<InvalidOperationException>(
    () => thermostat.AugmenterTemperature()
);
```

👉 Cette instruction vérifie que la méthode `AugmenterTemperature()` provoque bien une exception de type `InvalidOperationException`.

---

# Jeu de tests unitaires

Tester uniquement quelques exemples ne garantit pas l’absence d’erreurs.

Un jeu de tests est un ensemble de cas de tests permettant de couvrir différents scénarios possibles.

---

## Bonne pratique : définir des constantes pour les données de test

Dans les tests unitaires, il est recommandé de définir des constantes pour les valeurs utilisées dans les tests.

Cela permet :

- d’éviter de répéter les mêmes valeurs ;
- de rendre les tests plus faciles à lire ;
- de modifier les données plus facilement.

### Exemple

```csharp
// Valeurs limites
const int TEMPERATURE_MIN_TEST = 5;
const int TEMPERATURE_MAX_TEST = 35;

// Valeurs nominales (normales)
const int TEMPERATURE_NORMALE_TEST = 20;

// Valeurs hors limites
const int TEMPERATURE_HORS_LIMITE_BASSE_TEST = -1;
const int TEMPERATURE_HORS_LIMITE_HAUTE_TEST = 36;


// Objet null
const Question QUESTION_NULL_TEST = null;

// chaine vide ou null
const string NOM_QUESTION_VIDE_TEST = "";
const string NOM_QUESTION_NULL_TEST = null
```

Ces constantes peuvent ensuite être réutilisées dans plusieurs tests.

```csharp
Thermostat thermostat = new Thermostat(TEMPERATURE_NORMALE_TEST);
```

ou

```csharp
Assert.ThrowsException<ArgumentException>(
    () => new Thermostat(
        TEMPERATURE_HORS_LIMITE_HAUTE_TEST
    )
);
```
ou

```csharp
QUiz unQuiz = new Quiz();

Assert.ThrowsException<ArgumentNullException>(
    () => nQuiz.AjouterQuestion(QUESTION_NULL_TEST)
);
```


---






# Structure générale d’une classe de tests

```csharp
[TestClass]
public class ClasseDeTest
{
    [TestMethod]
    public void MethodeDeTest()
    {
        // Arrange
        // Préparer les objets et les données

        // Act
        // Exécuter la méthode à tester

        // Assert
        // Vérifier le résultat obtenu
    }
}
```

## Explication

- `[TestClass]`  
  Indique que la classe contient des tests unitaires.

- `[TestMethod]`  
  Indique qu’une méthode représente un test unitaire.

- `Arrange`  
  Préparer les objets et les données nécessaires au test.

- `Act`  
  Exécuter l’action ou la méthode à tester.

- `Assert`  
  Vérifier que le résultat obtenu correspond au résultat attendu.

