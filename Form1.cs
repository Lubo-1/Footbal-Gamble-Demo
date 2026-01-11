using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootbalGamble
{
    public partial class Form1 : Form
    {
        private int levl = 1;
        private int xp = 15;
        private int zapasy = 0; 
        private int kliknuti;
        private int penize = 100;
        private int cil = 10000000;
        private Random rnd = new Random();

        //private List<string> list = new List<string>()
        //{
        //    "Teplice", "Ostrava", "Jablonec", "Praha", "Plzeň"
        //};

        private List<Teams> list = new List<Teams>()
        {
            new Teams{Tymy = "Teplice",Body = 0},
            new Teams{Tymy = "Ostrava",Body = 0},
            new Teams{Tymy = "Jablonec",Body = 0},
            new Teams{Tymy = "Liberec",Body = 0},
            new Teams{Tymy = "Praha",Body = 0},
            new Teams{Tymy = "Plzen",Body = 0},

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            zapasy += 1;
            lblZapasy.Text = zapasy.ToString() + " / 30";

            if (penize == cil)
            {
                MessageBox.Show("Vyhral jsi !!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnResetGame.Enabled = true;
            }


            if (levl >= 1 && levl <= 10)
            {
                lblLevlNazev.Text = "Nováček";
            }
            else if (levl >= 10 && levl <= 30)
            {
                lblLevlNazev.Text = "pokročilí";
            }
            else if (levl >= 30 && levl <= 60)
            {
                lblLevlNazev.Text = "Master";
            }
            else if (levl > 60)
            {
                lblLevlNazev.Text = "Gambler";
            }

            lblLevl.Text = "Level: " + levl.ToString();
            levlBar.Value = 0;



            //foreach (var item in list)
            //{
            //    listViewTabulkaLigy.Items.Add(item);
            //}




            btn3.Enabled = false;
            lblCil.Text = penize.ToString() + " / " + cil.ToString();
            numSazeni.Maximum = 1000000000;
            lblPenize.Text = penize.ToString() + " Kč";
            RandomText();
            RefreshLeagueTable();
        }

        public void RandomText()
        {

            string text1 = list[rnd.Next(list.Count)].Tymy;

            //Dokud txt2 nebude mit jinou hodnotu
            string text2;
            do
            {
                text2 = list[rnd.Next(list.Count)].Tymy;
            }
            while (text2 == text1);

            btn1.Text = text1;       
            btn2.Text = text2;
        }

        private void RefreshLeagueTable()
        {
            listViewTabulkaLigy.Items.Clear();

            foreach (var team in list.OrderByDescending(t => t.Body))
            {
                var item = new ListViewItem(team.Tymy);
                item.SubItems.Add(team.Body.ToString());
                listViewTabulkaLigy.Items.Add(item);
            }
        }

        private void AddPoints(string teamName, int points)
        {
            var team = list.FirstOrDefault(t => t.Tymy == teamName);
            if (team != null)
            {
                team.Body += points;
                RefreshLeagueTable();
            }
        }



        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {      
            btn3.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btnRemiza.Enabled = false;
            kliknuti = 0;
            if (kliknuti == 0)
            {
                lbl1.Text = "Kliknuto levé tlačítko";
                btn1.BackColor = Color.YellowGreen;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {


            btnReset.Enabled = true;

            if (penize == 0)
            {
                MessageBox.Show("Nemáš dostatek peněz :/", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnResetGame.Enabled = true;

            }
            else
            {
                if ((int)numSazeni.Value > penize)
                {
                    MessageBox.Show("Tolik penez nemas !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (numSazeni.Value == 0)
                    {
                        MessageBox.Show("Nejdříve musiš vsadit častku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        btn3.Enabled = false;
                        //int dvojpenize;
                        int skoreVyherce;
                        int skorePorazeneho;
                        int minuspenize = (int)numSazeni.Value;

                        btn1.BackColor = SystemColors.Control;
                        btn2.BackColor = SystemColors.Control;



                        skoreVyherce = rnd.Next(1, 10);
                        skorePorazeneho = rnd.Next(0, 3);


                        if (skoreVyherce <= skorePorazeneho)
                        {
                            skoreVyherce = rnd.Next(4, 10);
                            skorePorazeneho = rnd.Next(0, 2);
                        }


                        int vyber = rnd.Next(3);

                        if (vyber == 0)
                        {
                            AddPoints(btn1.Text, 3);
                            lblSkoreZapasu.Text = skoreVyherce + " : " + skorePorazeneho;

                            if (kliknuti == 0)   // hráč vybral btn1
                            {
                                
                                int vyhra = (int)numSazeni.Value * 2;
                                penize += vyhra;
                                lbl2.Text = "Vyhrál jsi " + vyhra + " Kč!";
                                lbl2.ForeColor = Color.White;
                                lbl2.BackColor = Color.Green;


                                if (levl <= 10)
                                {
                                    levlBar.Value += xp;
                                }
                                else if (levl > 10 && levl <= 20)
                                {
                                    levlBar.Value += xp * 1;
                                }
                                else if (levl > 20 && levl <= 40)
                                {
                                    levlBar.Value += xp * 2;
                                }
                                else if (levl > 40 && levl <= 50)
                                {
                                    levlBar.Value += xp * 3;
                                }
                                else if (levl > 50 && levl <= 70)
                                {
                                    levlBar.Value += xp * 4;
                                }
                                else if (levl > 70 && levl <= 100)
                                {
                                    levlBar.Value += xp * 5;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Green;
                                lblLevlZprava.Text = "+ " + xp.ToString();

                            }
                            else
                            {

                                penize -= (int)numSazeni.Value;
                                lbl2.Text = "Prohrál jsi " + (int)numSazeni.Value + " Kč :(";
                                lbl2.ForeColor = Color.Red;
                                lbl2.BackColor = Color.Transparent;

                                if (levlBar.Value > 0)
                                {
                                    levlBar.Value -= 10;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Red;
                                lblLevlZprava.Text = "- 10xp";
                            }
                        }
                        else if (vyber == 1)
                        {
                            AddPoints(btn2.Text, 3);
                            lblSkoreZapasu.Text = skorePorazeneho + " : " + skoreVyherce;

                            if (kliknuti == 1)  // hráč vybral btn2
                            {
                                
                                int vyhra = (int)numSazeni.Value * 2;
                                penize += vyhra;
                                lbl2.Text = "Vyhrál jsi " + vyhra + " Kč!";
                                lbl2.ForeColor = Color.White;
                                lbl2.BackColor = Color.Green;

                                if (levl <= 10)
                                {
                                    levlBar.Value += xp;
                                }
                                else if (levl > 10 && levl <= 20)
                                {
                                    levlBar.Value += xp * 1;
                                }
                                else if (levl > 20 && levl <= 40)
                                {
                                    levlBar.Value += xp * 2;
                                }
                                else if (levl > 40 && levl <= 50)
                                {
                                    levlBar.Value += xp * 3;
                                }
                                else if (levl > 50 && levl <= 70)
                                {
                                    levlBar.Value += xp * 4;
                                }
                                else if (levl > 70 && levl <= 100)
                                {
                                    levlBar.Value += xp * 5;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Green;
                                lblLevlZprava.Text = "+ " + xp.ToString();
                            }
                            else
                            {

                                penize -= (int)numSazeni.Value;
                                lbl2.Text = "Prohrál jsi " + (int)numSazeni.Value + " Kč :(";
                                lbl2.ForeColor = Color.Red;
                                lbl2.BackColor = Color.Transparent;

                                if (levlBar.Value > 0)
                                {
                                    levlBar.Value -= 10;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Red;
                                lblLevlZprava.Text = "- 10xp";
                            }
                        }
                        else if (vyber == 2)
                        {
                            AddPoints(btn1.Text, 1);
                            AddPoints(btn2.Text, 1);
                            lblSkoreZapasu.Text = "Remiza";
                            if (kliknuti == 3)  // hráč vybral btnRemiza
                            {

                                lblSkoreZapasu.Text = "Remiza";

                                int vyhra = (int)numSazeni.Value * 2;
                                penize += vyhra;
                                lbl2.Text = "Vyhrál jsi " + vyhra + " Kč!";
                                lbl2.ForeColor = Color.White;
                                lbl2.BackColor = Color.Green;

                                if (levl <= 10)
                                {
                                    levlBar.Value += xp;
                                }
                                else if (levl > 10 && levl <= 20)
                                {
                                    levlBar.Value += xp * 1;
                                }
                                else if (levl > 20 && levl <= 40)
                                {
                                    levlBar.Value += xp * 2;
                                }
                                else if (levl > 40 && levl <= 50)
                                {
                                    levlBar.Value += xp * 3;
                                }
                                else if (levl > 50 && levl <= 70)
                                {
                                    levlBar.Value += xp * 4;
                                }
                                else if (levl > 70 && levl <= 100)
                                {
                                    levlBar.Value += xp * 5;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Green;
                                lblLevlZprava.Text = "+ " + xp.ToString();
                            }
                            else
                            {

                                penize -= (int)numSazeni.Value;
                                lbl2.Text = "Prohrál jsi " + (int)numSazeni.Value + " Kč :(";
                                lbl2.ForeColor = Color.Red;
                                lbl2.BackColor = Color.Transparent;

                                if(levlBar.Value > 0)
                                {
                                    levlBar.Value -= 10;
                                }

                                lblLevlZprava.Visible = true;
                                lblLevlZprava.ForeColor = Color.Red;
                                lblLevlZprava.Text = "- 10xp";

                                
                            }
                        }

                            // Aktualizace penez
                        lblPenize.Text = penize + " Kč";
                        lblCil.Text = penize + " / " + cil;

                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) //button Next
        {
            lblLevlZprava.Visible = false;

            btnReset.Enabled = false;
            zapasy += 1;
            lblZapasy.Text = zapasy.ToString() + " / 30";

            if (penize <= 0)
            {
                MessageBox.Show("Nemáš dostatek peněz :/", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSazeni.Enabled = false;  
                btnResetGame.Enabled = true;
                lbl2.Text = "Nemas dostek penez ! Reset hru !";
            }

            if (zapasy >= 30)
            {
                MessageBox.Show("Konec dohral jsi ligu. \n Tvoje finalni score je? " + lblSkoreZapasu.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn3.Enabled = true;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btnRemiza.Enabled = false;
                btnResetGame.Enabled = false;
                numSazeni.Enabled = false;
                btnResetGame.Enabled = true;

            }

            if (levlBar.Value == 100)
            {
                levl += 1;
                lblLevl.Text = "Level: " + levl.ToString();
                levlBar.Value = 0;
                lblLevlZprava.ForeColor = Color.Green;
                lblLevlZprava.Text = "Levl up !!!";
            }


            if(levl >= 1 && levl <= 10)
            {
                lblLevlNazev.Text = "Nováček";
            }
            else if(levl >= 10 && levl <= 30)
            {
                lblLevlNazev.Text = "pokročilí";
            }
            else if (levl >= 30 && levl <= 60)
            {
                lblLevlNazev.Text = "Master";
            }
            else if (levl > 60)
            {
                lblLevlNazev.Text = "Gambler";
            }

                RandomText();
            lbl1.Text = " --- ";
            lbl2.Text = " --- ";
            lblSkoreZapasu.Text = "-- : --";
            lbl2.BackColor = Color.Transparent;
            lbl2.ForeColor = Color.Black;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            numSazeni.Value = 0;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btnRemiza.Enabled = true;
            btn3.Enabled = false;
            numSazeni.Enabled = true;
            lblCil.Text = penize.ToString() + " / " + cil.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn3.Enabled = true;
            btn2.Enabled = false;
            btn1.Enabled = false;
            btnRemiza.Enabled = false;
            kliknuti = 1;
            if (kliknuti == 1)
            {
                lbl1.Text = "Kliknuto pravé tlačítko";
                btn2.BackColor = Color.YellowGreen;

            }
        }

        private void btnRemiza_Click(object sender, EventArgs e)
        {
            btn3.Enabled = true;
            btn2.Enabled = false;
            btn1.Enabled = false;
            btnRemiza.Enabled= false;
            kliknuti = 3;
            if (kliknuti == 3)
            {
                lbl1.Text = "Kliknuto prostřední tlačítko";
                btnRemiza.BackColor = Color.YellowGreen;

            }
        }

        private void numSazeni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnResetGame_Click(object sender, EventArgs e) //reset game
        {
            if (penize <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Chces začít i novým levlem?", "Reset", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RandomText();
                    lbl1.Text = " --- ";
                    lbl2.Text = " --- ";
                    lblSkoreZapasu.Text = "0 : 0";
                    lbl2.BackColor = Color.Transparent;
                    lbl2.ForeColor = Color.Black;
                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.White;
                    numSazeni.Value = 0;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = false;
                    numSazeni.Enabled = true;
                    penize += 100;
                    lblPenize.Text = penize.ToString() + " Kč";
                    lblCil.Text = penize.ToString() + " / " + cil.ToString();
                    listViewTabulkaLigy.Items.Clear();
                    levl = 1;
                    lblLevl.Text = "Level: " + levl.ToString();
                    zapasy = 0;
                    lblLevlNazev.Text = "Nováček";
                }
                else if (dialogResult == DialogResult.No)
                {
                    RandomText();
                    lbl1.Text = " --- ";
                    lbl2.Text = " --- ";
                    lblSkoreZapasu.Text = "0 : 0";
                    lbl2.BackColor = Color.Transparent;
                    lbl2.ForeColor = Color.Black;
                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.White;
                    numSazeni.Value = 0;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = false;
                    numSazeni.Enabled = true;
                    penize += 100;
                    lblPenize.Text = penize.ToString() + " Kč";
                    lblCil.Text = penize.ToString() + " / " + cil.ToString();
                    listViewTabulkaLigy.Items.Clear();
                    zapasy = 0;
                }         
            } 
           
           btnResetGame.Enabled = false;

        }

        private void levlBar_Click(object sender, EventArgs e)
        {
            
        }



        private void btnNavod_Click(object sender, EventArgs e)
        {
            FrmNavod frmNavod = new FrmNavod();
            frmNavod.Show();
        }
    }
}
