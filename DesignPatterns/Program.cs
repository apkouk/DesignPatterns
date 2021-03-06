﻿using System;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPattern.Classes.PizzaStores;
using DesignPatterns.Singleton;
using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.Commands;
using DesignPatterns.CommandPattern.Commands.Light;
using DesignPatterns.CommandPattern.Commands.CeilingFan;
using DesignPatterns.CommandPattern.Commands.GarageDoor;
using DesignPatterns.CommandPattern.Commands.Stereo;
using DesignPatterns.CommandPattern.Interfaces;
using DesignPatterns.ObjectAdapter.Interfaces;
using DesignPatterns.ObjectAdapter.Classes;
using DesignPatterns.ObjectAdapter.Adapters;
using DesignPatterns.Facade;
using DesignPatterns.Facade.Devices;
using DesignPatterns.Iterator;
using DesignPatterns.Template.NoHook;
using DesignPatterns.Iterator.Menus;
using DesignPatterns.Composite.Abstract;
using DesignPatterns.Composite.Menus;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////--------------------------------------
            ////    The Strategy Pattern
            ////--------------------------------------
            ////Defines a family of algorithms, encapsulates each one, and makes them interchangable.
            ////Stratey lets the algorithim vary independently from clients that use it.
            ////======================================
            ////Encapsulates what varies
            ////Favor composition over inheritance
            ////Program to interface, not implementations

            #region Strategy

            //Duck duck = new MallardDuck();
            //duck.display();
            //duck.PerformFly();
            //duck.PerformQuak();
            //duck.Swim();

            ////Change behavior
            //duck.SetFlyBehavior(new FlyNoWay());
            //duck.SetQuakBehavior(new MuteQuack());

            ////Result
            //duck.PerformFly();
            //duck.PerformQuak();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Observer Pattern
            ////--------------------------------------
            ////The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, 
            ////called observers, and notifies them automatically of any state changes, usually by calling one of their methods.
            ////======================================
            ////Strive for loosely coupled designs between objects that interact

            #region Observer

            //WeatherData weatherData = new WeatherData();

            //CurrentConditionsDisplay display1 = new CurrentConditionsDisplay(weatherData);
            //StatisticsDisplay display2 = new StatisticsDisplay(weatherData);

            //weatherData.getMeasurements();
            //weatherData.setMeasurement(1, 2, 3);

            //IWeatherDataMeasurement wdMeasuremtn = weatherData.getCurrentMeasurement();
            //wdMeasuremtn.displayMeasurements(); //There is no notification of this, we are just getting the current measurement

            //weatherData.setMeasurement(10, 20, 30);
            //weatherData.setMeasurement(100, 200, 300);

            //display2.ExitObserver();

            //weatherData.setMeasurement(1, 2, 3);
            //weatherData.setMeasurement(10, 20, 30);
            //weatherData.setMeasurement(100, 200, 300);

            //Console.ReadLine();

            ////----EXERCECISE----////
            ////Create a console app to retrieve data from a real API to append it in a file every 1 minute

            //DataObservers dataObservers = new DataObservers();
            //DataElement dataElement;
            //IDataWorker dataWorker;

            ////V1
            ////IDataElementConfiguration dataElementConfiguration;
            ////dataElementConfiguration = new DataElementConfigurationFile();
            ////dataElement = new DataElementFile(dataElementConfiguration);
            ////dataWorker = new DataWorkerFile(dataElement, dataObservers);
            ////dataWorker.readData();

            ////dataElementConfiguration = new DataElementConfigurationDB();
            ////dataElement = new DataElementDB(dataElementConfiguration);
            ////dataWorker = new DataWorkerDB(dataElement, dataObservers);

            ////V2
            //IDataElementConfiguration dataElementConfigurationFile = new DataElementConfigurationFile();
            //IDataElementConfiguration dataElementConfigurationDB = new DataElementConfigurationDB();
            //dataElement = new DataElementMixer(dataElementConfigurationDB, dataElementConfigurationFile);
            //dataWorker = new DataWorkerMixer(dataElement, dataObservers);

            //dataObservers.notifyObservers();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Decorator Pattern
            ////--------------------------------------
            ////Attach additional responsibilities to an object dynamically.
            ////Decorators provide a flexible alternative to subclassing for extended funtionality.
            ////======================================
            ////Classes shoud be open for extension but closed for modification (Open-Closed principle)

            #region Decorator

            //EXC Improve size decotaro to send and enum with the size, do the same wiht offers

            //Beverage beverage1 = new Espresso();
            //beverage1 = new SmallSize(beverage1);
            //Console.WriteLine(beverage1.getDescription());
            //Console.WriteLine(beverage1.cost());

            //Beverage beverage2 = new DarkRoast();
            //beverage2 = new MediumSize(beverage2);
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Whip(beverage2);
            //Console.WriteLine(beverage2.getDescription());
            //Console.WriteLine(beverage2.cost());

            //Beverage beverage3 = new DarkRoast();
            //beverage3 = new LargeSize(beverage3);
            //beverage3 = new Soy(beverage3);
            //beverage3 = new Mocha(beverage3);
            //beverage3 = new Whip(beverage3);
            //Console.WriteLine(beverage3.getDescription());
            //Console.WriteLine(beverage3.cost());

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Factory Pattern
            ////--------------------------------------
            ////Abstract Factory implemented (not the factory method)
            ////provides an interface for creating families of related or dependent objects
            ////without specifying their concrete classes. 
            ////======================================
            ////Depend on abstractions. Do not depend on concrete classes

            #region Abstract Factory

            //PizzaStore pizzaStore = new NyPizzaStore();
            //pizzaStore.OrderPizza("cheese");

            //Console.WriteLine("/////////////////////////////////////////");

            //pizzaStore = new ChicagoPizzaStore();
            //pizzaStore.OrderPizza("cheese");

            //Console.WriteLine("/////////////////////////////////////////");
            //pizzaStore.OrderPizza("veggie");

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Singleton Pattern
            ////--------------------------------------
            ////Ensure a class only has one instance and provide a global point of access to it

            #region Singleton

            //Singleton.Singleton singleton = Singleton.Singleton.getInstance();

            //System.Threading.Thread newThread = new System.Threading.Thread(new System.Threading.ThreadStart(NewInstance));
            //newThread.Start();

            //void NewInstance()
            //{
            //    Singleton.Singleton singleton2 = Singleton.Singleton.getInstance();               
            //}



            //Console.ReadLine();



            #endregion


            ////--------------------------------------
            ////    The Command Pattern
            ////--------------------------------------
            ////Encapsulates a request as an object, thereby letting you parametrize clients with different
            ////requests, queue or log requests, and supoort undoable operations.

            #region Command 

            //SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();

            ///////////////////////FIRST TEST///////////////////////

            //LightDev livingRoomLight = new LightDev("Living Room light");
            //LightDev kitchenLight = new LightDev("Kitchen light");
            //CeilingFanDev ceilingFan = new CeilingFanDev("Living Room");
            //GarageDoorDev garageDoor = new GarageDoorDev();
            //StereoDev stereo = new StereoDev("Living Room");

            //LightOn livingRoomLightOn = new LightOn(livingRoomLight);
            //LightOff livingRoomLightOff = new LightOff(livingRoomLight);
            //LightOn kitchenLightOn = new LightOn(kitchenLight);
            //LightOff kitchenLightOff = new LightOff(kitchenLight);

            //CeilingFanOn ceilingFanOn = new CeilingFanOn(ceilingFan);
            //CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);

            //GarageDoorUp garageDoorUp = new GarageDoorUp(garageDoor);
            //GarageDoorDown garageDoorDown = new GarageDoorDown(garageDoor);

            //StereoOn stereoOn = new StereoOn(stereo);
            //StereoOff stereoOff = new StereoOff(stereo);

            //simpleRemoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            //simpleRemoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            //simpleRemoteControl.setCommand(2, ceilingFanOn, ceilingFanOff);
            //simpleRemoteControl.setCommand(3, garageDoorUp, garageDoorDown);
            //simpleRemoteControl.setCommand(4, stereoOn, stereoOff);                 

            //simpleRemoteControl.slotsBrief();

            //simpleRemoteControl.onButtonWasPressed(0);
            //simpleRemoteControl.offButtonWasPressed(0);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(1);
            //simpleRemoteControl.offButtonWasPressed(1);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(2);
            //simpleRemoteControl.offButtonWasPressed(2);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(3);
            //simpleRemoteControl.offButtonWasPressed(3);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(4);
            //simpleRemoteControl.offButtonWasPressed(4);
            //simpleRemoteControl.undoButtonWasPressed();
            //Console.ReadLine();

            ///////////////////////SECOND TEST///////////////////////

            //CeilingFanDev ceilingFan = new CeilingFanDev("Living Room");
            //CeilingFanMedium ceilingFanMedium= new CeilingFanMedium(ceilingFan);
            //CeilingFanHigh ceilingFanHigh = new CeilingFanHigh(ceilingFan);
            //CeilingFanLow CeilingFanLow = new CeilingFanLow(ceilingFan);
            //CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);

            //simpleRemoteControl.setCommand(0, ceilingFanMedium, ceilingFanOff);
            //simpleRemoteControl.setCommand(1, ceilingFanHigh, ceilingFanOff);
            //simpleRemoteControl.setCommand(2, CeilingFanLow, ceilingFanOff);

            //simpleRemoteControl.onButtonWasPressed(0);
            //simpleRemoteControl.offButtonWasPressed(0);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(1);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(2);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.onButtonWasPressed(2);
            //simpleRemoteControl.onButtonWasPressed(1);
            //simpleRemoteControl.undoButtonWasPressed();
            //simpleRemoteControl.offButtonWasPressed(0);

            //Console.ReadLine();


            ///////////////////////FOURTH TEST///////////////////////

            //LightDev kitchenLight = new LightDev("Kitchen light");
            //CeilingFanDev ceilingFan = new CeilingFanDev("Living Room");
            //GarageDoorDev garageDoor = new GarageDoorDev();
            //StereoDev stereo = new StereoDev("Living Room");

            //LightOn kitchenLightOn = new LightOn(kitchenLight);
            //LightOff kitchenLightOff = new LightOff(kitchenLight);
            //CeilingFanOn ceilingFanOn = new CeilingFanOn(ceilingFan);
            //CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);
            //GarageDoorUp garageDoorUp = new GarageDoorUp(garageDoor);
            //GarageDoorDown garageDoorDown = new GarageDoorDown(garageDoor);
            //StereoOn stereoOn = new StereoOn(stereo);
            //StereoOff stereoOff = new StereoOff(stereo);

            //Command[] commandsOn = { kitchenLightOn, ceilingFanOn, garageDoorUp, stereoOn };
            //Command[] commandsOff = { kitchenLightOff, ceilingFanOff, garageDoorDown, stereoOff };
            //MacroCommand macroCommandOn = new MacroCommand(commandsOn);
            //MacroCommand macroCommandOff = new MacroCommand(commandsOff);

            //simpleRemoteControl.setCommand(0, macroCommandOn, macroCommandOff);
            //simpleRemoteControl.onButtonWasPressed(0);
            //Console.WriteLine("UNDO");
            //simpleRemoteControl.undoButtonWasPressed();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Adapter Pattern
            ////--------------------------------------
            ////Converts the interface of a class into another interface the client expects.
            ////Adapter lets classes work together that couldn't otherwise because of compatible interfaces.

            #region Adapter
            //MallardDuck mallardDuck = new MallardDuck();
            //WildTurkey wildTurkey = new WildTurkey();

            //Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            //Console.WriteLine("The Mallard Duck says...");
            //mallardDuck.fly();
            //mallardDuck.quack();

            //Console.WriteLine("The Wild Turkeys says...");
            //wildTurkey.fly();
            //wildTurkey.gobble();

            //Console.WriteLine("The Turkey Adapter says...");
            //turkeyAdapter.fly();
            //turkeyAdapter.quack();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Facade Pattern
            ////--------------------------------------
            ////Provides a unified interface to a set of interfaces in a subsystem.
            ////Facade defines a higher-level interface that makes the subsystem easier to use.
            ////======================================
            ////Principle of Least Knowledge: talk only to your immediate friends

            #region Facade


            //public class Car
            //{
            //    //Here's a component of this class. We can call its methods
            //    Engine engine;

            //    public Car()
            //    { }

            //    public void Start(Key key)
            //    {
            //        //Here we are creating a new object; its methods are legal
            //        Doors doors = new Doors();
            //        //You can call a method on a object passed as a parameter
            //        bool authorized = key.turns();

            //        if(authorized)
            //        {
            //            //You can call a method on a component of the object
            //            engine.start();
            //            //You can call a local method within the object
            //            updateDashboardDisplay();
            //            //You can call a method on an object you create or instantiate
            //            doors.lock();
            //        }

            //    }
            //}

            //Amplifier amplifier = new Amplifier();
            //CdPlayer cdPlayer = new CdPlayer();
            //DvdPlayer dvdPlayer = new DvdPlayer();
            //PopcornPopper popcornPopper = new PopcornPopper();
            //Projector projector = new Projector();
            //Screen screen = new Screen();
            //TheatherLights theatherLights = new TheatherLights();
            //Tuner tuner = new Tuner();

            //HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(amplifier, cdPlayer, dvdPlayer, popcornPopper, projector, screen, theatherLights, tuner);
            //homeTheaterFacade.watchMovie("The Godfather");
            //homeTheaterFacade.endMovie();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Template Pattern
            ////--------------------------------------
            ////Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
            ////Template method lest subclasses redefine certain steps of an algorithm without changing 
            ////the algorithm's structure.
            ////======================================
            ////Don't call us, we'll call you (superclasses are running the show, let them call your subclasses
            ////when they are nedded

            #region Template

            //NoHook
            //Coffee coffee = new Coffee();
            //coffee.prepareRecipe();

            //Tea tea = new Tea();
            //tea.prepareRecipe();

            //With hooh
            //CoffeeHook coffee = new CoffeeHook();
            //coffee.prepareRecipe();

            //Console.ReadLine();

            #endregion


            ////--------------------------------------
            ////    The Iterator Pattern
            ////--------------------------------------
            ////Provides a way to access the element of an aggregate object sequentially 
            ////without exposing its underlying representation            
            ////======================================
            ////A class should have only one reason to change

            #region Iterator

            //Menu pancakeHouseMenu = new PancakeHouseMenu();
            //Menu dinerMenu = new DinerMenu();
            //Menu cafeMenu = new CafeMenu();

            //Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            //waitress.printMenu();

            //Console.ReadLine();
            #endregion


            ////--------------------------------------
            ////    The Composite Pattern
            ////--------------------------------------
            ////Compose objects into tree structures to represent a part-whole hierarchies.
            ////Composite lets clients treat individual objects and compositions of objects uniformly
            ////======================================
            ////A class should have only one reason to change

            #region Composite

            MenuComponent pancakeHouseMenu = new Composite.Menus.PancakeHouseMenu();
            MenuComponent dinerMenu = new Composite.Menus.DinerMenu();
            MenuComponent cafeMenu = new Composite.Menus.CafeMenu();
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new Composite.MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));
            //dinerMenu.Add(cafeMenu);

            Composite.Waitress waitress = new Composite.Waitress(allMenus);
            waitress.printMenu();

            Console.ReadLine();
            #endregion

        }
    }
}