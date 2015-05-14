using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csv2sql {
    public partial class SQLForm : Form {
      
        public SQLForm(string sql) {
            InitializeComponent();
            rtbSql.Text = sql;
        }
    }
}
