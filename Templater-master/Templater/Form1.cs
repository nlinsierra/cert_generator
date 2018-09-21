using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Templater
{
    public partial class Form1 : Form
    {
        Word.Application word;
        Excel.Application excel;
        Word.Document templ;
        Excel.Workbook dexc;
        List<ComboBox> inTempl = new List<ComboBox>();
        List<ComboBox> inExcel = new List<ComboBox>();
        public Form1()
        {
            InitializeComponent();
            //tb_templ_path.Text = "templ.dot";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            word = new Word.Application();
            excel = new Excel.Application();
            templ = word.Documents.Add(Environment.CurrentDirectory + "\\templ.dot");
        }

        private void cb_Select(object sender, EventArgs e)
        {
            /* var selitem = (sender as ComboBox).SelectedItem;
             foreach (ComboBox cb in inTempl)
             {
                 if (cb == sender) continue;
                 cb.Items.Remove(selitem);
             }*/
        }


        private void loadTempl()
        {
            var ext = Path.GetExtension(Path.GetFullPath(tb_templ_path.Text)).ToLower();
            if (ext != ".dot" && ext != ".dotm" && ext != ".dotx")
            {
                MessageBox.Show("Неверный формат файла!");
                return;
            }

            foreach (ComboBox cb in inTempl)
            {
                p_fields.Controls.Remove(cb);
            }

            inTempl = new List<ComboBox>();

            templ = word.Documents.Add(Path.GetFullPath(tb_templ_path.Text));
            label2.Enabled = tb_excel_path.Enabled = b_sel_excel.Enabled = true;

            List<string> bookmarks = new List<string>();
            foreach (Word.Bookmark b in templ.Bookmarks)
            {
                bookmarks.Add(b.Name);
            }


            for (int i = 0; i < bookmarks.Count; ++i)
            {
                ComboBox cb = new ComboBox();
                cb.Items.AddRange(bookmarks.ToArray());
                cb.Top = i * (3 + cb.Height);
                cb.SelectedValueChanged += cb_Select;
                cb.Width = (p_fields.Width - 6) / 4 - 3;
                cb.Anchor = AnchorStyles.Left | AnchorStyles.Top;

                p_fields.Controls.Add(cb);
                inTempl.Add(cb);
            }
            /*inTempl.Add(cb);
            p_fields.Controls.Add(inTempl[1]);*/

            /*for (int i = 0; i < 100; ++i)
            {
                TextBox tb = new TextBox();
                p_fields.Controls.Add(tb);
                tb.Top = i * (3 + tb.Height);
            }*/
        }

        private void b_optempl_Click(object sender, EventArgs e)
        {
            if (tb_templ_path.Text.Length > 0 && File.Exists(Path.GetFullPath(tb_templ_path.Text)))
            {
                loadTempl();
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Шаблон Word 97-2003 (*.dot)|*.dot|Шаблон Word (*.dotx)|*.dotx|Шаблон Word с поддержкой макросов (*.dotm)|*.dotm";
            ofd.CheckPathExists = true;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Multiselect = false;
            ofd.Title = "Выберите файл шаблона...";
            var res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                tb_templ_path.Text = ofd.FileName;
                loadTempl();
                return;
            }

        }

        private void tb_templ_path_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b_optempl.PerformClick();
            }
        }

        private void b_sel_excel_Click(object sender, EventArgs e)
        {
            if (tb_excel_path.Text.Length > 0 && File.Exists(Path.GetFullPath(tb_excel_path.Text)))
            {
                loadExcel();
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Книга Excel 97-2003 (*.xls)|*.xls|Книга Excel (*.xlsx)|*.xlsx";
            ofd.CheckPathExists = true;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Multiselect = false;
            ofd.Title = "Выберите файл наполнения...";
            var res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                tb_excel_path.Text = ofd.FileName;
                loadExcel();
                return;
            }
        }

        private void loadExcel()
        {
            var ext = Path.GetExtension(Path.GetFullPath(tb_excel_path.Text)).ToLower();
            if (ext != ".xls" && ext != ".xlsx")
            {
                MessageBox.Show("Неверный формат файла!");
                return;
            }

            foreach (ComboBox cb in inExcel)
            {
                p_fields.Controls.Remove(cb);
            }

            inExcel = new List<ComboBox>();

            dexc = excel.Workbooks.Open(Path.GetFullPath(tb_excel_path.Text));
            mainpanel.Enabled = true;
            Excel.Worksheet wex = dexc.ActiveSheet;
            List<string> columns = new List<string>();
            for (int i = 1; i <= 50; ++i)
            {
                if ((string)wex.Cells[1, i].Text == "") continue;
                columns.Add(wex.Cells[1, i].Text);
            }

            for (int i = 0; i < inTempl.Count; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    ComboBox cb = new ComboBox();
                    cb.Items.AddRange(columns.ToArray());
                    cb.Top = i * (3 + cb.Height);
                    cb.Left = (j + 1) * inTempl[0].Width + 3 + 4 * j;
                    cb.SelectedValueChanged += cb_Select;
                    cb.Width = inTempl[0].Width;

                    p_fields.Controls.Add(cb);
                    inExcel.Add(cb);
                }
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            /*range = templ.Bookmarks["fio"].Range;
            range.Text = "777";
            templ.Bookmarks.Add("fio", range);
            range = templ.Bookmarks["fio"].Range;
            range.Text = "666";
            templ.Bookmarks.Add("fio", range);
            templ.Bookmarks["rank"].Range.Text = "!!!";
            templ.Bookmarks["univ"].Range.Text = "&&&&&&&&&&&&&&&";
            templ.SaveAs(Environment.CurrentDirectory + "\\docs\\" + 2 + ".doc");
            return;*/

            Excel.Worksheet wex = dexc.ActiveSheet;
            Word.Range range;

            List<List<int>> cols = new List<List<int>>();
            for (int i = 0; i < inTempl.Count(); ++i)
            {
                cols.Add(new List<int>());
                for (int j = 0; j < 3; ++j)
                {
                    if (inExcel[i * 3 + j].SelectedIndex == -1) break;
                    cols[i].Add(inExcel[i * 3 + j].SelectedIndex);
                }
            }

            for (int i = 0; i < cols.Count(); ++i)
            {
                for (int j = 0; j < cols[i].Count; ++j)
                {
                    for (int z = 1; z <= 50; ++z)
                    {
                        if ((string)wex.Cells[1, z].Text == (string)inExcel[0].Items[cols[i][j]])
                        {
                            cols[i][j] = z;
                            break;
                        }
                    }
                }
            }
            int k = 1;
            //templ.SaveAs(Environment.CurrentDirectory + "\\docs\\test.doc");
            while (wex.Cells[k, 1].Text != "")
            {
                var ctempl = templ;
                for (int i = 0; i < cols.Count; ++i)
                {
                    string tmp = "";
                    for (int j = 0; j < cols[i].Count(); ++j)
                    {
                        if (j > 0)
                            tmp += " ";
                        tmp += wex.Cells[k, cols[i][j]].Text;
                    }
                    range = templ.Bookmarks[inTempl[i].SelectedItem].Range;
                    range.Text = tmp;
                    templ.Bookmarks.Add((string)inTempl[i].SelectedItem, range);
                }
                templ.SaveAs(Environment.CurrentDirectory + "\\docs\\" + k + ".doc");
                k++;
            }
            MessageBox.Show("!!!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            templ.Close();
            dexc.Close();
        }
    }
}
