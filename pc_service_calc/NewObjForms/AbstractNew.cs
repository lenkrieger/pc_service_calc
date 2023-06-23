using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pc_service_calc.NewObjectForms
{
    [Serializable]
    public partial class AbstractNew : Form
    {
        public AbstractNew()
        {
            InitializeComponent();
        }
        protected virtual GenericNewHelper getContents()
        {
            return new GenericNewHelper("test", "asd");
        }
        protected void ReadyButton_Click(object sender, EventArgs e)
        {
            GenericNewHelper helper = getContents();
            if (helper.GetType() == typeof(ErrorHelper))
            {
                label3.Text = helper.description;
                label3.Visible = true;
                return;
            }
            Owner.Invoke(((Form1)Owner).myDelegate, new Object[] { helper });
            this.Close();
        }
    }
    public class GenericNewHelper : Object
    {
        public string name;
        public string description;
        public GenericNewHelper(string newName, string newDescription)
        {
            name = newName;
            description = newDescription;
        }
    }
    public class ErrorHelper : GenericNewHelper
    {
        public ErrorHelper(string newName, string newDescription) : base(newName, newDescription)
        {
        }
    }

}
