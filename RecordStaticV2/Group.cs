namespace RecordStaticV2
{
    class Group
    {
        public string GroupNo { get; set; }
        private int StudentLimit;
        private Student[] Students { get; set; }
        private int studentcount;

        public void SetStudentLimit(int StudentLimit)
        {
            if ((StudentLimit < 5 || StudentLimit > 18))
            {
                while (true)
                {
                    Console.WriteLine("Student limit is 5-18");
                    Console.Write("Student Limit: ");
                    int _studentlimit = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                this.StudentLimit = StudentLimit;
            }

        }
        public int GetStudentLimit()
        {
            return StudentLimit;
        }
        public Group(string groupno, int studentlimit)
        {
            if (CheckGroupNo(groupno))
            {
                GroupNo = groupno;
            }
            else
            {
                Console.WriteLine("Group number is not correct...");
            }
            //if (StudentLimit < 5 || StudentLimit > 18)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Student limit is 5-18");
            //        Console.Write("Student Limit: ");
            //        int _studentlimit = int.Parse(Console.ReadLine());
            //    }
            //}
            //else
            //{
            //    StudentLimit = studentlimit;
            //}
            //Students = new Student[StudentLimit];
            //studentcount = 0;
        }

        //public void SetStudentLimit(int StudentLimit)
        //{
        //    if(StudentLimit>=5 & StudentLimit <= 18)
        //    {
        //        this.studentlimit = StudentLimit;
        //    }
        //}
        //public int GetStudentLimit()
        //{
        //    return studentlimit;
        //}

        public bool CheckGroupNo(string groupno)
        {
            for (int i = 0; i < groupno.Length; i++)
            {
                if (Char.IsUpper(groupno[0]))
                {
                    return true;
                }
                if (Char.IsUpper(groupno[1]))
                {
                    return true;
                }
                if (Char.IsDigit(groupno[2]))
                {
                    return true;
                }
                if (Char.IsDigit(groupno[3]))
                {
                    return true;
                }
                if (Char.IsDigit(groupno[4]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddStudent(Student student)
        {
            if (studentcount < StudentLimit)
            {
                Students[studentcount] = student;
                studentcount++;
                return true;
            }
            else
            {
                Console.WriteLine("Class is full...");
                return false;
            }
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < studentcount; i++)
            {
                if (Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }


    }
}
