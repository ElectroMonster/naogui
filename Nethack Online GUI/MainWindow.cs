using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Nethack_Online_GUI
{
    public partial class MainWindow : Form
    {
        NethackController nhControl;

        public MainWindow()
        {
            InitializeComponent();
            
            nhControl = new NethackController();

            nhControl.ConnectToNAO();
        }

        override protected void OnPaint(PaintEventArgs e)
        {
            nhControl.Paint(e.Graphics);
        }
    }
}