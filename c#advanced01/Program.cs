using System.Data;

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
            #region Q9
            /*
            Q9: What is the new() constraint? Write an example.

            requires the type to have a public parameterless constructor.

            class Factory<T> where T : new()
            {
            public T Create()
            {
                return new T();
            }
            }
            */
            #endregion
            #region Q10
            /*
             Q10: What is the interface constraint? Write an example.
            requires the generic type to implement a specific interface.

            interface IPrintable
            {
            void Print();
            }

            class Printer<T> where T : IPrintable
            {
            public void PrintItem(T item)
            {
                item.Print();
            }
            }
            */
            #endregion
            #region Q11
            /*
             Q11: What is the base class constraint? Write an example.
            requires the generic type to inherit from a specific base class.

            class Animal
            {
            public void Eat()
            {
            Console.WriteLine("Eating");
            }
            }

            class Dog<T> where T : Animal
            {
            public void MakeDogEat(T animal)
            {
            animal.Eat();
            }
            }
            */
            #endregion
            #region Q12
            /*
             Q12: How do you apply multiple constraints? Write an example.

            class Person
            {
            }

            interface IPrintable
            {
            void Print();
            }

            class Manager<T> where T : Person, IPrintable, new()
            {
            public T Create()
            {
                return new T();
            }
            }
            */

            #endregion
            #region Q13
            /*
             Q13: What does the default keyword do in generics?

            The default keyword returns the default value of a type.
            */
            #endregion
            #region Q14
            /*
             Q14: Write a generic class SafeList<T> that wraps a List<T> and provides safe access to its elements.
            class SafeList<T> {
            private List<T> items = new List<T>();
            public void Add(T item)
            {
                items.Add(item);
            }
            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                {
                    return default;
                }
                return items[index];
            }
        }
        */

            #endregion
            #region Q15
            /*
        Q15: What is covariance? Explain the out keyword.
            allows a generic type to use a more derived type where a base type is expected.
            It is represented by the out keyword,anything out like return type of a method can be covariant.
            */
            #endregion
            #region Q16
            /*
        Q16: What is contravariance? Explain the in keyword.
            allows a generic type to use a base type where a more derived type is expected.
            It is represented by the in keyword, anything in like parameter type of a method can be contravariant.
                */
            #endregion
            #region Q17
            /*
             Q17: What is the difference between covariance and contravariance?
            Covariance: works with types that are returned/produced.(out)
            Contravariance: works with types that are passed as parameters.(in)
             */
            #endregion
            #region Q18
            /*
             Q18: How do static members work in generic types?
            Static members in a generic class are created separately for each closed generic type.
            */
            #endregion
            #region Q19
            /*
             Q19: How can you inherit from a generic class?
            A class can inherit from a generic class by specifying the generic type.
            */
            #endregion
            #region Q20
            Cache<string, string> cache = new Cache<string, string>();

            cache.Add(
                "name",
                "Mohamed",
                TimeSpan.FromSeconds(10)
            );

            Console.WriteLine(cache.Contains("name"));

            Console.WriteLine(cache.Get("name"));

            cache.Remove("name");

            Console.WriteLine(cache.Contains("name"));
            #endregion
        }
    }
}
