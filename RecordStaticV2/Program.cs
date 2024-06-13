using RecordStaticV2;

Console.WriteLine("Enter user details...");
Console.Write("Id: ");
int id = int.Parse(Console.ReadLine());
Console.Write("Fullname: ");
string fullname = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();

User user = new User(id, fullname, email, password);

Console.WriteLine("Enter group details...");
Console.Write("GroupNo: ");
string groupno = Console.ReadLine();
Console.Write("Student Limit: ");
int studentlimit = int.Parse(Console.ReadLine());
Group group = new Group(groupno, studentlimit);
