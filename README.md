# csharpcore
test 

Au vu des possibilités qui m'est offert pour ce test , j'ai deux choix qui me semble mieux qu'une boucle for

enchaîné avec une suite de if qui fait perdre beaucoup de temps ( relatif car pas beaucoup de données dans ce cas )


mes 2 choix sont :

- je passe par une boucle foreach 
- je passe par un switch case par le nom 

en utilisant un switch case , c'est rapide et efficace mais l'inconvénient est que si vous ajoutez un nouveau produit , il faut ajouter un case supplémentaire.

Si dans votre exemple , le produit que vous voulez ajouter est normal , dans la boucle on peut exclure les produits normal et lui donner une méthode de calcul.

la boucle foreach présente le même avantage et un peu moins rapide .
Ici pour les données j'utilise un switch de façon a implémenter chaque méthode pour chaque produits 

si l'on devrait ajouter plusieurs articles alors je serai sur une solution ou dans la classe Item , j'ajoute une catégorie de produit et suivant la catégorie de produits j'ai une méthode de calcul de qualité .


