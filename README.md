# Desafio de Criptografia do Navio

Este projeto em C# resolve um desafio de criptografia proposto pela empresa Intelitrade. O objetivo é descriptografar uma mensagem binária recebida de um navio. A mensagem criptografada é fornecida em formato binário e o desafio é convertê-la de volta para uma string legível.

## Descrição do Problema

A mensagem criptografada é uma sequência de bytes representados em formato binário. Cada byte é separado por um espaço na string. A criptografia aplicada envolve duas operações principais:

1. **Inversão dos Dois Últimos Bits**: Para cada byte, os dois últimos bits precisam ser invertidos. Se um bit for '1', ele deve ser alterado para '0', e vice-versa.
2. **Troca dos Primeiros 4 Bits com os Últimos 4 Bits**: Após a inversão dos bits, os primeiros 4 bits devem ser trocados com os últimos 4 bits do byte.

## Resolução

O código realiza as seguintes etapas para descriptografar a mensagem:

1. **Divisão da String Original**: A string original é dividida em um array de strings, onde cada string representa um byte em formato binário.
2. **Processamento de Cada Byte**:
   - **Inversão dos Bits**: Para cada byte, os dois últimos bits são invertidos.
   - **Troca dos Bits**: Os primeiros 4 bits são trocados com os últimos 4 bits.
3. **Conversão para Inteiro**: Cada byte processado é convertido de volta para um valor inteiro.
4. **Conversão para String**: O array de bytes resultante é convertido em uma string ASCII legível.

## Como Executar

Compile o código: Utilize um compilador C# para compilar o código fonte.
Execute o programa: Rode o executável gerado para ver a mensagem descriptografada.


