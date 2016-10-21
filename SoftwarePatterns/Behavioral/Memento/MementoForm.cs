using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePatterns.Behavioral.Memento
{
    public class MementoForm
    {
        public static Form GetNewForm(Form Form)
        {
            return (Form)Form.Clone();
        }
    }
}
