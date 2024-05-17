# Learning C# 🚀

[![wakatime](https://wakatime.com/badge/user/1cf7c976-595a-4fc7-a7c4-324b43a74aca/project/018dbe09-ae67-4e81-8249-ffee6e8c43fd.svg)](https://wakatime.com/badge/user/1cf7c976-595a-4fc7-a7c4-324b43a74aca/project/018dbe09-ae67-4e81-8249-ffee6e8c43fd)

Hello there, I created this repo to document my journey on learning C# from zero to hero. Of course I learned **C#** from the best so why wouldn't I be a world class **C#** Developer. I started learning C# **January 2024** and my goal is to master the language and start building solid projects by **August 2024**

## Resources 👜

Okay, so for the resources, I'm learning from **Mosh Hamedani**, you can find the video on Youtube. But since the course is kinda old too and somethings have changed in the **C#** community, I'm also using the official **Microsoft Documentation** and their videos to learn too. I've picked somethings **Mosh** didn't mention there. I'm also using **W3Schools** to learn too, I've finished their tutorial and I also took their test and got 22/25.

1. Mosh Hamedani C# For Beginners [Watch on Youtube](https://www.youtube.com/watch?v=gfkTfcpWqAY&pp=ygUQbW9zaCBoYW1lZGFuaSBDIw%3D%3D)
2. Mosh Hamedani DotNet Tutorials [Watch on Youtube](https://www.youtube.com/watch?v=gfkTfcpWqAY&list=PLTjRvDozrdlz3_FPXwb6lX_HoGXa09Yef)
3. Microsoft C# Step by Step Tutorials [Microsoft C# Tutorials](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)
4. Take W3School C# Quiz [Take The Quiz](https://www.w3schools.com/quiztest/quiztest.asp?qtest=CS)
5. Learn C# Basics from W3schools [Learn C# Tutorials](https://www.w3schools.com/cs/index.php)

I will also add any other resources here.

## What I've learned 🧠

C# is an amazing language created by Microsoft decades ago. I love C# because it is a High level language.Top that it is a typed language.

1. I've learned the C# basics like intializing a project with **dotnet** CLI tool, declaring variables, constants, functions as well as string methods, datetime methods, arrays, array methods, lists, list methods, conditonal statement, loops, namespaces, using statements, working with files, reading a file, File static class which provides static methods, FileInfo class, methods and properties, the difference between these methods, same as Directory class and DirectoryInfo class.

2. I just moved to intermediate about 3 days ago. That's on Tuesday. (16/04/2024). And I used C# to create my `0-c#-intermediate` directory and file. Which was mind blowing. I've been working with Classes and I just realized that everything in C# is classes. I've learned difference between a Class and an Object, constructors and conctructors overloading which is a new stuff. I haven't seen anything like that in **JavaScript** or **TypeScript** which are the languages I'm coming from. It is totally awesome, I learned about the constructor overloading signature concept, methods and methods overloading, access modifiers, here I also discovered C# has 2 more access modifiers that I haven't worked with before. `internal and protected internal`. I'm yet to learn about these modifiers but I trust they will be awesome as usual. I've also learned about the method modifiers such as `params, out and ref` I like the `params` and slighlty the `ref` but I think they are likely to appear in interviews than in a real world application. So I had to learn it just for that. Though my instructor **Mosh Hamedani** said there is a method in the **Dotnet** framework where you will use the `out` method modifier. The `int.TryParse()` method. So you just need to pass a out along with the value. Though I must say one weird thing I've noticed is that I get auto completions here on my Mac. But when I was still using my Linux Ubuntu, I don't get auto completions on Vscode. I don't even get any error even if I make a syntax error. It wasn't a good experience. I can't wait to learn the advance part of C#. I so much love this language. Okay so I've learned a lot since I last edited the documentation that's yesterday. I've worked with the `internal and protected internal` access modifiers which I would not be using any time soon. Why? well, to my understanding, the `internal and protected internal` access modifier works with assembly, bottomline you aren't really going to use it in a realworld application. Even **Mosh Hamedani** said those 2 keywords are the worse thing that has ever happend to **C#**. I haven't really been able to wrap my head around it. But I will soon.

3. I've learned a lot about OOP. The funny thing is that prior to learning C#. I didn't really understand some concepts in OOP until now. I didn't know how to use Composition, I've only worked with Inheritance. But I've not only learned how to work with it, I've also learned the best practices with composition and inheritance. When to use it and when not to use it. I've also learned another concept in OOP which is Polymorphism which means different forms. Basically it is the ability of a class to have or take different forms. I haven't practised it yet though.

4. Been a while since I wrote C#, glad I'm back now. I'm almost done with the C# advance course and I will move to writing backend API's and building fullstack apps with Blazor and C# soon. But what have I learned? I've learned about Delegates, Events, Generics, Extension Methods, Lambda Expressions etc. I will be practising what I've learned before moving to the next episode which is **LINQ** and then **Asynchronous Programming**. I can't wait to learn about **LINQ**. I've heard a lot about it. I even built a project with the name Linq. [Use Linq](https://uselinq.vercel.app) I can't wait to learn about it. I'm so excited. Okay, I finally practised Lambda expressions, delegates and generics.

5. I've been able to practise Lambda expressions, delegates and all. I event created my own custom **Func and Action** delegates. I'm also understanding generics bit by bit. I'm loving **C#** more and more. Right now, I'm about to practise events and understand how it works. Then I will move to Extensions and then to Enums which I already know, LINQ and then to Asyncronous operations in C#.

6. I must say events in C# gave me tough time, this is because events as a whole comprises of Delegates and all, top that events are like complext delegates but I love it, hopefully I should understand it better very soon. Up next is extension methods, though I'm not a fan of this approach but I'm still going to learn and practice it.

7. Yeah, I've learned method extension, At first it looked kinda confusing, I was kinda confused about where to add the this keyword. Basically, you just add the type you want to extend in the method you want. Though there are some requirements that must be met, the extension class and methods should be marked **static** they must have a **public** access modifier. Let's try to create an **Extension Method** eg

```csharp

using System;


namespace CSharpJourney{

    public static class StringExtension{

        public static int GetWordsCount(this string str){
            return str.Split(' ').Length;
        }
    }
}

```

Now, you've created an extension method that gets the length of words in a string. Now let's use it in out main program..

```csharp
using System;


namespace CSharpJourney{

    public class Program{
        static void Main(string[] args){
            string[] sentence = "I love C# with all my strength";

            Console.WriteLine(sentence.GetWordsCount());
        }
    }
}
```

8. Bingo, we created our **Extension Method**. But according to my instructor **Mosh Hamedani**, you should only create **Extension Methods** when you really have to. Though as awesome as it looks, I'm not really a fan of it, but yeah it was worth learning. I will also expore creating other extension methods apart from string methods.

9. I just thought of something cool, I think you should be able to use a **Lambda Expression** in an **Extension Method**, we can use the **Func Delegate or Action Delegate**. I will try it, this time it will be a Number Extension method.
