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
        private int[] sz;
        private int root(int i){
        while(i != id[i]) {
            id[i] = id[id[i]];
            i = id[i];
        }
        return i;
        }
        public uf(int n){
            id = new int[n];
            sz = new int[n];
            for(int i = 0; i < n; i++){
                id[i] = i;
                sz[i] = 1;
            }

        }
        public void union(int a, int b){
            int i = root(a);
            int j = root(b);
            if(i == j) return;
            if(sz[i] < sz[j]) { id[i] = j; sz[i] += 1;}
            else              { id[j] = 1; sz[j] += 1;}
            }
            
        
        public bool connection(int a, int b){
            return root(a) == root(b);
        }
    }

    }

}
