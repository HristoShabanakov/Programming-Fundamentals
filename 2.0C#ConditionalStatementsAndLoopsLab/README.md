# <p align="center"> Lab: Conditional Statements and Loops <p>

## Problem 1. Passed
Write a program, which takes as an input a **grade** and prints **“Passed!”** if the grade is **equal or more than 3.00**.<br>

**Input**<br>

The input comes as a single floating‐point number.<br>

**Output**<br>

The **output** is either **"Passed!"** if the grade is **equal or more than 3.00**, otherwise you should print nothing.<br>

#### Examples

|**Input**|**Output**|
|---|---|
|5.32|Passed !|


|**Input**|**Output**|
|---|---|
|2.34|(no output)|


## Problem 2. Passed or Failed

Modify the above program, so it will print **"Failed!"** if the grade is **lower than 3.00**.<br>

**Input**<br>

The **input** comes as a single double number.<br>

**Output**<br>

The **output** is either **"Passed!"** if the grade is **more than 2.99**, otherwise you should print **"Failed!"**.<br>

#### Examples

|**Input**|**Output**|
|---|---|
|5.32|Passed !|

|**Input**|**Output**|
|---|---|
|2.36|Failed !|

## Problem 3. Back in 30 Minutes

Every time Stamat tries to pay his bills he sees on the cash desk the sign: **"I will be back in 30 minutes"**. One day Stamat was sick of waiting and decided he needs a program, which **prints the time** after **30 minutes**. That way he won’t have to wait on the desk and come at the appropriate time. He gave the assignment to you, so you have to do it.<br>

**Input**<br>

The input will be on two lines. On the **first line**, you will receive the **hours** and on the **second** you will receive the **minutes**.

**Output**<br>

Print on the console the time after **30** minutes. The result should be in format **hh:mm**. The **hours** have **one or two numbers** and the **minutes** have always **two numbers (with leading zero)**.<br>

**Constraints**<br>

The **hours** will be between **0 and 23**.<br> The **minutes** will be between **0 and 59**.<br>

|**Input**|**Output**|  
|---|---|
|1|2:16|
|46| |

|**Input**|**Output**|
|---|---|
|0|0:31|
|01| |

|**Input**|**Output**|
|---|---|
|23|0:29|
|59| |

|**Input**|**Output**|
|---|---|
|11|11:38|
|08| |

|**Input**|**Output**|
|---|---|
|11|12:02|
|32| |

> #### Hints
>Add 30 minutes to the initial minutes, which you receive from the console. If the minutes are more than 59 – increase the hours with 1 and decrease the minutes with 60. The same way 
>check if the hours are more
>than 23. When you print check for leading zero.

## Problem 4. Month Printer

Write a program, which takes an **integer** from the console and prints the corresponding **month**. If the number **is more than 12** or **less than 1** print **"Error!"**.

**Input**<br>

You will receive a **single integer** on a **single line**.

**Output**<br>

If the number is within the boundaries print the corresponding month, otherwise print **"Error!"**.

#### Examples

|**Input**|**Output**|  
|---|---|
|2|February|


|**Input**|**Output**|
|---|---|
|13|Error!|

## Problem 5. Foreign Languages

Write a program, which prints the language, that a given country speaks. You can receive only the following combinations: English is **spoken** in England and USA; Spanish is **spoken** in Spain, Argentina and Mexico; for the others, we should print **"unknown"**.

**Input**<br>

You will receive a **single country name** on a **single line**.

**Output**<br>

**Print** the **language**, which the country **speaks**, or if it is **unknown** for your program, print **"unknown"**.

#### Examples

|**Input**|**Output**|  
|---|---|
|USA|English|


|**Input**|**Output**|
|---|---|
|Germany|unknown|

## Problem 6. Theatre Promotions

A theatre is **doing a ticket sale**, but they need a program **to** calculate the **price** of a **single ticket**. If the given age does not fit one of the categories, you should print **"Error!"**. You can see the prices **in** the table below:

<table style="width:100%">
  <tr>
    <th>Day / Age</th>
    <th>0 <= age <= 18</th>
    <th>18 < age <= 64</th>  
    <th>64 < age <= 122</th>
  </tr>
  <tr>
    <td>Weekday</td>
    <td>12$</td>
    <td>18$</td>
    <td>12$</td>
  </tr>
  <tr>
    <td>Weekend</td>
    <td>15$</td>
    <td>20$</td>
    <td>15$</td>
  </tr>
  <tr>
    <td>Holiday</td>
    <td>5$</td>
    <td>12$</td>
    <td>10$</td>
  </tr>
</table>

**Input**<br>

The input comes in **two lines**. On the first line, you will receive the **type of day**. On the **second** – the **age** of the person.

**Output**<br>

Print the price of the ticket according to the table, or **"Error!"** if the age is not in the table..<br>

**Constraints**<br>

