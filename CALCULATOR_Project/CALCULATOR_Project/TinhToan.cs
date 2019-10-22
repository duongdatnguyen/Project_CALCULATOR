using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR_Project
{
 
        class TinhToan:LuuTru
        {
            public Stack<float> Giatri = new Stack<float>();
            
        public string tinh()
            {
            /*for(int i=0;i<Luutrutoanhang.ToString().Length;i++)
            {
                if 
            }*/
            string[] tach = Luutrutoanhang.ToString().Split(' ');
            //Giatri.Push(0);
                foreach (string st in tach )
                {
                if ((st != "+") && (st != "-") && (st != "*") && (st != "/"))
                {
                    Giatri.Push(float.Parse(st));
                }
                
                    else
                    {
                        float y = Giatri.Pop();
                        float x = Giatri.Pop();
                        switch (st)
                        {
                            case "+": y = x + y; break;
                            case "-": y = x - y; break;
                            case "*": y = x * y; break;
                            case "/": y = x / y; break;
                        }
                      Giatri.Push(y);
                    }
                }
                return Giatri.Pop().ToString();
            }

        }
    }
