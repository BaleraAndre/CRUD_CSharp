> **Status do Projeto:** Incompleto :warning: </br>
> **Autor:** Andre Marino Balera :busts_in_silhouette: </br>
> **Ano:** 2024 :date:

# :computer:

Aplicação desktop com dois níveis de acesso para gerenciamento de clientes, produtos, compras/vendas.

### 🖥️ Tecnologias e Ferramentas 
<p align="left">
<img width="40px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" title = "CSHARP"/>
<img width="40px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/postgresql/postgresql-original.svg" title = "POSTGRESQL"/>
</p>

[Link para o script SQL](./Script.sql.txt)

## Tela Login 
Faça login para a aplicação funcionar de acordo com o nível de acesso do usuário 
![Login](./Login.png)

## Tela Menu Principal
Menu principal da aplicação, difere dependendo do nível de acesso do usuário
![Menu](./menu.png)

## Tela Lista de Usuários
Tela de acesso permitido apenas para o nível ADM, onde há busca por nome, com duplo clique em uma linha ou um caminho para adicionar um novo usuário
![Lista de Usuários](./listausuarios.png)

## Tela Cadastro de Usuário
Tela de acesso permitido apenas para o nível ADM, onde insere um novo usuário ou atualiza os dados de algum usuário já cadastrado
![Cadastro de Usuário](./cadusuario.png)

## Tela Lista de Produtos
Tela de acesso permitido apenas para o nível ADM, onde se encontra uma listagem de todos os produtos, permitindo selecionar um produto para atualização ou a inserção de um novo produto
![Lista de Produtos](./listaprod.png)

## Tela Cadastro de Produto
Tela de acesso permitido apenas para o nível ADM, onde insere um novo produto ou atualiza os dados (ex. quantidade) de algum produto já cadastrado. 
![Cadastro de Produtos](./cadprod.png)

## Tela de Compras
Tela de acesso permitido apenas para o nível usuário comum, onde se encontra a listagem de produtos e realiza os pedidos de compras (Apenas produtos do mesmo perfil que o cliente serão exibidos)
![Compra de Produtos](./comprar.png)
