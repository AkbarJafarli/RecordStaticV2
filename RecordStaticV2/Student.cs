namespace RecordStaticV2
{
    class Student
    {
        private int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public int Point {  get; set; }

        public Student(string fullname,int point)
        {
            Id=_id++;
            FullName=fullname;
            Point=point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Point: {Point}");
        }
    }
}
