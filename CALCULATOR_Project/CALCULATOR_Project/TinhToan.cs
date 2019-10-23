﻿using System;
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
            string[] tach = ST.Split(' ');
            //string[] tach = Luutrutoanhang.ToString().Split(' ');
            //Giatri.Push(0);
                foreach (string st in tach )
                {
                if ((st != "+") && (st != "-") && (st != "*") && (st != "/"))
                {
                    Giatri.Push(float.Parse(st));
                }
                
                else
                  {
                    if (Giatri.Count != 1)
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
                    else// trong trường hợp số âm 
                    {
                        float x = Giatri.Pop();
                        switch(st)
                        {
                            //case "+": x = x + 0; break;
                            case "-": x = 0 - x; break;
                            //case "*": x = x * 1; break;
                            //case "/": x = x / 1; break;
                        }
                        Giatri.Push(x);
                    }
                    }
                }
                return Giatri.Pop().ToString();
            }

        }
    }
