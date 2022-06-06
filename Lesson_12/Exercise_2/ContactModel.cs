using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class ContactModel
    {
        public static ContactModel Create(string row)
        {
            string[] columns = row.Split('\t');
            if (columns.Length == 3)
            {
                if (DateTime.TryParse(columns[2], out DateTime date)
                    && !string.IsNullOrEmpty(columns[1]))
                {
                    return new ContactModel { TypeFile = columns[0], NameFile = columns[1], CreateTime = date };
                }
            }
            return null;
        }
        public string TypeFile { get; set; }
        public string NameFile { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
