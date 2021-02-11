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

	public partial class Form1 : Form
	{

		string PATH;

		List<PictureBox> pictureBoxes;

		Random r = new Random();

		
		Highscore No1;

		int firstClick;
		int secondClick;
		bool attemp = false;

		int first, second;

		int time = 0;

		int totalAttemps;

		int score;

		int[] firstArray;
		int[] secondArray;
		string[] finalArray;

		public Form1()
		{
			InitializeComponent();
			PATH = Application.StartupPath;
			if (new FileInfo("Best_Player.dat").Length == 0)
			{
				No1 = new Highscore();
				No1.name = "CPU";
				No1.score = 0;
				BinaryFormatter bf = new BinaryFormatter();
				Stream ls = new FileStream("Best_Player.dat", FileMode.OpenOrCreate);
				bf.Serialize(ls, No1);
				ls.Close();
			}
			else
			{
				BinaryFormatter bf = new BinaryFormatter();
				Stream ls = new FileStream("Best_Player.dat", FileMode.OpenOrCreate);
				Highscore No1 = (Highscore)bf.Deserialize(ls);
				ls.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label7.Text = "";
			totalAttemps = 0;
			pictureBoxes = new List<PictureBox>();
			pictureBox1.ImageLocation = "hiding.JPG";
			pictureBox2.ImageLocation = "hiding.JPG";
			pictureBox3.ImageLocation = "hiding.JPG";
			pictureBox4.ImageLocation = "hiding.JPG";
			pictureBox5.ImageLocation = "hiding.JPG";
			pictureBox6.ImageLocation = "hiding.JPG";
			pictureBox7.ImageLocation = "hiding.JPG";
			pictureBox8.ImageLocation = "hiding.JPG";
			pictureBox9.ImageLocation = "hiding.JPG";
			pictureBox10.ImageLocation = "hiding.JPG";
			pictureBox11.ImageLocation = "hiding.JPG";
			pictureBox12.ImageLocation = "hiding.JPG";
			pictureBox13.ImageLocation = "hiding.JPG";
			pictureBox14.ImageLocation = "hiding.JPG";
			pictureBox15.ImageLocation = "hiding.JPG";
			pictureBox16.ImageLocation = "hiding.JPG";
			pictureBox17.ImageLocation = "hiding.JPG";
			pictureBox18.ImageLocation = "hiding.JPG";
			pictureBox19.ImageLocation = "hiding.JPG";
			pictureBox20.ImageLocation = "hiding.JPG";
			pictureBox21.ImageLocation = "hiding.JPG";
			pictureBox22.ImageLocation = "hiding.JPG";
			pictureBox23.ImageLocation = "hiding.JPG";
			pictureBox24.ImageLocation = "hiding.JPG";
			label4.Text = "0";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(PATH);
			textBox1.ReadOnly = true;
			if (String.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Please insert a name");
			}
			else
			{
				button1.Enabled = false;
				firstArray = new int[12];
				shuffleArray(firstArray);
				secondArray = new int[12];
				shuffleArray(secondArray);
				time = 0;
				finalArray = new string[24];
				finalArray = fillStringArray(firstArray, secondArray, finalArray);
				pictureBox1.ImageLocation = finalArray[0];
				pictureBox2.ImageLocation = finalArray[1];
				pictureBox3.ImageLocation = finalArray[2];
				pictureBox4.ImageLocation = finalArray[3];
				pictureBox5.ImageLocation = finalArray[4];
				pictureBox6.ImageLocation = finalArray[5];
				pictureBox7.ImageLocation = finalArray[6];
				pictureBox8.ImageLocation = finalArray[7];
				pictureBox9.ImageLocation = finalArray[8];
				pictureBox10.ImageLocation = finalArray[9];
				pictureBox11.ImageLocation = finalArray[10];
				pictureBox12.ImageLocation = finalArray[11];
				pictureBox13.ImageLocation = finalArray[12];
				pictureBox14.ImageLocation = finalArray[13];
				pictureBox15.ImageLocation = finalArray[14];
				pictureBox16.ImageLocation = finalArray[15];
				pictureBox17.ImageLocation = finalArray[16];
				pictureBox18.ImageLocation = finalArray[17];
				pictureBox19.ImageLocation = finalArray[18];
				pictureBox20.ImageLocation = finalArray[19];
				pictureBox21.ImageLocation = finalArray[20];
				pictureBox22.ImageLocation = finalArray[21];
				pictureBox23.ImageLocation = finalArray[22];
				pictureBox24.ImageLocation = finalArray[23];
				timer2.Enabled = true;

				button1.Enabled = true;
			}
		}

		int[] fillArray(int[] numbers)
		{
			for (int i = 0; i < 12; i++)
			{
				numbers[i] = i + 1;
			}
			return numbers;
		}

		string[] fillStringArray(int[] numbers1, int[] numbers2, string[] strings)
		{
			for (int i = 0; i < 12; i++)
			{
				strings[i] =  PATH + "/" + numbers1[i].ToString();
				strings[i + 12] = PATH + "/" + numbers2[i].ToString();
				strings[i] += ".JPG";
				strings[i + 12] += ".JPG";
			}
			return strings;
		}

		int[] shuffleArray(int[] numbers)
		{
			numbers = fillArray(numbers);
			// Knuth shuffle algorithm :: courtesy of Wikipedia :)
			for (int i = 0; i < 12; i++)
			{
				int temp = numbers[i];
				int pos = r.Next(i, numbers.Length);
				numbers[i] = numbers[pos];
				numbers[pos] = temp;
			}
			return numbers;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			time++;
			label4.Text = time.ToString();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (time < 6)
			{
				time++;
			}
			else
			{
				pictureBox1.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox1);
				pictureBox2.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox2);
				pictureBox3.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox3);
				pictureBox4.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox4);
				pictureBox5.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox5);
				pictureBox6.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox6);
				pictureBox7.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox7);
				pictureBox8.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox8);
				pictureBox9.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox9);
				pictureBox10.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox10);
				pictureBox11.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox11);
				pictureBox12.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox12);
				pictureBox13.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox13);
				pictureBox14.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox14);
				pictureBox15.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox15);
				pictureBox16.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox16);
				pictureBox17.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox17);
				pictureBox18.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox18);
				pictureBox19.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox19);
				pictureBox20.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox20);
				pictureBox21.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox21);
				pictureBox22.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox22);
				pictureBox23.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox23);
				pictureBox24.ImageLocation = "hiding.JPG";
				pictureBoxes.Add(pictureBox24);
				time = 0;
				timer1.Enabled = true;
				timer2.Stop();
			}


		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 1;
				attemp = true;
			}
			else
			{
				secondClick = 1;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 2;
				attemp = true;
			}
			else
			{
				secondClick = 2;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 3;
				attemp = true;
			}
			else
			{
				secondClick = 3;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 4;
				attemp = true;
			}
			else
			{
				secondClick = 4;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 5;
				attemp = true;
			}
			else
			{
				secondClick = 5;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 6;
				attemp = true;
			}
			else
			{
				secondClick = 6;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 12;
				attemp = true;
			}
			else
			{
				secondClick = 12;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 11;
				attemp = true;
			}
			else
			{
				secondClick = 11;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 10;
				attemp = true;
			}
			else
			{
				secondClick = 10;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 9;
				attemp = true;
			}
			else
			{
				secondClick = 9;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 8;
				attemp = true;
			}
			else
			{
				secondClick = 8;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 7;
				attemp = true;
			}
			else
			{
				secondClick = 7;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox24_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 24;
				attemp = true;
			}
			else
			{
				secondClick = 24;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox23_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 23;
				attemp = true;
			}
			else
			{
				secondClick = 23;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox22_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 22;
				attemp = true;
			}
			else
			{
				secondClick = 22;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox21_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 21;
				attemp = true;
			}
			else
			{
				secondClick = 21;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox20_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 20;
				attemp = true;
			}
			else
			{
				secondClick = 20;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox19_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 19;
				attemp = true;
			}
			else
			{
				secondClick = 19;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox18_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 18;
				attemp = true;
			}
			else
			{
				secondClick = 18;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox17_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 17;
				attemp = true;
			}
			else
			{
				secondClick = 17;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox16_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 16;
				attemp = true;
			}
			else
			{
				secondClick = 16;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 15;
				attemp = true;
			}
			else
			{
				secondClick = 15;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 14;
				attemp = true;
			}
			else
			{
				secondClick = 14;
				attemp = false;
				checkAttemp();
			}
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			if (!attemp)
			{
				firstClick = 13;
				attemp = true;
			}
			else
			{
				secondClick = 13;
				attemp = false;
				checkAttemp();
			}
		}

		void checkAttemp()
		{
			int count = 0;
			firstClick--;
			secondClick--;
			foreach (PictureBox p in pictureBoxes)
			{
				if (count == firstClick)
				{
					first = count;
					count++;
				}
				else if (count == secondClick)
				{
					second = count;
					count++;
				}
				else
				{
					count++;
				}
			}
			if (finalArray[first] == finalArray[second])
			{
				count = 0;
				foreach (PictureBox p in pictureBoxes)
				{
					if (count == first)
					{
						p.Visible = false;
						count++;
					}
					else if (count == second)
					{
						p.Visible = false;
						count++;
					}
					else
					{
						count++;
					}
				}
				checkIfCompleted();
			}
			else
			{
				totalAttemps++;
				label5.Text = totalAttemps.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void gAMEToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void lIGHTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}

		private void dARKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Navy;
		}

		private void cOMFORTABLEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Silver;
		}

		private void rELAXINGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Lime;
		}

		private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
		{
			highscoresForm form2 = new highscoresForm();
			form2.Close();
			this.Close();
		}

		private void sHOWLEADBOARDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			highscoresForm form2 = new highscoresForm();
			form2.Show();
		}

		private void cUSTOMIZEICONSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void iNSTERTFROMDIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Select a folder that appears to have 12 JPG picture icons. We suggest a size of (1.5 cm x 1.5 cm).Then click a random icon in this folder to set as default path.Icons must be named with numbers from 1 - 12(different ones). Press OK to start!");
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				PATH = Path.GetDirectoryName(openFileDialog1.FileName);
			}
		}

		void checkIfCompleted()
		{
			Boolean completed = true;
			foreach (PictureBox p in pictureBoxes)
			{
				if (p.Visible)
				{
					completed = false;
				}
			}
			if (completed)
			{
				timer1.Stop();
				Player p = new Player();  
				p.score = 300 - time * (totalAttemps+1);
				p.name = textBox1.Text;
				textBox1.ReadOnly = false;
				label7.Text = p.score.ToString();
				BinaryFormatter bf = new BinaryFormatter();
				Stream ls = new FileStream("Best_Player.dat", FileMode.OpenOrCreate);
				Highscore No1 = (Highscore)bf.Deserialize(ls);
				ls.Close();
				if (No1.score < p.score)
				{
					File.AppendAllText("Scores.txt", No1.name + " " + No1.score + Environment.NewLine);
					No1.score = p.score;
					No1.name = p.name;
					BinaryFormatter bf2 = new BinaryFormatter();
					Stream ls2 = new FileStream("Best_Player.dat", FileMode.OpenOrCreate);
					bf2.Serialize(ls2, No1);
					ls2.Close();
				}
				else
				{
					File.AppendAllText("Scores.txt" , Environment.NewLine + p.name + " " + p.score);
				}
				totalAttemps = 0;
				time = 0;
			}
		}

	}
}
