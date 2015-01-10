using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Segment_Compatibility
{
    public partial class SegmentVerifierFrm : Form
    {

        // pos, present or not , [chr]
        HashSet<long>[] c_23andme_v2 = new HashSet<long>[23];
        HashSet<long>[] c_23andme_v3 = new HashSet<long>[23];
        HashSet<long>[] c_23andme_v4 = new HashSet<long>[23];
        HashSet<long>[] c_ancestry = new HashSet<long>[23];
        HashSet<long>[] c_ftnda_a = new HashSet<long>[23];
        HashSet<long>[] c_ftdna_i = new HashSet<long>[23];

        SortedSet<long>[] positions = new SortedSet<long>[23];
        string detailed_filename = null;
        string[] kit_versions = new string[] { "23andMe V2", "23andMe V3", "23andMe V4", "Ancestry", "FTDNA Affymetrix", "FTDNA Illumina" };

        bool loading = true;

        public SegmentVerifierFrm()
        {
            InitializeComponent();
        }

        private void SegmentVerifierFrm_Load(object sender, EventArgs e)
        {
            cb_Chr.SelectedIndex = 0;
            cb_Company.SelectedIndex = 5;
            cb_MCompany.SelectedIndex = 2;
            statusLbl.Text = "Loading map ...";
            btn_Verify.Enabled = false;
            btnDownload.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        public byte[] Zip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }

        public void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLbl.Text = "Done.";
            btn_Verify.Enabled = true;
            btnDownload.Enabled = true;
            loading = false;
            updateMaxMin();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string map = Encoding.UTF8.GetString(Unzip(Segment_Compatibility.Properties.Resources.compatibility_map));
            StringReader reader = new StringReader(map);
            string line = null;
            string[] data=null;
            reader.ReadLine();// skip first line.
            int chr = 0;
            long pos = 0;

            for (int i = 0; i < 23;i++)
            {
                c_23andme_v2[i] = new HashSet<long>();
                c_23andme_v3[i] = new HashSet<long>();
                c_23andme_v4[i] = new HashSet<long>();
                c_ancestry[i] = new HashSet<long>();
                c_ftnda_a[i] = new HashSet<long>();
                c_ftdna_i[i] = new HashSet<long>();
                positions[i] = new SortedSet<long>();
            }


                while ((line = reader.ReadLine()) != null)
                {
                    data = line.Split(new char[] { '\t' });

                    chr = int.Parse(data[1]);
                    pos = long.Parse(data[2]);

                    positions[chr - 1].Add(pos);

                    if (data[3] == "Y")
                    {
                        //23andme_v2
                        c_23andme_v2[chr - 1].Add(pos);
                    }


                    if (data[4] == "Y")
                    {
                        //23andme_v3
                        c_23andme_v3[chr - 1].Add(pos);
                    }

                    if (data[5] == "Y")
                    {
                        //23andme_v4
                        c_23andme_v4[chr - 1].Add(pos);
                    }

                    if (data[6] == "Y")
                    {
                        //ancestry
                        c_ancestry[chr - 1].Add(pos);
                    }

                    if (data[7] == "Y")
                    {
                        //ftdna_affymetrix
                        c_ftnda_a[chr - 1].Add(pos);
                    }

                    if (data[8] == "Y")
                    {
                        //ftdna_illumina
                        c_ftdna_i[chr - 1].Add(pos);
                    }

                }
                reader.Close();
        }

        private void cb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if(!loading)
                updateMaxMin();
        }

        private void cb_Chr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
                updateMaxMin();
        }

        private void updateMaxMin()
        {
            switch (cb_Company.SelectedIndex)
            {
                case 0:
                    updateMaxMinChr(c_23andme_v2[cb_Chr.SelectedIndex]);
                    break;
                case 1:
                    updateMaxMinChr(c_23andme_v3[cb_Chr.SelectedIndex]);
                    break;
                case 2:
                    updateMaxMinChr(c_23andme_v4[cb_Chr.SelectedIndex]);
                    break;
                case 3:
                    updateMaxMinChr(c_ancestry[cb_Chr.SelectedIndex]);
                    break;
                case 4:
                    updateMaxMinChr(c_ftnda_a[cb_Chr.SelectedIndex]);
                    break;
                case 5:
                    updateMaxMinChr(c_ftdna_i[cb_Chr.SelectedIndex]);
                    break;
            }
        }

        private void updateMaxMinChr(HashSet<long> chr)
        {
            lbl_min.Text = "Min: " + chr.Min();
            lbl_max.Text = "Max: " + chr.Max();
            
            if (long.Parse(tb_Start.Text) < chr.Min())
                tb_Start.Text = chr.Min().ToString();

            if (long.Parse(tb_End.Text) > chr.Max())
                tb_End.Text = chr.Max().ToString();

            if (long.Parse(tb_Start.Text) > long.Parse(tb_End.Text))
                tb_End.Text = (long.Parse(tb_Start.Text)+1000000).ToString();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "Please wait ...";
            updateMaxMin();
            timer1.Enabled = true;
            btn_Verify.Enabled = false;
            btnDownload.Enabled = false;
        }

        private void countSNPs()
        {
            long start= long.Parse(tb_Start.Text);
            long end = long.Parse(tb_End.Text);
            dgOutput.Rows.Clear();

            dgOutput.Rows.Add(new string[] { kit_versions[0], getSNPCount(c_23andme_v2[cb_Chr.SelectedIndex], start, end) });
            dgOutput.Rows.Add(new string[] { kit_versions[1], getSNPCount(c_23andme_v3[cb_Chr.SelectedIndex], start, end) });
            dgOutput.Rows.Add(new string[] { kit_versions[2], getSNPCount(c_23andme_v4[cb_Chr.SelectedIndex], start, end) });
            dgOutput.Rows.Add(new string[] { kit_versions[3], getSNPCount(c_ancestry[cb_Chr.SelectedIndex], start, end) });
            dgOutput.Rows.Add(new string[] { kit_versions[4], getSNPCount(c_ftnda_a[cb_Chr.SelectedIndex], start, end) });
            dgOutput.Rows.Add(new string[] { kit_versions[5], getSNPCount(c_ftdna_i[cb_Chr.SelectedIndex], start, end) });

        }

        private string getSNPCount(HashSet<long> db, long start, long end)
        {
            int chr = cb_Chr.SelectedIndex;
            long idx_start = start;
            for(long i=start;i<int.MaxValue;i++)
            {
                if (positions[chr].Contains(i))
                {
                    idx_start = i;
                    break;
                }
            }
            long idx_end = end;
            for (long i = end; i < int.MaxValue; i++)
            {
                if (positions[chr].Contains(i))
                {
                    idx_end = i;
                    break;
                }
            }

            int snps_count = db.Count(val => (val >= idx_start && val <= idx_end));
            return snps_count.ToString();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV files|*.csv";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                statusLbl.Text = "Saving file ... "+dlg.FileName;
                string chr_selected = (cb_Chr.SelectedIndex + 1).ToString();
                if (chr_selected == "23")
                    chr_selected = "X";
                backgroundWorker2.RunWorkerAsync(new string[]{dlg.FileName,chr_selected});
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;            
            countSNPs();
            dgOutput.ClearSelection();
            getOverLaps();
            btn_Verify.Enabled = true;
            btnDownload.Enabled = true;
            statusLbl.Text = "Done.";
            long start = long.Parse(tb_Start.Text);
            long end = long.Parse(tb_End.Text);
            long snp_count_required = (end - start)/10000;
            if (snp_count_required < 150)
                snp_count_required = 150;
            if (int.Parse(lbl_Overlap.Text) > snp_count_required * 0.9 && int.Parse(lbl_Overlap.Text) < snp_count_required)
            {
                MessageBox.Show("Verification barely passed.\r\n\r\nIn order to confirm this segment, you need to have a minimum of " + snp_count_required.ToString() + " SNPs for the segment [Chr" + cb_Chr.SelectedItem + ":" + start.ToString() + "-" + end.ToString() + "]. But you have " + lbl_Overlap.Text + " SNPs.", "Barely Passed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(lbl_Overlap.Text) < snp_count_required)
            {
                MessageBox.Show("Verification failed.\r\n\r\nIn order to confirm this segment, you need to have a minimum of " + snp_count_required.ToString() + " SNPs for the segment [Chr" + cb_Chr.SelectedItem + ":" + start.ToString() + "-" + end.ToString() + "]. But you only have " + lbl_Overlap.Text + " SNPs.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Verification passed.\r\n\r\nYou have " + lbl_Overlap.Text + " SNPs for the segment [Chr" + cb_Chr.SelectedItem + ":" + start.ToString() + "-" + end.ToString() + "].", "Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getOverLaps()
        {
            HashSet<long> c1 = null;
            HashSet<long> c2 = null;
            switch (cb_Company.SelectedIndex)
            {
                case 0:
                    c1=c_23andme_v2[cb_Chr.SelectedIndex];
                    break;
                case 1:
                    c1=c_23andme_v3[cb_Chr.SelectedIndex];
                    break;
                case 2:
                    c1=c_23andme_v4[cb_Chr.SelectedIndex];
                    break;
                case 3:
                   c1=c_ancestry[cb_Chr.SelectedIndex];
                    break;
                case 4:
                   c1=c_ftnda_a[cb_Chr.SelectedIndex];
                    break;
                case 5:
                   c1=c_ftdna_i[cb_Chr.SelectedIndex];
                    break;
            }
            //
            switch (cb_MCompany.SelectedIndex)
            {
                case 0:
                    c2=c_23andme_v2[cb_Chr.SelectedIndex];
                    break;
                case 1:
                    c2=c_23andme_v3[cb_Chr.SelectedIndex];
                    break;
                case 2:
                    c2=c_23andme_v4[cb_Chr.SelectedIndex];
                    break;
                case 3:
                   c2=c_ancestry[cb_Chr.SelectedIndex];
                    break;
                case 4:
                   c2=c_ftnda_a[cb_Chr.SelectedIndex];
                    break;
                case 5:
                   c2=c_ftdna_i[cb_Chr.SelectedIndex];
                    break;
            }
            long start = long.Parse(tb_Start.Text);
            long end = long.Parse(tb_End.Text);

            lbl_Overlap.Text = getOverLaps(c1,c2, start, end);
        }

        private string getOverLaps(HashSet<long> c1, HashSet<long> c2, long start, long end)
        {
            int chr = cb_Chr.SelectedIndex;
            long idx_start = start;
            for (long i = start; i < int.MaxValue; i++)
            {
                if (positions[chr].Contains(i))
                {
                    idx_start = i;
                    break;
                }
            }
            long idx_end = end;
            for (long i = end; i < int.MaxValue; i++)
            {
                if (positions[chr].Contains(i))
                {
                    idx_end = i;
                    break;
                }
            }

            int snps_count = c1.Intersect(c2).Count(val => (val >= idx_start && val <= idx_end));
            return snps_count.ToString();

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            string[] args = ((string[])e.Argument);
            
            detailed_filename = args[0];
            string chr_selected = args[1];

            StringBuilder sb = new StringBuilder();           
            string map = Encoding.UTF8.GetString(Unzip(Segment_Compatibility.Properties.Resources.compatibility_map));
            StringReader reader = new StringReader(map);
            string line = null;
            string[] data = null;

            int chr = 0;
            long pos = 0;

            long start = long.Parse(tb_Start.Text);
            long end = long.Parse(tb_End.Text);
            

            sb.Append(reader.ReadLine().Replace('\t', ','));
            sb.Append("\r\n");

            while ((line = reader.ReadLine()) != null)
            {
                data = line.Split(new char[] { '\t' });

                chr = int.Parse(data[1]);
                pos = long.Parse(data[2]);

                if (chr.ToString() == chr_selected)
                {
                    if (pos >= start && pos <= end)
                    {
                        sb.Append(line.Replace('\t', ','));
                        sb.Append("\r\n");
                    }
                }
            }
            reader.Close();
            File.WriteAllText(detailed_filename, sb.ToString());
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (detailed_filename!=null)
                statusLbl.Text = "File '" + detailed_filename+"' saved.";
        }
    }
}
