using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_1
{
	public partial class highscoresForm : Form
	{
		public highscoresForm()
		{
			InitializeComponent();
		}

		private void highscoresForm_Load(object sender, EventArgs e)
		{
			//////////////////////////////////////////////////////////////////////////
			BinaryFormatter bf = new BinaryFormatter();
			Stream ls = new FileStream("Best_Player.dat", FileMode.OpenOrCreate);
			Highscore No1 = (Highscore)bf.Deserialize(ls);
			ls.Close();
			richTextBox1.Text = No1.name + " " + No1.score;
			//////////////////////////////////////////////////////////////////////////
			richTextBox2.LoadFile("Scores.txt", RichTextBoxStreamType.PlainText);
			string[] nameArray = new string[richTextBox2.Lines.Count()];
			int[] scoreArray = new int[richTextBox2.Lines.Count()];
			int count = 0;
			foreach (string s in richTextBox2.Lines)//diavazei tis grammes tou file apo to testbox
			{
				String[] tmp = s.Split(' ');//xwrizei ta stoixeia kathe grammes
				nameArray[count] = tmp[0];
				scoreArray[count] = Int32.Parse(tmp[1]);
				count++;
			}
			bubble(nameArray, scoreArray);
		}

		private void bubble(string[] names, int[] scores)
		{
			int temp;
			string temp2;
			for (int i = 0; i < richTextBox2.Lines.Count(); i++)
			{
				for (int j = 0; j < richTextBox2.Lines.Count() - 1; j++)
				{
					if (scores[j] < scores[j + 1])
					{
						temp = scores[j + 1];
						scores[j + 1] = scores[j];
						scores[j] = temp;
						temp2 = names[j + 1];
						names[j + 1] = names[j];
						names[j] = temp2;
					}
				}
			}
			
			int scoreNum;
			if (richTextBox2.Lines.Count() >= 10)
			{
				scoreNum = 10;
			}
			else
			{
				scoreNum = richTextBox2.Lines.Count();
			}

			richTextBox2.Text = "";

			for (int i = 0; i < scoreNum; i++)
			{
				richTextBox2.AppendText(names[i] + " " + scores[i] + Environment.NewLine);
			}
		}
	}
}
