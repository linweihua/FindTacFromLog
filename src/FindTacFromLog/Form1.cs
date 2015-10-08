using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTacFromLog
{
    public partial class Form1 : Form
    {
        public List<FileContent> ContentList;
        private List<ShowFindResultModel> showFindResultModels; 
        public Form1()
        {
            InitializeComponent();
            this.ContentList = new List<FileContent>();
            showFindResultModels = new List<ShowFindResultModel>();
        }

        private void btnSelectFindPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.txtSelectPath.Text = folderBrowser.SelectedPath;
     
            }
        }

        private void getTacs()
        {
            string[] resultStrings = this.txtFindContent.Text.Split(',');
            foreach (var s in resultStrings)
            {
                if ("".Equals(s))
                {
                    continue;
                }
                ShowFindResultModel  showFindResultModel = new ShowFindResultModel();
                showFindResultModel.tac = s;
                this.showFindResultModels.Add(showFindResultModel);
            }
        }

        private void makeColumn()
        {
            this.listView1.Clear();

            this.listView1.BeginUpdate();
            this.listView1.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "序号";
            ch.Width = 100;
            this.listView1.Columns.Add(ch);

            ColumnHeader chTac = new ColumnHeader();
            chTac.Text = "Tac";
            chTac.Width = 200;
            this.listView1.Columns.Add(chTac);

            ColumnHeader chCount = new ColumnHeader();
            chCount.Text = "count";
            chCount.Width = 100;
            this.listView1.Columns.Add(chCount);

            ColumnHeader chfiles = new ColumnHeader();
            chfiles.Text = "files";
            chfiles.Width = 300;
            this.listView1.Columns.Add(chfiles);
//            ColumnHeader chindexs = new ColumnHeader();
//            chindexs.Text = "indexs";
//            chindexs.Width = 300;
//            this.listView1.Columns.Add(chindexs);
            this.listView1.EndUpdate();
        }

        public void find()
        {
            var files = Directory.GetFiles(txtSelectPath.Text, "*.log");
            foreach (var file in files)
            {
                string content = "";
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                content = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                foreach (var model in showFindResultModels)
                {
                    if (model.count == 1)
                    {
                        continue;
                    }
                    Regex r = new Regex(model.tac);
                    MatchCollection mc = r.Matches(content);
                    for (int i = 0; i < mc.Count; i++)
                    {
                         model.count++;
                        FindResult f = new FindResult();
                        f.fileName = file;
                        f.index = mc[i].Index;
                        model.files.Add(f);
                    }
                   
                }
            }
        }

        public void show()
        {
            makeColumn();
            int i = 0;
            foreach (var findResultModel in showFindResultModels)
            {
                i++;
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(findResultModel.tac);
                item.SubItems.Add(findResultModel.count.ToString());
                string files = "";
                string indexs = "";
                foreach (var f in findResultModel.files)
                {
                    files += f.fileName + ",";
                    indexs += f.index + ",";
                }
                item.SubItems.Add(files);
//                item.SubItems.Add(indexs);
                this.listView1.Items.Add(item);
            }
        }

        public void save()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "文本文件|*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string path = sf.FileName;
             
                FileStream stream = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write);
                stream.Seek(0, SeekOrigin.Begin);
                stream.SetLength(0);
                stream.Close();
                StreamWriter sw = new StreamWriter(path);
                string line  = "";
                // 标题
                for (int i = 0; i < this.listView1.Columns.Count; i++)
                {
                    line += this.listView1.Columns[i].Text + ",";
                }
                sw.WriteLine(line);
                //内容
                foreach (ListViewItem item in this.listView1.Items)
                {
                    line = "";
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        line += item.SubItems[i].Text + ",";
                    }
                    sw.WriteLine(line);
                }
                sw.Close();
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            getTacs();
            if ("".Equals(this.txtSelectPath.Text))
            {
                this.btnSelectFindPath.PerformClick();
            }
            if (showFindResultModels.Count <= 0)
            {
                MessageBox.Show("请填写查找内容");
                return;
            }
            if ("".Equals(txtSelectPath.Text))
            {
                MessageBox.Show("请选择正确的路径");
                return;
            }
            find();
            show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
