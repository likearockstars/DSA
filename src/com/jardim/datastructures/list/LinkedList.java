package com.jardim.datastructures.list;

/**
 * Classe de implementaçao de uma singly linked list.
 */
public class LinkedList {
	private Node head;
	private Node tail;
	private int size = 0;
	
	/**
	 * Classe que implementa os nós.
	 */
	private static class Node {
		String name;
		Node next;
		
		/**
		 * Construtor de Node
		 * @param name
		 */
		public Node(String name) {
			this.name = name;
			this.next = null;
		}
	} // fim da classe Node
	
	/**
	 * Getter de head
	 */
	public Node getHead() {
		return head;
	} // fim do método getHead
	
	/**
	 * Setter de head
	 */
	public void setHead(Node node) {
		this.head = node;
	} // fim do método setHead
	
	/**
	 * Getter de tail
	 * @return tail
	 */
	public Node getTail() {
		return tail;
	} // fim do método getTail
	
	/**
	 * Setter de tail
	 */
	public void setTail(Node node) {
		this.tail = node;
	} // fim do método setTail
	
	/**
	 * Getter de size
	 * @return 
	 */
	public int getSize() {
		return size;
	} // fim do método getSize
	
	/**
	 * Setter de size
	 */
	public void setSize(int size) {
		this.size = size;
	} // fim do método setSize
			
	/**
	 * Verifica se a lista esta vazia.
	 * @return true caso a lista esteja vazia.
	 */
	public boolean isEmpty() {
	    return head == null;
	} // fim do método isEmpty

	/**
	 * Mostra toda a lista.
	 */
	public void showList() {
		Node node = getHead();
		while(node != null) {
			System.out.println(node.name);
			node = node.next;
		}
	} // fim do método showList
	
	/**
	 * Adiciona um nó ao inicio da lista.
	 * @param name
	 */
	public void addFirst(String name) {
		Node node = new Node(name);
		setSize(getSize() + 1);
		
		if(getHead() == null) {
			setHead(node);
			setTail(node);
		} else {
			node.next = getHead();
			setHead(node);
		}
	} // fim do método addFirst
	
	/**
	 * Adiciona um nó ao final da lista.
	 * @param name
	 */
	public void addLast(String name) {
		Node node = new Node(name);
		setSize(getSize() + 1);
		
		if(getHead() == null) {
            setHead(node);
            setTail(node);
		} else {
			getTail().next = node;
			setTail(node);
		}
	} // fim do método addLast
	
	/**
	 * Adiciona um nó no indice especificado.
	 * @param index
	 * @param name
	 */
	public void addAt(int index, String name) {
		Node newNode = new Node(name);
		setSize(getSize() + 1);
		
		if(index < 0 || index > getSize()) {
			System.out.println("Indice inválido");
			return;
		}
		
		if(index == 0) {
			newNode.next = getHead();
			setHead(newNode);
			return;
		}
		
		Node node = getHead();
		int count = 0;
		while(count < index - 1) {
			node = node.next;
			count++;
		}
		newNode.next = node.next;
		node.next = newNode;
		
	} // fim do método addAt
	
	/**
	 * Remove o primeiro nó da lista.
	 */
	public void removeFirst() {
		if(isEmpty()) {
			setTail(null);
			System.out.println("A lista esta vazia!");
			return;
		}
		setHead(getHead().next);
		setSize(getSize() - 1);
		
		if(getHead() == null) {
			setTail(null);
		}
	} // fim do método removeFirst
	
	/**
	 * Remove o último nó da lista.
	 */
	public void removeLast() {
		if(isEmpty()) {
			System.out.println("A Lista esta vazia!");
			return;
		}
		
		if(getHead().next == null) {
			setHead(null);
			setTail(null);
			return;
		}
		
		Node node = getHead();
		while(node.next.next != null) {
			node = node.next;
		}
		
		node.next = null;
		setTail(node);
		setSize(getSize() - 1);
	} // fim do método removeLast
	
	/**
	 * Remove um nó no indice especificado.
	 * @param index
	 */
	public void removeAt(int index) {
		if(index < 0 || index > getSize() - 1) {
			System.out.println("Indice invalido!");
			return;
		}
		
		if(getHead().next == null) {
			setSize(getSize() - 1);
			setHead(null);
			setTail(null);
			return;
		}
		
		if(index == 0) {
			setSize(getSize() - 1);
			setHead(getHead().next);
			
	        if (getHead() == null) { 
	            setTail(null);
	        }
	        return;
		}
		
		setSize(getSize() - 1);
		Node node = getHead();
		for(int i = 0; i < index - 1; i++) {
			node = node.next;
		}
		
	    if (node.next == getTail()) {
	        setTail(node);
	    }
		node.next = node.next.next;
	} // fim do método removeAt
		
	/**
	 * Obtém a posicao de um nó pelo nome.
	 * @param name
	 * @return o indice do primeiro nome que corresponda.
	 */
	public int finder(String name) {
		int index = 0;
		Node node = getHead();
		while(node != null) {
			if(node.name.equals(name)) {
				return index;
			} else {
				index++;
				node = node.next;
			}
		}
		return -1;
	} // fim do método finder
	
} // fim da classe LinkedList
