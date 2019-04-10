using System;
namespace EnumHW
{
    public enum Sex
    {
        male,
        female
    }
    public enum Education
    {
        fullTime,
        distance
    }
    public struct Student
    {


        public string Fullname { get; set; }
        public string Group { get; set; }
        public int Mark { get; set; }
        public int Income { get; set; }
        public Sex Sex { get; set; }
        public Education Education { get; set; }

        public Student(string fullname, string group, int mark, int income, Sex sex, Education education)
        {
            Fullname = fullname;
            Group = group;
            Mark = mark;
            Income = income;
            Sex = sex;
            Education = education;
        }
        public void Print()
        {
            Console.WriteLine($"Имя : {Fullname}; Группа : {Group} Оценка : {Mark} Доход : {Income} Пол : {Sex} Тип Обучения : {Education}");
            Console.WriteLine(" ");
        }
    }
}
