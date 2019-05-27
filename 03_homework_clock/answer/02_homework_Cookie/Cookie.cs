using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Cookie
    {
        private Boolean gloten;
        public Boolean Gloten
        {
            get { return gloten; }
            set { gloten = value; }
        }

        private int num_of_eggs;
        public int Num_of_eggs
        {
            get { return num_of_eggs; }
            set { num_of_eggs = value; }
        }

        private float sugar;
        public float Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        private float flour;
        public float Flour
        {
            get { return flour; }
            set { flour = value; }
        }
    }
}
