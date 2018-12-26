﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.Models
{

    public class RandomValue
    {
        public string Name { get; set; }

        public RandomValue(string name)
        {
            Name = name;

        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();

            }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }


        public List<string> RandomKeys(int quant, int leng)
        {

            List<string> keys = new List<string>();

            for (int i = 0; i < quant; i++)
            {

                StringBuilder builder = new StringBuilder();
                builder.Append(RandomString(leng, false));
                keys.Add(builder.ToString());
            }

            return keys;
        }

        
        }
    }




