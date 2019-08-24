/////////////////////////////////////////////////////////////////////////////////////
// TestUnit.cs: This package provides the entry point for both the packages.        /                                          
// version:    1.2                                                                  /              
// Languange:   C#, Visual Studio 2017                                              /
// Platform:    HP pavilion X360, Windows 10                                        /
// Application: Demonstatration of Project2 - Lexical Scanner Using State Based     /
//              Tokenizer.                                                          /
// Source:      Dr.JIm Fawcett                                                      /
// Author Name: Amruta Joshi                                                        /
// CSE681 :     Software Modeling and Analysis, Fall 2018                           /  
/////////////////////////////////////////////////////////////////////////////////////

/*Package Operations:
 * -------------------
 * This package acts as an entry point for the packages.
 * 
 *Required Files : Toker.cs , SemiExp.cs , ITokCollect.cs
 *
 *
 *Maintenance History
 * ----------------------------------------------------------------------- 
 *ver 1.0 : 07 October 2018
 * - first release
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemiExpressions;
using ITokCollection;
namespace AutomatedTestUnit
{
    using Token = StringBuilder;
   // using Semi = StringBuilder;

    public class Test
    {

        public static void Main(string[] args)
        {
            String path = "../../../Test.txt";
            string fullpath = System.IO.Path.GetFullPath(path);

            Console.WriteLine("\n*****************DEMONSTRATION OF LEXICAL SCANNER*******************");
            Console.WriteLine("\n********************REQUIREMENTS***************************************\n\n\n");

            ITokCollect semiExp = new SemiExp();

            requirement1();
            requirement3(fullpath, semiExp);
            requirement4(fullpath, semiExp);
            requirement6(fullpath, semiExp);
          //  requirement9(fullpath, semiExp);
            requirement10(fullpath, semiExp);
            Console.ReadLine();
        }

        private static void requirement1()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("***************************REQUIREMENT 1 AND 2 ************************************************" + "\n");
            msg.Append("***********Implemented Project 2 using Visual Studio 2017 and C# windows Console Project********" + "\n\n");
            Console.WriteLine(msg);
        }

        private static void requirement3(string fullpath, ITokCollect semiExp)
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("*****************************REQUIREMENT 3**********************************************************************" + "\n");
            msg.Append("Implemented 4 C# packages namely: AUTOMATED TEST UNIT, TOKENIZER, SEMIEXPRESSION AND ITOKENCOLLECTION " + "\n");
            msg.Append("********************************************************************************************************** " + "\n\n");
            Console.WriteLine(msg);
        }

        private static void requirement4(String fullpath, ITokCollect semiExp)
        {

            if (!semiExp.open(fullpath))
            {
                Console.Write("\n Unable to open the file", fullpath);
            }
            else
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("**************************REQUIREMENT 4 AND REQUIREMENT 5****************************************" + "\n");
                msg.Append("Created a Tokenizer package which contains Toker class to collect all the following Tokens." + "\n");
                msg.Append("Also, Implemented getTok() method to identify the current and the next state of the tokens" + "\n");
                msg.Append("1) AlphaNumeric Tokens" + "\n");
                msg.Append("2) Punctuator Tokens" + "\n");
                msg.Append("3) Special 1 and 2 character tokens that may be changed by calling setSpecialSingleChars or setSpecialCharacers" + "\n");
                msg.Append("4) SingleLine Comments" + "\n");
                msg.Append("5) MultiLine Comments" + "\n");
                msg.Append("6) Quoted Strings");
                Console.WriteLine(msg);

                Console.Write("\n  File is being processed: {0}", fullpath);
                try
                {
                    List<Token> ListofTokens = semiExp.getallTokens();
                }

                catch (Exception e)
                {

                    Console.Write("An Exception an occured: '{0}'", e);
                }
                Console.Write("\n\n");
                //Console.WriteLine("*********************************************************************************"+"\n");
            }
        }



        private static void requirement6(String fullpath, ITokCollect semiExp)
        {
            if (!semiExp.open(fullpath))
            {
                Console.Write("\n Unable to open the file", fullpath);
            }
            else
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("**********************************REQUIREMENT 6 , 7, 8 AND 9 ***********************************" + "\n");
                msg.Append("Implemented SemiExpression package, having class SemiExp to retrieve the collection of tokens." + "\n");
                msg.Append("Terminate the token collection after extracting the single character tokens." + "\n");
                msg.Append("Also, implemented the rule to ignore two semicolons in the paranthesis."+"\n");
                msg.Append("Implemented the interface ITokenCollection");
                Console.WriteLine(msg);
                Console.Write("\n  File is being processed: {0} \n", fullpath);
                try
                {
                    semiExp.get();
                }
                catch (Exception e)
                {
                    Console.Write("An Exception an occured: '{0}'", e);
                }
                Console.WriteLine("\n\n\n");
               
            }
           
        }

       /* private static void requirement9(string fullpath, ITokCollect semiExp)
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("*************************************REQUIREMENT 9*************************************************************"+"\n");
            msg.Append("***********************Implemented the interface ITokenCollection**********************************************"+"\n");
            Console.WriteLine(msg);
        }*/



        private static void requirement10(string fullpath, ITokCollect semiExp)
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("*******************************REQUIREMENT 10********************************************************************"+"\n");
            msg.Append("***********************Implemented Automated Test Unit for two packeages.******************************************"+"\n");
            Console.WriteLine(msg);
        }

    }
}

