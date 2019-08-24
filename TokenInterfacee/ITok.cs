/////////////////////////////////////////////////////////////////////////////////////
// ITokCollect.cs: This package acts as an interface for Tokenizer package.         /            
// version:      1.2                                                                /              
// Languange:    C#, Visual Studio 2017                                             /
// Platform:     HP pavilion X360, Windows 10                                       /
// Application:  Demonstatration of Project2 - Lexical Scanner Using State Based    /
//               Tokenizer.                                                         /
// Source:      Dr.Jim Fawcett                                                      /
// Author Name: Amruta Joshi                                                        /
// CSE681 :     Software Modeling and Analysis, Fall 2018                           /  
/////////////////////////////////////////////////////////////////////////////////////

/*Package Operations:
 * -------------------
 * This package acts as an interface for Tokenizer package. It contains
 * ItokenSource and ItokenState for performing the operations on the tokens. 
 * 
 * Public Interface:
 * -----------------
 *  bool open(string path);
 *      void close();
 *       int next();
 *      int peek(int n = 0);
 *      bool end();
 *      int lineCount { get; set; }
 *       Token getTok();
 *      bool isDone();

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

namespace TokenInterface
{
    using Token = StringBuilder;

    ///////////////////////////////////////////////////////////////////
    // ITokenSource interface
    // - Declares operations expected of any source of tokens
    // - Typically we would use either files or strings.  This demo
    //   provides a source only for Files, e.g., TokenFileSource, below.


    public interface ITokenSource
    {
        bool open(string path);
        void close();
        int next();
        int peek(int n = 0);
        bool end();
        int lineCount { get; set; }
    }

    ///////////////////////////////////////////////////////////////////
    // ITokenState interface
    // - Declares operations expected of any token gathering state

    public interface ITokenState
    {
        Token getTok();
        bool isDone();
    }
}

