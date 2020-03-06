namespace Chapter3{
    public struct Sushi{
        private int count;
        private string neta;
        private int price;
        public int Count => count;
        public string Neta => neta;
        public int Price => price;
        public Sushi(int count, string neta, int price){
            this.count = count;
            this.neta = neta;
            this.price = price;
        }
    }
}
