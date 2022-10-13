# Arbre-binaire
2015. / 

## Introduction
Le but de ce travail est de proposer à l’utilisateur de visualiser une vente à multiniveau à l’aide une application réalisée en groupe.

L’environnement de développement utilisé est Microsoft Visual Studio 2013.

Le langage utilisé est le C#, langage dont nous avons appris les bases lors de notre CFC, et avons obtenus d’avantage de théorie sur celui-ci ici au Cifom.

Dans ce rapport vous trouverez : 
⦁	Une documentation de développement :
⦁	Une explication détaillée du projet,
⦁	Les conventions de nommage
⦁	Les cas d’utilisation divers de l’application, comprenant pour chaque cas :
⦁	Un diagramme
⦁	Une explication des points clés du code
⦁	Les différents tests effectués afin de s’assurer des résultats escomptés
⦁	Les problèmes rencontrés ainsi que leurs solutions
⦁	Annexes diverses :
⦁	Cahier des charges
⦁	Référence
⦁	Code source.

## Explications détaillées du projet
Le but du projet est de présenter à l’utilisateur une vue graphique d’un arbre de vente multiniveau. Tout partira d’un point de départ, le « Parent » appelé ‘moi’, (l’utilisateur), possède plusieurs caractéristiques, modifiables qui sont :

⦁	Nom
⦁	Volume personnel
⦁	Remarque

Il possède également plusieurs caractéristiques, qui elles, seront (re)calculées à chaque modification apportée à n’importe quel endroit de l’arbre, les voici :

⦁	Niveau
⦁	Volume de groupe
⦁	Gain Théorique
⦁	Gain Net
⦁	Gain Associés

Cette personne de base peut avoir des personnes « enfants », des personnes donc que la personne originelle aura « rapporté » dans l’arbre en les recrutant par exemple. Ces mêmes personnes pourront elles-aussi avoir, comme leur parent, des enfants. Ceci permet de recréer la topologie d’un arbre de vente multiniveau.

Le principe final de l’application sera, à l’aide d’une vue graphique des différentes personnes insérées, de visualiser le gain de chaque personne de l’arbre avec son pourcentage de bonus, obtenu grâce au niveau. 

La répartition exacte des différents gains entre les personnes seront expliqués plus tard dans ce rapport.

