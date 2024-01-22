# ParaBank Selenium Automation Project in C#

This repository contains an automation framework that I wrote back in 2015 for automating the Parasoft demo website 
ParaBank [here](https://parabank.parasoft.com/parabank/index.htm).

It is an example of Selenium in C# using the Page Object Model.

I wrote it in C# using Microsoft Visual Studio 2013 (v12). It has not been updated or revisited since 2015, as I switched
to Java when I started working for NorthRow which was predominantly an Amazon Web Services / Java shop. 

In Jan 2024 I added the project to my list of GitHub repositories.

## Test Areas / Classes

There are approximately 40 different tests in total which are broken down into the following test areas/classes:  

* Account Menu Tests
* Contact Us Tests
* Footer Menu Test
* Forgot Login
* Login Tests
* Solutions Menu Tests
* User registration Tests

These tests are supported by approximately 30 different page objects.  

## Page Object Design Pattern

I used the Page Object Design Pattern (POM). POM, is a design pattern that creates an object repository for storing all
web elements. It helps reduce code duplication and improves test case maintenance.

In Page Object Model, you consider each web page of an application as a class file. Each class file will contain only
corresponding web page elements. Using these elements, testers can perform operations on the website under test.

## What is ParaBank ?

ParaBank, a deliberately vulnerable web application and API, developed by Parasoft, a vendor of automated testing tools.

A demo site from Parasoft that simulates an online banking environment, offering a different kind of challenge for 
automation testing.

![ParaBank](/assets/images/parabank.PNG)
*ParaBank Landing page*
