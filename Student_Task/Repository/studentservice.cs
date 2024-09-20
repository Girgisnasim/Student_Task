using Student_Task.Models;
using Student_Task.ModelView;

namespace Student_Task.Repository
{
    public class studentservice : Istudentservice
    {
        public studentDb context;
        public studentservice(studentDb _context) { 
         context = _context;
        }
        public void Add_New_Student(studentMV studentMV)
        {
           Student student =new Student()
           {
               Id = 0,
               Name = studentMV.Name,
               email=studentMV.email,
               Address = studentMV.Address,
               CreatedDate = studentMV.CreatedDate,
                Subject = studentMV.Subject,

           };

            context.Students.Add(student);
            context.SaveChanges();



        }
    }
}
