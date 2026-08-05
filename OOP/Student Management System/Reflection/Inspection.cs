using System;
using System.Reflection;
using Interfaces.IOperations;

namespace Reflection.Inspection;

public class Inspection
{
    public static void ToBeInspected(Type type)
    {
        if (type is null)
        {
            throw new ArgumentNullException(nameof(type));
        }
        //======== All methods that will execute on this method call
        {
            PrintBasicInfo(type);
            PrintProperties(type);
            PrintAttributes(type);
            PrintMethods(type);
            PrintInterfaces(type);
            PrintConstructors(type);
        }

    }

    private static void PrintBasicInfo(Type type)
    {
        Console.WriteLine($"Type Name: {type.Name}");
        Console.WriteLine($"Full Name: {type.FullName}");
        Console.WriteLine($"Namespace: {type.Namespace}");
        Console.WriteLine($"Base Type: {type.BaseType?.Name}");
        Console.WriteLine($"IsClass? {type.IsClass}");
        Console.WriteLine($"IsAbstract? {type.IsAbstract}");
        Console.WriteLine($"IsInterface? {type.IsInterface}");
        Console.WriteLine($"IsEnum? {type.IsEnum}");
        Console.WriteLine($"IsValueType? {type.IsValueType}");
        Console.WriteLine($"IsPublic? {type.IsPublic}");
        Console.WriteLine();
    }

    private static void PrintProperties(Type type)
    {
        Console.WriteLine("All Properties:");

        var propertiesList = type.GetProperties();
        foreach (var property in propertiesList)
        {
            Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
        }

        Console.WriteLine();
    }

    private static void PrintAttributes(Type type)
    {
        Console.WriteLine("All Attributes:");

        var attributeList = type.GetCustomAttributes(false);
        foreach (var attribute in attributeList)
        {
            Console.WriteLine(attribute.GetType().Name);
        }

        Console.WriteLine();
    }

    private static void PrintMethods(Type type)
    {
        Console.WriteLine("All Methods:");

        var methodList = type.GetMethods();
        foreach (var method in methodList)
        {
            Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
        }

        Console.WriteLine();
    }

    private static void PrintInterfaces(Type type)
    {
        Console.WriteLine("All Interfaces:");

        var interfaceList = type.GetInterfaces();
        foreach (var interfacee in interfaceList)
        {
            Console.WriteLine(interfacee.Name);
        }

        Console.WriteLine();
    }

    private static void PrintConstructors(Type type)
    {
        Console.WriteLine("All Constructors:");

        var constructorList = type.GetConstructors();
        foreach (var constructor in constructorList)
        {
            Console.WriteLine(constructor.Name);

            foreach (var parameter in constructor.GetParameters())
            {
                Console.WriteLine($"    Parameter: {parameter.ParameterType.Name} {parameter.Name}");
            }
        }

        Console.WriteLine();
    }
}