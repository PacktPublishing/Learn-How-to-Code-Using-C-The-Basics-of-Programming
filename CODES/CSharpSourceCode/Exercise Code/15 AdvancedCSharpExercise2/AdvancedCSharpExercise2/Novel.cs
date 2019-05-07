using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Novel : IWritable
    {
        private string name;
        private string author;

        public Novel(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return author;
        }
    }
}
