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
using System.Xml; // Library for Reading, Modifying XML files
using System.Xml.Linq;

namespace inoutlinktool
{
    public partial class home : Form
    {

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public home()
        {
            InitializeComponent();
        }

        private void GetDirectory_Click(object sender, EventArgs e) // Get a base directory
        {
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();// Have user select a directory path

            if (folderBrowse.ShowDialog() == DialogResult.OK) // if the directory path is OK
            {
                mainDirectory.Text = folderBrowse.SelectedPath; // Set Directory Textbox Text to the selected location
                checkInlink.Enabled = true;
                checkHash.Enabled = true;
                Start.Enabled = true;
                MessageBox.Show("Please check your options and click START button.");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        /* FIND THE NODE POSITION FOR INLINK PROPERTY */
        static int FindElementIndex(XmlElement element)
        {
            XmlNode parentNode = element.ParentNode;
            if (parentNode is XmlDocument)
            {
                return 1;
            }
            XmlElement parent = (XmlElement)parentNode;
            int index = 1;
            foreach (XmlNode candidate in parent.ChildNodes)
            {
                if (candidate is XmlElement && candidate.Name == element.Name)
                {
                    if (candidate == element)
                    {
                        return index;
                    }
                    index++;
                }
            }
            throw new ArgumentException("Couldn't find element within parent");
        }

        private void Start_Click(object sender, EventArgs e) // Start Parsing
        {
            /* CREATE BACKUP DIRECTORY AND START BACKUP */
            string originalPath = System.IO.Directory.GetParent(mainDirectory.Text).ToString();
            string bkpPath = originalPath + "\\bkp";
            DirectoryCopy(originalPath, bkpPath, true);
;

            /* CHANGE VALUE OF _outlink TO source , CHANGE THE VALUE OF _inlink TO source and CHANGE THE VALUES ACCORDING TO THE PATH */
            if (checkInlink.Checked) 
            {
                this.Enabled = false; // user should not do anything while code is running

                XmlDocument xml = new XmlDocument(); // read new XML documnent
                string @path = mainDirectory.Text; // set path

                /* SEARCH FOR HASH NODES */
                int outcountnodes = 0;
                int incountnodes = 0;
                foreach (string file in Directory.GetFiles(@path, "*.xml", SearchOption.AllDirectories))
                {
                    label1.Text = file;
                    xml.Load(@file); // load each XML
                    XmlNodeList outnodesfound = xml.SelectNodes("//string[@name='_outlink']"); // find _hash
                    label1.Name = file;
                    linkprogress.Maximum += outnodesfound.Count;

                    XmlNodeList innodesfound = xml.SelectNodes("//string[@name='_inlink']"); // find _hash
                    linkprogress.Maximum += innodesfound.Count;
                }
                /* END OF SEARCHING FOR HASH NODES */

                foreach (string file in Directory.GetFiles(@path, "*.xml", SearchOption.AllDirectories))
                {
                    XmlNodeList outlinks = xml.SelectNodes("//string[@name='_outlink']");
                    xml.Load(file); // load each XML
                    for (int i = outlinks.Count - 1; i >= 0; i--) // for every nodes
                    {
                        outlinks[i].Attributes["name"].Value = "source";
                        linkprogress.Value += 1;
                    }
                    xml.Save(@file);
                }

                foreach (string file in Directory.GetFiles(@path, "*.xml", SearchOption.AllDirectories))
                {
                    XmlNodeList inlinks = xml.SelectNodes("//string[@name='_inlink']");
                    xml.Load(file); // load each XML


                    Uri absolutepath = new Uri(file);
                    Uri relativepath = new Uri(path);
                    string inlinkPath = Uri.UnescapeDataString(relativepath.MakeRelativeUri(absolutepath).ToString()
                        .Replace("workdirectory/", "")
                        .Replace(".img.xml", ".img/")
                        .Replace("Item.wz/","Item/")
                        .Replace("Character.wz/","Character/")
                        .Replace("Effect.wz/", "Effect/")
                        .Replace("Etc.wz/", "Etc/")
                        .Replace("Map.wz/", "Map/")
                        .Replace("Mob.wz/", "Mob/")
                        .Replace("Morph.wz/", "Morph/")
                        .Replace("Npc.wz/", "Npc/")
                        .Replace("Reactor.wz/", "Reactor/")
                        .Replace("Skill.wz/", "Skill/")
                        .Replace("TamingMob.wz/", "TamingMob/")
                        .Replace("UI.wz/", "UI/")
                        );

                    for (int i = inlinks.Count - 1; i >= 0; i--) // for every nodes
                    {
                        string currentValue = inlinks[i].Attributes["value"].Value;
                        inlinks[i].Attributes["value"].Value = inlinkPath + currentValue; // change the values
                        inlinks[i].Attributes["name"].Value = "source"; // change _inlink to source
                        linkprogress.Value += 1;
                    }
                    xml.Save(file);
                }
                linkprogress.Enabled = false;
                this.Enabled = true;
            }
            MessageBox.Show("_in/_out links successfully cleared");

            /* REMOVING _hash nodes */
            if (checkHash.Checked) // if user wants to remove _hash
            {

                this.Enabled = false; // user should not do anything while code is running

                XmlDocument xml = new XmlDocument(); // read new XML documnent
                string path = mainDirectory.Text; // set path

                /* SEARCH FOR HASH NODES */
                int hashcountnodes = 0;
                string[] temphash = Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);
                foreach (string hashnodes in temphash)
                {
                    xml.Load(hashnodes); // load each XML
                    XmlNodeList hashnodesfound = xml.SelectNodes("//string[@name='_hash']"); // find _hash

                    hashprogress.Maximum += hashnodesfound.Count;
                }
                /* END OF SEARCHING FOR HASH NODES */

                /* REMOVING _hash NODES */
                foreach (string file in Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories)) // for each files in all directories
                {

                    xml.Load(file); // load each XML
                    XmlNodeList nodes = xml.SelectNodes("//string[@name='_hash']"); // find _hash

                    for (int i = nodes.Count - 1; i >= 0; i--) // for every nodes
                    {
                        nodes[i].ParentNode.RemoveChild(nodes[i]); // remove _hash node
                        hashprogress.Value += 1;

                    }
                    xml.Save(file);
                }
                hashprogress.Enabled = false;
                this.Enabled = true;
                MessageBox.Show("_hash successfully removed");
            }
            /* END OF REMOVING _hash nodes */
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please place all your Wizet Folders (.wz) inside the workdirectory folder.");
        }
    }
}
