﻿# Challenge: Find the longest substring present in an array!

Let be a two-dimensional square array of (any) characters, return the longest string of equal adjacent characters.

**Input**
|B|B|D|A|D|E|F|
|--|--|--|--|--|--|--|
|B|X|C|D|D|J|K|
|H|Y|I|3|D|D|3|
|R|7|O|Ñ|G|D|2|
|W|N|S|P|E|0|D|
|A|9|C|D|D|E|F|
|B|X|D|D|D|J|K|

**Output**

    Result: D, D, D, D, D

It should return the string D, D, D, D, D because there is a diagonal of D of length 5 which is the longest.

# Overview

The project was made in the C# programming language, it is a console application that uses .NET 5.0.

Inside the project you will find a file `Input.txt` where you can place the input array that the program will use.

In order to compile the application you will need:

 1. Have .NET 5.0 installed.
 2. Have Visual Studio 2019 or higher installed.
