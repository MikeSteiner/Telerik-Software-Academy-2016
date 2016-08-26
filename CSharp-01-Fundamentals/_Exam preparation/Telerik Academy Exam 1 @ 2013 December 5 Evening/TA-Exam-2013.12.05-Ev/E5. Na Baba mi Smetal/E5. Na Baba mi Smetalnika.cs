/*
Problem 5 – Na Baba mi Smetalnika

  

See this mad baba? She is crazy I tell you! But this is life and you are going to be stuck with her for all the lqto, so better pay attention!
The baba has very izbuhliva personality, so every time you mess up something she smacks your head with her tochilka. She mainly spends her vreme in pletene of sweaters, which she sells to important klienti on the selski market.
Every sweater has a different sharka, so she needs to calculate how many reda to use of one prejda and how many of some other kind. She figured out a formula that helps her to izchisli the right amount of rows and brimki.
The formula is as follows: She uses a different smetalo for every sweater, and every smetalo has different number of topchenca. As she plete, she moves the topchenca to the left or right side of the smetaloto. If she makes a mistake she resets the smetaloto by placing all the topchenca on the left most side.
Once she is done she izchislqva the sum of all the lines and then multiplies them by the broikata of all columns that don’t have any topchenca in them.
Since you are spending the summer with her, she put you in charge of the smetaloto, but be vnimatelen, because if you opleskash the formula she will mess up the sweater and you will get smacked. Every time she smacks your head some mozuchni cells are dying and you lose a part of your genialnost.
Quick! Use what mozuk you have left to create a computer program, that can do your rabota for you, before you get so tup that you cannot think straight from getting smacked on the head by this luda baba!
How the smetalnika works:
You need to know how wide it needs to be, so that it can calculate the sharkata for the current sweater. Listen to the babata, she will tell you the width at the beginning. After that she will give you 8 positive numbers that you have to magically preobrazuvash into bitwise data and use the bits as topchenca for your smetalnik.
After this is done she will start giving you commands: Whenever she makes a mistake she will tell you to “reset” the smetaloto, so she can start over. Then you must burzo put all the topchenca to the left most corner. When she tells you to slide “right” or “left”, this means that you need to put your prust on a selected line and position and to slide all the topchenca to the left or to the right most corner of the smetaloto.
Once she is gotova she will tell you to “stop” and tell her the result. You better do it fast or that brain cells killing smack is coming right at you!
Input
The input data should be red from the console.
On the first line you will be given the width of the smetaloto. 
On the next 8 lines you will be given 8 numbers, one number on each line, so you can use them to understand where to put your topchenca. 
After that you will receive a random number of commands - “reset”, “right” and “left”. If there is no topchence where she tells you to slide your finger, you must do it either way, since she is a little kiorava, and sometimes misses the right position. When you slide you must always start from where she instructs you and stop when you reach the opposite krai of the smetaloto. 
The program must end when the “stop” command is given. The result must be printed right afterwards.
Output
The output data should be printed on the console.
The output result is the sum of all the lines as numbers multiplied by the number of columns that don’t have any topchenca in them.
Constraints
•	The width of the smetaloto will be from 5 to 32 inclusive.
•	The eight numbers will be from 0 to 2 147 483 647 inclusive.
•	The line will be from 0 to 7 inclusive.
•	The prust position will be from -50 to 50 inclusive.
•	There will be no topchenca outside of the smetaloto at any given time.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.





	0	1	2	3	4	5	6	7	
0	■			■	■	■			156
1					■	■	■	■	15
2		■	■	■			■		114
3			■	■		■		■	53
4	■	■	■	■					240
5				■	■	■		■	29
6	■		■		■	■			172
7		■		■		■		■	85 
		0	1	2	3	4	5	6	7	
0	■			■			■	■	147
1					■	■	■	■	15
2		■	■	■			■		114
3			■	■		■		■	53
4	■	■	■	■					240
5				■	■	■		■	29
6	■		■		■	■			172
0		■		■		■		■	85

	0	1	2	3	4	5	6	7	
0	■			■			■	■	147
1					■	■	■	■	15
2	■	■	■	■					240
3			■	■		■		■	53
4	■	■	■	■					240
5				■	■	■		■	29
6	■		■		■	■			172
7		■		■		■		■	85 


	0	1	2	3	4	5	6	7	
0	■	■	■	■					240
1	■	■	■	■					240
2	■	■	■	■					240
3	■	■	■	■					240
4	■	■	■	■					240
5	■	■	■	■					240
6	■	■	■	■					240
7	■	■	■	■					240

Examples
Example
input	Example
output
8
156
15
114
53
240
29
172
85
right
0
4
left
2
7
reset
stop	7680


 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5.Na_Baba_mi_Smetal
{
    class NaBabaMiSmetal
    {
        static void Main(string[] args)
        {
        }
    }
}
