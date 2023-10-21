using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace week7_rpruitt
{
    public partial class GuestLogForm : Form
    {
        public GuestLogForm()
        {
            InitializeComponent();
        }
        private IEnumerable<Guests> guestList;
        private void button1_Click(object sender, EventArgs e)
        {
            GuestLogForm_Load(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuestLogForm_Load(object sender, EventArgs e)
        {
            guestList = DBHelper.GuestGet();
            PopulateList(guestList, AddItemStandard);
        }

        private void guestsHaveNotSignedOutOver30DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateList(guestList, GuestGreaterThan48Hours);
        }

        private void tenetsWithGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateList(guestList, ApartmentHasGuests);
        }

        private delegate void AddItem(ListViewItem item1);

        private void PopulateList(IEnumerable<Guests> guestList, AddItem delegateFunc)
        {
            listView1.Clear();
            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("LastName");
            listView1.Columns.Add("SignedInStatus");
            listView1.Columns.Add("TimeStamp");
            listView1.Columns.Add("Apartment#");

            foreach (var guest in guestList)
            {
                var item1 = new ListViewItem(new[] { guest.FirstName, guest.LastName, guest.SignedInStatus.ToString(), guest.LastModified.ToString(), guest.ApartmentId });

                delegateFunc(item1);
            }

            listView1.View = View.Details;
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void GuestGreaterThan48Hours(ListViewItem item1)
        {
            DateTime timestamp = DateTime.Parse(item1.SubItems[3].Text);
            if (timestamp < DateTime.Now.AddHours(-48) && item1.SubItems[2].Text == "True")
            {
                listView1.Items.Add(item1).BackColor = Color.Red;
            }
            else
            {
                listView1.Items.Add(item1);
            }

        }

        private void ApartmentHasGuests(ListViewItem item1)
        {
            if (item1.SubItems[2].Text == "True")
            {
                listView1.Items.Add(item1).BackColor = Color.Red;
            }
            else
            {
                listView1.Items.Add(item1);
            }

        }

        private void AddItemStandard(ListViewItem item1)
        {
            listView1.Items.Add(item1);
        }
    }
}