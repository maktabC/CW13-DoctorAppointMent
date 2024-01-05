using cw12.Entities;

namespace cw12.DataBase
{
    public static class Tempdatabase
    {
        public static List<Doctor> doctors = new List<Doctor>()
        {
            new Doctor{FirstName =  "Hassan", LastName="Hassani", Id=100, Skill=new Sickness{Id=1,Name="Ent"},Price=150000,Role=Enums.RoleEnum.Doctor},
            new Doctor{FirstName =  "Amir", LastName="Amiri", Id=200, Skill=new Sickness{Id=1,Name="Ent"},Price=150000,Role=Enums.RoleEnum.Doctor}
        };

        public static List<Reservation> reservations = new List<Reservation>();
    }
}
