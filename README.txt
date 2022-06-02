----------------------------------------------------------------
Interface Utilisateur avec données chiffrées dans une BDD
Projet réalisé avec le langage C# sous VisualStudio & SQL Server
LEVACHER JIMMY - 18901505

Executable  -> ProjetSecu\ProjetSecu\bin\Debug\ProjetSecu.exe
BDD         -> ProjetSecu\ProjetSecu\bin\Debug\DB1.mdf
----------------------------------------------------------------

La BDD étant à la racine de l'exécutable, il est possible de le lancer sans rien modifier, sinon, modifier le
@path de la BDD dans le fichier 'Config.cs'

AES sous C# fonctionne avec une clef privée (128/256 bits) et un vecteur (IV).

La méthode de stockage dans la BDD est la suivante :
    -> On récupère le hash (sha256) du mot de passe qui servira de clef privée, ainsi que
       le hash (sha512) du mot de passe encore une fois, qui sera chiffré puis stocké.
       En chiffrant le hash et non directement le mot de passe, cela évite de le retrouver si ce dernier
       s'avère déchiffré (il était possible de stocker directement le hash du mot de passe dans la BDD)

    -> Pour stocker une autre donnée (mail, age, ...), cette dernière est par contre, chiffrée puis
       stockée dans la BDD. Impossible d'utiliser un hash car non réversible.
       Le nom de compte est également "chiffrable" mais il sera impossible par la suite
       de vérifier s'il en éxiste plusieurs.

    -> Lorsque le mdp est modifié, toutes les autres données chiffrées le sont aussi (comme le montre les screens).

Pour vérifier une connexion :
    -> On chiffre le mot de passe de la même manière que pour le stocker puis on vérifie le
       résultat avec celui dans la BDD.

    -> Pas de sécurité sur la saisie des données pour les champs car jugé non essentiel pour ce projet.
       Mais facilement ajoutable avec les expressions régulières (Regex) par exemple.

Des idées :
    -> Systeme de récupération de mdp avec un système de question/réponse par exemple.
    -> Un panel Admin qui liste l'ensemble des comptes afin de pouvoir en supprimer, réinitialiser des mdp, ...

- Les requêtes SQL sont sous forme de "StoredProcedure" dans le répertoire ...\ProjetSecu\DB\Procédures stockées

- Des screens du bon fonctionnement du logiciel sont disponbles dans le répertoire ...\Screens


=======================================================
SCIPT d'ajout d'un compte (Bob:password) manuellement :

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [Username], [Password], [Email], [Address], [Age], [Sex]) VALUES (11, N'Bob', N'xn0r7mfV9DYqDLz+o79caW7LrlmPVP5vRIocClnctpQ9Vi60NJaGODFv5XRyPYhjruoC6fDzn7w9/0PPd3NoWdJqkzaBmH5ZXVVbz98wbCTaNb8xRnFShhyp2bkNsIvJFKqkAQSEXadkhMpXbxlwf79YeXgyZKFpri8UqOqy59jDZzUaneQywXM7BfDM2+Gi', N'TVYJpqY+TlpF4cP8okl4Uw==', N'NUcNBR839e40A9SL8V45ikB+sLbuaDNzibRgBK9DNLAfn7JMBIPB0JSgasqKegM1', N'0EiHMA49wISnp7TjQk8IlQ==', N'CzANyYmlGfDjia0HGnybEw==')
SET IDENTITY_INSERT [dbo].[Users] OFF

======================================================
Exemple d'une clé avec le hash256(password)     | byte->hex

5E-88-48-98-DA-28-04-71-51-D0-E5-6F-8D-C6-29-27-73-60-3D-0D-6A-AB-BD-D6-2A-11-EF-72-1D-15-42-D8

======================================================
Exemple de chiffrement de "mot" avec cette clef | byte->base64

GXVe/RMh7fs3r5FAbZ4M8w==