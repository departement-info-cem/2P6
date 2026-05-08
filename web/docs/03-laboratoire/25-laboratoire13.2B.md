---
title: Tests unitaires - Montre
---
# 🧪 Labo 13.2B – Pratique de tests unitaires

---

## Exercice 2 – Écrire des tests unitaires pour compléter la classe ``Montre``

### 🎯 Objectif 


### 🛠️ Instructions

La classe `Montre` représente une montre numérique affichant l’heure au format :

```text
HH:MM:SS
```

La classe vous sera fournie, mais certaines parties du code seront volontairement incomplètes ou erronées:

- certains constructeurs ne seront pas entièrement implémentés ;
- certaines méthodes seront incomplètes ;
- certaines validations seront absentes.

:::warning
Votre travail consiste à appliquer une approche de **développement dirigé par les tests (DDT / TDD)**.

Pour chaque fonctionnalité de la classe `Montre`, vous devez :

1. écrire les tests unitaires correspondant au comportement attendu ;
2. exécuter les tests ;
3. identifier les erreurs ou les fonctionnalités manquantes ;
4. compléter ou corriger la classe `Montre` ;
5. exécuter de nouveau les tests ;
6. vérifier que tous les tests réussissent.
:::
---

### Description fonctionnelle

La classe `Montre` permet de représenter une heure composée :

- des heures ;
- des minutes ;
- des secondes.

Les règles suivantes doivent toujours être respectées :

- les heures doivent être comprises entre `0` et `23` ;
- les minutes doivent être comprises entre `0` et `59` ;
- les secondes doivent être comprises entre `0` et `59`.

---

### Constructeur par défaut

Le constructeur par défaut doit initialiser la montre à :

```text
00:00:00
```

#### Comportement attendu

Après la création d’une instance avec le constructeur par défaut :

- `Heures` doit valoir `0` ;
- `Minutes` doit valoir `0` ;
- `Secondes` doit valoir `0`.

---

### Constructeur avec paramètres

Le constructeur avec paramètres doit permettre d’initialiser une montre avec une heure précise.

#### Exemple

```csharp
Montre montre = new Montre(10, 30, 45);
```

#### Comportement attendu

Après la création de cette instance :

- `Heures` doit valoir `10` ;
- `Minutes` doit valoir `30` ;
- `Secondes` doit valoir `45`.

---

### Propriété `Heures`

La propriété `Heures` permet d’obtenir ou de modifier l’heure courante.

#### Domaine de validité

```csharp
0 <= Heures <= 23
```

#### Validations requises

Une exception de type `ArgumentOutOfRangeException` doit être levée si une valeur invalide est assignée.

#### Exemples de valeurs invalides

```csharp
-1
24
```

---

### Propriété `Minutes`

La propriété `Minutes` permet d’obtenir ou de modifier les minutes courantes.

#### Domaine de validité

```csharp
0 <= Minutes <= 59
```

#### Validations requises

Une exception de type `ArgumentOutOfRangeException` doit être levée si une valeur invalide est assignée.

#### Exemples de valeurs invalides

```csharp
-1
60
```

---

### Propriété `Secondes`

La propriété `Secondes` permet d’obtenir ou de modifier les secondes courantes.

#### Domaine de validité

```csharp
0 <= Secondes <= 59
```

#### Validations requises

Une exception de type `ArgumentOutOfRangeException` doit être levée si une valeur invalide est assignée.

#### Exemples de valeurs invalides

```csharp
-1
60
```

---

### Méthode `AvancerUneSeconde`

La méthode `AvancerUneSeconde` doit augmenter le temps courant d’une seconde.

#### Comportement attendu

##### Cas normal

Si la montre indique :

```text
10:30:45
```

après l’appel de la méthode, elle doit indiquer :

```text
10:30:46
```

---

##### Cas particuliers

###### Passage à la minute suivante

Si la montre indique :

```text
10:30:59
```

elle doit ensuite indiquer :

```text
10:31:00
```

---

###### Passage à l’heure suivante

Si la montre indique :

```text
10:59:59
```

elle doit ensuite indiquer :

```text
11:00:00
```

---

###### Passage à la journée suivante

Si la montre indique :

```text
23:59:59
```

elle doit ensuite revenir à :

```text
00:00:00
```

---

### Méthode `ObtenirTempsCourant`

La méthode `ObtenirTempsCourant` doit retourner l’heure courante sous forme de chaîne de caractères.

#### Format attendu

```text
HH:MM:SS
```

Les minutes et les secondes doivent toujours être affichées avec deux chiffres.

#### Exemples

```csharp
Montre montre = new Montre(8, 5, 3);
```

doit retourner :

```text
8:05:03
```

---

```csharp
Montre montre = new Montre(14, 25, 9);
```

doit retourner :

```text
14:25:09
```

---

