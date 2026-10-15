using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateCollection_Refactoring
{
    public class Person_After
    {
        private List<string> _courses = new List<string>();

        // Chỉ trả về danh sách dạng Chỉ đọc
        public IReadOnlyList<string> Courses => _courses.AsReadOnly();

        // Cung cấp hàm thêm phần tử có kiểm soát
        public void AddCourse(string course)
        {
            if (!string.IsNullOrEmpty(course))
            {
                _courses.Add(course);
            }
        }

        public void RemoveCourse(string course)
        {
            _courses.Remove(course);
        }
    }
}
