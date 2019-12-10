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

    class TinhToan : LuuTru
    {
        public Stack<double> Giatri = new Stack<double>();
        double ketqua;
        int kiemtraso=0;
        int kiemtradauvao=0;
        public string tinh()
        {
            string[] tach = ST.Split(' ');
            int len = tach.Length;
            foreach(string stt in tach)
            {
                if ((stt == "+") || (stt == "-") || (stt == "*") || (stt == "/"))
                {
                    kiemtradauvao++;
                }
                else
                    kiemtraso++;
               
            }
            
            for(int i=0;i<len;i++)
            {
                if ((tach[i] != "+") && (tach[i] != "-") && (tach[i] != "*") && (tach[i] != "/"))
                {
                    Giatri.Push(double.Parse(tach[i]));
                }

                else
                {
                    if (Giatri.Count != 1)
                    {
                        double y = Giatri.Pop();
                        double x = Giatri.Pop();
                        if (tach[i] == "+")
                        {
                            y = x + y;
                            
                        }
                        if (tach[i] == "-")
                        {
                            int j = i + 1;
                            int k = i - 2;
                            int o = i + 2;
                            if (j < len && kiemtradauvao >= kiemtraso && k >= 0 && o < len)
                            {
                                if ((tach[j] == "+") || (tach[j] == "-") || (tach[j] == "*") || (tach[j] == "/"))
                                {
                                    y = 0 - y;
                                    Giatri.Push(x);
                                    kiemtradauvao--;
                                }
                                else if (((tach[k] == "+") || (tach[k] == "-") || (tach[k] == "*") || (tach[k] == "/")) &&
                                    ((tach[o] == "+") || (tach[o] == "-") || (tach[o] == "*") || (tach[o] == "/")))
                                {
                                    y = 0 - y;
                                    Giatri.Push(x);
                                    kiemtradauvao--;
                                }
                                else if (((tach[k] != "+") || (tach[k] != "-") || (tach[k] != "*") || (tach[k] != "/")) &&
                                    ((tach[o] == "+") || (tach[o] == "-") || (tach[o] == "*") || (tach[o] == "/")))
                                {
                                    y = 0 - y;
                                    Giatri.Push(x);
                                    kiemtradauvao--;
                                }
                                else
                                {
                                    y = x - y;
                                }
                            }
                            else
                            {
                                y = x - y;
                            }
                        }
                        if (tach[i] == "*")
                        {
                            y = x * y;
                        }
                        if (tach[i] == "/")
                            {
                                if (y == 0)
                                {
                                    MessageBox.Show("Can not devide by zero!", "Math Error!");
                                    return Form1.result = "error";
                                }
                                else
                                    y = x / y;
                        }
                        Giatri.Push(y);
                        
                    }
                    else 
                        {
                        double x = Giatri.Pop();
                         if(tach[i] == "-")
                            x = 0 - x;
                         Giatri.Push(x);
                        kiemtradauvao--;
                        }
                    
                }

            }
            ketqua = Giatri.Peek();
            kiemtraso = 0;
            kiemtradauvao = 0;
            return ketqua.ToString();
        }
       
           
    }
}/*if ((st == "-") && (kiemtradauvao % 2 != 0))
                    {
                        float x = Giatri.Pop();
                        x = 0 - x;
                        Giatri.Push(x);
                        kiemtradauvao--;
                        
                    }*/
 //&&(kiemtradauvao%2==0)
 // else if (k >= 0 && tach[k] == "*" || tach[k] == "/" && kiemtradauvao < kiemtraso)
 //{
 //  y = x + y;
 //}
 //else if(j<len&&tach[j]=="-")
 //{
 //  y = x + y;
 //}