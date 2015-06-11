using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LanguageTeacher
{
    public partial class Form1 : Form
    {
        Business business = new Business();
        Random r = new Random();
        List<decimal> wordsLeft = new List<decimal>();
        int currentPosInWordsLeft = 0;
        int correctAnsware = 0;
        int numberOfCorect;
        int numberOfWrong;
        int numberOfHits;

        DataSet1.WordsRow currentRow = null;
        public Form1()
        {
            InitializeComponent();

            comboBoxClass.Items.Add("");
            comboBoxClass.Items.Add("con");

            business.Load();
            bindingSource1.DataSource = business.DataSet;
            StartGame();
        }

        private void StartGame()
        {
            wordsLeft.Clear();
            foreach (DataSet1.WordsRow row in business.DataSet.Words.Rows)
            {
                if (!row.Guessed)
                {
                    if (comboBoxClass.SelectedItem == null || comboBoxClass.SelectedItem == "" || comboBoxClass.SelectedItem.ToString() == row.Class)
                    {
                        wordsLeft.Add(row.ID);
                    }
                }
            }
            FillGame();
        }

        private void FillGame()
        {
            List<Decimal> usedEntries = new List<decimal>();
            listBoxOptions.Items.Clear();
            //bool rightClass = false;
            //while (!rightClass)
            {
            currentPosInWordsLeft = r.Next(wordsLeft.Count-1);
            usedEntries.Add(currentPosInWordsLeft);
            currentRow = (DataSet1.WordsRow)business.DataSet.Words.Rows[(int)wordsLeft.ElementAt(currentPosInWordsLeft)-1];
            //if (comboBoxClass.SelectedItem == "" || comboBoxClass.SelectedItem == currentRow.Class)
                {
                    //rightClass = true;
                }
            }
            textBoxCurrentWord.Text = currentRow.Foreign;

            correctAnsware = r.Next(5);

            for (int i = 0; i < 5; i++)
            {
                if (i == correctAnsware)
                {
                    listBoxOptions.Items.Add(currentRow.Native);
                }
                else
                {
                    int nextSugestion = currentPosInWordsLeft;
                    bool enoughResources = wordsLeft.Count > 5;
                    nextSugestion = r.Next(wordsLeft.Count - 1);
                    while (usedEntries.Contains(nextSugestion) && enoughResources)
                    {
                        nextSugestion = r.Next(wordsLeft.Count - 1);
                    }
                    usedEntries.Add(nextSugestion);

                    DataSet1.WordsRow optionRow = (DataSet1.WordsRow)business.DataSet.Words.Rows[(int)wordsLeft.ElementAt(nextSugestion)-1];
                    listBoxOptions.Items.Add(optionRow.Native);
                }
            }
        }

        private void listBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wordsLeft.Count == 0)
            {
                return;
            }
            if (listBoxOptions.SelectedIndex == correctAnsware)
            {
                labelAnsware.ForeColor = Color.Green;
                labelAnsware.Text = textBoxCurrentWord.Text + " = " + listBoxOptions.SelectedItem;
                numberOfHits++;
                numberOfCorect++;
                wordsLeft.RemoveAt(currentPosInWordsLeft);
            }
            else
            {
                labelAnsware.ForeColor = Color.Red;
                labelAnsware.Text = textBoxCurrentWord.Text + " <> " + listBoxOptions.SelectedItem;
                numberOfHits++;
                numberOfWrong++;
                currentRow.Difficulty++;
            }
            labelStatistics.Text = numberOfCorect + " / " + business.DataSet.Words.Rows.Count + " After " + numberOfHits + " hits " + wordsLeft.Count + " left";
            if (wordsLeft.Count > 0)
            {
                FillGame();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataSet1.WordsRow row in business.DataSet.Words.Rows)
            {
                sb.AppendLine(row.Foreign + "," + row.Native + "," + (row.Difficulty != null ? row.Difficulty : 0) + "," + (row.Class !=null ? row.Class : ""));
            }
            business.Save(sb.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataSet1.WordsRow row = (DataSet1.WordsRow)((DataRowView)bindingSource1.Current).Row;
            row.ID = bindingSource1.Count + 1;
            row.Class = "";
            row.Difficulty = 0;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartGame();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
