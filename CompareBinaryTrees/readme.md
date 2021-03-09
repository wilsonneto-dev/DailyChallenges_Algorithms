Dadas duas árvores binárias, escreva uma função que indique se elas são iguais ou não.

As duas árvores binárias são consideradas as mesmas se elas forem estruturalmente identicas e os nós estiverem com o mesmo valor.

Exemplo 1:
Entrada:

      1          1         
     / \        / \   
    2   3      2   3    
   [1,2,3],   [1,2,3]
Deverá retornar true pois as duas arvores são identicas.

Exemplo 2:
Entrada:

      1          1         
     / \        / \   
    2   3      2   3
   / \    
  4   5
 [1,2,4,5,3],  [1,2,3]
Deverá retornar false pois as duas arvores são diferentes.