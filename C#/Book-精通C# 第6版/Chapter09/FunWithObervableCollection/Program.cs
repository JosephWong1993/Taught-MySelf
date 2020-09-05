using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace FunWithObervableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Person temp = new Person() { FirstName = "Peter", LastName = "Murphy", Age = 52 };
            //  创建一个用来观察的集合,并添加一些Person对象
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                temp,
                new Person(){ FirstName="Kevin", LastName="Key", Age=52 }
            };

            //  绑定CollectionChanged事件
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person() { FirstName = "Fred", LastName = "Smith", Age = 32 });
            people.Remove(temp);
            Console.ReadLine();
        }

        private static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //  触发事件的行为是什么
            Console.WriteLine("Action for this event: {0}", e.Action);
            if (e.Action.Equals(System.Collections.Specialized.NotifyCollectionChangedAction.Remove))
            {
                Console.WriteLine("Here are tho old items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            //  是添加项
            else if (e.Action.Equals(System.Collections.Specialized.NotifyCollectionChangedAction.Add))
            {
                //  显示添加后的项
                Console.WriteLine("Here are the new items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