The age will be in the interval **[‐1000…1000]**.<br> The type of day will **always be valid**.<br>

#### Examples

**Input**|**Output**|  
|---|---|              
|Weekday|18$|          
|42|  

**Input**|**Output**|  
|---|---|              
|Holiday|Error!|          
|-12|  

**Input**|**Output**|  
|---|---|              
|Holiday|5$|          
|-15|    

**Input**|**Output**|  
|---|---|              
|Weekend|15$|          
|122|        

## Problem 7. Divisible by 3

Write a program, which prints all the numbers from **1 to 100**, which are **divisible by 3**. You have to use a single **for** loop. The program should not receive input.

## Problem 8. Sum of Odd Numbers

Write a program that prints the next **n odd numbers** (starting from 1) and on the **last row** prints the **sum of them**.

**Input**<br>

>On the first line, you will receive a number – **n**. This number shows how many **odd numbers** you should print.

**Output**<br>

>Print the next **n** odd numbers, starting from **1**, separated by **new lines**. On the last line, print the **sum** of these numbers.

**Constraints**<br>

>**n** will be in the interval **[1…100]**

#### Examples

**Input**|**Output**|  
|---|---|              
|5|1<br>3<br>5<br>7<br>9<br>Sum: 25<br>|

**Input**|**Output**|  
|---|---|              
|3|1<br>3<br>5<br>Sum: 9<br>| 


## Problem 9. Multiplication Table

You will receive an **integer** as an input from the console. Print the **10 times table** for this integer. See the examples below for more information. 

**Output**<br>

Print every row of the table in the following format:<br>

**{ the Integer} X { times } = { product }**  

**Constraints**<br>

The integer will be in the interval **[1…100]**

#### Examples

**Input**|**Output**|  
|---|---|              
|5|5 x 1 = 5<br>5 x 2 = 10<br>5 x 3 = 15<br>5 x 4 = 20<br>5 x 5 = 25<br>5 x 6 = 30<br>5 x 7 = 35<br> 5 x 8 = 40<br> 5 x 9 = 45<br> 5 x 10 = 50<br>|

**Input**|**Output**|  
|---|---|              
|2|2 x 1 = 2<br>2 x 2 = 4<br>2 x 3 = 6<br>2 x 4 = 8<br>2 x 5 = 10<br>2 x 6 = 12<br>2 x 7 = 14<br>2 x 8 = 16<br>2 x 9 = 18<br>2 x 10 = 20<br>| 

## Problem 10. Multiplication Table 2.0

Rewrite you program so it can receive the **multiplier from the console**. Print the **table from the given multiplier to 10**. If the given multiplier is **more than 10** ‐ print only one row with the **integer**, the given **multiplier** and the **product**. See the examples below for more information.

**Output**<br>

Print every row of the table in the following format:<br>

**{ the Integer} X { times } = { product }**  
**Constraints**<br>

The integer will be in the interval **[1…100]**

#### Examples

**Input**|**Output**|  
|---|---|              
|5<br>1|5 x 1 = 5<br>5 x 2 = 10<br>5 x 3 = 15<br>5 x 4 = 20<br>5 x 5 = 25<br>5 x 6 = 30<br>5 x 7 = 35<br> 5 x 8 = 40<br> 5 x 9 = 45<br> 5 x 10 = 50<br>|


**Input**|**Output**|  
|---|---|              
|2<br>5|2 x 5 = 10<br>2 x 6 = 12<br>2 x 7 = 14<br>2 x 8 = 16<br>2 x 9 = 18<br>2 x 10 = 20<br>|


**Input**|**Output**|  
|---|---|              
|2<br>14|2 x 14 = 28|

## Problem 11. Odd Number

Take as an input an **odd number** and print the **absolute value** of it. If the number is even, print **"Please write an odd number."** and continue reading numbers.

**Input**<br>

You will receive even integers until you receive an odd number.

**Output**<br>

Print **"Please write an odd number."** if the received number is even. If the number is odd – **"The number is: {number}"**.

**Constraints**<br>

You will receive maximum 10 numbers.
The numbers will be in the interval **[-1000…1000]**

#### Examples

**Input**|**Output**|  
|---|---|
|2|Please write an odd number.|
|4|Please write an odd number.|
|5|The number is: 5|

 **Input**|**Output**|  
|---|---|
|-7|The number is: 7| 

## Problem 12. Number checker

Write a program, which reads an input from the console and prints **"It is a number."** if it’s a **number**. If it is **not** write
**"Invalid input!"**

**Input**<br>

You will receive a single line of input.

**Output**<br>

Print one of the messages, but without throwing an exception.

#### Examples

**Input**|**Output**|  
|---|---|
|5|It is a number.|

**Input**|**Output**|  
|---|---|
|five|Invalid input!|

> #### Hints 
>You can use a **try - catch** block to prevent throwing an exception.

  
