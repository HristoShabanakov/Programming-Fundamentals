# <p align="center"> C# Conditional Statements and Loops - Exercises<p>

## Problem 1. Choose a Drink

Write a program, which receives a **profession** (as a **string**) and chooses the perfect **drink** for the person. The possible combinations are:

“**Water**” – for “**Athlete**”<br> “**Coffee**” – for “**Businessman**” or “**Businesswoman**”<br> “**Beer**” – for “**SoftUni Student**”<br> “**Tea**” – for all **other professions**.<br>

#### Examples

**Input**|**Output**|  
|---|---|
|Athlete|Water|

**Input**|**Output**|  
|---|---|
|Doctor|Tea|

## Problem 2. Choose a Drink 2.0

Your program needs to get smarter. Now you will receive on the second line the quantities of the drink and you have to print the calculated the price. You can see the prices of the drinks in the table below:

<table style="width:100%">
  <tr>
  <th></th>
    <th>Coffee</th>
    <th>Water</th> 
    <th>Beer</th>
    <th>Tea</th>
  </tr>
  <tr>
  <td>Price</td>
    <td>0.70</td>
    <td>1.00</td>
    <td>1.70</td>
    <td>1.20</td>
  </tr>
</table>

**Input**<br>

The input will be on two lines:<br> On the **first line**, you will receive the **profession**.<br> On the **second** line, you will receive the **quantity** as an **integer**.<br>

**Output**<br>

Print the output in the following format:<br> **The {profession} has to pay {totalPrice}.**<br> **Format** the **price** to the **2nd decimal place**.<br>

#### Examples

**Input**|**Output**|  
|---|---|
|Athlete<br>1|The Athlete has to pay 0.70.|
|SoftUni Student<br>8|The SoftUni Student has to pay 13.60|
|Chef<br>3|The Chef has to pay 3.60.|

## Problem 3. Restaurant Discount

A restaurant want to automate their reservation process. They need a program that reads the **hall** and the **count of people** from the console and calculates **how much** the customer should **pay** to book the place.<br> Different halls have different prices:

<table style="width:100%">
  <tr>
  <th></th>
    <th>Small Hall</th>
    <th>Terrace</th> 
    <th>Great Hall</th>
  </tr>
  <tr>
  <td>Price</td>
    <td>2500$</td>
    <td>5000$</td>
    <td>7500$</td>
  </tr>
  <tr>
  <td>Capacity</td>
  <td>50</td>
  <td>100</td>
  <td>120</td>
</table>

You should **add** the **price** of the **package** to the **price** of the **hall**. The discount is calculated based on the **hall’s price** + **package’s price**.<br>

Example: The group has **10 people** and wants the **gold package** => **$292.50 per person**:

**10 people** <= 50 => they get the **Small Hall** => $2500<br> Gold package => **$750**, **10%** discount on the entire purchase.<br> Total price: **$2500 + $750 = $3250**<br> Discount: $3250 ‐ **10% discount** = $2925<br> Price per person: $2925 / **10 people = $292.50 per person**.<br>

You should print **which hall** is the **most suitable** for the group and the **price per person**. If the group is **bigger than 120 people** – print **“We do not have an appropriate hall.”**.

**Input**<br>

First line: the **group size** as an **integer**.<br> Second line: the **package** as a **string**.<br>

**Output**<br>

Print the output in the following format:

**We can offer you the {hallName}<br> The price per person is {price}$**.<br>

**Format** the **price** to the **2nd decimal place**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>20<br>Gold</td>
    <td>We can offer you the Small Hall<br> The price per person is 146.25$</td>
  </tr>
  <tr>
  <td>90<br>Platinum</td>
  <td>We can offer you the Terrace<br> The price per person is 56.67$</td>
  </tr>
  <tr>
  <td>150<br>Normal</td>
  <td>We do not have an appropriate hall.</td>
  </tr>
</table>

## Problem 4. Hotel

A hotel has three types of rooms: **studio**, **double** and **master suite**. The prices are different for the different months:

