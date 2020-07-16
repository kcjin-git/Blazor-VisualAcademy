using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class About
    {
        private String _title = "Test About";

        private string Title 
        { 
            get { return _title; } 
            set { _title = value; } 
        }

        protected override void OnInitialized()
        {

        }
    }
}
