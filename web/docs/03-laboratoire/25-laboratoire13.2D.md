---
title: Tests unitaires - RefugeChats
---
# 🧪 Labo 13.2D – Pratique de tests unitaires

---

## Exercice 4 – Écrire des tests unitaires pour compléter la classe `RefugeChats`

### 🛠️ Instructions

La classe `RefugeChats` représente une collection de chats.

Elle permet notamment :

- d’ajouter des chats ;
- de supprimer des chats ;
- de vérifier si un matricule existe ;
- de rechercher des chats selon leur âge.

La classe vous sera fournie, mais certaines parties du code seront volontairement incomplètes ou erronées :

- certaines validations pourraient être absentes ;
- certaines méthodes pourraient être incomplètes ;
- certaines fonctionnalités pourraient être mal implémentées.

:::warning
Votre travail consiste à appliquer une approche de **développement dirigé par les tests (DDT / TDD)**.

Pour chaque fonctionnalité de la classe `RefugeChats`, vous devez :

1. écrire les tests unitaires correspondant au comportement attendu ;
2. exécuter les tests ;
3. identifier les erreurs ou les fonctionnalités manquantes ;
4. compléter ou corriger la classe `RefugeChats` ;
5. exécuter de nouveau les tests ;
6. vérifier que tous les tests réussissent.
:::

---

### Description fonctionnelle

La classe `RefugeChats` permet de gérer une collection de chats à l’aide de la propriété suivante :

- `ColChats` : la liste des chats du refuge.

---

### Constructeurs

La classe possède deux constructeurs :

```csharp id="f0d9qz"
RefugeChats refuge = new RefugeChats();
````

et

```csharp id="r6m2xv"
RefugeChats refuge = new RefugeChats(listeChats);
```

#### Comportement attendu

* le constructeur sans paramètre doit créer une liste vide ;
* le constructeur recevant une liste ne doit pas accepter une valeur `null`.

#### Validation requise

Une exception de type `ArgumentNullException` doit être levée si la liste reçue est `null`.

---

### Méthode `MatriculeExiste`

La méthode `MatriculeExiste` permet de vérifier si un chat avec ce matricule est déjà présent dans la collection.

#### Exemple

```csharp 
bool existe = refuge.MatriculeExiste("A123");
```

#### Comportement attendu

* retourne `true` si un chat avec ce matricule existe ;
* retourne `false` sinon.

La comparaison doit ignorer :

* les espaces au début et à la fin ;
* La comparaison ne doit pas être sensible à la casse (pas de différences entre majuscules et minuscules).

---

### Méthode `Ajouter`

La méthode `Ajouter` permet d’ajouter un chat à la collection.

#### Exemple

```csharp
refuge.Ajouter(chat);
```

#### Validations requises

Une exception de type `ArgumentNullException` doit être levée si le chat est `null`.

Une exception de type `InvalidOperationException` doit être levée si un chat avec le même matricule existe déjà dans la collection.

#### Comportement attendu

Si le chat est valide :

* il doit être ajouté à la collection ;
* le nombre de chats doit augmenter.

---

### Méthode `Supprimer`

La méthode `Supprimer` permet de supprimer un chat à une position donnée dans la collection.

#### Exemple

```csharp
refuge.Supprimer(0);
```

#### Domaine de validité

L’index doit être compris entre :

```csharp
0 et ColChats.Count - 1
```

#### Validation requise

Une exception de type `ArgumentOutOfRangeException` doit être levée si l’index est invalide.

#### Exemples de valeurs invalides

```csharp
-1
```

```csharp
ColChats.Count
```

---

### Méthode `ChatsSelonAge`

La méthode `ChatsSelonAge` permet d’obtenir la liste des chats dont l’âge est supérieur à un âge donné.

#### Exemple

```csharp
List<Chat> chats = refuge.ChatsSelonAge(5);
```

#### Comportement attendu

La méthode doit retourner :

* une nouvelle liste ;
* contenant uniquement les chats ayant un âge supérieur à l’âge spécifié.

#### Exemple

Si la collection contient :

| Nom   | Âge |
| ----- | --- |
| Minou | 2   |
| Félix | 7   |
| Milo  | 10  |

L’appel suivant :

```csharp
refuge.ChatsSelonAge(5);
```

doit retourner :

* Félix ;
* Milo.

---

### Travail demandé

Créer une classe de tests unitaires permettant de valider :

* le constructeur sans paramètre ;
* le constructeur avec une liste valide ;
* le constructeur avec une liste `null` ;
* `MatriculeExiste` lorsque le matricule existe ;
* `MatriculeExiste` lorsque le matricule n’existe pas ;
* `Ajouter` avec un chat valide ;
* `Ajouter` avec un chat `null` ;
* `Ajouter` avec un matricule déjà existant ;
* `Supprimer` avec un index valide ;
* `Supprimer` avec un index négatif ;
* `Supprimer` avec un index trop grand ;
* `ChatsSelonAge` avec des chats correspondants ;
* `ChatsSelonAge` sans résultat.

---


