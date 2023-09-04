using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVExpressDemo.Models
{
    public class CustModel
    {
        private string name = "Name";
        public CustModel()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //public override string ToString()
        //{
        //    return name;
        //}
    }
}
