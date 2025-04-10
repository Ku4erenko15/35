using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
     class Textbook:Book
    {
        private int grade_level;

        public int Grade_level { get => grade_level; set => grade_level = value; }

        public Textbook(string title, string author, int year, double price, int grade_level)
            : base(title, author, year, price)
        {
            this.Grade_level = grade_level;
        }

        public override void Info()
        {
            Console.WriteLine($"Название:{Title}" +
                $"Уровень обучения{Grade_level} " +
                $"Автор:{Author} " +
                $"Год издания:{Year} " +
                $"Цена:{Price}");
        }

    }
}
