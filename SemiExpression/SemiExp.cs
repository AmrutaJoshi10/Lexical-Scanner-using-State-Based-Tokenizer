/////////////////////////////////////////////////////////////////////////////////////
// SemiExp.cs:  This package gets the tokens from the Tokenizer and checks the     /
//              terminating conditions.                                            /
// version:     1.2                                                                /              
// Languange:   C#, Visual Studio 2017                                              /
// Platform:    HP pavilion X360, Windows 10                                        /
// Application: Demonstatration of Project2 - Lexical Scanner Using State Based     /
//              Tokenizer.                                                          /
// Source:      Dr.Jim Fawcett                                                      /
// Author Name: Amruta Joshi                                                        /
// CSE681 :     Software Modeling and Analysis, Fall 2018                           /  
/////////////////////////////////////////////////////////////////////////////////////
/*
 * Package Operations:
 * -------------------
 * -This package gets the tokens from the Tokenizer and demonstrates different Terminating
 * conditions.
 * 
 * 
 * Public Interface:
 * -----------------
 * SemiExp semiExp = new SemiExp()
 * semiExp.open(path)
 * semiExp.get()
 * semiExp.getallTokens()
 * GetSemi(Toker toker)
 * 
 *
 * Required Files :  Toker.cs , ITokCollect
 *
 *
 *Maintenance History
 * ----------------------------------------------------------------------- 
 *ver 1.0 : 07 October 2018
 * - first release
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITokCollection;
using Tokenizer;

namespace SemiExpressions
{
    using Token = StringBuilder;
    using SemiString = StringBuilder;

    public class SemiExp : ITokCollect
    {
        Toker toker = null;
        SemiString semiStr = null;

        public SemiExp()
        {
            toker = new Toker();
            semiStr = new SemiString();
            //List<string> semiExplist = null;
        }
        //--------<Get the list of Tokens-----------------------------------
        public List<Token> getallTokens()
        {
            List<Token> listoftokens = new List<Token>();
            listoftokens = toker.getToken();
            return listoftokens;
        }

        /*        public List<SemiString> getallSemi()
                {
                    List<SemiString> listofSemi = new List<SemiString>();
                    listofSemi = get();
                    return listoftokens;
                }*/


        //-------------< attempt to open source of tokens >-----------------------

        public bool open(string fullpath)
        {
            return toker.open(fullpath);
        }
        // -------------<LineCount Property- Counts the line for tokens>-------------------
        public int lineCount
        {
            get { return toker.lineCount(); }
        }
        //-----------------<Checks for the terminating Conditions>-------------------------
        public void get()
        {
            List<SemiString> list = new List<SemiString>();
            String[] semicheck = { ";", "{", "}" };

            while (!toker.isDone())
            {

                Token tok = toker.getTok();
                semiStr.Append(tok);
                foreach (String semi in semicheck)
                {
                    if (tok.ToString().Contains(semi))
                    {
                        Console.Write(semiStr + "\n");
                        semiStr.Length = 0;
                    }
                    /* if (semicheck.Contains(tok.ToString()))
                     {
                         //semiStr.Append(tok);
                         Console.Write("\n" + semiStr);
                         semiStr.Length = 0;
                     }*/
                    if (tok.ToString().Equals("for"))
                    {
                        do
                        {
                            tok = toker.getTok();
                            semiStr.Append(tok);
                            //  Console.Write(" "+semiStr);
                        } while (!tok.ToString().Contains("{"));
                        Console.WriteLine(" " + semiStr);
                        semiStr.Length = 0;

                        //semiStr.Append(tok);



                    }
                    else if (tok.ToString().Contains("#"))
                    {
                        Console.WriteLine("\n" + semiStr);
                        semiStr.Length = 0;
                    }
                }
            }
        }

        //-------------------------------------TEST STUB-------------------------------------

#if (TEST_SEMI)

        class DemoSemi
        {
            static bool testSemi(string path)
            {
                SemiExp semiExp = new SemiExp();
                string fqf = System.IO.Path.GetFullPath(path);
                if (!semiExp.open(fqf))
                {
                    Console.Write("\n File cannot be opened{0}\n", fqf);
                    return false;
                }
                else
                {
                    Console.Write("\n File is being processed : {0}", fqf);
                }
                semiExp.get();
                return true;
            }

            public static void Main(string[] args)
            {
                Console.Write("\n Demonstration id SemiExpression Class");
                Console.Write("\n =========================");

                StringBuilder msg = new StringBuilder();
                msg.Append("\n *****************************");
                StringBuilder message = new StringBuilder();
                message.Append("\n **************COLLECTION OF SEMIWXPRESSION*******************");
                Console.WriteLine(msg);
                testSemi("../../../Test.txt");
                Console.Write("\n\n\n\n");
            }
        }

    }
}

#endif