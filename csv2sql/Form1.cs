using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jas.Utils.CSVTools;


namespace csv2sql {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
            bGenSQL.Enabled = false;
        }

        private void loadFromCSV() {
            if ( od2.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {

                ParserConfig c = Jas.Utils.CSVTools.SettingsForm.GetConfig();

                if ( c == null ) {
                    return;
                }

                c.FileName = od2.FileName;

                dgv.Rows.Clear();
                dgv.Columns.Clear();
                CSVParser p = new CSVParser();
                p.OnRowComplete += new CSVParser.IRowComplete( p_OnRowComplete );
                p.Parse( c );

                bGenSQL.Enabled = dgv.Rows.Count > 0;

                dgv.Rows.Insert( 0, 1 );
            }
        }

        void p_OnRowComplete( string[] row ) {
            if ( dgv.Columns.Count == 0 ) {
                int i = 0;
                foreach ( string s in row ) {
                    dgv.Columns.Add( "col" + i++, s );
                }
            }

            dgv.Rows.Add( row );
        }

        private void bOpen_Click( object sender, EventArgs e ) {
            loadFromCSV();
        }

        private void bGenSQL_Click( object sender, EventArgs e ) {
            List<ColumnInfo> cols = new List<ColumnInfo>();

            DataGridViewRow firstRow = dgv.Rows[0];

            foreach ( DataGridViewCell cell in firstRow.Cells ) {

                if ( cell.Value == null ) {
                    continue;
                }

                string columnName = (string)cell.Value;
                if (string.IsNullOrEmpty(columnName)){
                    continue;
                }

                ColumnInfo ci = new ColumnInfo();
                ci.ColumnType = ColType.Text;
                ci.Index = cell.ColumnIndex;
                ci.Name = columnName;

                cols.Add( ci );
            }

            string prefix = buildPrefix( cols );

            StringBuilder sb = new StringBuilder();

            foreach ( DataGridViewRow row in dgv.Rows ) {
                if ( row.Index == 0 ) {
                    continue;
                }
                sb.AppendLine( prefix + getValues(row,cols) );
            }

            new SQLForm( sb.ToString() ).Show();
        }

        private string getValues( DataGridViewRow row, List<ColumnInfo> cols ) {
            StringBuilder sb = new StringBuilder();
            
            bool first = true;
            foreach ( var ci in cols ) {
                if ( first ) {
                    first = false;
                }
                else {
                    sb.Append( "," );
                }
                sb.Append( "'" );
                sb.Append( row.Cells[ci.Index].Value );
                sb.Append( "'" );
            }

            sb.Append( ");" );

            return sb.ToString();
        }

        private string buildPrefix( List<ColumnInfo> cols ) {
            StringBuilder sb = new StringBuilder();

            sb.Append( "INSERT INTO " );
            sb.Append( tbTable.Text );
            sb.Append( " (" );

            bool first = true;
            foreach ( var ci in cols ) {
                if ( first ) {
                    first = false;
                }
                else {
                    sb.Append( "," );
                }
                sb.Append( ci.Name );
            }

            sb.Append( ") VALUES (" );

            return sb.ToString();
        }

      
    }

    
}
