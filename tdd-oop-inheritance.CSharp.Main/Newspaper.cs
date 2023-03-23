using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper
    {
        public String title;

        Boolean onLoan = false;

        public Newspaper(String title) {
            this.title = title;
        }

        public bool isOnLoan() {
            return onLoan;
        }

        public String checkIn() {
            return "newspapers are not available for loan";
        }

        public String checkOut() {
            return "newspapers are not available for loan";
        }
    }
}
