using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR_Project
{
    class LuuTru
    {
        private string trungto;
        public StringBuilder Bieuthuc = new StringBuilder();
        public Stack<char> Hauto = new Stack<char>();
        public StringBuilder Luutrutoanhang=new StringBuilder();// đây là biểu thức hậu tố ta được 
        public string Trungto
        {
            get { return trungto; }
            set { trungto = value; }
        }
        public void savegiatribieuthuc(string trungto)
        {
            if ((trungto == "+") || (trungto == "-") || (trungto == "*") || (trungto == "/"))
                Bieuthuc.Append(" ").Append(trungto);
            else
                Bieuthuc.Append(trungto);

        }
        // Biểu thức cho ra đã đúng 
        public static int latoantu(char st)
        {
            if ((st == '+') || (st == '-') || (st == '*') || (st == '/'))
                return 1;
           
            return 0;
        }
        public static int douutien(char st)
        {
            if ((st == '*') || (st == '/'))
                return 2;
            else if ((st == '(')||(st==')')) 
                return 0;
            else return 1;
        }
        public void duavaostack(StringBuilder Bieuthuc)
        {
            Bieuthuc.Append(' ');
            foreach (char st in Bieuthuc.ToString())
            {
                if (latoantu(st) == 0 && (st != '(')&&(st!=')'))
                    Luutrutoanhang.Append(st);
                else if (st == '(')
                    Hauto.Push(st);
                else if (st == ')')
                {
                    char x = Hauto.Pop();
                    while (x != '(')
                    {
                        //char y = Hauto.Pop();
                        Luutrutoanhang.Append(' ').Append(x);
                        x = Hauto.Pop();
                    }
                    if(Hauto.Peek()=='(')
                        Hauto.Pop();
                }
                
                else
                {
                    if (st == ' ')
                        Luutrutoanhang.Append(st);
                    else if ((Hauto.Count == 0)||((douutien(st) > douutien(Hauto.Peek()))))
                    {
                        Hauto.Push(st);
                    }
                    else if (douutien(st) <= douutien(Hauto.Peek()) && (Hauto.Count > 0))
                    {

                        char y = Hauto.Pop();
                        Luutrutoanhang.Append(y).Append(' ');
                        Hauto.Push(st);
                        //if (douutien(st) <= douutien(Hauto.Peek()))
                          //  Luutrutoanhang.Append(st);
                    }
                    
                }  
            }
            while (Hauto.Count != 1)
            {
                Luutrutoanhang.Append(Hauto.Pop()).Append(' ');
                
            }
            if (Hauto.Count == 1)
                Luutrutoanhang.Append(Hauto.Pop());
        }

    }
}
