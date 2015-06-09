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
            business.Load();
            bindingSource1.DataSource = business.DataSet;
            StartGame();
        }

        private void StartGame()
        {
            foreach (DataSet1.WordsRow row in business.DataSet.Words.Rows)
            {
                if (!row.Guessed)
                {
                    wordsLeft.Add(row.ID);
                }
            }
            FillGame();
        }

        private void FillGame()
        {
            listBoxOptions.Items.Clear();
            currentPosInWordsLeft = r.Next(wordsLeft.Count-1);
            currentRow = (DataSet1.WordsRow)business.DataSet.Words.Rows[(int)wordsLeft.ElementAt(currentPosInWordsLeft)-1];
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
                    DataSet1.WordsRow optionRow = (DataSet1.WordsRow)business.DataSet.Words.Rows[(int)wordsLeft.ElementAt(r.Next(wordsLeft.Count-1))-1];
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
                sb.AppendLine(row.Foreign + "," + row.Native+ "," + row.Difficulty);
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
            ((DataSet1.WordsRow)((DataRowView)bindingSource1.Current).Row).ID = bindingSource1.Count + 1;
        }
    }
}
