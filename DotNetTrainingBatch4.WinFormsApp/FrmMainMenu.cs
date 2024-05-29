using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTrainingBatch4.WinFormsApp;

public partial class FrmMainMenu : Form
{
    public FrmMainMenu()
    {
        InitializeComponent();
    }

    private void newBlogToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmBlog frm = new FrmBlog();
        //frm.Show();
        frm.ShowDialog();
    }

    private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmBlogList frm = new FrmBlogList();
        frm.ShowDialog();
    }
}
