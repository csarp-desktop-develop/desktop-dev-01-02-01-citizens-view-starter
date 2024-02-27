using System.Collections.Generic;
using System;
using MenuProject.SchoolCitizens;

namespace MenuProject.Repos
{
    public class ParentRepo
    {
        #region Database
        List<Parent> _parents = new()
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Virág",
                    LastName="Vas",
                    IsWoman=true,
                    BirthDay=new DateTime(1998,8,8),
                    PlaceOfBirth="Szeged",
                    MathersName="Érc Kitti",
                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Petra",
                    LastName="Pénzes",
                    IsWoman=true,
                    BirthDay=new DateTime(1997,7,7),
                    PlaceOfBirth="Kistelek",
                    MathersName="Szegény Szandi",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Ferenc",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(1995,5,5),
                    PlaceOfBirth="Szeged",
                    MathersName="Adakozó Andor",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Fruzsi",
                    LastName="Fukar",
                    IsWoman=true,
                    BirthDay=new DateTime(1994,4,4),
                    PlaceOfBirth="Makó",
                    MathersName="Adó Anna",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Hedvig",
                    LastName="Hosszú",
                    IsWoman=true,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Szeged",
                    MathersName="Alacsony Anikó",

                },
                new Parent
                {
                    Id=Guid.NewGuid(),
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Deszk",
                    MathersName="Alacsony Anikó",

                }
            };
        #endregion

        public List<Parent> FindAll()
        {
            return _parents;
        }
    }
}
