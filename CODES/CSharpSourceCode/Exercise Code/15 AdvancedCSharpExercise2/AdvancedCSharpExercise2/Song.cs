using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Song : IWritable
    {
        private string name;
        private string songwriter;

        public Song(string name, string songwriter)
        {
            this.name = name;
            this.songwriter = songwriter;
        }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return songwriter;
        }
    }
}
