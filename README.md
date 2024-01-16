# Teste SmartHint

## Projeto do processo seletivo
### Requisitos
    ● Linguagem: .Net ou .Net Core
    ● Banco de dados: MYSQL

### Tecnologias Utilizadas 
    ● NET 7
    ● MYSQL
    ● Entity Framework Core 
    ● mvc-grid.azurewebsite
    ● Toastr

### Notas de Implementação
    ● Os princípios da Arquitetura Limpa foram seguidos para separar preocupações e dependências.
    ● Padrão de Repositório: Implementado para oferecer uma abordagem padronizada ao acesso aos dados
    ● O Entity Framework Core foi utilizado para o aspecto ORM do acesso aos dados.
    ● O padrão de arquitetura Model-View-Controller (MVC), contribuindo para uma organização elegante e modular do código-fonte.


## Tela Listagem - Listagem de Compradores - Filtros

![filtros](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/37a2dfb7-cb98-4ff8-9de1-cac3647f1b84)

![limpeza filtros](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/dda9b876-50d7-4d87-8c98-29a75ec78a34)

![paginacao](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/3ab915b0-d907-4348-add0-f1eecc10f3d6)

## Tela Cadastro - Cadastro de Clientes

![inserir](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/591492ae-cfb6-4103-a091-2ec86a4594a5)

![inserir_usuario](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/665998d5-35ac-4949-938b-57c60befd56a)

![inserir_usuario_2](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/17d08169-d2c0-432c-bc3b-a773fb182759)

![inserir2](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/12673fa8-d62f-44f3-b2aa-97ea64cc7b62)

## Estrutura de Diretórios

![Captura de tela 2024-01-15 222454](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/7e182b70-ecd6-4ba0-be63-384fae09b18a)

### Como executar 
 1 - Altere a string de conexão do banco de dados
 2 - No Package Manager Console, mude o Default project para SmartHint.Infrastucture e digite o comando Update-DataBase 
 3 - Builde o projeto 
 ![create](https://github.com/HenriqueLopesDeSouza/Teste-SmartHint/assets/43977679/4fdbdb4d-a006-4228-be75-a040f58e94b0)

 PS: Existem uma pasta SQL com um insert com uma massa de dados que pode ser excutado no Banco para teste do projeto.
