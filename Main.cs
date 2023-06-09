﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminForm.DLayers;

namespace AdminForm
{
    public partial class Main : Form
    {
        Views views = new Views();
        Proc procs = new Proc();
        Func funcs = new Func();
        DataTable DataTables = null;
        DataSet DataSets = null;

        //FLAGS
        private bool Res = false;
        private bool ShowTime = false;
        private bool Movie = false;
        private bool Customer = false;
        private bool Employee = false;
        private bool Review = false;
        private bool Company = false;
        private bool Room = false;
        public Main()
        {
            InitializeComponent();
            DataSets = views.Movies();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.TextBox.Enabled = false;
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = false;
        }
        private void RESETFLAGS()
        {
            Res = false;
            ShowTime = false;
            Movie = false;
            Customer = false;
            Employee = false;
            Review = false;
            Company = false;
            Room = false;
            this.TextBox.Enabled = false;
            this.TextBox.Clear();
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.BalanceTextBox.Visible = false;
            this.BalanceBUTT.Visible = false;
        }
        //TOOL STRIP
        private void showingTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            ShowTime = true;
            DataSets = views.ShowTime();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ShowingInDay",
            "ComingShowing",
            "ClosedShowing",
            "ShowingInDayAvailable",
            "ShowingInDayOut",
            "HighRatingShowing",
            "ShowingByScreen"});
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }
        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Movie = true;
            DataSets = views.Movies();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ShowTimeByCompany",
            "ShowTimeByActor"});
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Res = true;
            DataSets = views.Res();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = true;
        }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Customer = true;
            DataSets = views.KH();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "VIP",
            "NoVIP",
            "UserInfo"});
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;

            this.label1.Visible = true;
            this.label1.Text = "<- UserID";
            this.TextBox.Enabled = true;
            this.TextBox.Focus();
            this.label2.Visible = true;
            this.BalanceTextBox.Visible = true;
            this.BalanceBUTT.Visible = true;
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Employee = true;
            DataSets = views.Emp();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = false;
        }
        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Review = true;
            DataSets = views.Rev();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "MovieRating",
            "UserRating"});
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = false;
        }
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Company = true;
            DataSets = views.Company();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Room = true;
            DataSets = views.Room();
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = this.toolStripComboBox1.Items.Count.ToString() + " Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }

        //ADD - DEL BUTT
        private void ADDBUTT_Click(object sender, EventArgs e)
        {
            int a = this.DataView.Rows.Count - 2;
            if (Res)
            {
                if (procs.AddRES(this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[3].Value.ToString())))
                {
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");

            }
            else if(ShowTime)
            {
                if (procs.AddShowTime(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[8].Value.ToString()))
                {
                    showingTimeToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if(Movie)
            {
                if (procs.AddMov(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[2].Value.ToString()), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[4].Value.ToString(), this.DataView.Rows[a].Cells[5].Value.ToString(), this.DataView.Rows[a].Cells[6].Value.ToString()))
                {
                    moviesToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if(Customer)
            {
                if (procs.AddCus(this.DataView.Rows[a].Cells["User_ID"].Value.ToString(), this.DataView.Rows[a].Cells["Password"].Value.ToString(), this.DataView.Rows[a].Cells["Name"].Value.ToString(), this.DataView.Rows[a].Cells["Email"].Value.ToString(), this.DataView.Rows[a].Cells["Address"].Value.ToString(),Int32.Parse(this.DataView.Rows[a].Cells["Phone"].Value.ToString())))
                {
                    customersToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if(Employee)
            {

            }
            else if(Company)
            {
                if (procs.AddComp(this.DataView.Rows[a].Cells["Company_ID"].Value.ToString(), this.DataView.Rows[a].Cells["Name"].Value.ToString(), this.DataView.Rows[a].Cells["Email"].Value.ToString(), this.DataView.Rows[a].Cells["Phone"].Value.ToString(), this.DataView.Rows[a].Cells["Address"].Value.ToString()))
                {
                    companyToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if(Room)
            {
                int seats = Int32.Parse(this.DataView.Rows[a].Cells["MaxSeats"].Value.ToString());
                if (procs.AddRom(this.DataView.Rows[a].Cells["Room_ID"].Value.ToString(), seats, this.DataView.Rows[a].Cells["Screen_Resolution"].Value.ToString(), this.DataView.Rows[a].Cells["Audio_Quality"].Value.ToString()))
                {
                    roomToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Res)
            {
                if (procs.DelRES(Int32.Parse(this.DataView.Rows[this.DataView.CurrentRow.Index].Cells["Reservation_ID"].Value.ToString())))
                {
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");

            }
            else if (ShowTime)
            {

            }
            else if (Movie)
            {

            }
            else if (Customer)
            {

            }
            else if (Employee)
            {

            }
        }
        private void BalanceBUTT_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(this.BalanceTextBox.Text);
            if (procs.AddBaL(this.TextBox.Text, a))
            {
                //RESET
                DataView.DataSource = null;
                DataView.Rows.Clear();
                DataView.Columns.Clear();
                //REBIND
                DataSets = views.KH();
                DataTables = DataSets.Tables[0];
                DataView.DataSource = DataTables;
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Fail");
        }

        //TEXTBOX FILTERS
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "VIP")
                DataSets = views.ISVIP();
            else if (toolStripComboBox1.Text == "NoVIP")
                DataSets = views.NoVIP();
            else if (toolStripComboBox1.Text == "ShowingInDay")
                DataSets = views.ShowingInDay();
            else if (toolStripComboBox1.Text == "ComingShowing")
                DataSets = views.ComingShow();
            else if (toolStripComboBox1.Text == "ClosedShowing")
                DataSets = views.ClosedShow();
            else if (toolStripComboBox1.Text == "ShowingInDayAvailable")
                DataSets = views.ShowInDayAva();
            else if (toolStripComboBox1.Text == "ShowingInDayOut")
                DataSets = views.ShowInDayOut();
            else if (toolStripComboBox1.Text == "HighRatingShowing")
                DataSets = views.highRatingShow();
            else if (toolStripComboBox1.Text == "MovieRating")
            {
                this.label1.Visible = true;
                this.label1.Text = "<- ShowTimeID";
                this.TextBox.Enabled = true;
                this.TextBox.Focus();
            }
            else if (toolStripComboBox1.Text == "UserRating")
            {
                this.label1.Visible = true;
                this.label1.Text = "<- UserID";
                this.TextBox.Enabled = true;
                this.TextBox.Focus();
            }
            else if (toolStripComboBox1.Text == "ShowTimeByCompany")
            {
                this.label1.Visible = true;
                this.label1.Text = "<- Company Name";
                this.TextBox.Enabled = true;
                this.TextBox.Focus();
            }
            else if (toolStripComboBox1.Text == "ShowTimeByActor")
            {
                this.label1.Visible = true;
                this.label1.Text = "<- Actor Name";
                this.TextBox.Enabled = true;
                this.TextBox.Focus();
            }
            else if (toolStripComboBox1.Text == "ShowingByScreen")
            {
                this.label1.Visible = true;
                this.label1.Text = "<- Screen Resolution";
                this.TextBox.Enabled = true;
                this.TextBox.Focus();
            }
            //else if (toolStripComboBox1.Text == "UserInfo")
            //{
            //    this.label1.Visible = true;
            //    this.label1.Text = "<- UserID";
            //    this.TextBox.Enabled = true;
            //    this.TextBox.Focus();
            //}
            //RESET
            DataView.DataSource = null;
            DataView.Rows.Clear();
            DataView.Columns.Clear();
            //REBIND DATA
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "MovieRating")
                DataSets = funcs.MovieRating(this.TextBox.Text);
            else if (toolStripComboBox1.Text == "UserRating")
                DataSets = funcs.UserCommented(this.TextBox.Text);
            else if(toolStripComboBox1.Text == "UserInfo")
                DataSets = funcs.Userinfo(this.TextBox.Text);
            else if (toolStripComboBox1.Text == "ShowTimeByCompany")
                DataSets = funcs.CompMovie(this.TextBox.Text);
            else if (toolStripComboBox1.Text == "ShowTimeByActor")
                DataSets = funcs.ActorMovie(this.TextBox.Text);
            else if (toolStripComboBox1.Text == "ShowingByScreen")
                DataSets = funcs.ResMovie(this.TextBox.Text);
            DataTables = DataSets.Tables[0];
            DataView.DataSource = DataTables;
        }


        //MISC
        private void BalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

    }
}
