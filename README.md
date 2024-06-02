
# Project Title
# Console Applications

This project consists of three separate console applications written in C#:

1. Grade Calculator
2. Ticket Price Calculator
3. Triangle Type Identifier

The main program allows users to select which application to run from a menu.

## Table of Contents

- [Overview](#overview)
- [Setup](#setup)
- [Usage](#usage)
- [Applications](#applications)
  - [Grade Calculator](#grade-calculator)
  - [Ticket Price Calculator](#ticket-price-calculator)
  - [Triangle Type Identifier](#triangle-type-identifier)

## Overview

This project includes three console applications to perform different tasks:
- Calculate the letter grade based on a numerical grade.
- Calculate the ticket price based on the user's age.
- Identify the type of a triangle based on the lengths of its sides.

## Setup

### Prerequisites

- .NET SDK (Download from [here](https://dotnet.microsoft.com/download))

### Installation

1. Clone the repository:

   git clone https://github.com/yourusername/ConsoleApplications.git
   cd ConsoleApplications

2. Build the project:
    dotnet build

#Usage
Run the project:

Copy code
    dotnet run

Follow the on-screen prompts to select an application and enter the required inputs.

#Applications
1. Grade Calculator
Prompts the user to enter a numerical grade between 0 and 100 and displays the corresponding letter grade.

Example
    Enter a numerical grade between 0 and 100: 85

    The letter grade is: B #Output

2. Ticket Price Calculator
Prompts the user to enter their age and calculates the ticket price based on the age entered. Standard ticket price is GHC10. Senior citizens (age 65 and above) and children (age 12 and below) receive a discounted price of GHC7.

Example
    Enter your age: 70

    The ticket price is: GHC7 #Output

3. Triangle Type Identifier
Prompts the user to enter the lengths of the three sides of a triangle and determines the type of the triangle (Equilateral, Isosceles, or Scalene).

Example
    Enter the first side of the triangle: 5
    Enter the second side of the triangle: 5
    Enter the third side of the triangle: 8

    The triangle is Isosceles. #Output


### How to Use the README

1. **Save the above content** into a file named `README.md` in the root directory of your project.
2. **Update the repository URL** in the `git clone` command to match your GitHub repository.
3. **Add any additional information** or sections that you think are necessary for users of your project.

The README file provides clear instructions on setting up and running the project, making it easier for others to understand and use your code.


