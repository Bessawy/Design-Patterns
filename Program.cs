// See https://aka.ms/new-console-template for more information

using Singleton;
using Prototype;


// #################################### SingletonClass ############################################
SingletonClass obj = SingletonClass.GetSingletonClass();
SingletonClass obj2 = SingletonClass.GetSingletonClass();

if(obj != obj2)
    throw new Exception("Singleton Objects are not the same");

// #################################### Prototype ###############################################
ToCloneA obj3 = new ToCloneA();
obj3.x = 5;
obj3.y = 5;
obj3.m = 10;
AbstractProtype obj4 = obj3.Clone();

if(obj3 == obj4 || obj3.x != obj4.x || obj3.y != obj4.y)
    throw new Exception("Object is not a deep copy");