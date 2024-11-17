package com.jardim.datastructures.list;

/**
 * @author m-jardim
 * A classe principal para realizar testes nas operações da lista encadeada.
 * Realiza diversos testes com as operações de adição, remoção, busca e verificação de estado da lista.
 */
public class Main {
    public static void main(String args[]) {
        LinkedList list = new LinkedList();

        // Teste: Adicionar ao início
        System.out.println("--> Adicionando 'Alpha' no início");
        list.addFirst("Alpha");
        list.showList();

        // Teste: Adicionar ao final
        System.out.println("\n--> Adicionando 'Beta' no final");
        list.addLast("Beta");
        list.showList();

        // Teste: Adicionar no índice 1
        System.out.println("\n--> Adicionando 'Gama' no índice 1");
        list.addAt(1, "Gama");
        list.showList();

        // Teste: Remover o primeiro nó
        System.out.println("\n--> Removendo o primeiro nó");
        list.removeFirst();
        list.showList();

        // Teste: Remover o último nó
        System.out.println("\n--> Removendo o último nó");
        list.removeLast();
        list.showList();

        // Teste: Remover no índice 0
        System.out.println("\n--> Removendo no índice 0");
        list.removeAt(0);
        list.showList();

        // Teste: Verificar se a lista está vazia
        System.out.println("\n--> Lista está vazia? " + list.isEmpty()); // Deve retornar true
        list.addFirst("Alpha");
        System.out.println("--> Lista está vazia? " + list.isEmpty()); // Deve retornar false
        list.removeFirst();
        System.out.println("--> Lista está vazia? " + list.isEmpty()); // Deve retornar true

        // Teste: Verificar o tamanho da lista
        System.out.println("\n--> Tamanho da lista: " + list.getSize()); // Deve ser 0
        list.addFirst("Alpha");
        System.out.println("--> Tamanho da lista: " + list.getSize()); // Deve ser 1
        list.addLast("Beta");
        System.out.println("--> Tamanho da lista: " + list.getSize()); // Deve ser 2
        list.removeLast();
        System.out.println("--> Tamanho da lista: " + list.getSize()); // Deve ser 1
        list.removeFirst();
        System.out.println("--> Tamanho da lista: " + list.getSize()); // Deve ser 0

        // Teste: Adicionar um nó no índice inválido
        System.out.println("\n--> Tentando adicionar 'Gamma' no índice 10 (inválido)");
        list.addAt(10, "Gamma"); // Índice inválido (fora do alcance da lista)

        // Teste: Buscar "Beta" (não existe)
        System.out.println("\n--> Buscando 'Beta': Índice = " + list.finder("Beta")); // Deve retornar -1
        System.out.println();

        // Teste: Buscar "Beta" (existe, índice 1)
        list.addFirst("Alpha");
        list.addLast("Beta");
        list.addLast("Gama");
        System.out.println("--> Buscando 'Beta': Índice = " + list.finder("Beta")); // Deve retornar 1
        list.showList();

        // Teste: Mostrar a lista vazia e depois com elementos
        LinkedList emptyList = new LinkedList();
        System.out.println("\n--> Lista vazia antes de qualquer operação: ");
        emptyList.showList(); // Deve não mostrar nada

        System.out.println("\n--> Lista depois das operações: ");
        emptyList.addFirst("Alpha");
        emptyList.addLast("Beta");
        emptyList.addAt(1, "Gama");
        emptyList.showList(); // Deve mostrar Alpha, Beta, Gama
    }
}
