using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_A2___Converted_code
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // You can't put letters in the number box.
            TeamNumberBox.KeyPress += new KeyPressEventHandler(this.TeamNumberBox_KeyPress);

            // All boxes start at the unknown orange option.
            ComboBox_VisibleChanged(AutoForwardBox);
            ComboBox_VisibleChanged(AutoLowGoalBox);
            ComboBox_VisibleChanged(AutoHighGoalBox);
            ComboBox_VisibleChanged(PassBallBox);
            ComboBox_VisibleChanged(CatchBallBox);
            ComboBox_VisibleChanged(PickUpBallBox);
            ComboBox_VisibleChanged(MiddleBarBox);
            ComboBox_VisibleChanged(LowGoalBox);
            ComboBox_VisibleChanged(HighGoalBox);

        }

        private void TeamDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TeamNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamNumberBox_TextChanged(object sender, EventArgs e) // Handles TeamNumberBox.TextChanged
        {
            //TeamNumberBox_KeyPress(sender, e);
        }

        private void TeamNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AutonomousDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AutoForwardLabel_Click(object sender, EventArgs e)
        {

        }

        private void AutoLowGoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void AutoHighGoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void AutoForwardBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(AutoForwardBox);
        }

        private void AutoLowGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(AutoLowGoalBox);
        }

        private void AutoHighGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(AutoHighGoalBox);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PassBallLabel_Click(object sender, EventArgs e)
        {

        }

        private void CatchBallLabel_Click(object sender, EventArgs e)
        {

        }

        private void PickUpBallLabel_Click(object sender, EventArgs e)
        {

        }

        private void MiddleBarLabel_Click(object sender, EventArgs e)
        {

        }

        private void LowGoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void HighGoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void PassBallBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(PassBallBox);
        }


        private void CatchBallBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(CatchBallBox);
        }

        private void PickUpBallBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(PickUpBallBox);
        }

        private void MiddleBarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(MiddleBarBox);
        }

        private void LowGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(LowGoalBox);
        }

        private void HighGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SelectedValueChanged(HighGoalBox);
        }

        private void ComboBox_VisibleChanged(ComboBox sender) // missing event e args // Handles HighGoalBox.VisibleChanged, LowGoalBox.VisibleChanged, MiddleBarBox.VisibleChanged, PickUpBallBox.VisibleChanged, CatchBallBox.VisibleChanged, AutoHighGoalBox.VisibleChanged, AutoLowGoalBox.VisibleChanged, PassBallBox.VisibleChanged, AutoForwardBox.VisibleChanged
        {
            sender.SelectedIndex = 0;
        }




        private void ComboBox_SelectedValueChanged(ComboBox sender)  // missing event args e //Handles HighGoalBox.SelectedValueChanged, LowGoalBox.SelectedValueChanged, MiddleBarBox.SelectedValueChanged, PickUpBallBox.SelectedValueChanged, CatchBallBox.SelectedValueChanged, AutoHighGoalBox.SelectedValueChanged, AutoLowGoalBox.SelectedValueChanged, PassBallBox.SelectedValueChanged, AutoForwardBox.SelectedValueChanged
        {
            sender.ForeColor = Color.White;
            switch (sender.SelectedIndex)
            {
                case 0:
                    sender.BackColor = Color.Orange;
                    break;
                case 1:
                    sender.BackColor = Color.Green;
                    break;
                case 2:
                    sender.BackColor = Color.Red;
                    break;

            } 
        }





        private void TeamNumberBox_KeyPress(object sender, KeyPressEventArgs e) // Handles TeamNumberBox.KeyPress
        {
            if (!int.TryParse(e.KeyChar.ToString(), out int x) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }





    } // class that everything is in
}
