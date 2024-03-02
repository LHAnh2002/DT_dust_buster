using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorDustBuster.DTO
{
    internal class RandomID
    {
        private static readonly Random random = new Random();

        // Hàm để sinh ra một chuỗi ngẫu nhiên từ các chữ số từ '0' đến '9'
        public  string GenerateRandomId(int K = 5)
        {
            StringBuilder randomId = new StringBuilder();

            for (int i = 0; i < K; i++)
            {
                randomId.Append(random.Next(10).ToString());
            }

            return randomId.ToString();
        }

    }
}
