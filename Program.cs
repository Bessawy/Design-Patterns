// See https://aka.ms/new-console-template for more information

using Singleton;
using Prototype;
using BUilder;
using Factory;
using Proxy;
using Decorator;
using FlyWeight;
using Composite;
using Bridge;
using Adapter;
using State;


// #################################### SingletonClass ############################################
SingletonClass obj = SingletonClass.GetSingletonClass();
SingletonClass obj2 = SingletonClass.GetSingletonClass();

if(obj != obj2)
    throw new Exception("Singleton Objects are not the same");

// #################################### Prototype ###############################################
ToCloneA obj3 = new();
obj3.x = 5;
obj3.y = 5;
obj3.m = 10;
AbstractProtype obj4 = obj3.Clone();
https://refactoring.guru/
if(obj3 == obj4 || obj3.x != obj4.x || obj3.y != obj4.y)
    throw new Exception("Object is not a deep copy");

// ########################################## Builder #########################################
Director director = new();
GamingPCBuilder_00 builder_00 = new();
GamingPCBuilder_01 builder_01 = new();

PC newPC_00 = director.BuildPC(builder_00);
PC newPC_01 = director.BuildPC(builder_01);

if(newPC_00.cpu != 12 || newPC_01.cpu != 8)
    throw new Exception("Builder is building wrong structures");

// ########################################## Factory #########################################
Dialog dialog;
dialog = new StylishDialogFactory();
int x = 5, y = 10;
dialog.Render(ref x, ref y);
dialog = new BoringDialogFactory();
dialog.Render(ref x, ref y);

// ########################################### Proxy ###########################################
ServiceDatabase database = new();
Console.WriteLine("#-------------------------------------------#");
Console.WriteLine(database.Query("Name"));
Console.WriteLine("#-------------------------------------------#");
LoggerProxy proxy = new(database);
Console.WriteLine(proxy.Query("Name"));


// ############################################# Flyweight ######################################
DrawTree tree = new();
tree.DrawTrees();

// ############################################ Decorator ######################################
IPrintConsole source = new BasePrinter();
source = new DecoretorPrinter_0(source);
source = new DecoretorPrinter_0(source);
source = new DecoretorPrinter_1(source);
source = new DecoretorPrinter_1(source);
source.PrintText();

// ############################################ Composite #####################################
CompoundBox mainBox = new(); // 5 + 12 + 9 + 2 = 19 + 9 = 28
CompoundBox smallBox_0 = new(); // 2 + 5 + 2 = 9
CompoundBox smallBox_1 = new(); // 10 + 2 = 12

smallBox_0.AddItem(new Item(5)); 
smallBox_0.AddItem(new Item(2));

smallBox_1.AddItem(new Item(10));

mainBox.AddItem(new Item(5));
mainBox.AddItem(smallBox_0);
mainBox.AddItem(smallBox_1);

if(mainBox.Price() != 28)
    throw new Exception("Wrong price!");

// ######################################### Bridge ##############################################
Color color = new Red();
Shape shape = new Circle(4, color);

if(shape.getColorNumber() != 10)
    throw new Exception("Wrong Color!");

// ######################################### Adaptor ############################################
SquarePeg square = new(5);
SquarePegAdaptor adaptor = new(square);
int radius = adaptor.GetRadius();

// ######################################### Chain ##############################################
Chain.Dialog dialog00 = new Chain.Dialog();
Console.WriteLine("-----------------------------------");
dialog00.Help();
dialog00.dialogHelp = "Happy party!";
dialog00.Help();

// ######################################## State Machine ######################################
WashingMachine machine = new();
Console.WriteLine("-------------------------------------");
Console.WriteLine(machine.led);
machine.Toggle();
Console.WriteLine(machine.led);
machine.Toggle();
Console.WriteLine(machine.led);
