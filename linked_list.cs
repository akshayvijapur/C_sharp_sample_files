using System;

public class node {
    public int data;

    public node(int data){
        this.data = data;
        next = null;
    }
    public node next;
}

public class  LinkedList {
 public   node head;

 public void  AddDataToFrontLinkedList(LinkedList List, int data){
       node newNode = new node(data);
     if (List.head == null){
          List.head = newNode;
          return;
     }
     newNode.next=List.head;
     List.head = newNode;    
 }
 
 public void printLinkedList(LinkedList List){
     if (List.head == null){
         return;
     }
    node temp = List.head;
    while(temp != null){
         Console.WriteLine("{0}",temp.data);
    temp = temp.next;
}


 }


public void AddAtTheEndOfLinkedList(LinkedList list, int data){
node newnode = new node(data);

if (list.head == null){
    list.head = newnode;
    return;
}

node temp = list.head;
while(temp.next != null){
    temp = temp.next;
}
temp.next=newnode;
}
 public static void Main(){
LinkedList l1 = new LinkedList();
    l1.AddDataToFrontLinkedList(l1, 10);
   
    l1.AddAtTheEndOfLinkedList(l1,20);
    l1.printLinkedList(l1);
 }

}
