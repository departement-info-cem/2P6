---
title: Tests unitaires - Chat
---
# 🧪 Labo 13.1A – Pratique de tests unitaires

---

## Exercice 1 – Écrire des tests unitaires pour compléter la classe `Chat`




### 🎯 Objectif

Appliquer une approche de **développement dirigé par les tests (DDT / TDD)** afin de compléter progressivement la classe `Chat`.

---

### 🛠️ Instructions

La classe `Chat` représente un chat avec :

- un nom ;
- un âge.

La classe vous sera fournie, mais certaines parties du code seront volontairement incomplètes ou erronées :

- le constructeur pourrait être incomplet ;
- certaines validations pourraient être absentes ;
- certaines propriétés pourraient être mal implémentées.

:::warning
Votre travail consiste à appliquer une approche de **développement dirigé par les tests (DDT / TDD)**.

Pour chaque fonctionnalité de la classe `Chat`, vous devez :

1. écrire les tests unitaires correspondant au comportement attendu ;
2. exécuter les tests ;
3. identifier les erreurs ou les fonctionnalités manquantes ;
4. compléter ou corriger la classe `Chat` ;
5. exécuter de nouveau les tests ;
6. vérifier que tous les tests réussissent.
:::

---

### Description fonctionnelle

La classe `Chat` permet de représenter un chat à l’aide de deux informations :

- `Nom` : le nom du chat ;
- `Age` : l’âge du chat en années.

---

### Constructeur avec paramètres

Le constructeur doit permettre d’initialiser un chat avec un nom et un âge.

#### Exemple

```csharp
Chat chat = new Chat("Minou", 3);
```

#### Comportement attendu

Après la création de cette instance :

- `Nom` doit valoir `"Minou"` ;
- `Age` doit valoir `3`.

---

### Propriété `Nom`

La propriété `Nom` permet d’obtenir ou de modifier le nom du chat.

#### Domaine de validité

Le nom du chat :

- ne doit pas être `null` ;
- doit contenir au moins `3` caractères après avoir retiré les espaces au début et à la fin.

#### Validations requises

Une exception de type `ArgumentNullException` doit être levée si le nom est `null`.

Une exception de type `ArgumentException` doit être levée si le nom contient moins de `3` caractères.

#### Exemples de valeurs invalides

```csharp
null
```

```csharp
""
```

```csharp
"  "
```

```csharp
"Mi"
```

---

### Propriété `Age`

La propriété `Age` permet d’obtenir ou de modifier l’âge du chat.

#### Domaine de validité

```csharp
Age > 0
```

#### Validations requises

Une exception de type `ArgumentException` doit être levée si l’âge est plus petit ou égal à 0.

#### Exemple de valeur invalide

```csharp
0
```

---

### Travail demandé

Créer une classe de tests unitaires permettant de valider :

- la création d’un chat avec des valeurs valides ;
- la propriété `Nom` avec une valeur valide ;
- la propriété `Nom` avec une valeur `null` ;
- la propriété `Nom` avec une chaîne vide ;
- la propriété `Nom` avec une chaîne contenant seulement des espaces ;
- la propriété `Nom` avec moins de `3` caractères ;
- la propriété `Age` avec une valeur valide ;
- la propriété `Age` avec une valeur négative.

---