package br.edu.ufn.MedidorTempo.view;

import java.util.List;

public class Utilidades{
    /**
     * método de classe que exibe conteúdo de uma lista de inteiros
     * * @param lista
     * * @param frase - para exibir no início do método
     */
    public static void exibirLista(List<Integer> lista, String frase) {
        System.out.println(frase);
        for(Object item: lista) {
            System.out.println(item);
        }
        System.out.println("-----------------------")
        System.out.println("Total de Registros: " + lista.size());
    }
}