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


namespace LBABodyRandomise
{
    public partial class LBABodyRand : Form
    {
        /*
         * We can avoid this use of static if we compare the offset at the start
         * of the file with the filesize.
         * As the last "offset" at the start of the file is the file size
         */
        private int NUMOFSKINS;
        private Nullable<bool> LBA1;
        private LookupLBABody lookup;
        private int timeSeconds;

        /*
         * We already store the true location/Name the combination pair
         * As the data never moves and only the offset
         */

        public LBABodyRand()
        {
            InitializeComponent();
        }

        /** This was a hack to allow me to copy the
         * offsets out of the ListView that I decided
         * to leave in, incase anybody needs it in future.
         */
        private void lvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(lvItemList);
            }
        }
        public void CopyListBox(ListView list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list.SelectedItems)
            {
                ListViewItem l = item as ListViewItem;
                if (l != null)
                    foreach (ListViewItem.ListViewSubItem sub in l.SubItems)
                        sb.Append(sub.Text + "\t");
                sb.AppendLine();
            }
            Clipboard.SetDataObject(sb.ToString());
        }

        private void btnFindLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFDBodyLoc = new OpenFileDialog();
            Nullable<bool> LBA1;
            oFDBodyLoc.InitialDirectory = "c:\\";
            oFDBodyLoc.Filter = "BODY.HQR|BODY.HQR";
            oFDBodyLoc.FilterIndex = 0;

            if (oFDBodyLoc.ShowDialog() == DialogResult.OK)
            {
                if (0 != oFDBodyLoc.FileName.Length)
                {
                    txtBodyLoc.Text = oFDBodyLoc.FileName;
                }
                else
                    return;
            }
            else
                return;
            LBA1 = parseBodyFile(txtBodyLoc.Text);
            if (null == LBA1) return;
            DialogResult dialogResult;
            if(false != false)//if ((bool)LBA1 != rbLBA1.Checked)
            {
                dialogResult = MessageBox.Show("This file appears different to your choice\nWould you like to reparse it?",
                                                "Wrong type", MessageBoxButtons.YesNo);
            }
            else
                return;

            if (dialogResult == DialogResult.Yes)
            {
                this.LBA1 = (bool) LBA1;
                if (null != this.LBA1)
                {
                    //rbLBA1.Checked = (bool)this.LBA1;
                    //rbLBA2.Checked = !rbLBA1.Checked;
                }
                parseBodyFile(txtBodyLoc.Text);
            }

        }

        private string convertURI(string s)
        {
            return new Uri(s).LocalPath;
        }

        private void LBABodyRand_Load(object sender, EventArgs e)
        {
            string sExeBasePath = "";
            try
            {
                sExeBasePath = convertURI(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase));
                txtBodyLoc.Text = sExeBasePath + "\\BODY.HQR";
                parseBodyFile(txtBodyLoc.Text);
            }
            catch
            {
                //MessageBox.Show("Body file expected at: " + sExeBasePath);
            }
        }

        /**
         * This returns true if positively identified as LBA1
         * This returns false if positively identified as LBA2
         * Else returns null
         */ 
        private Nullable<bool> parseBodyFile(string path)
        {
            int i;
            long fileSize;
            int offset=0;
            Nullable<bool> lba1 = isLBA1File(new System.IO.FileInfo(path).Length);
            if (null != lba1)
            {
                lookup = new LookupLBABody(lba1);
            }
            FileStream fsStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            LBA1 = false; //rbLBA1.Checked;

            //Clear the list view as it may have already
            //had a file loaded
            lvItemList.Clear();
            //Reset column headers
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.chPosition,
                this.chOffset,
                this.chName
            });
            fileSize = new System.IO.FileInfo(path).Length;
            for (i=0; offset != fileSize; i++)
            {

                //Read in four bytes;
                int[] bytes = new int[4];
                for (int j = 0; j < 4;j++)
                {                    
                    bytes[j] = fsStream.ReadByte();
                }
                //Reverse byte order
                offset = (bytes[3] << 24) + (bytes[2] << 16) + (bytes[1] << 8) + (bytes[0]);
                if (offset != fileSize)
                {
                    //lookup.addOffset(offset);
                    //Output OffSet location
                    addLVItoLV(lvItemList, i + 1, offset, lookup.getName(offset + ""));
                }
            }
            lvItemList.Columns[0].Width = -1;
            lvItemList.Columns[1].Width = -1;
            lvItemList.Columns[2].Width = -1;
            NUMOFSKINS = i-1;
            fsStream.Close();
            return isLBA1File(fileSize);
        }


        private void addLVItoLV(ListView lv, int pos, int offset, string name)
        {            
            ListViewItem x = new ListViewItem(pos + "");
            x.SubItems.Add(offset + "");
            x.SubItems.Add(name);
            lv.Items.Add((ListViewItem)x.Clone());
        }

        /**
         * This randomises all selected skins
         * in the given range from txtRandomFirst.text > txtRandomLast.txt
         */
        private void btnRandomiseRange_Click(object sender, EventArgs e)
        {
            int rangeFirst, rangeLast;
            //Check for valid converstion
            if (!(int.TryParse(txtRandomFirst.Text, out rangeFirst)) || (!int.TryParse(txtRandomLast.Text, out rangeLast)))
            {
                MessageBox.Show("Error: Invalid range selected. Please enter a number into both boxes");
                return;
            }
            if (rangeFirst > rangeLast)
            {
                MessageBox.Show("Error: First must be lower than Last");
                return;
            }
            if(rangeLast > lookup.getOffsetSize())
            {
                MessageBox.Show("Error: end is higher than list count");
                return;
            }
            if(rangeFirst<1)
            {
                return;
            }
            randomiseRange(rangeFirst, rangeLast, 1, NUMOFSKINS);
        }

        /** Randomises skins start to end i.e. 1-9, 
         * with skins in the range of startPos - end pos
         */ 
        private void randomiseRange(int start, int end, int startPos, int endPos)
        {
            Random random = new Random();
            for (int i=start-1;i<end;i++)
            {
                updateLVI(lvItemList, i, lookup.getOffset(random.Next(startPos, endPos)));
            }
        }

        /** 
         * This swaps the offset in the LV at position A, with the offset at position B
            Then updates the name accordingly
        */
        private void swapLVI(ListView lv, int indexA, int indexB, bool swap = true)
        {
            string offset;
            //Decrement to correct for first position being 0 not 1
            --indexA;
            --indexB;
            //There's no point swapping with ourself
            if (indexA == indexB) return;
            //Backup A
            offset = lv.Items[indexA].SubItems[1].Text;
            //Set A to B
            updateLVI(lv, indexA, lv.Items[indexB].SubItems[1].Text);
            if (swap)
            {
                //Set B to backup
                updateLVI(lv, indexB, offset);
            }
        }

        private void updateLVI(ListView lv, int index, string newOffset)
        {
            lv.Items[index].SubItems[1].Text = newOffset; 
            lv.Items[index].SubItems[2].Text = lookup.getName(newOffset);
        }

        private void btnSet0_Click(object sender, EventArgs e)
        {            
            if (1 != lvItemList.SelectedItems.Count)
            {
                MessageBox.Show("Error: More or less than one line selected");
                return; //Check we have one and only one item selected
            }
            lblSwap0.Text = lvItemList.SelectedItems[0].SubItems[0].Text ;
        }

        private void btnSet1_Click(object sender, EventArgs e)
        {
            if (1 != lvItemList.SelectedItems.Count)
            {
                MessageBox.Show("Error: More or less than one line selected");
                return; //Check we have one and only one item selected
            }
            lblSwap1.Text = lvItemList.SelectedItems[0].SubItems[0].Text;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            int.TryParse(lblSwap0.Text, out a);
            int.TryParse(lblSwap1.Text, out b);
            swapLVI(lvItemList, a, b, chkBtoA.Checked);
        }

        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {
            int i;
            string str;
            if (0 >= lookup.getOffsetSize())
            {
                lookup = new LookupLBABody(true); //ToDo Fix this shit
                
                Console.WriteLine("Size: " + lookup.getOffsetSize());
                MessageBox.Show("Fix this!");
            }
            for (i=0;i< NUMOFSKINS;i++)
            {
                str = lookup.getOffset(i);
                Console.WriteLine(str);
                updateLVI(lvItemList, i, lookup.getOffset(i));
            }
        }


        /**
         * Sets a range of entries as dictated by "start" and "end"
         * to a single entry as specified by "offset"
         */
        private void setRangeToSingle(int start, int end, string offset)
        {
            for (--start; start < end; start++)
                updateLVI(lvItemList, start, offset);
        }

        //Replaces entries 10-132 with selected item
        private void btnReplaceRange_Click(object sender, EventArgs e)
        {
            int rangeFirst, rangeLast;
            //Check for valid converstion
            if (!(int.TryParse(txtReplaceFirst.Text, out rangeFirst)) || (!int.TryParse(txtReplaceLast.Text, out rangeLast)))
            {
                MessageBox.Show("Error: Invalid range selected. Please enter a number into both boxes");
                return;
            }
            if(rangeFirst> rangeLast)
            {
                MessageBox.Show("Error: First must be lower than Last");
                return;
            }
            if(rangeLast > lookup.getOffsetSize())
            {
                MessageBox.Show("Error: Last more than list size");
                return;
            }
            if (1 != lvItemList.SelectedItems.Count)
            {
                MessageBox.Show("Please select a single row to continue");
                return; //Check we have one and only one item selected
            }
            if(1 > rangeFirst)
            {
                return;
            }
            setRangeToSingle(rangeFirst, rangeLast, lvItemList.SelectedItems[0].SubItems[1].Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile(txtBodyLoc.Text);
        }

        private void saveFile(string path)
        {
            int i, offset;   
            byte[] b = new byte[4]; 

            //Check if the file exists and if it doesn't "create" it
            if(!File.Exists(path))
            {
                //We use the input file as a donar file, as that contains the data we don't store
                File.Copy(txtBodyLoc.Text, path, false);
            }
            FileStream fsStream;
            try
            {
                fsStream = new FileStream(path, FileMode.Open, FileAccess.Write);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
            //For each entry in the listview
            for (i = 0; i < lvItemList.Items.Count; i++)
            {
                //Convert the selected offset from a string to an int
                int.TryParse(lvItemList.Items[i].SubItems[1].Text, out offset);

                //Translate the bytes to the correct order 
                //as it's stored backwards
                b[0] = (byte)(offset & 0x000000FF);
                b[1] = (byte)((offset & 0x0000FF00) >> 8);
                b[2] = (byte)((uint)(offset & 0x00FF0000) >> 16);
                b[3] = (byte)((uint)(offset & 0xFF000000) >> 24);

                for (int j = 0; j < 4; j++)
                {
                    fsStream.WriteByte(b[j]);
                }
            }
            //Clean up and close the stream/file pointer
            fsStream.Close();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "BODY.HQR";
            // set filters - this can be done in properties as well
            savefile.Filter = "BODY HQR (BODY.HQR)|*.HQR|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                saveFile((savefile.FileName));
            }
        }

        /**
         * We return 
         *     - true if any of our LBA1 checks pass
         *     - false if any of our LBA2 checks pass
         *     - null if no checks pass
         */
        private Nullable<bool> isLBA1File(long fileSize)
        {
            /* //Correct first offset for LBA1
            if ("532" == lvItemList.Items[0].SubItems[0].Text)
                return true;
            //Correct first offset for LBA2
            if ("1880" == lvItemList.Items[0].SubItems[0].Text)
                return true;*/
            //Typically LBA1 contains 132 entries
            /*if (132 == lvItemList.Items.Count)
                return true;
            if (469 == lvItemList.Items.Count)
                return false;*/
             //Correct original filesize for LBA1
            if (396854 == fileSize)
                return true;
            //Standard filesize for LBA2
            if (2197406 == fileSize)
                return false; 
            return null;
        }

        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            int r = 0;
            try
            {
                int.TryParse(txtSeconds.Text, out r);
            }
            catch { };
            if (0 == r)
            {
                btnRestoreDefault_Click(null, null);
                randomiseRange(1, lvItemList.Items.Count, 1, lvItemList.Items.Count);
                saveFile(txtBodyLoc.Text + "_");
                File.Copy(txtBodyLoc.Text+"_", txtBodyLoc.Text, true);
                //reset timer
                txtSeconds.Text = timeSeconds.ToString();
            }
            else
               txtSeconds.Text = --r + "";
        }

        private void btnAutoSwap_Click(object sender, EventArgs e)
        {
            if ("Auto" == btnAutoSwap.Text)
            {
                if (DialogResult.OK == MessageBox.Show("This will over write your BODY.HQR file at location: " + txtBodyLoc.Text +
                                " every '" + txtSeconds.Text + "' seconds until you hit stop",
                                "Critical Warning",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2)
                )
                {
                    btnAutoSwap.Text = "Stop";
                    timeSeconds = 0;
                    int.TryParse(txtSeconds.Text, out timeSeconds);
                    tmrTick.Interval = 1000;
                    tmrTick.Start();
                }
            }
            else
            {
                btnAutoSwap.Text = "Auto";
                tmrTick.Stop();
            }
        }
    }

    /*
     * Known file format
     * four byte offset location i.e. 02 00 00 00 == file offset byte 2.
     * There can be many four byte offsets stored consecutively.
     * The location of the first offset is at (4 * numberOfOffsets) + 4 byte space.
     * The four byte space after the last file offset is equal to the file size in bytes
     * 
     * 04 1a 00 00 2c 10 00 00 01 00
     * So that's the first 10 bytes at the start of the location a skin is stored at. 
     * The first four bytes are the original size, the second to last byte is a compressed flag. 
     * I'm still working on the rest
     * 
     * So that's the 10 bytes of padding 1-4 original size, 
     * 5-8 packed size, byte 9 compressed flag, or possibly 9 - 10 are compressed flags
     */
}
