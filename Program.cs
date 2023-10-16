// See https://aka.ms/new-console-template for more information

using Singleton;
using Prototype;
using BUilder;


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

// ############################################# Builder #########################################
Director director = new();
GamingPCBuilder_00 builder_00 = new();
GamingPCBuilder_01 builder_01 = new();

PC newPC_00 = director.BuildPC(builder_00);
PC newPC_01 = director.BuildPC(builder_01);

if(newPC_00.cpu != 12 || newPC_01.cpu != 8)
    throw new Exception("Builder is building wrong structures");


