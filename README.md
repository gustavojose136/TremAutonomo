# Trem Autônomo - Controle de Movimentos

# Equipe: Gustavo José Rosa, Thomas Taiga Nakagawa

## Descrição

Este projeto implementa um sistema de controle para um trem autônomo que se move ao longo de um trilho numérico infinito. O sistema recebe uma lista de comandos de movimento (ESQUERDA ou DIREITA) e executa esses comandos de forma autônoma, respeitando certas restrições para garantir a segurança e a eficiência da operação.

## Funcionalidades

- **Comandos de Movimento**: Permite que o operador forneça uma lista de comandos (ESQUERDA, DIREITA) para que o trem se mova ao longo do trilho.
- **Limite de Movimentos**: O trem para automaticamente após percorrer 50 posições, garantindo a segurança da operação.
- **Prevenção de Movimentos Consecutivos**: Evita que o trem faça mais de 20 movimentos consecutivos na mesma direção, minimizando o desgaste dos trilhos e dos componentes do trem.
- **Relatório de Posição Final**: Após a execução dos comandos, o sistema retorna a posição final do trem para que o operador possa acompanhar sua localização.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework utilizado para desenvolver a aplicação.
- **C#**: Linguagem de programação utilizada no desenvolvimento.
- **xUnit**: Framework de testes utilizado para garantir a robustez e a correção do código

## Estrutura do Projeto

- **Models**: Contém a lógica de domínio, incluindo a modelagem do trem e as regras de negócios relacionadas aos movimentos.
- **Controllers**: Contém os controladores que gerenciam as requisições HTTP e coordenam a interação entre o modelo e as views.
- **Views**: (Somente se aplicável para MVC) Contém as interfaces do usuário, que são renderizadas e enviadas ao cliente.
- **Tests**: Contém os testes unitários para garantir a cobertura e a correção do código.
