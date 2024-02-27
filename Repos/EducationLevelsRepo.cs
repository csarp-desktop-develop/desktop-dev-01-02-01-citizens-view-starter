using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuProject.Repos
{
    public class EducationLevelsRepo
    {
        private List<String> _educationLevels= new() { "érettségi", "szakképzés", "szakmai vizsga" };
        public List<string> FindAll()
        {
            return _educationLevels;
        }

        public string FindFirst()
        {
            return FindAll().FirstOrDefault() ?? string.Empty;
        }
    }
}