<table style="width:100%">
  <tr>
    <th>May and October</th>
    <th>June and September</th> 
    <th>July, August and December</th>
  </tr>
  <tr>
    <td>Studio ‐ 50 leva per night</td>
    <td>Studio ‐ 60 leva per night</td>
    <td>Studio ‐ 68 leva per night</td>
  </tr>
  <tr>
  <td>Double ‐ 65 leva per night</td>
  <td>Double ‐ 72 leva per night</td>
  <td>Double ‐ 77 leva per night</td>
  </tr>
  <tr>
  <td>Suite ‐ 75 leva per night</td>
  <td>Suite ‐ 82 leva per night</td>
  <td>Suite ‐ 89 leva per night</td>
  </tr>
</table>

They have also the following discounts:<br>
For **studio** and **more than 7** nights in **May and October: 5% discount**.<br> For **double** and **more than 14** nights in **June and September: 10% discount**.<br> For **suite** and **more than 14** nights in **July, August and December: 15% discount**.<br> For **studio** and **more than 7** nights in **September and October: one night is free.**<br>

**Input**<br>

The input consists of exactly **2 lines**:<br> First line: **Month – May, June, July, August, September, October or December**.<br> Second line: **Nights Count – an integer between [0 ... 200]**.<br>

**Output**<br>

Print **3 lines** on the console:<br>
On **the first: “Studio: {price for the stay} lv.”**<br> On **the second: “Double: {price for the stay} lv.”**<br> On **the third: “Suite: {price for the stay} lv.”**<br>

**Format** the **prices** to the **2nd decimal place**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
    <th>Comment</th> 
  </tr>
  <tr>
    <td>June<br>5</td>
    <td>Studio: 300.00 lv<br>Double: 360.00 lv.<br>Suite: 410.00 lv<br></td>
    <td>The nights are not enough for getting a discount,<br>so the studio is 60 lv, double room = 72 and<br>apartment = 82. We multiply the prices by the<br>nights and get the total prices.
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
    <th>Comment</th> 
  </tr>
  <tr>
    <td>May<br>10</td>
    <td>Studio: 475.00 lv<br>Double: 650.00 lv.<br>Suite: 750.00 lv<br></td>
    <td>In May, we have a discount of 5%, when the<br>nights are more than 7. That means the price for<br>night in the studios is 50 * 0.95 = 47.5. Again, we<br> multiply the prices by the nights and get the total prices.
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>July<br>16</td>
    <td>Studio: 1088.00 lv.<br>Double: 1232.00 lv.<br>Suite: 1210.40 lv.<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>September<br>10</td>
    <td>Studio: 540.00 lv.<br>Double: 720.00 lv.<br>Suite: 820.00 lv.<br></td>
  </tr>
</table>

## Problem 5. Word in Plural

Write a program, which receives a **noun** and prints the **noun** in **plural**. You will receive one of the following cases:<br>

A noun that ends in **y** – remove the **y** and add **ies**.<br> A noun that ends in **o**, **ch**, **s**, **sh**, **x** or **z** – add **es** at the end of the word.<br> In all other cases – just add **s** at the end.<br>

**Input**<br>

You will receive a **single** word, which you have to **pluralize**.<br>

**Output**<br>
Print only the **word in plural**.<br>

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>couch</td>
    <td>couches<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>butterfly</td>
    <td>butterflies<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>door</td>
    <td>doors<br></td>
  </tr>
</table>

> #### Hints
>You can use the method **String.EndsWith(…)** and **String.Remove(…)** – search for more information on how to use this methods in internet. Do not forget that strings are immutable. 

## Problem 6. Interval of Numbers

Write a program, which takes **two numbers** as input and prints the **interval of numbers between them, starting** from the **smaller one** and **ending** with the **larger** one.

**Input**<br>

You will receive **two lines**. Each of them will contain **one integer**.

**Output**<br>

Print all the numbers separated on **new lines**.

**Constraints**<br>

The numbers, which you receive will be in the interval **[0…100]**.<br> The two numbers, which you take as an input will **not be equal**.<br>

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>42<br>48</td>
    <td>42<br>43<br>44<br>45<br>46<br>47<br>48<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>100<br>14</td>
    <td>15<br>15<br>16<br>continues...<br>98<br>99<br>100<br></td>
  </tr>
</table>

## Problem 7. Cake Ingredients

Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system. **For every given ingredient**, you should write: **“Adding ingredient {name of the ingredient}.”**. When you receive the command **“Bake!”** from the console you should **stop the program** and write **“Preparing cake with {number of given ingredients} ingredients.”**.

