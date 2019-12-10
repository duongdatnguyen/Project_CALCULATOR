using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_Project
{
    class LuuTru
    {
        private string trungto;
        public StringBuilder Bieuthuc = new StringBuilder();
        public Stack<char> Hauto = new Stack<char>();
        public StringBuilder Luutrutoanhang=new StringBuilder(); 
        public string ST;
        public StringBuilder BieuthucChuaXoa = new StringBuilder();
        
        public string Trungto
        {
            get { return trungto; }
            set { trungto = value; }
        }
        public void savegiatribieuthuc(string trungto)
        {
            BieuthucChuaXoa = Bieuthuc;
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
                if (latoantu(st) == 0 && (st != '(') && (st != ')'))
                    Luutrutoanhang.Append(st);
                else if (st == '(')
                {
                    Hauto.Push(st);
                    
                }
                else if (st == ')')
                {
                    
                    char x = Hauto.Peek();
                    while (x != '(')
                    {
                        char y = Hauto.Pop();
                        Luutrutoanhang.Append(' ').Append(y);
                        x = Hauto.Peek();
                    }
                    if (Hauto.Peek() == '(')
                        Hauto.Pop();
                }

                else
                {
                    if (st == ' ')
                        Luutrutoanhang.Append(st);
                    else if ((Hauto.Count == 0) || ((douutien(st) > douutien(Hauto.Peek()))))
                    {
                        Hauto.Push(st);
                    }
                    else if (douutien(st) <= douutien(Hauto.Peek()) && (Hauto.Count > 0))
                    {

                        char y = Hauto.Pop();
                        Luutrutoanhang.Append(y).Append(' ');
                        Hauto.Push(st);
                        
                    }

                }
            }
            while (Hauto.Count != 1)
            {
                Luutrutoanhang.Append(Hauto.Pop()).Append(' ');

            }
            if (Hauto.Count == 1)
                Luutrutoanhang.Append(Hauto.Pop());
            ST = Luutrutoanhang.ToString();
            while (ST.IndexOf("  ") != -1)
            {
                ST = ST.Replace("  ", " ");

            }
            ST = ST.Trim();
        }
        
    }
}
