using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractInterface_Refactoring
{
    // Tạo interface chỉ chứa những hàm mà TimeSheet cần
    public interface IBillable
    {
        int GetRate();
        bool HasSpecialSkill();
    }

    public class Employee_After : IBillable
    {
        public int GetRate() => 500;
        public bool HasSpecialSkill() => true;
        public string GetName() => "John";
    }

    public class TimeSheet_After
    {
        // Tính tiền giờ dựa trên Interface, không quan tâm đối tượng là Employee hay Freelancer
        public double Charge(IBillable worker, int days)
        {
            int baseCharge = worker.GetRate() * days;
            if (worker.HasSpecialSkill())
                return baseCharge * 1.5;
            return baseCharge;
        }
    }
}
