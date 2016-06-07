using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperSample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTestOne_Click(object sender, EventArgs e)
        {
            LinqToSQL linq = new LinqToSQL();
            var linqTime = linq.RunTestOne();
            lblLinq.Text = linqTime.TotalMilliseconds.ToString("###.00ms");

            ADO ado = new ADO();
            var adoTime = ado.RunTestOne();
            lblADO.Text = adoTime.TotalMilliseconds.ToString("###.00ms");

            DapperTest dapper = new DapperTest();
            var dapperTime = dapper.RunTestOne();
            lblDapper.Text = dapperTime.TotalMilliseconds.ToString("###.00ms");

            if (linqTime > dapperTime && linqTime > adoTime)
            {
                progressADO.Maximum = (int)linqTime.TotalMilliseconds;
                progressLinq.Maximum = (int)linqTime.TotalMilliseconds;
                progressDapper.Maximum = (int)linqTime.TotalMilliseconds;

            }
            else if (dapperTime > linqTime && dapperTime > adoTime)
            {
                progressADO.Maximum = (int)dapperTime.TotalMilliseconds;
                progressLinq.Maximum = (int)dapperTime.TotalMilliseconds;
                progressDapper.Maximum = (int)dapperTime.TotalMilliseconds;

            }
            else if (adoTime > linqTime && adoTime > dapperTime)
            {
                progressADO.Maximum = (int)adoTime.TotalMilliseconds;
                progressLinq.Maximum = (int)adoTime.TotalMilliseconds;
                progressDapper.Maximum = (int)adoTime.TotalMilliseconds;
            }

            progressADO.Value = (int)adoTime.TotalMilliseconds;
            progressLinq.Value = (int)linqTime.TotalMilliseconds;
            progressDapper.Value = (int)dapperTime.TotalMilliseconds;

        }
    }
}
