using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.binding
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class StudentsCollection
    {
        static DataTable _dtStudents;

        static StudentsCollection()
        {
            _dtStudents = GetStudentsDataTable();
        }

        public static DataTable DTStudents { get; } = _dtStudents;

        public static ObservableCollection<StudentEntity> GetStudents()
        {
            ObservableCollection<StudentEntity> collection = new ObservableCollection<StudentEntity>();
            foreach (DataRow student in _dtStudents.Rows)
            {
                collection.Add(new StudentEntity() {Id = (int)student.ItemArray[0],  Name = student.ItemArray[1].ToString(),Age = (int)student.ItemArray[2]});
            }

            return collection;
        }

        public static DataTable GetStudentsDataTable()
        {
            DataTable dtStudent = new DataTable();
            dtStudent.Columns.Add("Id",Type.GetType("System.Int32"));
            dtStudent.Columns.Add("Name",Type.GetType("System.String"));
            dtStudent.Columns.Add("Age", Type.GetType("System.Int32"));

            var row = dtStudent.NewRow();
            row[0] = 1;
            row[1] = "Tim";
            row[2] = "22";
            dtStudent.Rows.Add(row);
            dtStudent.Rows.Add(new object[] {2, "Tom", 23});
            dtStudent.Rows.Add(new object[] {3, "Xin", 31});
            dtStudent.Rows.Add(new object[] { 4, "Windey", 32 });
            dtStudent.Rows.Add(new object[] { 5, "Candey", 21 });
            dtStudent.Rows.Add(new object[] { 6, "Nancy", 18 });
            
            return dtStudent;
        }
        

    }

    
}
