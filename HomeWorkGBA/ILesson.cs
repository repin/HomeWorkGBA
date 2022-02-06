using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA
{
    interface ILesson
    {
        public string lessonID { get; }

        public string discriprions { get; }

        void Demo();

    }
}
