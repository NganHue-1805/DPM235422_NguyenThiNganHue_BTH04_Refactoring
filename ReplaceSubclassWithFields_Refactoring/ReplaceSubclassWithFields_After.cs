using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields_Refactoring
{
    public class Person_After
    {
        // Thay vì tạo Lớp con, ta tạo thuộc tính để chứa dữ liệu
        private readonly char _genderCode;

        private Person_After(char genderCode)
        {
            _genderCode = genderCode;
        }

        // Cung cấp hàm Factory cho tiện sử dụng
        public static Person_After CreateMale() => new Person_After('M');
        public static Person_After CreateFemale() => new Person_After('F');

        public char GetCode() => _genderCode;
    }
}
