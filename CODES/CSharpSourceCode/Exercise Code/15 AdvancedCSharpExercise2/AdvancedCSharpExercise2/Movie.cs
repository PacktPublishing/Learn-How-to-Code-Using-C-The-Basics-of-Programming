using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Movie : IWritable
    {
        private string name;
        private string screenwriter;

        public Movie(string name, string screenwriter)
        {
            this.name = name;
            this.screenwriter = screenwriter;
        }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return screenwriter;
        }
    }
}
