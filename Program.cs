// See https://aka.ms/new-console-template for more information

using Singleton;

SingletonClass obj = SingletonClass.GetSingletonClass();
SingletonClass obj2 = SingletonClass.GetSingletonClass();

if(obj != obj2)
    throw new Exception("Singleton Objects are not the same");