**Input**<br>

You will receive **ingredients until the command “Bake!”** is given.

**Output**<br>

For every given ingredient write on a **new line** the message: **“Adding ingredient {name of the ingredient}.”**. At the end print the message: **“Preparing cake with {number of given ingredients} ingredients.”**.

**Constraints**<br>

You will receive maximum **20** ingredients.<br> Every ingredient will be between **1** and **50** characters.<br>

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>Flour<br>Bread<br>Sugar<br>Butter<br>Bake!<br></td>
    <td>Adding ingredient Flour.<br>Adding ingredient Bread.<br>Adding ingredient Sugar.<br>Adding ingredient Butter.<br>Preparing cake with 4 ingredients.<br></td>
  </tr>
</table>

## Problem 8. Calories Counter

You have to write a program, which **counts the calories**, which can be found in your **pizza recipe**. In your recipe, there are only **four** ingredients – **cheese**, **tomato sauce**, **salami** and **pepper**. Each ingredient contains a **fixed amount** of calories:<br>

**Cheese – 500** calories<br> **Tomato sauce – 150** calories<br> **Salami – 600** calories<br> **Pepper – 50** calories<br>

If you **receive** one of these ingredients **more than once**, you should add the calories to the total amount again. You should **not process any other ingredients**. Ingredients are
**case‐insensitive**.

**Input**<br>

On the next **n lines**, you will receive different **ingredients**. **Add** the calories **only** from the ones, **which are in your recipe**.<br>

**Output**<br>

Print the answer in the following format:<br> **Total calories : {totalCaloriesAmount}**<br>

**Constraints**<br>

You will receive maximum **20** ingredients.<br> Every ingredient will be between **1** and **50** characters.


#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>5<br>chesese<br>toMatO sauce<br>flour<br>salami<br>pepper<br></td>
    <td>Total calories: 1300<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>3<br>Cheese<br>Cucumber<br>cheese<br></td>
    <td>Total calories: 1000<br></td>
  </tr>
</table>

## Problem 9. Count the Integers

Write a program, which can receive **any type of input**, but upon receiving anything **other than an integer – stops the execution** of the program and prints **how many numbers were read**.

**Input**<br>

You can receive **any type of data** as **input** from the console.<br>

**Output**<br>

Print only the **total count** of the numbers.

**Constraints**<br>

You will receive **no more than 100 lines**.<br> Every line of input will not be longer than **7 characters/digits**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>1<br>2<br>3<br>4<br>5<br>6<br>PF is the best<br></td>
    <td>6<br></td>
  </tr>
  
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>12312<br>End the input</td>
    <td>1<br></td>
  </tr>
</table>

## Problem 10. Triangle of Numbers

Write a program, which receives a number – **n**, and prints a triangle from **1 to n** as in the examples.

**Constraints**<br>

**n** will be in the interval **[1...20]**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>3</td>
    <td>1<br>2 2<br>3 3 3<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>5</td>
    <td>1<br>2 2<br>3 3 3<br>4 4 4 4<br>5 5 5 5 5<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>6</td>
    <td>1<br>2 2<br>3 3 3<br>4 4 4 4<br>5 5 5 5 5<br>6 6 6 6 6 6 6<br></td>
  </tr>
</table>

## Problem 11. 5 Different Numbers

You will be given two numbers – **a** and **b**. Generate **five** numbers -n1, n2, n3, n4, n5, for which the following
**conditions** are true: **a ≤ n1 < n2 < n3 < n4 ≤ n5 ≤ b**. If there is **no number** in the given interval, which **satisfies the conditions** – print **“No”**.

**Input**<br>

The input contains **two integers**, each on a **new line**.<br>

**Output**<br>

Print all numbers in **increasing order** and on a **new line**.

**Constraints**<br>

**a** and **b** will be integers in the interval **[‐100…100]**

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>3<br>8</td>
    <td>3 4 5 6 7<br>3 4 5 6 8<br>3 4 5 7 8<br>3 4 6 7 8<br>3 5 6 7 8<br>4 5 6 7 8<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th> 
  </tr>
  <tr>
    <td>13<br>16</td>
    <td>No<br></td>
  </tr>
</table>

## Problem 12. Test Numbers

