using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        public Lab02_Bai06()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            // Thêm ổ đĩa vào TreeView
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                treeView_folder.Nodes.Add(node);

                // Thêm các tệp tin và thư mục vào treeview
                AddFilesAndDirectoriesToTreeView(node, drive.RootDirectory.FullName);
            }
        }

        private void AddFilesAndDirectoriesToTreeView(TreeNode parentNode, string path)
        {
            try
            {
                // Lấy danh sách tệp tin và thư mục
                var filesAndDirectories = Directory.GetFileSystemEntries(path);

                foreach (var fileOrDirectory in filesAndDirectories)
                {
                    // Tạo một nút mới cho tệp tin hoặc thư mục và thêm vào treeview
                    TreeNode newNode = new TreeNode(Path.GetFileName(fileOrDirectory));
                    newNode.Tag = fileOrDirectory;

                    if (File.GetAttributes(fileOrDirectory).HasFlag(FileAttributes.Directory))
                    {
                        newNode.ImageIndex = 0;
                        newNode.SelectedImageIndex = 0;
                        newNode.Nodes.Add(new TreeNode()); // Thêm nút con trống để đánh dấu thư mục có thể mở rộng
                    }
                    else
                    {
                        string extension = Path.GetExtension(fileOrDirectory);
                        if (extension == ".txt")
                        {
                            newNode.ImageIndex = 2;
                            newNode.SelectedImageIndex = 2;
                        }
                        else if (extension == ".jpg" || extension == ".png")
                        {
                            newNode.ImageIndex = 3;
                            newNode.SelectedImageIndex = 3;
                        }
                    }

                    parentNode.Nodes.Add(newNode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void treeView_folder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Hiển thị thư mục con khi nhấp đúp chuột
            e.Node.Nodes.Clear();
            AddFilesAndDirectoriesToTreeView(e.Node, e.Node.Tag.ToString());

        }

        private void treeView_folder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Hiển thị nội dung của tệp tin khi bấm chọn
            if (File.Exists(e.Node.Tag.ToString()))
            {
                string extension = Path.GetExtension(e.Node.Tag.ToString());
                if (extension == ".txt")
                {
                    ShowTextFileContent(e.Node.Tag.ToString());
                }
                else if (extension == ".jpg" || extension == ".png")
                {
                    ShowImageFileContent(e.Node.Tag.ToString());
                }
            }
        }

        private void ShowTextFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    richTextBox_file.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void ShowImageFileContent(string filePath)
        {
            try
            {
                Image img = Image.FromFile(filePath);
                pictureBox_file.Image = img;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

