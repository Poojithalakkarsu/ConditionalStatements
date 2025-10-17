using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    /*
     * Conditional Statements are also called as decision making statements.
     * Based on some condition statement will be executed,
     * if condition is true or else based on the conditonal statement
     * it will print the statements.
     * Conditional Statements are of 2 types:
     * 1)Conditional Branching:
     * Branching statements will execute based on each branch 
     * under conditional branching we have
     * if
     * else
     * else if
     * switch
     * 2)Conditional looping: A program will be executed untill
     * the condition is met based on ittrative statements.
     * for
     * while
     * do while
     * for each.
     * 
     * Simple If:
     * If Condition is true the statement will be executed.
     * syntax:
     * if(condition)
     * {
     * statements;
     * }
     * 
     * If else:
     * In case if statement does not satisfy the conditon then it will
     * goes to else block.
     * Syntax:
     * if(condition)
     * {
     * statemetns;
     * }
     * else
     * {
     * statements;
     * }
     * 3)else if
     * it conditional statement incase if statement does not stastify then it goes
     * else if statement
     * syntax:
     * if(condition)
     * {
     * statements;
     * }
     * else if(condition)
     * {
     * statements;
     * }
     * else if(condition)
     * {
     * statements;
     * }
     * else
     * {
     * statements;
     * }
     * Added one more line in GITHUB
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("A is greater than B");
            }
            else if(a<b)
            {
                Console.WriteLine("A is lessthan B");

            }
            else if(a==b)
            {
                Console.WriteLine("A is equal to B");
            }
            else
            {
                Console.WriteLine("A is not eqaul to B");
            }


        }
    }
}