Write a program, which finds all the possible combinations between two numbers – **N** and **M**.
The first digit **decreases** from **N to 1**, and the second digit **increases** from **1 to M**. The two digits form a **number**. **Multiply the two digits**, then **multiply** their **product** by **3**. **Add** the **result** to the **total sum**.<br> You will also be given a **third number**, which will be the **maximum boundary of the sum**. If the **sum is equal or greater than this number** you should **stop the program**. See the examples for further information.

**Input**<br>

The input is read from the console and consists of three lines:<br>

**First line – N – integer** in the interval **[1…100]**<br> **Second line – M – integer** in the interval **[1…100]**<br> **Third line – maximum sum boundary – integer** in the interval **[1…1000000]**<br>

**Output**<br>

The output depends on the result:<br> If the **sum is equal or greater** than the maximum sum:<br>

<ul>
  <li><b>"{count of combinations} combinations"</b></li>
  <li><b>"Sum: {sum from the combinations} >= { maxi mum sum} "</b></li>
</ul> 

If the sum is **less than** the **maximum sum**:<br>

<ul>
  <li><b>"{count of combinations} combinations"</b></li>
  <li><b>"Sum: {sum from the combinations} "</b></li>
</ul> 


#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th>
    <th>Comments</th>  
  </tr>
  <tr>
    <td>3<br>4<br>123</td>
    <td>7 combinations<br>Sum: 126 >= 123<br></td>
    <td>Total 12 combinations: 3 1; 3 2; 3 3; 3 4; 2 1; 2 2; 2 3;<br>2 4; 1 1; 1 2; 1 3; 1 4;<br>1st: 3 * (3 * 1) = 9; 2nd: 9 + 3 * (3 * 2) = 27;…; 7th:<br>108 + 3 * (2 * 3) = 126;<br>126 >= 123 – we have to stop our program and print the result.<br>
  </tr>
  <tr>
  <td>2<br>2<br>50<br></td>
  <td>4 combinations<br>Sum: 27<br></td>
  <td>Total 4 combinations: 2 1; 2 2; 1 1; 1 2<br>1st: 3 * (2 * 1) = 6; 2nd: 6 + 3 * (2 * 2) = 18;<br>3rd: 18 + 3 * (1 * 1) = 21; 4th: 21 + 3 * (1 * 2) = 27<br>Sum: 27 < 50 -> total 4 combinations<br>
  </tr>
</table>

## Problem 13. Game of Numbers

Write a program, which finds all possible combinations in the interval **between two numbers**. The program should also find the **last combination**, in which a **number’s digits are equal to a given magical number**.

**Input**<br>

The input is read from the console and consists of three lines:<br>

**First line – N – integer** in the interval **[1…999]**<br> **Second line – M – integer** in the interval **[N…1000]**<br> **Third line – magical number – integer** in the interval **[1…10000]**<br>

**Output**<br>

The output depends on the result:<br> 

If there is a number with **digits equal to the magical number**:<br>

<ul>
  <li><b>"Number found! {first number} + {second number} = {magical number} "</b></li>
</ul> 

If such **combination does not exist**:<br>

<ul>
  <li><b>"Total combinations : {total number of combinations} – neither equals {magical number} "</b></li>
</ul> 

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th>
    <th>Comments</th>  
  </tr>
  <tr>
    <td>1<br>10<br>5</td>
    <td>Number found! 4 + 1 = 5<br></td>
    <td>All combinations between 1 and 10 are: 1 1, 1 2, 1 3, 1 4,<br>1 5, ... 2 1, 2 2, ... 4 1, 4 2, 4 3 ... 10 9, 10 10. Last combination with<br>sum of the digits equal to the magical number (5) is 4 1<br></td>
  </tr>
  <tr>
  <td>23<br>24<br>100<br></td>
  <td>4 combinations -<br>neither equals 100<br></td>
  <td>Total 4 combinations: 23 23; 23 24; 24 23 24 24<br>Neither of them has a sum of 100.<br></td>
  </tr>
</table>

## Problem 14. Magic Letter

Write a program, which prints all **3‐letter combinations, using only the letters from a given interval**. You will also receive a **third letter**. Every **combination**, which **contains** this letter **should not** be printed.

**Input**<br>

The input is read from the console and consists of three lines:<br>

