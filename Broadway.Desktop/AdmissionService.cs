using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop
{
    public class AdmissionService
    {
        Broadway_Entities db = new Broadway_Entities();

        public void StudentCreate(Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            catch (Exception)
            {

                
            }
        }
        public void StudentEdit(Student student)
        {
            try
            {
                var existingStudent = db.Students.Find(student.Id);
                if (existingStudent!=null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Email = student.Email;
                    existingStudent.Status = student.Status;

                    db.Entry(existingStudent).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }
    }
}
