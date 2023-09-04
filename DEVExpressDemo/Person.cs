using DevExpress.Mvvm.DataAnnotations;
using DEVExpressDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVExpressDemo
{
    public class Person
    {
        CustModel custModel1 = new CustModel();
        public CustModel CModel
        {
            get
            {
                return custModel1;
            }
            set
            {
                custModel1 = value;
            }
        }
        public CustModel CModel1 { get; set; } = new CustModel();
        public CustModel CModel2 { get; set; } = new CustModel();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;

    }
}
