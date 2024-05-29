using Dapper;
using DotNetTrainingBatch4.Shared;
using DotNetTrainingBatch4.WinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTrainingBatch4.WinFormsApp;

public partial class FrmBlogList : Form
{
    private readonly DapperService _dapperService;
    //private const int _edit = 1;
    //private const int _delete = 2;

    public FrmBlogList()
    {
        InitializeComponent();
        dgvData.AutoGenerateColumns = false;
        _dapperService = new DapperService(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
    }

    private void FrmBlogList_Load(object sender, EventArgs e)
    {
        BlogList();
    }

    private void BlogList()
    {
        List<BlogModel> lst = _dapperService.Query<BlogModel>("select * from tbl_blog");
        dgvData.DataSource = lst;
    }

    private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //int columnIndex = e.ColumnIndex;
        //int rowIndex = e.RowIndex;

        if (e.RowIndex == -1) return;

        #region If Case

        var blogId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["colId"].Value);

        if (e.ColumnIndex == (int)EnumFormControlType.Edit)
        {
            FrmBlog frm = new FrmBlog(blogId);
            frm.ShowDialog();

            BlogList();
        }
        else if (e.ColumnIndex == (int)EnumFormControlType.Delete)
        {
            var dialogResult = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            DeleteBlog(blogId);
        }

        #endregion


        #region Switch Case

        //int index = e.ColumnIndex;
        //EnumFormControlType enumFormControlType = (EnumFormControlType)index;
        //switch (enumFormControlType)
        //{
        //    case EnumFormControlType.Edit:
        //        FrmBlog frm = new FrmBlog(blogId);
        //        frm.ShowDialog();

        //        BlogList();
        //        break;
        //    case EnumFormControlType.Delete:
        //        var dialogResult = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dialogResult != DialogResult.Yes) return;

        //        DeleteBlog(blogId);
        //        break;
        //    case EnumFormControlType.None:
        //    default:
        //        MessageBox.Show("Invalid Case.");
        //        break;
        //}

        #endregion


        //EnumFormControlType enumFormControlType = EnumFormControlType.None;
        //switch (enumFormControlType)
        //{
        //    case EnumFormControlType.None:
        //        break;
        //    case EnumFormControlType.Edit:
        //        break;
        //    case EnumFormControlType.sddafdasf:
        //        break;
        //    default:
        //        break;
        //}

        //string formControlType = "None";
        //switch (formControlType)
        //{
        //    case "asdfasdfasdf":
        //        break;
        //    case "adf":
        //        break;
        //    case "asdfa":
        //        break;
        //    default:
        //        break;
        //}
    }

    private void DeleteBlog(int id)
    {
        string query = @"Delete From [dbo].[Tbl_Blog] WHERE BlogId = @BlogId";

        int result = _dapperService.Execute(query, new { BlogId = id });
        string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
        MessageBox.Show(message);
        BlogList();
    }
}
