package Pesquisa.Hash;

import java.util.HashSet;


public class ExemploHashSimples {
    public static void main(String[] args) {
        HashSet<String> tabelaHashStrings = new HashSet<>();

        tabelaHashStrings.add("alexandre");
        tabelaHashStrings.add("hermes");
        tabelaHashStrings.add("davi");
        tabelaHashStrings.add("alan");
        tabelaHashStrings.add("Alexandre");
        tabelaHashStrings.add("davi");

        for (String item : tabelaHashStrings) {
            System.out.println(item + " ->" + item.hashCode());
        }

        System.out.println(tabelaHashStrings.contains("alan") + " ->" + "alan".hashCode());
    }
}