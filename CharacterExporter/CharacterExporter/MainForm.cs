using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CharacterExporter.Data;

namespace CharacterExporter
{
    public partial class MainForm : Form
    {
        private SaveFile saveFile;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonSave1Export.Enabled = false;
            buttonSave1Import.Enabled = false;
            buttonSave2Export.Enabled = false;
            buttonSave2Import.Enabled = false;
            buttonSave3Export.Enabled = false;
            buttonSave3Import.Enabled = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MHX/Gen System File|system|All files (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    saveFile = getSaveFile(File.ReadAllBytes(ofd.FileName));
                    loadSave();
                }

                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Error");
                saveFile = null;
                clearForms();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == null)
            {
                MessageBox.Show("Load a file first!");
                return;
            }
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "All files (*.*)|*.*";
                    sfd.FilterIndex = 1;
                    sfd.RestoreDirectory = true;
                    sfd.FileName = "system";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        saveSaveFile(saveFile);
                        File.WriteAllBytes(sfd.FileName, saveFile.FileData);
                        MessageBox.Show("Save Complete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Unsucessful");
            }
        }

        private void loadSave()
        {
            labelSave1Name.Text = saveFile.Players[0] == null ? "[Uninitialized]" : saveFile.Players[0].Name;
            buttonSave1Export.Enabled = saveFile.Players[0] != null;
            buttonSave1Import.Enabled = saveFile.Players[0] != null;

            labelSave2Name.Text = saveFile.Players[1] == null ? "[Uninitialized]" : saveFile.Players[1].Name;
            buttonSave2Export.Enabled = saveFile.Players[1] != null;
            buttonSave2Import.Enabled = saveFile.Players[1] != null;

            labelSave3Name.Text = saveFile.Players[2] == null ? "[Uninitialized]" : saveFile.Players[2].Name;
            buttonSave3Export.Enabled = saveFile.Players[2] != null;
            buttonSave3Import.Enabled = saveFile.Players[2] != null;
        }

        private void clearForms()
        {
            buttonSave1Export.Enabled = false;
            buttonSave1Import.Enabled = false;
            buttonSave2Export.Enabled = false;
            buttonSave2Import.Enabled = false;
            buttonSave3Export.Enabled = false;
            buttonSave3Import.Enabled = false;
            labelSave1Name.Text = "[Uninitialized]";
            labelSave1Name.Text = "[Uninitialized]";
            labelSave1Name.Text = "[Uninitialized]";
        }

        private SaveFile getSaveFile(byte[] buff)
        {
            SaveFile save = new SaveFile();
            save.FileData = buff;
            save.Players = new Player[3];
            BinaryReader binaryReader = new BinaryReader((Stream)new MemoryStream(buff));

            for (int i = 0; i < 3; i++)
            {
                if (buff[Constants.CHAR_SLOT_1_USED_OFFSET + (1 * i)] != 0)
                {
                    save.Players[i] = new Player();

                    binaryReader.BaseStream.Seek(Constants.CHAR_SLOT_1_OFFSET + (4 * i), SeekOrigin.Begin);
                    save.Players[i].SaveOffset = binaryReader.ReadUInt32();

                    binaryReader.BaseStream.Seek(save.Players[i].SaveOffset, SeekOrigin.Begin);
                    save.Players[i].Data = binaryReader.ReadBytes(Constants.SIZEOF_CHARACTER);

                    binaryReader.BaseStream.Seek(save.Players[i].SaveOffset + Constants.NAME_OFFSET, SeekOrigin.Begin);
                    save.Players[i].Name = Encoding.UTF8.GetString(binaryReader.ReadBytes(Constants.SIZEOF_NAME), 0, Constants.SIZEOF_NAME);
                }
            }

            return save;
        }

        private void saveSaveFile(SaveFile save)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)new MemoryStream(save.FileData));

            for (int i = 0; i < 3; i++)
            {
                if (save.Players[i] != null)
                {
                    binaryWriter.BaseStream.Seek(save.Players[i].SaveOffset, SeekOrigin.Begin);
                    binaryWriter.Write(save.Players[i].Data);
                }
            }
        }

        private void exportPlayer(int player)
        {
            if (saveFile.Players[player] == null) { return; }
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Binary file (*.bin)|*.bin|All files (*.*)|*.*";
                    sfd.FilterIndex = 1;
                    sfd.RestoreDirectory = true;
                    sfd.FileName = saveFile.Players[player].Name;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, saveFile.Players[player].Data);
                        MessageBox.Show("Save Complete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Unsucessful");
            }
        }

        private void importPlayer(int player)
        {
            if (saveFile.Players[player] == null) { return; }
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Character Files (*.bin)|*.bin|All files (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] buff = File.ReadAllBytes(ofd.FileName);

                    if (buff.Length != Constants.SIZEOF_CHARACTER)
                    {
                        MessageBox.Show("Invalid character file");
                        return;
                    }

                    BinaryReader binaryReader = new BinaryReader((Stream)new MemoryStream(buff));
                    binaryReader.BaseStream.Seek(Constants.NAME_OFFSET, SeekOrigin.Begin);
                    saveFile.Players[player].Data = buff;
                    saveFile.Players[player].Name = Encoding.UTF8.GetString(binaryReader.ReadBytes(Constants.SIZEOF_NAME), 0, Constants.SIZEOF_NAME);
                    loadSave();
                }

                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Error");
                saveFile = null;
                clearForms();
            }
        }


        private void buttonSave1Export_Click(object sender, EventArgs e)
        {
            exportPlayer(0);
        }

        private void buttonSave1Import_Click(object sender, EventArgs e)
        {
            importPlayer(0);
        }

        private void buttonSave2Export_Click(object sender, EventArgs e)
        {
            exportPlayer(1);
        }

        private void buttonSave2Import_Click(object sender, EventArgs e)
        {
            importPlayer(1);
        }

        private void buttonSave3Export_Click(object sender, EventArgs e)
        {
            exportPlayer(2);
        }

        private void buttonSave3Import_Click(object sender, EventArgs e)
        {
            importPlayer(2);
        }
    }
}
