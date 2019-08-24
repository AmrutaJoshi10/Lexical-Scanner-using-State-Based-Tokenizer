/////////////////////////////////////////////////////////////////////////////////////
// ITokCollect.cs: This package acts as an interface for SemiExpression package.    /
//                It contains a declared method get().                              /            
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
 * This package acts as an interface for SemiExpression package. It provides
 * get() method to check for the terminating conditions.
 * 
 * Public Interface:
 * -----------------
 * get()
 * getallTokens()
 * bool open(string fullpath)
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

namespace ITokCollection
{
    public interface ITokCollect
    {
        void get();
        List<StringBuilder> getallTokens();
        bool open(string fullpath);
    }
}
