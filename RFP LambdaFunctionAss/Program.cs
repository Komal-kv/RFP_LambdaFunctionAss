﻿// See https://aka.ms/new-console-template for more information
using RFP_LambdaFunctionAss;

Console.WriteLine("Welcome to User Registration");
Console.WriteLine();

Pattern patterns = new Pattern();
Console.WriteLine(patterns.validateFirstName("Komal"));
Console.WriteLine(patterns.validateLastName("Vairagade"));
Console.WriteLine(patterns.validateEmail("divyavairagade@gmail.com"));
Console.WriteLine(patterns.validatePhoneNo("91 8788254798"));
Console.WriteLine(patterns.validatePassword("Bridgelabz"));