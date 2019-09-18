using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxRNG
{
    public partial class Form1 : Form
    {
        private string line;
        const string file = @"savedmovies.txt";
        public Form1()
        {
            InitializeComponent();
            try
            {
            using (StreamReader sr = new StreamReader(file))
                while ((line = sr.ReadLine()) != null)
                {
                    listBox.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                resultsLabel.Text = "Error: " + ex.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file);
                foreach(var item in listBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                resultsLabel.Text = "Error: " + ex.ToString();
            }
        }

        private void rngButton_Click(object sender, EventArgs e)
        {
            var random = new Random();

            int index = random.Next(0, listBox.Items.Count);
            resultsLabel.Text = listBox.Items[index].ToString();
            listBox.SetSelected(index,true);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(addBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox);
            selectedItems = listBox.SelectedItems;

            if (listBox.SelectedIndex != 1)
            {
                for (int i =selectedItems.Count -1; i >=0; i--)
                {
                    listBox.Items.Remove(selectedItems[i]);
                }
            }
        }
    }
}
