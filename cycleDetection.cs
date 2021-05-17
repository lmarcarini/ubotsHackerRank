    static bool hasCycle(SinglyLinkedListNode head) {
        if(head==null) return false;
        SinglyLinkedListNode slowNode;
        SinglyLinkedListNode fastNode;
        
        slowNode=head;
        fastNode=head;
        while(fastNode!=null && fastNode.next!=null){
            slowNode=slowNode.next;
            fastNode=fastNode.next.next;
            if(fastNode==slowNode) return true;
        }
        return false;
    }
