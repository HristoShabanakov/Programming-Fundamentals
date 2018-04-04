# <p align="center"> C# Intro and Basic Syntax - Exercises<p>

## 01. **Debit Card Number**

#### **Problem Description**

Write a program, which receives **4 integers** on the console and **prints them** in **4‐digit debit card format.** See the examples below for the appropriate formatting.

 #### Examples

|**Input**|**Output**|
|---|---|
|12<br> 433<br> 1<br> 5331<br>| 0012 0433 0001 5331
|9182<br> 4221<br> 12<br> 3<br>| 9182 4221 0012 0003
|812<br> 321<br> 123<br> 22<br>| 0812 0321 0123 0022


## 02. **Rectangle Area** 

#### **Problem Description**

Write a program, which calculates a **rectangle’s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2nd character after the decimal point.**

#### Examples

|**Input**|**Output**|
|---|---|
|2<br> 7<br>| 14.00|
|7<br> 8<br>| 56.00|
|12.33<br> 5<br>| 61.65|

## 03. **Miles to Kilometers** 

#### **Problem Description**

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2nd decimal place**.<br> Note: **1 mile == 1.60934 kilometers**

#### Examples
|**Input**|**Output**|
|---|---|
|60 |96.56|
|1  |1.61 |
|52.1113 | 83.86|

## 04. **Beverage Labels** 

#### **Problem Description**

Write a program, which reads a food product **name, volume, energy content per 100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content** for the **given volume** and print them on the console in the following format:<br>
Name – as per the input<br> Volume – **integer**, **suffixed** by **“ml”** (e.g. **“220ml”**)<br> Energy content – **integer**, **suffixed** by **“kcal”** (e.g. **“500kcal”**)<br> Sugar content – **integer**, **suffixed** by **“g”** (e.g. **“30g”**)<br>

#### Examples

|**Input**|**Output**|
|---|---|
|Nuka-Cola| 220ml Nuka-Cola:|
|220| 660kcal, 154g sugars |
|300|
|70|

|**Input**|**Output**|
|---|---|
|Ice Cold Nuka-Cola| 250ml Ice Cold Nuka-Cola:|
|250 | 875kcal, 162.5g sugars|
|350 |
| 65 |

|**Input**|**Output**|
|---|---|
|Nuka-Cola Quantum | 350ml Nuka-Cola Quantum:|
|350 | 2100kcal, 490g sugars |
|600 |
|140 |

## 05. **Character Stats** 

#### **Problem Description**

Write a program, which **displays information** about a video game character. You will receive their **name, current health, maximum health, current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

#### Examples

|**Input**|**Output**|                                       
|---|---|
|Mayro<br>  | Name: Mayro |
|5<br> | Health: ||||||.....| |
|10<br> | Energy: ||||||||||.| |
|9 |
|10<br> |

|**Input**|**Output**|
|---|---|
|Bauser<br>  | Name: Bauser |
|10<br> | Health: |||||||||||| |
|10<br> | Energy: |||||||||||| |
|10 |
|10<br> |

|**Input**|**Output**|
|---|---|
|Loogi<br>  | Name: Loogi |
|8<br> | Health: |||||||||............| |
|20<br> | Energy: |||............|
|2 |
|14<br> |

|**Input**|**Output**|
|---|---|
|Toad<br>  | Name: Toad |
|0<br> | Health:|.....| 
|5<br> | Energy:|..........||
|0 |
|10<br> |

#### Hints

You can print a character **multiple** times, using **new string(character, count).**
