---
title: Tests unitaires - Stats
---

# 🧪 Labo 13.2C – Pratique de tests unitaires

---

## Exercice 3 – Écrire des tests unitaires pour compléter la classe `Statistiques`

### 🎯 Objectif

Appliquer une approche de **développement dirigé par les tests (DDT / TDD)** afin de compléter progressivement la classe `Statistiques`.

---

### 🛠️ Instructions

La classe `Statistiques` permet de travailler avec une collection de nombres entiers.

La classe vous sera fournie, mais certaines parties du code seront volontairement incomplètes ou erronées :

- certains constructeurs ne seront pas entièrement implémentés ;
- certaines méthodes seront incomplètes ;
- certaines validations seront absentes.

:::warning
Votre travail consiste à appliquer une approche de **développement dirigé par les tests (DDT / TDD)**.

Pour chaque fonctionnalité de la classe `Statistiques`, vous devez :

1. écrire les tests unitaires correspondant au comportement attendu ;
2. exécuter les tests ;
3. identifier les erreurs ou les fonctionnalités manquantes ;
4. compléter ou corriger la classe `Statistiques` ;
5. exécuter de nouveau les tests ;
6. vérifier que tous les tests réussissent.
:::

---

### Description fonctionnelle

La classe `Statistiques` contient une collection de nombres entiers appelée `ColNombres`.

Elle permet notamment de :

- créer une collection vide ;
- créer une collection à partir d’une liste existante ;
- ajouter un nombre ;
- compter le nombre d’occurrences d’un nombre ;
- calculer la somme des nombres ;
- calculer la moyenne ;
- obtenir les nombres pairs.

---

### Constructeur par défaut

Le constructeur par défaut doit initialiser une collection vide.

#### Comportement attendu

Après la création d’une instance avec le constructeur par défaut :

- `ColNombres` ne doit pas être `null` ;
- `ColNombres` doit contenir `0` éléments.

---

### Constructeur avec paramètres

Le constructeur avec paramètres doit permettre d’initialiser un objet `Statistiques` avec une collection de nombres entiers.

#### Exemple

```csharp
List<int> nombres = new List<int>() { 2, 4, 6 };

Statistiques statistiques =
    new Statistiques(nombres);
```

#### Comportement attendu

Après la création de cette instance :

- `ColNombres` ne doit pas être `null` ;
- `ColNombres` doit contenir les valeurs `2`, `4` et `6` dans le même ordre.

#### Validation requise

Une exception de type `ArgumentNullException` doit être levée si la collection passée en paramètre est `null`.

#### Exemple de valeur invalide

```csharp
null
```

---

### Propriété `Somme`

La propriété `Somme` doit calculer le total des nombres contenus dans la collection.

#### Exemple

```csharp
Statistiques statistiques =
    new Statistiques(new List<int>() { 2, 4, 6 });

int resultat = statistiques.Somme();
```

#### Comportement attendu

La valeur retournée doit être :

```csharp
12
```

Si la collection est vide, la méthode doit retourner :

```csharp
0
```
---

### Propriété `Moyenne`

La propriété `Moyenne` doit calculer la moyenne des nombres contenus dans la collection.

#### Exemple

```csharp
Statistiques statistiques =
    new Statistiques(new List<int>() { 10, 20, 30 });

decimal resultat = statistiques.Moyenne();
```

#### Comportement attendu

La valeur retournée doit être :

```csharp
20
```

Si la collection est vide, la méthode doit retourner :

```csharp
0
```

---

### Propriété `NombresPairs`

La propriété `NombresPairs` doit retourner une nouvelle collection contenant uniquement les nombres pairs de `ColNombres`.

#### Exemple

```csharp
Statistiques statistiques =
    new Statistiques(new List<int>() { 1, 2, 3, 4, 5, 6 });

List<int> resultat = statistiques.NombresPairs();
```

#### Comportement attendu

La collection retournée doit contenir :

```csharp
2
4
6
```

Si aucun nombre pair n’est présent, la méthode doit retourner une collection vide.

La méthode ne doit pas modifier la collection originale `ColNombres`.


---

### Méthode `Ajouter`

La méthode `Ajouter` permet d’ajouter un nombre entier à la fin de la collection.

#### Exemple

```csharp
Statistiques statistiques = new Statistiques();

statistiques.Ajouter(10);
```

#### Comportement attendu

Après l’appel de la méthode :

- la collection doit contenir le nombre ajouté ;
- le nombre doit être ajouté à la fin de la collection ;
- le nombre d’éléments doit augmenter de `1`.

#### Validation requise

Une exception de type `ArgumentOutOfRangeException` doit être levée si le nombre à ajouter est négatif.

#### Exemple de valeur invalide

```csharp
-1
```

---

### Méthode `NbOccurences`

La méthode `NbOccurences` doit retourner le nombre de fois qu’un nombre apparaît dans la collection.

#### Exemple

```csharp
Statistiques statistiques =
    new Statistiques(new List<int>() { 2, 4, 2, 6, 2 });

int resultat = statistiques.NbOccurences(2);
```

#### Comportement attendu

La valeur retournée doit être :

```csharp
3
```

Si le nombre n’existe pas dans la collection, la méthode doit retourner :

```csharp
0
```

