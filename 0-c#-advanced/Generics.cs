using System;


namespace CSharpJourney{

    /*
        I created this custom list class to understand
        how Generics work and how I can create a custom Generic
    */
     
    class CustomList<T>{

        private readonly List<T> _list;
        public int Count { get { return _list.Count; } }

        public CustomList()
        {
            _list = new List<T>();
        }
        public void Add(T item){
            _list.Add(item);
        }

        public void Remove(T item){
            _list.Remove(item);
        }

        public T this[int index]{
            get{
                return _list[index];
            }
        }
        
    }

    
}