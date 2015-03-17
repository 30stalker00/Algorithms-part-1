using System;
namespace algoritm1
{
    static public class lab{
        static public int Main(){
            uf Uf = new uf(10);
            Uf.union(1,2);
            Uf.union(3,4);
            Uf.union(2,3);
            bool test = Uf.connection(1,4);
            Console.Write("{0}\n", test);
            return 0;
        }
    
    public class uf{
        private int[] id;
        public uf(int n){
            id = new int[n];
            for(int i = 0; i < n; i++)
            id[i] = i;

        }
        public void union(int a, int b){
            for(int i = 0; i < id.Length; i++){
                int dpi = id[a];
                if(id[i] == dpi)
                id[i] = id[b];
            }
            
        }
        public bool connection(int a, int b){
            return id[a] == id[b];
        }
    }

    }


}