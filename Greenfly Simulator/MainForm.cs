using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenfly_Simulator.Properties;
using System.IO;

namespace Greenfly_Simulator
{
    public partial class MainForm : Form
    {
        Bug[,] flies = new Bug[18, 8];
        double YoungSR;
        double AdultSR;
        double OldSR;
        double BirthRate;
        double DiseasePoint;
        bool disease = false;
        int generation;
        List<Point> ladybirdPosition = new List<Point>();
        public MainForm(int young, int adult, int old)
        {
            InitializeComponent();
            YoungSR = (double)UDYoung.Value;
            AdultSR = (double)UDAdult.Value;
            OldSR = (double)UDOld.Value;
            BirthRate = (double)UDBirth.Value;
            DiseasePoint = (double)UDDisease.Value;
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
            timerGenerations.Interval = 20000 / ((int)UDSpeed.Value / 10);
            generation = 0;
            Random rnd = new Random();
            for (int i = 0; i < young; i++)
            {
                bool success = false;
                while (success == false)
                {
                    int x = rnd.Next(0, 18);
                    int y = rnd.Next(0, 8);
                    if (flies[x, y] == null)
                    {
                        flies[x, y] = new GreenflyYoung();
                        Controls.Add(flies[x, y].image);
                        success = true;
                    }
                }
            }
            for (int i = 0; i < adult; i++)
            {
                bool success = false;
                while (success == false)
                {
                    int x = rnd.Next(0, 18);
                    int y = rnd.Next(0, 8);
                    if (flies[x, y] == null)
                    {
                        flies[x, y] = new GreenflyAdult();
                        Controls.Add(flies[x, y].image);
                        success = true;
                    }
                }
            }
            for (int i = 0; i < old; i++)
            {
                bool success = false;
                while (success == false)
                {
                    int x = rnd.Next(0, 18);
                    int y = rnd.Next(0, 8);
                    if (flies[x, y] == null)
                    {
                        flies[x, y] = new GreenflyOld();
                        Controls.Add(flies[x, y].image);
                        success = true;
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int young = 0;
            int adult = 0;
            int old = 0;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (flies[i, j] != null)
                    {
                        flies[i, j].image.Location = new Point(i * 90, j * 110);
                        if (flies[i, j] is GreenflyYoung)
                        {
                            young++;
                        }
                        else if (flies[i, j] is GreenflyAdult)
                        {
                            adult++;
                        }
                        else if (flies[i, j] is GreenflyOld)
                        {
                            old++;
                        }
                    }
                }
            }
            txtJuveniles.Text = young.ToString();
            txtAdults.Text = adult.ToString();
            txtSeniles.Text = old.ToString();
            txtTotal.Text = (young + adult + old).ToString();
            if (GetTotalLadybirds() > 0)
            {
                for (int i = 0; i < ladybirdPosition.Count(); i++)
                {
                    if (ladybirdPosition[i] != null)
                    {
                        try
                        {
                            flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Dispose();
                            flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] = null;
                        }
                        catch (Exception)
                        {
                        }
                        int direction = new Random().Next(1, 5);
                        if (ladybirdPosition[i].X == 17 || ladybirdPosition[i].X == 0 || ladybirdPosition[i].Y == 7 || ladybirdPosition[i].Y == 0)
                        {
                            LadyBirdDestroy(i);
                            return;
                        }
                        switch (direction)
                        {
                            case 1: ladybirdPosition[i] = new Point(ladybirdPosition[i].X - 1, ladybirdPosition[i].Y); break;
                            case 2: ladybirdPosition[i] = new Point(ladybirdPosition[i].X, ladybirdPosition[i].Y - 1); break;
                            case 3: ladybirdPosition[i] = new Point(ladybirdPosition[i].X + 1, ladybirdPosition[i].Y); break;
                            case 4: ladybirdPosition[i] = new Point(ladybirdPosition[i].X, ladybirdPosition[i].Y + 1); break;
                            default: break;
                        }
                        if (flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] != null)
                        {
                            flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Dispose();
                            flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] = null;
                        }
                        flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] = new Ladybird();
                        Controls.Add(flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image);
                        switch (direction)
                        {
                            case 2: flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Image.RotateFlip((RotateFlipType.Rotate90FlipNone)); break;
                            case 3: flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Image.RotateFlip((RotateFlipType.Rotate180FlipNone)); break;
                            case 4: flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Image.RotateFlip((RotateFlipType.Rotate270FlipNone)); break;
                            default: break;
                        }
                        flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Location = new Point(ladybirdPosition[i].X * 90, ladybirdPosition[i].Y * 110);
                    }
                }
                if (GetTotalFlies() > DiseasePoint)
                {
                    disease = true;
                    txtDiseaseStatus.Text = "Active";
                }
                else
                {
                    disease = false;
                    txtDiseaseStatus.Text = "Inactive";
                }
            }
        }

        private void LadyBirdDestroy(int i)
        {
            if (flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] != null)
            {
                flies[ladybirdPosition[i].X, ladybirdPosition[i].Y].image.Dispose();
                flies[ladybirdPosition[i].X, ladybirdPosition[i].Y] = null;
            }
            ladybirdPosition.RemoveAt(i);
        }

        private void timerGenerations_Tick(object sender, EventArgs e)
        {
            int diseaseChance = 0;
            Random rnd = new Random();
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
            if (disease)
            {
                diseaseChance = rnd.Next(20, 51);
            }
            generation++;
            txtGeneration.Text = generation.ToString();
            if (YoungSR != 100 || disease)
            {
                for (int i = 0; i < 18; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {

                        if (flies[i, j] != null && flies[i, j] is GreenflyYoung && (rnd.Next(0, 101) > YoungSR || (disease && rnd.Next(0, 101) > diseaseChance)))
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                        }
                    }
                }
            }
            if (AdultSR != 100)
            {
                for (int i = 0; i < 18; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (flies[i, j] != null && flies[i, j] is GreenflyAdult && rnd.Next(0, 101) > AdultSR)
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                        }
                    }
                }
            }
            if (OldSR != 100 || disease)
            {
                for (int i = 0; i < 18; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (flies[i, j] != null && flies[i, j] is GreenflyOld && (rnd.Next(0, 101) > OldSR || (disease && rnd.Next(0, 101) > diseaseChance)))
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                        }
                    }
                }
            }
            int adult = 0;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (flies[i, j] != null)
                    {
                        if (flies[i, j] is GreenflyAdult)
                        {
                            adult++;
                        }
                    }
                }
            }
            txtAdults.Text = adult.ToString();
            int births = int.Parse(Math.Round((Double.Parse(txtAdults.Text) * BirthRate), 0).ToString());
            if ((GetTotalFlies() + births) >= 144)
            {
                births = 144 - GetTotalFlies();
            }
            for (int i = 0; i < births; i++)
            {
                bool success = false;
                while (success == false)
                {
                    int x = rnd.Next(0, 18);
                    int y = rnd.Next(0, 8);
                    if (flies[x, y] == null)
                    {
                        flies[x, y] = new GreenflyEgg();
                        success = true;
                    }
                }
            }
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (flies[i, j] != null)
                    {
                        if (flies[i, j] is GreenflyYoung)
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                            flies[i, j] = new GreenflyAdult();
                            Controls.Add(flies[i, j].image);
                        }
                        else if (flies[i, j] is GreenflyAdult)
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                            flies[i, j] = new GreenflyOld();
                            Controls.Add(flies[i, j].image);
                        }
                        else if (flies[i, j] is GreenflyEgg)
                        {
                            flies[i, j].image.Dispose();
                            flies[i, j] = null;
                            flies[i, j] = new GreenflyYoung();
                            Controls.Add(flies[i, j].image);
                        }
                    }
                }
            }
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GetTotalFlies() >= 144)
            {
                return;
            }
            Random rnd = new Random();
            bool success = false;
            while (success == false)
            {
                int x = rnd.Next(0, 18);
                int y = rnd.Next(0, 8);
                if (flies[x, y] == null)
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0: flies[x, y] = new GreenflyYoung(); break;
                        case 1: flies[x, y] = new GreenflyAdult(); break;
                        case 2: flies[x, y] = new GreenflyOld(); break;
                        default: break;
                    }
                    Controls.Add(flies[x, y].image);
                    success = true;
                }
            }
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
        }

        private int GetTotalFlies()
        {
            int x = 0;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (flies[i, j] != null)
                    {
                        x++;
                    }
                }
            }
            return x;
        }

        private int GetTotalLadybirds()
        {
            return ladybirdPosition.Count();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            YoungSR = (int)UDYoung.Value;
            AdultSR = (int)UDAdult.Value;
            OldSR = (int)UDOld.Value;
            BirthRate = (double)UDBirth.Value;
            DiseasePoint = (double)UDDisease.Value;
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
            timerGenerations.Interval = 20000 / ((int)UDSpeed.Value / 10);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLadybird_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (GetTotalLadybirds() < 10)
            {
                int x = rnd.Next(2, 16);
                int y = rnd.Next(2, 6);
                if (flies[x, y] != null)
                {
                    flies[x, y].image.Dispose();
                    flies[x, y] = null;
                }
                flies[x, y] = new Ladybird();
                Controls.Add(flies[x, y].image);
                ladybirdPosition.Add(new Point(x, y));
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"./Save.txt", FileMode.OpenOrCreate);
            fs.SetLength(0);
            StringBuilder builder = new StringBuilder();
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    if (flies[x, y] != null)
                    {
                        if (flies[x, y] is GreenflyYoung) builder.Append("1");
                        else if (flies[x, y] is GreenflyAdult) builder.Append("2");
                        else if (flies[x, y] is GreenflyOld) builder.Append("3");
                        else if (flies[x, y] is Ladybird) builder.Append("4");
                    }
                    else builder.Append("0");
                }
                builder.AppendLine();
            }
            builder.Append((20000 / timerGenerations.Interval) * 10);
            builder.AppendLine();
            builder.Append(generation);
            builder.AppendLine();
            builder.Append(DiseasePoint);
            builder.AppendLine();
            builder.Append(OldSR);
            builder.AppendLine();
            builder.Append(AdultSR);
            builder.AppendLine();
            builder.Append(YoungSR);
            builder.AppendLine();
            builder.Append(BirthRate);
            byte[] info = new UTF8Encoding(true).GetBytes(builder.ToString());
            fs.Write(info, 0, info.Length);
            fs.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"./Save.txt");
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
                counter++;
            }
            file.Close();
            ladybirdPosition.Clear();
            for (int i = 0; i < 8; i++)
            {
                char[] item = list[i].ToCharArray();
                for (int j = 0; j < 18; j++)
                {
                    if (flies[j, i] != null)
                    {
                        flies[j, i].image.Dispose();
                        flies[j, i] = null;
                    }
                    switch (int.Parse(item[j].ToString()))
                    {
                        case 1:
                            flies[j, i] = new GreenflyYoung();
                            Controls.Add(flies[j, i].image);
                            break;
                        case 2:
                            flies[j, i] = new GreenflyAdult();
                            Controls.Add(flies[j, i].image);
                            break;
                        case 3:
                            flies[j, i] = new GreenflyOld();
                            Controls.Add(flies[j, i].image);
                            break;
                        case 4:
                            flies[j, i] = new Ladybird();
                            Controls.Add(flies[j, i].image);
                            ladybirdPosition.Add(new Point(j, i));
                            break;
                        default: break;
                    }
                }
            }
            decimal speed = decimal.Parse(list[8].ToString());
            UDSpeed.Value = speed;
            timerGenerations.Interval = 20000 / ((int)UDSpeed.Value / 10);
            generation = int.Parse(list[9]);
            txtGeneration.Text = generation.ToString();
            DiseasePoint = double.Parse(list[10]);
            UDDisease.Value = (decimal)DiseasePoint;
            YoungSR = double.Parse(list[11]);
            UDYoung.Value = (decimal)YoungSR;
            AdultSR = double.Parse(list[12]);
            UDAdult.Value = (decimal)AdultSR;
            OldSR = double.Parse(list[13]);
            UDOld.Value = (decimal)OldSR;
            BirthRate = double.Parse(list[14]);
            UDBirth.Value = (decimal)BirthRate;
            if (GetTotalFlies() > DiseasePoint)
            {
                disease = true;
                txtDiseaseStatus.Text = "Active";
            }
            else
            {
                disease = false;
                txtDiseaseStatus.Text = "Inactive";
            }
            timerGenerations.Interval = 20000 / ((int)UDSpeed.Value / 10);
        }
    }
}