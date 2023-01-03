# Continuação do Projeto Comex

O projeto **Comex** é um sistema de _e-commerce marketplace_. Seu objetivo é permitir que a sua base de clientes tenha acesso a vários vendedores e, assim, consolidar-se como o shopping eletrônico mais popular da internet.

## Requisitos
[ ] Validar entrada e saída de produtos no Estoque.

[ ] Verificar se a classe `Estoque` valida corretamente os cenários de exceção.

[ ] Criar e lançar exceções aderentes ao negócio:
</br>
    - definir uma **_custom exception_** chamada `LimiteDeEstoqueExcedidoException`;
</br>
    - alterar as classes `Estoque`, `TestaEntradaDeProdutoNoEstoque` e `TestaSaidaDeProdutoNoEstoque` para utilizar a nova *exception*.

[ ] Não permitir que uma `Categoria` seja criada com valores inválidos.

[ ] Garantir que as classes `Produto` e `ProdutoIsento` não sejam criadas com valores inválidos.
