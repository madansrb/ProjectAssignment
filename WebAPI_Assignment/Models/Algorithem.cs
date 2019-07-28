using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Assignment.Models
{
    public class Algorithem : IStream
    {
        public int GarbageIdentify(string Inputstream)
        {
            int score = 0;
            bool ingarb = false;
            bool ignore = false;
            int answer = 0;
             
            foreach (var item in Inputstream)
            {
                if (ignore)
                {
                    ignore = false;
                    continue;
                }
                if (item == '!')
                {
                    ignore = true;
                    continue;
                }
                if (ingarb && item == '>')
                {
                    ingarb = false;
                    continue;
                }
                else if (ingarb)
                {
                    //  cnt += 1;
                    continue;
                }
                if (item == '<')
                {
                    ingarb = true;
                    continue;
                }
                if (item == '{')
                {
                    score += 1;
                    answer += score;
                    continue;

                }
                else if (item == '}')
                {
                    score -= 1;
                    continue;
                }
            }
            return answer;

            //  throw new NotImplementedException();
        }
    }
}