-03/08-
  Padrão arquitetural
  - MVC
      * Model
      * View
      * Controller
    - 1. Model (Classes)
    - 2. Controller (Menu, CRUD)    
    - 3. View

  -Bubble Sort:
      *Memória: Memória interna.
      *Estabilidade: Estável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Final do vetor.
  -Selection Sort:
      *Memória: Memória interna.
      *Estabilidade: Instável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Início do vetor.
  -Insertion Sort:
      *Memória: Memória interna.
      *Estabilidade: Estável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Início do vetor.
  -Shell Sort:
      *Memória: Memória interna.
      *Estabilidade: Instável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Não possui uma porção fixa ordenada; trabalha com subsequências parcialmente ordenadas.
  -Shake Sort (Cocktail Sort):
      *Memória: Memória interna.
      *Estabilidade: Estável.
      *Notação Big-O: O(n²)
  -Porção ordenada: Início e fim do vetor.
      *Comb Sort:
      *Memória: Memória interna.
      *Estabilidade: Instável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Não possui uma porção fixa ordenada.
  -Heap Sort:
      *Memória: Memória interna.
      *Estabilidade: Instável.
      *Notação Big-O: O(n log n)
      *Porção ordenada: Final do vetor.
  -Merge Sort:
      *Memória: Memória interna.
      *Estabilidade: Estável.
      *Notação Big-O: O(n log n)
      *Porção ordenada: Subvetores ordenados que são mesclados ao final.
  -Quick Sort:
      *Memória: Memória interna.
      *Estabilidade: Instável.
      *Notação Big-O: O(n²)
      *Porção ordenada: O pivô fica na posição definitiva após cada partição.
  -Bucket Sort:
      *Memória: Memória externa.
      *Estabilidade: Estável.
      *Notação Big-O: O(n²)
      *Porção ordenada: Cada bucket é ordenado individualmente antes da junção.
  -Radix Sort:
      *Memória: Memória externa.
      *Estabilidade: Estável.
      *Notação Big-O: O(d(n + k))
      *Porção ordenada: Os elementos ficam ordenados pelos dígitos já processados.

  

-30/07-
  Conceitos iniciais
    - ordenar: organizar uma estrutura (lista ou vetor) a partir de um ou mais índices ou chaves
        - por que ordenar?
          - para otimizar a busca ou pesquisa
          - Processo estável: sempre garante a ordenação da estrutura
          - Processo instável: não garante a ordenação da estrutura
    - pesquisar/find/search: localizar ou buscar um dado dentro de uma estrutura via alguma chave
    - recuperar/retrieve: localizar ou buscar dados com relevância(semântica ou significado) --> buscador da google
    - CRUD: CREATE, RETRIEVE, UPDATE, DELETE


-27/07-
  Pesquisa e ordenação
    - ordenação: conceitos; algoritmos
    - pesquisa: conceitos; algoritmos
    - pesquisa digital: algoritmos
    - tabelas hash: conceitos; algoritmos
    - balanceamento em árvores: conceitos; algoritmos
    - árvores B: conceitos; algoritmos

  Algoritmos de ordenação
    * Sort 
      * select
      * buble
      * insertion
      * agitação
      * radix
      * bucket
      * merge (complexos, mas baixa complexidade)
      * quick (complexos, mas baixa complexidade)
      * comb
      * shell
      * heap
    * Complexidade de um alrgorítmo (Esforço computacional de um algorítmo), é o quanto de recurso ele aloca para
      realizar suas tarefas
      * alta complexidade: mais esforço
      * baixa complexidade: menos esforço
      * Notação Big O 
        * linear(n) ---> boa
        * logaritmico(log n) ---> excelente, menor complexidade
          * logaritmico(log n + n)
        * exponecial(n^x) ---> ruim
        * fatorial(n!) ---> pior ainda, maior complexidade
        * Propósito simples, mas altra comlplexidade não são funcionais
      * Estabilidade
        * quanto a estrutura é desordenada até chegar na ordenação
        * melhores algorítimos de pesquisa e ordenação são os instáveis
    
      
  
