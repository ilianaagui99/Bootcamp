class CircularQueue {
    constructor(cap) {
        this.head = 0;
        this.tail = -1;
        this.capacity = cap;
        this.arr = [];
        this.length = 0;
    }
    
    Front() {
        if(this.isEmpty()){
            return null;
        }
        return this.arr[head];
    }
    isEmpty() {
        if(this.length == 0){
            return true;
        }
        return false;
    }
    isFull() {
        if(this.length == this.capacity){
            return true;
        }
        return false;
    }
    Size(){
        return this.length;
    }

    Enqueue(num) {
        if (this.length = this.capacity){
            console.log("Queue is full!");
            return;
        }
        if(this.tail == this.capacity - 1){
            this.tail = 0;
        }
        else{
            this.tail++;
        }
        this.arr[this.tail] = num;
        this.length++;
    }
    Dequeue() {
        if (this.isEmpty()){
            console.log("Queue is empty!")
            return;
        }
        num = arr[this.head];
        arr[this.head] = null;
        if(this.head == this.capacity - 1){
            this.head = 0;
        }
        else{
            this.head++;
        }
        this.length--;
        return num;
    }

    Contains(num){
        for(let i = head; i <=this.tail; i++){
            if(arr[i] == num){
                return true;
            }
        }
        return false;
    }

}

let circle = new CircularQueue(5);
circle.Enqueue(1);
circle.Enqueue(2);
circle.Enqueue(3);
console.log(circle.Size());
circle.Enqueue(4);
circle.Enqueue(5);
console.log(circle.Front());