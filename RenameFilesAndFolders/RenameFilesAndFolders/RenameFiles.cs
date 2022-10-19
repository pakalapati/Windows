namespace RenameFilesAndFolders
{
    public partial class RenameFiles : Form
    {
        public RenameFiles()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (fbDialogue.ShowDialog() == DialogResult.OK)
            {
                txtSelectedFolder.Text = fbDialogue.SelectedPath;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            var folderName = txtSelectedFolder.Text;

            if (!string.IsNullOrEmpty(folderName))
            {
                RenameFilesInDirectory(folderName, txtReplace.Text, txtReplaceCharacter.Text);
            }

            MessageBox.Show("Success!");
        }

        private void RenameFilesInDirectory(string folderPath, string replaceText, string replaceCharacter)
        {
            var newFolderPath = folderPath.Replace(replaceText, "");

            if (!string.IsNullOrEmpty(replaceCharacter))
            {
                newFolderPath = newFolderPath.Replace(replaceCharacter, " ");
            }

            if (!folderPath.Equals(newFolderPath))
            {
                Directory.Move(folderPath, newFolderPath);
            }

            foreach (var file in Directory.GetFiles(newFolderPath))
            {
                string fileName = GetNewFileName(replaceText, replaceCharacter, file);

                File.Move(file, fileName);
            }

            foreach (string subDir in Directory.GetDirectories(newFolderPath))
            {
                RenameFilesInDirectory(subDir, replaceText, replaceCharacter);
            }
        }

        private static string GetNewFileName(string replaceText, string replaceCharacter, string file)
        {
            var fileName = file.Replace(replaceText, "");

            if (!string.IsNullOrEmpty(replaceCharacter))
            {
                var fileExtension = Path.GetExtension(fileName);

                fileName = fileName.Replace(fileExtension, "");

                fileName = fileName.Replace(replaceCharacter, " ");

                fileName = $"{fileName}{fileExtension}";
            }

            return fileName;
        }
    }
}