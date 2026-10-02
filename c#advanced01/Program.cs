namespace c_advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Q1: What is a generic class? Why use generics?
            is a class that works with a type specified when the object is created.
            Generics allow us to write reusable and type-safe code without specifying a specific data type inside the class.
            */
            #endregion
            #region Q2
            /*
             Q2: Write a generic class Container<T> with Add and Get methods.
            
            class Container<T>
        {
            private T value;

            public void Add(T value)
            {
                this.value = value;
            }

            public T Get()
            {
                return value;
            }
        }
            */
            #endregion
            #region Q3
            /*
             Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            
            Multiple type parameters allow a generic class or method to work with more than one type.
            class Pair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public Pair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }
            */
            #endregion
            #region Q4
            /*
             Q4: What is a generic method? Write Swap<T> method.
            
            is a method that uses a type parameter so it can work with different data types.
            
             
            static void Swap<T>(ref T first, ref T second)
            {
                T temp = first;
                first = second;
                second = temp;
            }
            */
            #endregion
            #region Q5
            /*
             Q5: Write a generic method FindMax<T> that finds maximum value.
            
            static T FindMax<T>(T first, T second) where T : IComparable<T>
            {
                return first.CompareTo(second) > 0 ? first : second;
            }
            */
            #endregion
            #region Q6
            /*
             Q6: What is a generic interface? Write IRepository<T>.
            is an interface that uses a type parameter.
            It allows the same interface to work with different types.
           
            interface IRepository<T>
        {
            void Add(T item);
            T Get(int id);
            void Remove(int id);
        }
        */
            #endregion
            #region Q7
            /*
             Q7: What is the struct constraint? Write an example.
            means that the generic type must be a value type.

            class Test<T> where T : struct
        {
            public T Value { get; set; }
        }
        */
            #endregion
            #region Q8
            /*
        Q8: What is the class constraint? Write an example.
       means that the generic type must be a reference type.

            class Test<T> where T : class
        {
            public T Value { get; set; }
        }
        */
            #endregion
        }
    }
}
