using System;
using System.Collections.Generic;

namespace DesafioSysQuestao02
{
    class Program
    {
        static void Main(string[] args)
        {

            VerificaBalanceamento("{[()]}");
            
        }

        static void VerificaBalanceamento(string s)
        {
            Stack<char> pilha = new Stack<char>();

            char p;
            for (int i = 0; i < s.Length; i++)
            {
                p = s[i];

                if (p == '(')
                    pilha.Push(p);
                else if (p == '{')
                    pilha.Push(p);
                else if (p == '[')
                    pilha.Push(p);
                else if (p == ')')
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
                    else if (pilha.Peek() == '(')
                        pilha.Pop();
                    else
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
                else if (p == '}')
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
                    else if (pilha.Peek() == '{')
                        pilha.Pop();
                    else
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
                else if (p == ']')
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
                    else if (pilha.Peek() == '[')
                        pilha.Pop();
                    else
                    {
                        Console.WriteLine("NAO");
                        return;
                    }
            }
            Console.WriteLine(pilha.Count == 0 ? "SIM" : "NAO");
        }
    }
}
