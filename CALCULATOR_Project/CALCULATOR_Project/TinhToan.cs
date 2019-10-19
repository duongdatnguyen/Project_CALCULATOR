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
                
                foreach (char st in Luutrutoanhang.ToString())
                {
                    if (LuuTru.latoantu(st) == 0)
                    {
                        string x = st.ToString();
                        Giatri.Push(float.Parse(x));

                    }
                    else
                    {
                        float y = Giatri.Pop();
                        float x = Giatri.Pop();
                        switch (st)
                        {
                            case '+': y = x + y; break;
                            case '-': y = x - y; break;
                            case '*': y = x * y; break;
                            case '/': y = x / y; break;
                        }
                      Giatri.Push(y);
                    }
                }
                return Giatri.Pop().ToString();
            }

        }
    }