**First line – lower case **English letter** from ‘a’ to ‘z’<br> **Second line –lower case **English letter** from ‘a’ to ‘z’<br> **Third line – lower case **English letter** from ‘a’ to ‘z’ – combinations, containing this letter should not be printed<br>

**Output**<br>

Print **all combinations on a single line**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th>
    <th>Comments</th>  
  </tr>
  <tr>
    <td>a<br>b<br>c</td>
    <td>aaa aac aca acc caa cac cca ccc<br></td><br></td>
    <td>All combinations with a, b, and c are:<br>aaa aab aac aba abb abc aca acb acc baa bab bac bba<br>bbb bbc bca bcb bcc caa cab cac cba cbb cbc cca ccb ccc<br>Combinations containing b are invalid.<br></td>
  </tr>
  <tr>
  <td>a<br>c<br>z<br></td>
  <td>aaa aab aac aba abb abc aca acb acc baa bab bac bba bbb bbc bca bcb bcc caa<br>cab cac cba cbb cbc cca ccb ccc<br></td>
  </tr>
</table>

## Problem 15. Neighbour Wars

Gosho and Pesho are neighbours, but they don’t like each other very much. They don’t like violence as well, so they decided they need a save environment where they can fight each other. They hired you to write a program, which calculates who would win the fight.<br>

Gosho and Pesho have their own signature attacks – **Gosho** attacks with **“Thunderous fist” on every even turn** of the game and **Pesho** attacks with **“Roundhouse kick” on every odd turn**. You will receive **how much damage these attacks do from the console**.<br>

**Both players start with 100 Health points**. On **every third turn** Pesho and Gosho **restore 10 Health Points**. Health points are restored **after the attack is made.**<br>

When one of the **player’s health is below or equal to zero** you should **stop any other further operations** and **print who the winner is, how much health points** he has and in **which turn** he won. Since Mike Tyson is the judge of the match, the winning round is always printed with **“th”** in the end.

**Input**<br>

The input is read from the console and consists of two lines:<br>

**First line – Pesho’s damage**<br>
**Second line – Gosho’s damage**<br>

**Output**<br>

Print on every turn who is attacking and how much health the opponent is after the attack:<br>

**"{name of the attacker} used {name of the attack} and reduced {name of the defending player} to {health of the defending player} health."**<br>

When one of the players is **dead** print:<br>

**"{name of the winner} won in {number of the round}th round."**

**Constraints**<br>

**Pesho’s damage** and **Gosho’s damage** will be **integers** in the interval **[0…100]**<br>

There will **always** be a **winner**.

#### Examples

<table style="width:100%">
    <th>Input</th>
    <th>Output</th>
  </tr>
  <tr>
    <td>30<br>40<br></td>
    <td>Pesho used Roundhouse kick and reduced Gosho to 70 health.<br>Gosho used Thunderous fist and reduced Pesho to 60 health.<br>Pesho used Roundhouse kick and reduced Gosho to 40 health.<br>Gosho used Thunderous fist and reduced Pesho to 30 health.<br>Pesho used Roundhouse kick and reduced Gosho to 20 health.<br>Gosho won in 6th round.<br></td>
  </tr>
</table>

<table style="width:100%">
    <th>Input</th>
    <th>Output</th>
  </tr>
  <tr>
    <td>20<br>10<br></td>
    <td>Pesho used Roundhouse kick and reduced Gosho to 80 health.<br>Gosho used Thunderous fist and reduced Pesho to 90 health.<br>Pesho used Roundhouse kick and reduced Gosho to 60 health.<br>Gosho used Thunderous fist and reduced Pesho to 90 health.<br>Pesho used Roundhouse kick and reduced Gosho to 50 health.<br>Gosho used Thunderous fist and reduced Pesho to 80 health.<br>Pesho used Roundhouse kick and reduced Gosho to 40 health.<br>Gosho used Thunderous fist and reduced Pesho to 80 health.<br>Pesho used Roundhouse kick and reduced Gosho to 20 health.<br>Gosho used Thunderous fist and reduced Pesho to 80 health.<br>Pesho used Roundhouse kick and reduced Gosho to 10 health.<br>Gosho used Thunderous fist and reduced Pesho to 70 health.<br>Pesho won in 13th round.<br></td>
  </tr>
  <tr>
  <td>100<br>100<br></td>
  <td>Pesho won in 1th round.</td>
</table>
