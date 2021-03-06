﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopsAndMessageBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnWhile_Click(object sender, EventArgs e)
    {
      DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs", "While", MessageBoxButtons.YesNo);

      // While loop. It does things while a statement is true. If the statement is never true, the code is never used.
      while(selected == DialogResult.Yes)
      {
        selected = MessageBox.Show("In our hubris we undermine our greatest efforts to prevail over what we perceived as unworthy of us.", "While", MessageBoxButtons.YesNo);
      }
    }

    private void btnDo_Click(object sender, EventArgs e)
    {
      DialogResult selected;

      // Do loop. It does, and then checks to see if it should do again. It's code will always be run.
      do
      {
        selected = MessageBox.Show("No matter how great our advances, in the end we must reap what we sow.", "Do", MessageBoxButtons.YesNo);
      }while (selected == DialogResult.Yes) ;
    }

    private void btnFor_Click(object sender, EventArgs e)
    {
      // For loop. Does something for X number of times.
      for (int i = 5; i > 0; i--)
      {
        MessageBox.Show("The great hights we have risen to just means we have further to fall. " + i * 10, "Do");
      }
    }
  }
}
