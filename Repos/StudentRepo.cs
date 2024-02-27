using MenuProject.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuProject.Repos
{
    public class StudentRepo
    {
        #region Database
        private List<Student> _students = new()
        {
            new() {
                Id=Guid.NewGuid(),
                FirstName="János",
                LastName="Jegy",
                IsWoman=false,
                BirthDay=new DateTime(2021,3,13),
                PlaceOfBirth="Szeged",
                SchoolYear=9,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="szakképzés"
            },
            new() {
                Id=Guid.NewGuid(),
                FirstName="Szonja",
                LastName="Stréber",
                BirthDay=new DateTime(2020,4,24),
                PlaceOfBirth="Makó",
                IsWoman=true,
                SchoolYear=10,
                SchoolClass = SchoolClassType.ClassB,
                EducationLevel="szakképzés"
            },
            new() {
                Id=Guid.NewGuid(),
                FirstName="Ubul",
                LastName="Ugráló",
                PlaceOfBirth="Makó",
                IsWoman=false,
                BirthDay=new DateTime(2020,2,11),
                SchoolYear=10,
                SchoolClass = SchoolClassType.ClassB,
                EducationLevel="érettségi"
            },
            new() {
                Id=Guid.NewGuid(),
                FirstName="Kati",
                LastName="Késő",
                PlaceOfBirth="Domaszék",
                IsWoman=true,
                BirthDay=new DateTime(2019,2,11),
                SchoolYear=12,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="érettségi"
            },
            new() {
                Id=Guid.NewGuid(),
                FirstName="Kenéz",
                LastName="Kísérletező",
                PlaceOfBirth="Budapest",
                IsWoman=false,
                BirthDay=new DateTime(2017,2,11),
                SchoolYear=14,
                SchoolClass = SchoolClassType.ClassA,
                EducationLevel="szakképzés"
            }
        };
        #endregion

        public List<Student> FindAll()
        {
            return _students;
        }
        public void Insert(Student student)
        {
            _students.Add(student);
        }

        public void Update(Student student)
        {
            if (!student.HasId)
            {
                Insert(student);
            }
            else
            {
                Student? studentToUpdate = _students.FirstOrDefault(s => s.Id == student.Id);
                studentToUpdate?.Set(student);
            }
        }

        public void Delete(Student student)
        {
            _students.Remove(student);
        }


    }
}
